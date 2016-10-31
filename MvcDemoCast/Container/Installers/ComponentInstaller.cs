using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;

namespace MvcDemoCast.Container.Installers
{
    public class ComponentInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            var componentBootstrapper = new ComponentModule();
            componentBootstrapper.Init(container);
        }
    }
}