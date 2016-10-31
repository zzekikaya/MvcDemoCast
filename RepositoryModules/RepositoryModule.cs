
using Castle.Windsor;
using Ioc.AspectLayer;
using Ioc.AspectLayer.Aspects;
using MyComponent;
using MyFoundation;
using RepositoryContracts;
using Component = Castle.MicroKernel.Registration.Component;


public class RepositoryModule : IIoCBootstrapper
{
    public void Init(IWindsorContainer container)
    {
        container.Register(Component.For<IMessageRepository>().ImplementedBy<IMessageRepository>().Interceptors(typeof(RepositoriesInterceptor)));
        //container.Register(Component.For<IMessageSenderComponent>().ImplementedBy<MessageSenderComponent>());
    }

}
