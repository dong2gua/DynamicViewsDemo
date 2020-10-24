using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace DynamicViewsDemo
{
    class MainWindowVM : BindableBase
    {
        private IRegionManager _regionManager;
        public ICommand SwitchCommand { get; set; }
        private string _viewA = "ViewA";
        private string _viewB = "ViewB";
        private string _currentPageURL;

        public MainWindowVM(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            SwitchCommand = new DelegateCommand(OnSwitch);
        }

        private void OnSwitch()
        {
            _regionManager.RequestNavigate("ContentRegion", _currentPageURL != _viewA ? _viewA : _viewB, OnNavigation);
        }

        private void OnNavigation(NavigationResult obj)
        {
            _currentPageURL = obj.Context.Uri.ToString();
        }
    }
}
