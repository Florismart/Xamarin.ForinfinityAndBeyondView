using System;

namespace Florismart.Forinfinityandbeyondview.iOS
{
	/// <summary>
	/// Base Toy speed entity.
	/// </summary>
	public class ToySpeed
	{
		private readonly nfloat DEFAULT_SPACE = 5;
		private readonly double DEFAULT_TIME = 10;

		protected nfloat _space;

		public nfloat Space {
			get {
				return _space;
			}
			set { 
				_space = value;
			}
		}

		protected double _time;

		public double Time { 
			get { 
				return _time;
			}
			set { 
				_time = value;
			}
		}

		public double Speed {
			get { 
				return _time / _space;
			}
		}

		public ToySpeed ()
		{
			_time = DEFAULT_TIME;
			_space = DEFAULT_SPACE;
		}
	}
}

