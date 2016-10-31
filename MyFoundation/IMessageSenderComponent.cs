using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFoundation
{
  public  interface IMessageSenderComponent
    {
        string SendMessage(string Message);
        double Topla(int a, int b);
    }

}
