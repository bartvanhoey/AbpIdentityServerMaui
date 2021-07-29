using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConnectToApi
{
    public partial class App
    {
        public const string AuthorityUrl = "https://f1d705976803.ngrok.io";
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



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
