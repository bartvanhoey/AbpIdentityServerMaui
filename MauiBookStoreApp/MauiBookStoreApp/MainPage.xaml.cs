using System;
using MauiBookStoreApp.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiBookStoreApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new MainViewModel();
		}

		
	}
}
