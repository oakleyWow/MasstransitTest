using System;

namespace Contracts
{
    public interface IMessageRejected
    {
        Guid MessageId { get; set; }

        string Reason { get; set; }
    }
}