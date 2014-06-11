using XB.API.Client.Request;
using XB.API.Client.Response;

namespace XB.API.Client
{
    public interface IClient
    {
        T Execute<T>(IRequest<T> request) where T : BaseResponse;
    }
}