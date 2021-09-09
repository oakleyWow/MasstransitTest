using System.Threading.Tasks;
using MassTransit;
using Contracts;

namespace WebConsumer
{
    public class QueueMessageConsumer : IConsumer<QueueMessage>
    {
        public async Task Consume(ConsumeContext<QueueMessage> context)
        {
            await context.RespondAsync<MessageAccepted>(new MessageAccepted() { MessageId = context.Message.MessageId });
        }
    }
}