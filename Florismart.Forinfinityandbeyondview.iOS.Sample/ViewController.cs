using System;

using UIKit;

namespace Florismart.Forinfinityandbeyondview.iOS.Sample
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			startButton.TouchUpInside += StartButtonTouchUpInside;
			stopButton.TouchUpInside += StopButtonTouchUpInside;
			reverseButton.TouchUpInside += ReverseButtonTouchUpInside;
		}

		void StopButtonTouchUpInside (object sender, EventArgs e)
		{
			myHorizontalScroll1.Stop ();
			myHorizontalScroll2.Stop ();
			myVerticalScroll1.Stop ();
			myVerticalScroll2.Stop ();
		}

		void StartButtonTouchUpInside (object sender, EventArgs e)
		{
			myHorizontalScroll1.Start ();
			myHorizontalScroll2.Start ();
			myVerticalScroll1.Start ();
			myVerticalScroll2.Start ();
		}

		void ReverseButtonTouchUpInside (object sender, EventArgs e)
		{
			ChangeDirection (myHorizontalScroll1);
			ChangeDirection (myHorizontalScroll2);
			ChangeDirection (myVerticalScroll1);
			ChangeDirection (myVerticalScroll2);
		}

		private void ChangeDirection (AInfiniteAndBeyondView scrollView)
		{
			if (DirectionModes.Natural.Equals (scrollView.Direction))
				scrollView.Direction = DirectionModes.Innatural;
			else
				scrollView.Direction = DirectionModes.Natural;
		}
	}
}