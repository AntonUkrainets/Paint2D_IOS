using System;
using CoreAnimation;
using CoreGraphics;
using UIKit;

namespace Paint2D
{
    public class Painter
    {
        public static UIBezierPath GetBezierPath(CGPoint point, nfloat lineWidth)
        {
            var path = new UIBezierPath();
            
            var endAngle = (float)Math.PI * 2;
            var dot = new CGPoint(point.X, point.Y);
            path.AddArc(dot, lineWidth, startAngle: 0, endAngle, clockWise: true);

            return path;
        }

        public static CAShapeLayer GetShapeLayer(CGPath bezierPath, CGColor lineColor)
        {
            var shapeLayer = new CAShapeLayer
            {
                Path = bezierPath,
                FillColor = lineColor
            };

            return shapeLayer;
        }
    }
}