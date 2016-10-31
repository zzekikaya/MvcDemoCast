using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Ioc.AspectLayer;


namespace AspectLayer
{
    public class ProxyHandleManager : IProxyHandleManager
    {
        void IProxyHandleManager.IsYap(IInvocation invocation)
        {
           
        }
    }
}
