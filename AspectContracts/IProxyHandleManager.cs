using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace Ioc.AspectLayer
{
    public interface IProxyHandleManager
    {
        void IsYap(IInvocation invocation);
    }
}
