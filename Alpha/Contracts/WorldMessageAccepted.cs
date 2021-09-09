using System;

namespace Contracts
{
    public class WorldMessageAccepted : IWorldMessageAccepted
    {
        public Guid MessageId { get; set; }
        
        public string Text { get; set; }
    }
}