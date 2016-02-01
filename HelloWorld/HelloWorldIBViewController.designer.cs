// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HelloWorld
{
	[Register ("HelloWorldIBViewController")]
	partial class HelloWorldIBViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton PreviewButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView TextKeyName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView TextKeyValue { get; set; }

		[Action ("Next_UpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Next_UpInside (UIButton sender);

		[Action ("Preview_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Preview_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (PreviewButton != null) {
				PreviewButton.Dispose ();
				PreviewButton = null;
			}
			if (TextKeyName != null) {
				TextKeyName.Dispose ();
				TextKeyName = null;
			}
			if (TextKeyValue != null) {
				TextKeyValue.Dispose ();
				TextKeyValue = null;
			}
		}
	}
}
