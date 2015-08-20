using System;
using UIKit;
using Foundation;
using CoreGraphics;
using System.Timers;

namespace Florismart.Forinfinityandbeyondview.iOS
{
	[Register ("HorizontalInfiniteAndBeyondView")]
	public partial class HorizontalInfiniteAndBeyondView: AInfiniteAndBeyondView
	{
		public HorizontalInfiniteAndBeyondView (IntPtr handle) : base (handle)
		{
		}

		protected override nfloat Limit {
			get {
				if (_directionModenatural)
					return Subviews [0].Frame.Width;
				return Frame.Width;
			}
		}

		protected override bool CheckLimit (CGPoint contentOffset)
		{
			if (Subviews.Length == 0)
				return false;
			return Math.Abs (contentOffset.X) > Math.Abs (Limit);
			
		}

		protected override void Scroll (object sender, ElapsedEventArgs e)
		{
			InvokeOnMainThread (() => {
				if (_directionModenatural) {
					ContentOffset = new CGPoint (ContentOffset.X + _speed.Space, 0);
				} else {
					ContentOffset = new CGPoint (ContentOffset.X - _speed.Space, 0);
				}
			});
		}

	}
}

