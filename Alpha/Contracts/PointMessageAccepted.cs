using System;

namespace Contracts
{
    public class PointMessageAccepted : IPointMessageAccepted
    {
        public Guid MessageId { get; set; }
        public string Text { get; set; }
    }
}