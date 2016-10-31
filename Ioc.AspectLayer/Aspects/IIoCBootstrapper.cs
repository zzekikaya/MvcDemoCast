using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace Ioc.AspectLayer
{
    public interface IIoCBootstrapper
    {
        void Init(IWindsorContainer container);
    }
}
