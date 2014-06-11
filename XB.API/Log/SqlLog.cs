using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web.Hosting;

namespace XB.API.Log
{
    internal class ResultCode
    {
        public static string UNKNOWN = "0";         // 默认，未知
        public static string OK = "1";              // 成功
        public static string PLATFORM_FAILED = "2"; // 平台返回错误
        public static string EXCEPTION = "9";       // 异常
    }
    public class SqlLog
    {
        /// <summary>
        /// 记录平台指令
        /// </summary>        
        public static void WriteCommand(string logId, string commandType, string commandBody, string resultMessage)
        {
            var strConn = ConfigurationManager.AppSettings["conn"];
            const string strSql = @"insert into T_Log_Platform_Command
(
    Log_Id,
    Command_Type,
    Command_Body,
    Result_Message,
    Date_Created
)
Values
(
    @Log_Id,
    @Command_Type,
    @Command_Body,
    @Result_Message,
    getdate() 
)";
            var conn = new SqlConnection(strConn);
            var cmd = new SqlCommand(strSql, conn);
            cmd.Parameters.Add(new SqlParameter("@Log_Id", logId));
            cmd.Parameters.Add(new SqlParameter("@Command_Type", commandType));
            cmd.Parameters.Add(new SqlParameter("@Command_Body", commandBody));
            cmd.Parameters.Add(new SqlParameter("@Result_Message", resultMessage));            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpdateCommand(string logId, string resultMessage)
        {
            var strConn = ConfigurationManager.AppSettings["conn"];
            const string strSql = @"update T_Log_Platform_Command
Set
    Result_Message = @Result_Message
Where
    Log_Id = @Log_Id";
            var conn = new SqlConnection(strConn);
            var cmd = new SqlCommand(strSql, conn);
            cmd.Parameters.Add(new SqlParameter("@Log_Id", logId));
            cmd.Parameters.Add(new SqlParameter("@Result_Message", resultMessage));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// write log message in database
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="reqName"></param>
        /// <param name="reqApplyCode"></param>
        /// <param name="reqMsg"></param>
        /// <param name="respBody"></param>
        /// <param name="resultCode"></param>
        /// <param name="resultMessage"></param>
        public static void Write(string logId,
            string reqName,
            string reqApplyCode,
            string reqMsg,
            string respBody,
            string resultCode,
            string resultMessage)
        {
            var strConn = ConfigurationManager.AppSettings["conn"];
            const string strSql =
@"insert into T_Log_Platform_Transfer 
(
    Log_Id,
    Request_Name,
    Request_ApplyCode,
    Request_MSG,
    Response_Body,
    Result_code,
    Result_Message,
    Date_Created
)
values
(
    @Log_Id,
    @Request_Name,
    @Request_ApplyCode,
    @Request_MSG,
    @Response_Body,
    @Result_Code,
    @Result_Message,
    getdate()
)";
            var conn = new SqlConnection(strConn);
            var cmd = new SqlCommand(strSql, conn);
            cmd.Parameters.Add(new SqlParameter("@Log_Id", logId));
            cmd.Parameters.Add(new SqlParameter("@Request_Name", reqName));
            cmd.Parameters.Add(new SqlParameter("@Request_ApplyCode", reqApplyCode));
            cmd.Parameters.Add(new SqlParameter("@Request_MSG", reqMsg));
            cmd.Parameters.Add(new SqlParameter("@Response_Body", respBody));
            cmd.Parameters.Add(new SqlParameter("@Result_Code", resultCode));
            cmd.Parameters.Add(new SqlParameter("@Result_Message", resultMessage));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void Update(string logId,string respBody,string resultCode,string resultMessage)
        {
            var strConn = ConfigurationManager.AppSettings["conn"];
            const string strSql = 
@"update T_Log_Platform_Transfer
set
    Response_Body = @Response_Body,
    Result_Code = @Result_Code,
    Result_Message = @Result_Message
where
    Log_Id = @Log_Id";
            var conn = new SqlConnection(strConn);
            var cmd = new SqlCommand(strSql, conn);
            cmd.Parameters.Add(new SqlParameter("@Response_Body", respBody));
            cmd.Parameters.Add(new SqlParameter("@Result_Code", resultCode));
            cmd.Parameters.Add(new SqlParameter("@Result_Message", resultMessage));
            cmd.Parameters.Add(new SqlParameter("@Log_Id", logId));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
