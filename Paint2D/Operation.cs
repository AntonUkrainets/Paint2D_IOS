using CoreAnimation;
using System;

namespace Paint2D
{
    public class Operation
    {
        public CAShapeLayer Line { get; set; }
        public Guid DrawBatchId { get; set; }
    }
}