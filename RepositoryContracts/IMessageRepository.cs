using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryContracts
{
    public interface IMessageRepository
    {
        string SendMessage(string Message);
          double Topla(int a, int b);
    }

}
