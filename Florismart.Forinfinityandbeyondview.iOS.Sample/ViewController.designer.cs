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

namespace Florismart.Forinfinityandbeyondview.iOS.Sample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Florismart.Forinfinityandbeyondview.iOS.HorizontalInfiniteAndBeyondView myHorizontalScroll1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Florismart.Forinfinityandbeyondview.iOS.HorizontalInfiniteAndBeyondView myHorizontalScroll2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Florismart.Forinfinityandbeyondview.iOS.VerticalInfiniteAndBeyondView myVerticalScroll1 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Florismart.Forinfinityandbeyondview.iOS.VerticalInfiniteAndBeyondView myVerticalScroll2 { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton reverseButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton startButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton stopButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (myHorizontalScroll1 != null) {
				myHorizontalScroll1.Dispose ();
				myHorizontalScroll1 = null;
			}
			if (myHorizontalScroll2 != null) {
				myHorizontalScroll2.Dispose ();
				myHorizontalScroll2 = null;
			}
			if (myVerticalScroll1 != null) {
				myVerticalScroll1.Dispose ();
				myVerticalScroll1 = null;
			}
			if (myVerticalScroll2 != null) {
				myVerticalScroll2.Dispose ();
				myVerticalScroll2 = null;
			}
			if (reverseButton != null) {
				reverseButton.Dispose ();
				reverseButton = null;
			}
			if (startButton != null) {
				startButton.Dispose ();
				startButton = null;
			}
			if (stopButton != null) {
				stopButton.Dispose ();
				stopButton = null;
			}
		}
	}
}
