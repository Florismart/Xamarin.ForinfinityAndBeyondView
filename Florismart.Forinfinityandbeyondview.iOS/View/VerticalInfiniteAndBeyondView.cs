using System;
using UIKit;
using Foundation;
using CoreGraphics;
using System.Timers;

namespace Florismart.Forinfinityandbeyondview.iOS
{
	[Register ("VerticalInfiniteAndBeyondView")]
	public partial class VerticalInfiniteAndBeyondView: AInfiniteAndBeyondView
	{
		public VerticalInfiniteAndBeyondView (IntPtr handle) : base (handle)
		{
		}

		protected override nfloat Limit {
			get {
				if (_directionModenatural)
					return Subviews [0].Frame.Height;
				return Frame.Height;
			}
		}

		protected override bool CheckLimit (CGPoint contentOffset)
		{
			if (Subviews.Length == 0)
				return false;
			return Math.Abs (contentOffset.Y) > Math.Abs (Limit);
		}

		protected override void Scroll (object sender, ElapsedEventArgs e)
		{
			InvokeOnMainThread (() => {
				if (_directionModenatural) {
					ContentOffset = new CGPoint (0, ContentOffset.Y + _speed.Space);
				} else {
					ContentOffset = new CGPoint (0, ContentOffset.Y - _speed.Space);
				}
			});
		}

	}
}

