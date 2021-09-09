using System.Threading.Tasks;
using Contracts;
using MassTransit;

namespace ConsumerWebApp
{
    public class PointMessageConsumer : IConsumer<PointMessage>
    {
        public async Task Consume(ConsumeContext<PointMessage> context)
        {
            await context.RespondAsync<WorldMessageAccepted>(new PointMessageAccepted() 
                { MessageId = context.Message.MessageId, Text = string.Format("{0}.", context.Message.MessageText)});
        }
    }
}