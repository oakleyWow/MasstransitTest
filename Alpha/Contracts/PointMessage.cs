using System;

namespace Contracts
{
    public class PointMessage : IPointMessage
    {
        public Guid MessageId { get; set; }
        public string MessageText { get; set; }
    }
}