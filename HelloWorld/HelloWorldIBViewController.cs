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
			//var nsObject = new NSString ("Wow");

			var values = NSDictionary.FromObjectsAndKeys (new NSObject[] {
				new NSString ("KeyValue")
			},
				             new NSObject[] {
					new NSString ("KeyName")
				});

			var rootNode = NSDictionary.FromObjectAndKey (values, new NSString("root"));

			firebase.SetValue(rootNode);

			this.TextKeyName.Text = "KeyName";
			this.TextKeyValue.Text = "KeyValue";


//			firebase.ObserveEventType(FEventType.ChildChanged, snapshot =>
//				{
//					var key = snapshot.Key;
//					var value = snapshot.Value;
//					this.TextKeyName.Text = snapshot.Key;
//					this.TextKeyValue.Text = snapshot.Value.ToString();
//				});

			firebase.ChildByAppendingPath("root/KeyName").ObserveEventType(FEventType.Value, snapshot =>
				{
					var key = snapshot.Key;
					var value = snapshot.Value;
					this.TextKeyName.Text = snapshot.Key;
					this.TextKeyValue.Text = snapshot.Value.ToString();
				});

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.


		}


		partial void Preview_TouchUpInside (UIButton sender)
		{
			//this.LabelKeyName.Text = "Preview Clicked";
		}

		partial void Next_UpInside (UIButton sender)
		{
			//this.LabelKeyName.Text = "Next Clicked";
		}

	}
}


