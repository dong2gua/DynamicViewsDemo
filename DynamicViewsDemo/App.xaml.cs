using System.Windows;
using DynamicViewsDemo.View;
using DynamicViewsDemo.ViewModel;
using Prism.Ioc;
using Prism.Mvvm;
using Unity.Lifetime;

namespace DynamicViewsDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<MainWindow, MainWindowVM>();

            ViewModelLocationProvider.Register<ViewA, ViewAVM>();
            ViewModelLocationProvider.Register<ViewB, ViewBVM>();

            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();

        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
