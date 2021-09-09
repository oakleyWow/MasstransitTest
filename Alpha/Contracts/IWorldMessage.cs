using System;

namespace Contracts
{
    public interface IWorldMessage
    {
        Guid MessageId { get; set; }

        string MessageText { get; set; }
    }
}