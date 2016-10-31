using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Castle.MicroKernel;

namespace Ioc.AspectLayer.Aspects
{
    public class RepositoriesInterceptor : IInterceptor
    {
        private readonly IKernel _kernel;

        public RepositoriesInterceptor(IKernel karnel)
        {
            _kernel = karnel;
        }
        public void Intercept(IInvocation invocation)
        {
            var proxyHandleManager = _kernel.Resolve<IProxyHandleManager>();
            try
            {
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
