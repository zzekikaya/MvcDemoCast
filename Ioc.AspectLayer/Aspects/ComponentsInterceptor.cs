using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Castle.MicroKernel;

namespace Ioc.AspectLayer
{
    public class ComponentsInterceptor : IInterceptor
    {
        private readonly IKernel _kernel;

        public ComponentsInterceptor(IKernel kernel)
        {
            _kernel = kernel;
        }
        void IInterceptor.Intercept(IInvocation invocation)
        {
            var proxyHandleManager = _kernel.Resolve<IProxyHandleManager>();
            try
            {

                //HttpClient client;

                //client.SendAsync("LocalHost//" + invocation.Proxy.ToString() + "//" + invocation.Method.Name, string.Join(",", invocation.Arguments));

                invocation.Proceed();
                proxyHandleManager.IsYap(invocation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
