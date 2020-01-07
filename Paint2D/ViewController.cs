using CoreAnimation;
using CoreGraphics;
using System;
using System.Collections.Generic;
using System.Linq;
using UIKit;

namespace Paint2D
{
    public partial class ViewController : UIViewController, IUIGestureRecognizerDelegate
    {
        private UIColor _lineColor;
        private nfloat _lineWidth;

        private List<Operation> _operations;

        private Guid currentDrawBatchId = Guid.Empty;

        public ViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _operations = new List<Operation>();

            InitLine();

            #region Set Taps Gesture Recognizers
            var tapGesture = new UITapGestureRecognizer(Tap);
            var panGesture = new UIPanGestureRecognizer(Pan);

            MainView.AddGestureRecognizer(tapGesture);
            MainView.AddGestureRecognizer(panGesture);
            #endregion
        }

        private void InitLine()
        {
            _lineColor = UIColor.Red;
            _lineWidth = 5;
        }

        #region Clean Buttons
        partial void CleanButton_Tapped(UIButton sender)
        {
            if (DrawView?.Layer?.Sublayers == null || _operations.Count == 0)
                return;

            var lastDrawBatchId = _operations.Last().DrawBatchId;

            _operations.RemoveAll(x => x.DrawBatchId == lastDrawBatchId);

            DrawView.Layer.Sublayers = _operations.Select(x => x.Line).ToArray();
        }

        partial void CleanAllButton_Tapped(UIButton sender)
        {
            DrawView.Layer.Sublayers = null;
            _operations.Clear();
        }
        #endregion

        #region Line Styles
        partial void StrokeWidthButton_Tapped(UIButton sender)
            => _lineWidth = sender.Tag;

        partial void ColorButton_Tapped(UIButton sender)
            => _lineColor = sender.BackgroundColor;
        #endregion

        #region Taps

        private void Pan(UIPanGestureRecognizer gesture)
        {
            var location = gesture.LocationInView(MainView);

            CAShapeLayer line = Draw(location);

            if (gesture.State == UIGestureRecognizerState.Began)
                currentDrawBatchId = Guid.NewGuid();

            _operations.Add(
                new Operation
                {
                    Line = line,
                    DrawBatchId = currentDrawBatchId
                });

            DrawView.Layer.AddSublayer(line);
        }

        private void Tap(UITapGestureRecognizer gesture)
        {
            if (gesture.State != UIGestureRecognizerState.Ended)
                return;

            DrawLine(gesture);
        }
        #endregion

        #region Draw Lines
        private void DrawLine(UIGestureRecognizer gesture)
        {
            var point = gesture.LocationInView(MainView);
            Draw(point);
        }

        private CAShapeLayer Draw(CGPoint point)
        {
            var bezierPath = Painter.GetBezierPath(point, _lineWidth);
            var shapeLayer = Painter.GetShapeLayer(bezierPath.CGPath, _lineColor.CGColor);

            return shapeLayer;
        }
        #endregion

        public override void DidReceiveMemoryWarning()
            => base.DidReceiveMemoryWarning();
    }
}