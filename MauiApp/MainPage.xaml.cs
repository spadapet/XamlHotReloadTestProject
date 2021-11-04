using Microsoft.Maui.Controls;
using System;

namespace MauiApp5
{
    public partial class MainPage : ContentPage
	{
        public MainViewModel ViewModel { get; } = new MainViewModel();

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnClicked(object sender, EventArgs args)
		{
			ViewModel.Count++;
		}

		//private void OnClicked2(object sender, EventArgs args)
		//{
		//	ViewModel.Count += 2;
		//}
	}
}
