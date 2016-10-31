 
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor; 

namespace MvcDemoCast.Container.Installers
{
    public class RepositoryInstaller : IWindsorInstaller
    {

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var componentBootstrapper = new RepositoryModule();
            componentBootstrapper.Init(container);
        }
    }
}