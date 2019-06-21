﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HotUI.Forms.Sample {
	public partial class App : Application {
		public App ()
		{
			UI.Init ();
			InitializeComponent ();

			MainPage = new NavigationPage(new MainPage ().ToForms());
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
