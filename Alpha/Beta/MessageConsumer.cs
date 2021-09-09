using System;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;
using Contracts;


namespace Second
{
    public class MessageConsumer :
        IConsumer<WorldMessage>
    {
        public Task Consume(ConsumeContext<WorldMessage> context)
        {
            Console.WriteLine(context.Message.MessageText);

            return Task.CompletedTask;
        }
    }
}