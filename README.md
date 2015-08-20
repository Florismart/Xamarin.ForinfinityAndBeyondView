ForinfinItyAndBeyondView
===============


ForinfinityAndBeyondView is an Open Source iOS library that allows developers to easily an automatic scrolling view to their projects. Feel free to use it all you want in your iOS apps provided that you cite this project and include the license in your app.


![Screenshot](https://raw.githubusercontent.com/Florismart/Xamarin.ForinfinityAndBeyondView/master/screen-app.png)


Setup
-----
__1.__ In Xamarin, import the library as a iOS library project. Now you can build it and export as DLL.

__2.__ Then, add ForinfinityAndBeyondView dll as a dependency to your existing project.

__3.__ At Last quick setup your application class and you are good to go!

Or just import via nuget as Florismart.Forinfinityandbeyondview.iOS



```C#
	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();

		myHorizontalScroll1.LimitReached += (object sender, EventArgs e) => {
			//on limit reached!
		};

		myHorizontalScroll1.DirectionModeChanged += (object sender, EventArgs e) => {
			//on direction changed
		};

		//to stop
		myHorizontalScroll1.Stop ();

		//to start
		myVerticalScroll1.Start ();
	}

```

Usage
-----
Configurations ended! Now open your storyboard or simple xibs and use our 

- HorizontalInfiniteAndBeyondView as UISCrollView horizontally
- HorizontalInfiniteAndBeyondView as UISCrollView vertically

...and set User Runtimes


![Screenshot](https://raw.githubusercontent.com/Florismart/Xamarin.ForinfinItyAndBeyondView/master/runtime_attrbutes.png)
