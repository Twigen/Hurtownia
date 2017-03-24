using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Kontrachent.View;
using Kontrachent.ViewModels;

namespace Kontrachent.Adapters
{
    public class ViewService
    {
        public static Window CreateView(object viewModel)
        {
            if (viewModel is MainViewModel)
            {
                var mainView = new MainView { DataContext = viewModel };
                return mainView;
            }
            if (viewModel is AddContractorViewModel)
            {
                var addContractorView = new AddContractorView { DataContext = viewModel };
                return addContractorView;
            }
            if (viewModel is EditContractorViewModel)
            {
                var editContractorView = new EditContractorView { DataContext = viewModel };
                return editContractorView;
            }

            throw new ArgumentOutOfRangeException("viewModel nie został przekazany.");
        }

        public static void CloseView(Window view)
        {
            view.Close();
        }
    }
}
