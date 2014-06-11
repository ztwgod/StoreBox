using XB.API.Client.Response;

namespace XB.API.Client.Request
{
    public interface IRequest<T> where T : BaseResponse
    {
        string GetApplyCode();
        string GetServiceUrl();
    }
}