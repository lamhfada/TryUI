using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TryUI
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            Page a = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.Blue
            };
            MainPage = a;
            //MainPage = new TryUI.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
