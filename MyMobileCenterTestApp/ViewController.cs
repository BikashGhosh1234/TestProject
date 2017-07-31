using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile.Analytics;
using UIKit;

namespace MyMobileCenterTestApp
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

			//bool isEnabled = await Analytics.IsEnabledAsync();
			//if(isEnabled)
			Analytics.TrackEvent("First Screen Loaded", new Dictionary<string, string> {
				{ "Category", "AppLaunch" },
				{ "Event", "Custome Analytics Event"}
			});

			BtnCrash.TouchUpInside+=(sender, e) => {
				var i=0;
				var div=10/i;
			};
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
