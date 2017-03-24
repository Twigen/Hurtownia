using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Kontrachent.Adapters;
using Kontrachent.ViewModels;

namespace Kontrachent
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
