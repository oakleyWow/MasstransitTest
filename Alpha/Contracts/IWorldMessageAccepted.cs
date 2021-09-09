using System;

namespace Contracts
{
    public interface IWorldMessageAccepted
    {
        Guid MessageId { get; set; }
        
        string Text { get; set; }
    }
}