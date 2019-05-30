using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Prism.Commands;
using Программное_обеспечение_для_Диспетчеров_Службы_Спасения.WpfForm.Model;

namespace Программное_обеспечение_для_Диспетчеров_Службы_Спасения.WpfForm.ViewModel
{
   public class ViewModel
    {

        public Model.ModellAddApplication ModelApplication { get; set; }

        public ICommand CreteApplication { get; set; }
        public ICommand StatusWin { get; set; }

        public ICommand DeleteApplication{ get; set; }

        public ICommand Statistic { get; set; }
        /// <summary>
        /// Модель всех форм
        /// </summary>
        public ViewModel()
        {
           ModelApplication = new ModellAddApplication() {}; 
           CreteApplication = new DelegateCommand((() => { ModelApplication.CreateApplication(); }));
           StatusWin = new DelegateCommand((() => { ModelApplication.StatusWin(); }));
           Statistic = new DelegateCommand((() => { ModelApplication.SeathStatistics(); }));
           DeleteApplication = new DelegateCommand((() => { ModelApplication.DeleteApplication(); }));
        }

    }
}
