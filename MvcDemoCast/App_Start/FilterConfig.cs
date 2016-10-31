using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;

namespace MvcDemoCast
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
         //   container.Register(
    //Classes.FromThisAssembly()
    //    .BasedOn<IMessage>()
    //    .BasedOn(typeof(IMessageHandler<>)).WithService.Base()
    //    .Where(Component.IsInNamespace("Acme.Crm.MessageDTOs"))
 
        }
    }
}