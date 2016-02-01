using System;
using Foundation;
using Xamarin.Firebase;
using UIKit;

namespace HelloWorld
{
	public partial class HelloWorldIBViewController : UIViewController
	{
		public HelloWorldIBViewController () : base ("HelloWorldIBViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			var firebase = new Firebase("https://boiling-torch-6531.firebaseio.com");
			var nsObject = new NSString ("Wow");

			firebase.SetValue(nsObject);
			firebase.AddObserver(new NSString ("New Key"), new NSKeyValueObservingOptions(), dataSnapShot => {
				this.Label.Text = dataSnapShot.NewValue.ToString();
			});


		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.


		}


		partial void Preview_TouchUpInside (UIButton sender)
		{
			this.Label.Text = "Preview Clicked";
		}

		partial void Next_UpInside (UIButton sender)
		{
			this.Label.Text = "Next Clicked";
		}

	}
}


