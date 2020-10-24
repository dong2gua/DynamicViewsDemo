using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace DynamicViewsDemo.ViewModel
{
    class ViewAVM : BindableBase, IRegionMemberLifetime
    {
        public ICommand PlayCommand { get; set; }

        public ViewAVM()
        {
            PlayCommand = new DelegateCommand(OnPlay);
        }

        private void OnPlay()
        {
            MessageBox.Show("Play A");
        }

        public bool KeepAlive => false;
    }
}
