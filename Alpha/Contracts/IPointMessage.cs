using System;

namespace Contracts
{
    public interface IPointMessage
    {
        Guid MessageId { get; set; }

        string MessageText { get; set; }
    }
}