using System;
using System.Threading;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;
using Contracts;

namespace Alpha
{
    public class MessageSender : IMessageSender
    {
        private readonly IPublishEndpoint _endpoint;
        
        public MessageSender(IPublishEndpoint endpoint)
        {
            _endpoint = endpoint;

        }

        public async Task Put(WorldMessage message)
        {
            try
            {
                await _endpoint.Publish<IWorldMessage>(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}