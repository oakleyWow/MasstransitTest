using System;

namespace Contracts
{
    public class WorldMessage : IWorldMessage
    {
        public Guid MessageId { get; set; }

        public string MessageText { get; set; }
    }
}