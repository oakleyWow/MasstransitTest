using System;

namespace Contracts
{
    public interface IPointMessageAccepted
    {
        Guid MessageId { get; set; }

        string Text { get; set; }
    }
}