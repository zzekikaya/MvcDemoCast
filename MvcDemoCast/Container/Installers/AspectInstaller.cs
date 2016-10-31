using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspectModeles;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;

namespace MvcDemoCast.Container.Installers
{
    public class AspectInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, IConfigurationStore store)
        {
            var aspectBootStrapper = new AspectModule();
            aspectBootStrapper.Init(container);
        }
    }
}