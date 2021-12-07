using CommerceAdmin.ServiceModel;
using ServiceStack;


namespace CommerceAdmin.ServiceInterface
{
    public class MyServices : Service
    {
        public static object Any(Hello request)
        {
            return new HelloResponse {Result = $"Hello, {request.Name}!"};
        }
    }
}