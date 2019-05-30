using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Программное_обеспечение_для_Диспетчеров_Службы_Спасения.WpfForm.View;

namespace Программное_обеспечение_для_Диспетчеров_Службы_Спасения.WpfForm.LoadWpfTo_WinForm
{
   public class LoadWpf 
    {
        /// <summary>
        /// Сами страницы
        /// </summary>
        public UserControl[] UserControls = new UserControl[3];

        /// <summary>
        /// Загрузка страниц и помещения в них ViewModel для патерна MVVM
        /// </summary>
        public LoadWpf()
        {
            ViewModel.ViewModel viewModel = new ViewModel.ViewModel();
            UserControls[0] = new Applications(viewModel);
            UserControls[1] = new Fulfilled(viewModel);
            UserControls[2] = new Statistics(viewModel);
        }

    }
}
