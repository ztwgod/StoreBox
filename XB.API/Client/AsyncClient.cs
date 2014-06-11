using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using log4net;

namespace XB.API.Client
{
    public class RequestState
    {
        // This class stores the State of the request.
        const int BUFFER_SIZE = 1024;
        public StringBuilder requestData;
        public byte[] BufferRead;
        public HttpWebRequest request;
        public HttpWebResponse response;
        public Stream streamResponse;
        public RequestState()
        {
            BufferRead = new byte[BUFFER_SIZE];
            requestData = new StringBuilder("");
            request = null;
            streamResponse = null;
        }
    }

    public class AsyncClient
    {
        const int BUFFER_SIZE = 1024;
        const int DefaultTimeout = 2 * 60 * 1000; // 2 minutes timeout

        // Abort the request if the timer fires.
        private static void TimeoutCallback(object state, bool timedOut)
        {
            if (timedOut)
            {
                HttpWebRequest request = state as HttpWebRequest;
                if (request != null)
                {
                    request.Abort();
                }
            }
        }


        private static readonly ILog Log = LogManager.GetLogger(typeof(DefaultClient));
        private static ManualResetEvent allDone = new ManualResetEvent(false);

        public void Run()
        {
            var url = ConfigurationManager.AppSettings["plat_url_base"];
            string cometServiceUrl = "cometServlet";
            if (string.IsNullOrEmpty(url))
            {
                Log.Error("configuration with name 'plat_url_base' not found");
                throw new ApplicationException("configuration with name 'plat_url_base' not found");
            }
            
            var wreq = (HttpWebRequest)WebRequest.Create("http://10.211.55.2:8080/cometServlet");
            wreq.Proxy = new WebProxy("127.0.0.1",8888);
            wreq.Method = "POST";
            wreq.ContentType = "application/x-www-form-urlencoded";
            // wreq.AllowReadStreamBuffering
            // wreq.AllowWriteStreamBuffering = false;
            var postData = Encoding.Default.GetBytes("ssCode=31010100010101");
            wreq.GetRequestStream().Write(postData, 0, postData.Length);

            var myRequestState = new RequestState { request = wreq };

            IAsyncResult result = wreq.BeginGetResponse(new AsyncCallback(RespCallback), myRequestState);

            ThreadPool.RegisterWaitForSingleObject(result.AsyncWaitHandle, 
                new WaitOrTimerCallback(TimeoutCallback),
                wreq, DefaultTimeout, true);

            // The response came in the allowed time. The work processing will happen in the  
            // callback function.
            allDone.WaitOne();

            // Release the HttpWebResponse resource.
            myRequestState.response.Close();
        }

        private static void RespCallback(IAsyncResult asynchronousResult)
        {
            try
            {
                // State of request is asynchronous.
                RequestState myRequestState = (RequestState)asynchronousResult.AsyncState;
                HttpWebRequest myHttpWebRequest = myRequestState.request;
                myRequestState.response = (HttpWebResponse)myHttpWebRequest.EndGetResponse(asynchronousResult);

                // Read the response into a Stream object.
                Stream responseStream = myRequestState.response.GetResponseStream();
                myRequestState.streamResponse = responseStream;

                // Begin the Reading of the contents of the HTML page and print it to the console.
                IAsyncResult asynchronousInputRead = responseStream.BeginRead(myRequestState.BufferRead, 0, BUFFER_SIZE, new AsyncCallback(ReadCallBack), myRequestState);
                return;
            }
            catch (WebException e)
            {
                Console.WriteLine("\nRespCallback Exception raised!");
                Console.WriteLine("\nMessage:{0}", e.Message);
                Console.WriteLine("\nStatus:{0}", e.Status);
            }
            allDone.Set();
        }
        private static void ReadCallBack(IAsyncResult asyncResult)
        {
            try
            {

                RequestState myRequestState = (RequestState)asyncResult.AsyncState;
                Stream responseStream = myRequestState.streamResponse;
                int read = responseStream.EndRead(asyncResult);
                // Read the HTML page and then print it to the console. 
                if (read > 0)
                {
                    myRequestState.requestData.Append(Encoding.ASCII.GetString(myRequestState.BufferRead, 0, read));
                    IAsyncResult asynchronousResult = responseStream.BeginRead(myRequestState.BufferRead, 0, BUFFER_SIZE, new AsyncCallback(ReadCallBack), myRequestState);
                    return;
                }
                else
                {
                    Console.WriteLine("\nThe contents of the Html page are : ");
                    if (myRequestState.requestData.Length > 1)
                    {
                        string stringContent;
                        stringContent = myRequestState.requestData.ToString();
                        Console.WriteLine(stringContent);
                    }
                    Console.WriteLine("Press any key to continue..........");
                    Console.ReadLine();

                    responseStream.Close();
                }

            }
            catch (WebException e)
            {
                Console.WriteLine("\nReadCallBack Exception raised!");
                Console.WriteLine("\nMessage:{0}", e.Message);
                Console.WriteLine("\nStatus:{0}", e.Status);
            }
            allDone.Set();

        }
    }
}
