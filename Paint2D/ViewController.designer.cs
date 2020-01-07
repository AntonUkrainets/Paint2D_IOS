// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Paint2D
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CleanAllButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CleanButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView DrawView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GreenButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Paint2D.MainView MainView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton MediumButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RedButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ThickButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ThinButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton YellowButton { get; set; }

        [Action ("CleanAllButton_Tapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CleanAllButton_Tapped (UIKit.UIButton sender);

        [Action ("CleanButton_Tapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CleanButton_Tapped (UIKit.UIButton sender);

        [Action ("ColorButton_Tapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ColorButton_Tapped (UIKit.UIButton sender);

        [Action ("StrokeWidthButton_Tapped:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StrokeWidthButton_Tapped (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CleanAllButton != null) {
                CleanAllButton.Dispose ();
                CleanAllButton = null;
            }

            if (CleanButton != null) {
                CleanButton.Dispose ();
                CleanButton = null;
            }

            if (DrawView != null) {
                DrawView.Dispose ();
                DrawView = null;
            }

            if (GreenButton != null) {
                GreenButton.Dispose ();
                GreenButton = null;
            }

            if (MainView != null) {
                MainView.Dispose ();
                MainView = null;
            }

            if (MediumButton != null) {
                MediumButton.Dispose ();
                MediumButton = null;
            }

            if (RedButton != null) {
                RedButton.Dispose ();
                RedButton = null;
            }

            if (ThickButton != null) {
                ThickButton.Dispose ();
                ThickButton = null;
            }

            if (ThinButton != null) {
                ThinButton.Dispose ();
                ThinButton = null;
            }

            if (YellowButton != null) {
                YellowButton.Dispose ();
                YellowButton = null;
            }
        }
    }
}