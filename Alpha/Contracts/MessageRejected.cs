using System;

namespace Contracts
{
    public class MessageRejected : IMessageRejected
    {
        public Guid MessageId { get; set; }

        public string Reason { get; set; }
    }
}