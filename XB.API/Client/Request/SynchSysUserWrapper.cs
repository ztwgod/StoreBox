using XB.API.Client.Response;

namespace XB.API.Client.Request
{
    public class SynchSysUserWrapper : BaseRequest,IRequest<SynchSysUserResult>
    {
        public string GetServiceUrl()
        {
            return "/XBPhysicalBoxServlet";
        }

        public string GetApplyCode()
        {
            return "9";
        }
    }
}