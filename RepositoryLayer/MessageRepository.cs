using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryContracts;

namespace RepositoryLayer
{
    public class MessageRepository : IMessageRepository
    {
        public string SendMessage(string Message)
        {
            var Result = "dbden okudu";
            return Result;
        }


        
        public double Topla(int a, int b)
        {
            var result = a + b;
            return result;
        }
    }
}
