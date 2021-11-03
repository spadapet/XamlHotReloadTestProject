using Microsoft.Maui.Controls;
using System;

namespace MauiApp5
{
    public partial class App : Application
	{
		public static Random Random = new Random();

		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}
	}
}
