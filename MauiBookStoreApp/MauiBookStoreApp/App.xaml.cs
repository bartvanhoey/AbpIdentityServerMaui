using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiBookStoreApp
{
	public partial class App : Application
	{

		public const string AuthorityUrl = "https://618beff66fa6.ngrok.io";
		public const string CallbackUri = "xamarinformsclients";
		public static readonly string RedirectUrl = $"{CallbackUri}:/authenticated";
		public static readonly string PostLogoutRedirectUrl = $"{CallbackUri}:/signout-callback-oidc";
		public const string Scopes = "email openid profile role phone address Medusa";
		public const string? ClientSecret = "1q2w3e*";
		public const string ClientId = "Medusa_Xamarin";


		public App()
		{
			InitializeComponent();
			MainPage = new MainPage();
		}
	}
}
