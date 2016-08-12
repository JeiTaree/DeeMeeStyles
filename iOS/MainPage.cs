using Foundation;
using System;
using UIKit;

namespace DeeMeeStyles.iOS
{
    public partial class MainPage : UIViewController
    {

		public MainPage(IntPtr handle) : base(handle)
		{
		}

		partial void UIButton19_TouchUpInside(UIButton sender)
		{
			Styles StylePage = this.Storyboard.InstantiateViewController("Styles") as Styles;
			this.NavigationController.PushViewController(StylePage, true);
		}

		partial void UIButton20_TouchUpInside(UIButton sender)
		{
			Booking BookingPage = this.Storyboard.InstantiateViewController("Booking") as Booking;
			this.NavigationController.PushViewController(BookingPage, true);		}

		partial void UIButton21_TouchUpInside(UIButton sender)
		{
			gallery GalleryPage = this.Storyboard.InstantiateViewController("gallery") as gallery;
			this.NavigationController.PushViewController(GalleryPage, true);
		}


		partial void UIButton22_TouchUpInside(UIButton sender)
		{
			About AboutPage = this.Storyboard.InstantiateViewController("About") as About;
			this.NavigationController.PushViewController(AboutPage, true);
		}

		partial void UIButton23_TouchUpInside(UIButton sender)
		{
			Contact contactPage = this.Storyboard.InstantiateViewController("Contact") as Contact;
			this.NavigationController.PushViewController(contactPage, true);
		}

	}
}