using DryIoc;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Essentials;
using Xamarin.Forms;
using Device = Xamarin.Forms.Device;
using System;
using System.Diagnostics;
using ReactiveUIXamarin.ViewModels;
using ReactiveUIXamarin.Infrastructure.DI;

namespace ReactiveUIXamarin
{
    public partial class App
    {
        public static IContainer AppContainer;
        public static IContainerRegistry AppContainerRegistry;
        private static readonly Lazy<App> LazyInstance =
          new Lazy<App>(() => new App());
        public static App Instance => LazyInstance.Value;
        public App()
        {
          
        }
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            new ServiceDIBindings().Configure(containerRegistry);
            AppContainer = containerRegistry.GetContainer();
            AppContainerRegistry = containerRegistry;
        }
    }
}
