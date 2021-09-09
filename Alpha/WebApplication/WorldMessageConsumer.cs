using System.Threading.Tasks;
using MassTransit;
using Contracts;

namespace ConsumerWebApp
{
    public class WorldMessageConsumer : IConsumer<WorldMessage>
    {
        public async Task Consume(ConsumeContext<WorldMessage> context)
        {
            await context.RespondAsync<WorldMessageAccepted>(new WorldMessageAccepted() 
                { MessageId = context.Message.MessageId, Text = string.Format("{0} world", context.Message.MessageText)});
        }
    }
}