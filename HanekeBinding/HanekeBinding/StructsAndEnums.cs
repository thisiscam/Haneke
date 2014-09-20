using System;
using MonoTouch.UIKit;

namespace HanekeBinding
{
	public enum HNKScaleMode {
		Fill = UIViewContentMode.ScaleToFill,
		AspectFit = UIViewContentMode.ScaleAspectFit,
		AspectFill = UIViewContentMode.ScaleAspectFill,
		None
	}

	public enum HNKPreloadPolicy{
		None = 0,
		LastSession = 1,
		All = 2
	}
}

