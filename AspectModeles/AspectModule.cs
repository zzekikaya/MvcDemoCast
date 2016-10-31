
using AspectLayer;
using Castle.Core;
using Castle.Windsor;
using Ioc.AspectLayer;
using Ioc.AspectLayer.Aspects;
using Component = Castle.MicroKernel.Registration.Component;

namespace AspectModeles
{
    public class AspectModule : IIoCBootstrapper
    {
        public void Init(IWindsorContainer container)
        {
            container.Register(Component.For<IProxyHandleManager>().ImplementedBy<ProxyHandleManager>());
            container.Register(Component.For<ComponentsInterceptor>());
            container.Register(Component.For<RepositoriesInterceptor>());
           
        }
    }
}
