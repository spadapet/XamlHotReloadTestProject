using Microsoft.Maui.Controls;
using System;

namespace MauiApp5
{
    public partial class MainPage : ContentPage
	{
        public MainViewModel ViewModel { get; } = new MainViewModel();
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			CounterLabel.Text = $"Current count: {++count}";
		}

		//private void OnCounterClicked2(object sender, EventArgs e)
		//{
		//    CounterLabel.Text = $"Current count: {count += 2}";
		//}
	}
}
