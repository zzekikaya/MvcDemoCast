using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyFoundation;
using RepositoryContracts;

namespace MyComponent
{
    public class MessageSenderComponent : IMessageSenderComponent
    {
        private IMessageRepository _messageRepository;
        public MessageSenderComponent(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public string SendMessage(string message)
        {
            var resultVal = "mehmet";
            return resultVal;
        }
        
        public double Topla(int a, int b)
        {
            var result = a + b;
            return result;
        }
    }
}
