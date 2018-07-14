using System;
using SharedResources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace SharedResourceDemo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

		    Page page = new MainPage();

            var viewModel = new MainPageViewModel(
                new ResourceProvider());

		    page.BindingContext = viewModel;

		    MainPage = page;
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
