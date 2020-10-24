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
    class ViewBVM : BindableBase, IRegionMemberLifetime
    {
        public ICommand PlayCommand { get; set; }

        public ViewBVM()
        {
            PlayCommand = new DelegateCommand(OnPlay);
        }

        private void OnPlay()
        {
            MessageBox.Show("Play B");
        }

        public bool KeepAlive => false;
    }
}
