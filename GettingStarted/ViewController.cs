using Foundation;
using System;
using Syncfusion.iOS.Buttons;
using UIKit;
using CoreGraphics;

namespace GettingStarted
{
	public partial class ViewController : UIViewController
	{
	    bool skip = false;
		SfCheckBox selectAll, pepperoni, beef, mushroom, onion;

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			selectAll = new SfCheckBox();
			selectAll.Frame = new CGRect(50, 50, 200, 50);
			selectAll.StateChanged += SelectAll_StateChanged;
			selectAll.SetTitle("Select All", UIControlState.Normal);

			pepperoni = new SfCheckBox();
			pepperoni.Frame = new CGRect(50, 100, 200, 50);
			pepperoni.StateChanged += CheckBox_StateChanged;
			pepperoni.SetTitle("Pepperoni", UIControlState.Normal);

			beef = new SfCheckBox();
			beef.Frame = new CGRect(50, 150, 200, 50);
			beef.StateChanged += CheckBox_StateChanged;
			beef.SetTitle("Beef", UIControlState.Normal);
			beef.IsChecked = true;

			mushroom = new SfCheckBox();
			mushroom.Frame = new CGRect(50, 200, 200, 50);
			mushroom.StateChanged += CheckBox_StateChanged;
			mushroom.SetTitle("Mushrooms", UIControlState.Normal);

			onion = new SfCheckBox();
			onion.Frame = new CGRect(50, 250, 200, 50);
			onion.StateChanged += CheckBox_StateChanged;
			onion.SetTitle("Onions", UIControlState.Normal);
			onion.IsChecked = true;

			this.View.AddSubview(selectAll);
			this.View.AddSubview(pepperoni); 
			this.View.AddSubview(beef);
			this.View.AddSubview(mushroom);
			this.View.AddSubview(onion);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		private void SelectAll_StateChanged(object sender, StateChangedEventArgs e)
		{
			if (!skip)
			{
				skip = true;
				pepperoni.IsChecked = beef.IsChecked = mushroom.IsChecked = onion.IsChecked = e.IsChecked;
				skip = false;
			}
		}

		private void CheckBox_StateChanged(object sender, StateChangedEventArgs e)
		{
			if (!skip)
			{
				skip = true;
				if (pepperoni.IsChecked.Value && beef.IsChecked.Value && mushroom.IsChecked.Value && onion.IsChecked.Value)
					selectAll.IsChecked = true;
				else if (!pepperoni.IsChecked.Value && !beef.IsChecked.Value && !mushroom.IsChecked.Value && !onion.IsChecked.Value)
					selectAll.IsChecked = false;
				else
					selectAll.IsChecked = null;
				skip = false;
			}
		}
	}
}