
using AspectLayer.Interceptors;
using Castle.Core;
using Castle.Windsor;
using Ioc.AspectLayer;
using MyComponent;
using MyFoundation;
using Component = Castle.MicroKernel.Registration.Component;


public class ComponentModule : IIoCBootstrapper
{
    public void Init(IWindsorContainer container)
    {
        container.Register(Component.For<IMessageSenderComponent>().ImplementedBy<MessageSenderComponent>().Interceptors(typeof(ComponentsInterceptor)));
        //container.Register(Component.For<IMessageSenderComponent>().ImplementedBy<MessageSenderComponent>());
        //container.Register(
        //    Component.For<IMessageSenderComponent>().ImplementedBy<MessageSenderComponent>().Interceptors(typeof(ProxyBaseInterceptor)));

        //2.yöntem 
        //container.Register(
        //       Component.For<IMessageSenderComponent>().ImplementedBy<MessageSenderComponent>().Interceptors(InterceptorReference.ForType<ProxyBaseInterceptor>()).Anywhere);
    }

}
