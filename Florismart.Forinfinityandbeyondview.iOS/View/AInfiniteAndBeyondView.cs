using System;
using UIKit;
using Foundation;
using CoreGraphics;
using System.Timers;

namespace Florismart.Forinfinityandbeyondview.iOS
{
	public abstract class AInfiniteAndBeyondView: UIScrollView
	{
		private Timer timer;

		public event EventHandler LimitReached;
		public event EventHandler DirectionModeChanged;

		[Export ("directionModeNatural")]
		protected bool _directionModenatural { get; set; }

		public DirectionModes Direction {
			get { 
				return _directionModenatural ? DirectionModes.Natural : DirectionModes.Innatural;
			}
			set {
				if (value != Direction) {
					_directionModenatural = DirectionModes.Natural.Equals (value);
					RaiseOnDirectionModeChanged ();
				}
			}
		}

		protected ToySpeed _speed;

		public virtual ToySpeed Speed {
			protected get {
				return _speed;
			}
			set {
				_speed = value;
				timer.Interval = _speed.Time;
			}
		}

		[Export ("space")]
		protected virtual nfloat space {
			get { 
				return Speed.Space;
			}
			set { 
				Speed.Space = value;
			}
		}

		[Export ("time")]
		protected virtual double time {
			get { 
				return Speed.Time;
			}
			set { 
				Speed.Time = value;
			}
		}

		public override CGPoint ContentOffset {
			get {
				return base.ContentOffset;
			}
			set {
				base.ContentOffset = value;
				if (CheckLimit (value))
					OnLimitReached ();
			}
		}

		public AInfiniteAndBeyondView (IntPtr handle) : base (handle)
		{
			Initialize ();
		}

		public AInfiniteAndBeyondView (ToySpeed toySpeed)
		{
			Initialize ();
		}

		protected void Initialize ()
		{
			timer = new Timer ();
			Speed = new MrPotatoSpeed ();
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
			timer.Elapsed += new ElapsedEventHandler (Scroll);
			timer.Start ();
		}

		protected abstract nfloat Limit { get; }

		protected abstract bool CheckLimit (CGPoint contentOffset);

		protected abstract void Scroll (object sender, ElapsedEventArgs e);

		public virtual void ScrollToBase ()
		{
			InvokeOnMainThread (() => {
				ContentOffset = new CGPoint (0, 0);
			});
		}

		protected void OnLimitReached ()
		{
			if (LimitReached != null)
				LimitReached (this, EventArgs.Empty);
			ScrollToBase ();
		}

		protected void RaiseOnDirectionModeChanged ()
		{
			if (DirectionModeChanged != null)
				DirectionModeChanged (this, EventArgs.Empty);
		}

		public void Start ()
		{
			timer.Start ();
		}

		public void Stop ()
		{
			timer.Stop ();
		}

	}
}

