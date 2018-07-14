using System.Reflection;
using SharedResources;
using Xamarin.Forms;

namespace SharedResourceDemo
{
    class MainPageViewModel
    {
        private readonly ResourceProvider _resources;

        public MainPageViewModel(ResourceProvider resources)
        {
            _resources = resources;
            
            // Either of these would work

            //Image = ImageSource.FromResource("SharedResources.Resources.image.png", Assembly.GetAssembly(typeof(ResourceProvider)));

            Image = ImageSource.FromStream(() => _resources.GetResource());
        }

        public ImageSource Image { get; }
    }
}
