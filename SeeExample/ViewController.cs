using System;

using UIKit;

namespace SeeExample
{
    public partial class ViewController : UIViewController
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ButtonCenter.TouchUpInside += ButtonCenter_TouchUpInside;
            ButtonLeftUp.TouchUpInside += ButtonLeftUp_TouchUpInside;
            ButtonRightUp.TouchUpInside += ButtonRightUp_TouchUpInside;
            ButtonLeftDown.TouchUpInside += ButtonLeftDown_TouchUpInside;
            ButtonRightDown.TouchUpInside += ButtonRightDown_TouchUpInside;
        }

        void ButtonCenter_TouchUpInside(object sender, EventArgs e)
        {

        }

        void ButtonLeftUp_TouchUpInside(object sender, EventArgs e)
        {

        }

        void ButtonRightUp_TouchUpInside(object sender, EventArgs e)
        {

        }

        void ButtonLeftDown_TouchUpInside(object sender, EventArgs e)
        {

        }

        void ButtonRightDown_TouchUpInside(object sender, EventArgs e)
        {

        }
    }
}
