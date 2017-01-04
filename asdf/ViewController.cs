using System;

using AppKit;
using Foundation;

namespace asdf
{
	public partial class ViewController : NSViewController
	{
		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public static int numberOfTimesClicked = 0;

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.


		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		partial void Button1_Action(Foundation.NSObject sender)
		{

			// Update counter and label
			Label1.StringValue = string.Format("The button has been clicked {0} time{1}.", ++numberOfTimesClicked, (numberOfTimesClicked < 2) ? "" : "s");
		}
	}
}
