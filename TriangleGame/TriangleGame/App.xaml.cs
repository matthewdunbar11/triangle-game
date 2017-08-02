using Microsoft.Practices.Unity;
using Prism.Unity;
using TriangleGame.Services;
using TriangleGame.Views;
using Xamarin.Forms;

namespace TriangleGame
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();

            Container.RegisterType(typeof(IShareService), typeof(ShareService));
            Container.RegisterType(typeof(IGameService), typeof(GameService));
        }
    }
}
