using System;
using ServiceStack;
using CommerceAdmin.ServiceModel;

namespace CommerceAdmin.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
