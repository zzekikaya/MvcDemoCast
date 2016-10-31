using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace MvcDemoCast
{
    public static class IocContainer
    {
        public static IWindsorContainer Container;

        public static void Setup()
        {
            Container = new WindsorContainer()
                .Install(FromAssembly.This());
            var controllerFactory = new WindsorControllerFactory(Container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
      


        public static void Dispose()
        {
            Container.Dispose();
        }
    }
}
