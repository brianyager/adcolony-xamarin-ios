using System;

using UIKit;
using AdColonySDK;
using CoreGraphics;

namespace AdColonyBasic
{
	public partial class ViewController : UIViewController
	{
		public ViewController () : base ()
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			var button = new UIButton (UIButtonType.RoundedRect);
			button.Frame = new CGRect (30, 30, 100, 30);
			button.SetTitle ("Load Video", UIControlState.Normal);

			button.TouchUpInside += (object sender, EventArgs e) => {
				var x = new AdColonyAdDelegate ();
				AdColony.PlayVideoAdForZone ("vzf8fb4670a60e4a139d01b5", x);
			};
			View.Add (button);
		}


		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

