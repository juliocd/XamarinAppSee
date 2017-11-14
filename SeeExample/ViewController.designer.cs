// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SeeExample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonCenter { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonLeftDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonLeftUp { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonRightDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonRightUp { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonCenter != null) {
                ButtonCenter.Dispose ();
                ButtonCenter = null;
            }

            if (ButtonLeftDown != null) {
                ButtonLeftDown.Dispose ();
                ButtonLeftDown = null;
            }

            if (ButtonLeftUp != null) {
                ButtonLeftUp.Dispose ();
                ButtonLeftUp = null;
            }

            if (ButtonRightDown != null) {
                ButtonRightDown.Dispose ();
                ButtonRightDown = null;
            }

            if (ButtonRightUp != null) {
                ButtonRightUp.Dispose ();
                ButtonRightUp = null;
            }
        }
    }
}