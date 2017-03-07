using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Magazyn.Adapters;
using Magazyn.ViewModels;

namespace Magazyn
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainViewModel = new MainViewModel();
            var mainView = ViewService.CreateView(mainViewModel);
            mainView.ShowDialog();
        }
    }
}
