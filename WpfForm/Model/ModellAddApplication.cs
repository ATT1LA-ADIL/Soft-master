using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prism.Mvvm;
using LiveCharts;
using LiveCharts.Geared;
using System.Windows.Media;
using System.Reflection;

namespace Программное_обеспечение_для_Диспетчеров_Службы_Спасения.WpfForm.Model
{
   public class ModellAddApplication : BindableBase, IDataErrorInfo
   {
       private string _statistic = null;

        public string Statistic
        {
            get { return _statistic; }
            set
            {
                _statistic = value;
                RaisePropertyChanged();
            }
        }

        private DateTime _startDateTime = DateTime.Now;

       public DateTime StartDateTime
        {
            get { return _startDateTime; }
            set
            {
                _startDateTime = value;
                RaisePropertyChanged();
            }
        }

        private DateTime _finishDateTime = DateTime.Now;

        public DateTime FinishDateTime
        {
            get { return _finishDateTime; }
            set
            {
                _finishDateTime = value;
                RaisePropertyChanged();
            }
        }


        public ModellAddApplication()
       {
           UpdateModel();
       }

       private void UpdateModel()
       {
            AddApplicationWork();
            AddApplicationWin();
        }

       private void AddApplicationWork()
       {
            ApplicationWork.Clear();
            using (DbTest db = new DbTest())
            {
                var app = db.Aplication.Where(appl => appl.Status ==true);
                foreach (Aplication aplication in app)
                {
                    ApplicationWork.Add(aplication);
                }
            }
        }

        private void AddApplicationWin()
        {
            ApplicationWin.Clear();
            using (DbTest db = new DbTest())
            {
                var app = db.Aplication.Where(appl => appl.Status == false);
                foreach (Aplication aplication in app)
                {
                    ApplicationWin.Add(aplication);
                }
            }
        }

        public Aplication SelectAplication { get; set; }

      private ObservableCollection<Aplication>  _applicationwork = new ObservableCollection<Aplication>();
      public ObservableCollection<Aplication> ApplicationWork
        {
            get { return _applicationwork; }
            set
            {
                _applicationwork = value;
                RaisePropertyChanged();
            }
        }
        private ObservableCollection<Aplication> _applicationwin = new ObservableCollection<Aplication>();
        public ObservableCollection<Aplication> ApplicationWin
        {
            get { return _applicationwin; }
            set
            {
                _applicationwin = value;
                RaisePropertyChanged();
            }
        }



        private string _messageDb = null;
        public string MessageDb
        {
            get { return _messageDb; }
            set
            {
                _messageDb = value;
                RaisePropertyChanged();
            }
        }


        private string _name = null;
        private string _surname = null;
        private string _middleName = null;
        private string _adress = null;
        private string _problem = null;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                RaisePropertyChanged();
            }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                _middleName = value;
                RaisePropertyChanged();
            }
        }

        public string Adress
        {
            get { return _adress; }
            set
            {
                _adress  = value;
                RaisePropertyChanged();
            }
        }

        public string Problem
        {
            get { return _problem; }
            set
            {
                _problem = value;
                RaisePropertyChanged();
            }
        }


        /// <summary>
        /// Попадание ошибки
        /// </summary>
        public string Error { get; set; }
        /// <summary>
        /// Проверка состояния объектов
        /// </summary>
        private bool _isValid;
        /// <summary>
        /// Метод проверки данных
        /// </summary>
        /// <returns>true and false</returns>
        public bool IsValidation()
        {
            RaisePropertyChanged("Name");
            RaisePropertyChanged("Surname");
            RaisePropertyChanged("MiddleName");
            RaisePropertyChanged("Adress");
            RaisePropertyChanged("Problem");
            return _isValid;
        }
        /// <summary>
        /// Интерфейс по проверки ошибки
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public string this[string columnName]
        {
            get { return ValidateErrs(columnName); }
        }
        /// <summary>
        /// Собственно сама реализация проверки достоверности по IDataErrorInfo
        /// </summary>
        /// <param name="columnName">Проверяемая колонка</param>
        /// <returns></returns>
        private string ValidateErrs(string columnName)
        {
            _isValid = false;
            Error = null;
            switch (columnName)
            {
                case "Name":
                    if (!String.IsNullOrEmpty(Name))
                    { _isValid = true; break; }
                    { Error = "Ошибка не введено имя"; break; }
                case "Surname":
                    if (!String.IsNullOrEmpty(Surname))
                    { _isValid = true; break; }
                    { Error = "Ошибка не введена фамилия"; break; }
                case "MiddleName":
                    if (!String.IsNullOrEmpty(MiddleName))
                    { _isValid = true; break; }
                    { Error = "Ошибка не введено отчество"; break; }
                case "Adress":
                    if (!String.IsNullOrEmpty(Adress))
                    { _isValid = true; break; }
                    { Error = "Ошибка не введен адрес"; break; }
                case "Problem":
                    if (!String.IsNullOrEmpty(Problem))
                    { _isValid = true; break; }
                    { Error = "Ошибка не введена проблема"; break; }
                case "StartDateTime":
                    if (StartDateTime < FinishDateTime)
                    { _isValid = true; break; }
                    { Error = "Стартовая дата не может быть больше финиширующей!!!"; break; }
                case "FinishDateTime":
                    if (FinishDateTime > StartDateTime)
                    { _isValid = true; break; }
                    { Error = "Финиширующая дата не может быть больше стартовой!!!"; break; }
            }
            return Error;
        }
        /// <summary>
        /// Проверка даты на статистике
        /// </summary>
        /// <returns></returns>
        public bool IsValidationDateStatistics()
        {
            RaisePropertyChanged("StartDateTime");
            RaisePropertyChanged("FinishDateTime");
            return _isValid;
        }

        public void StatusWin()
       {
           if (SelectAplication == null)
           {
                MessageBox.Show(@"Ошибка не выбран объект");
           }
           else
           {
               SelectAplication.Status = false;
               using (DbTest db = new DbTest())
               {
                    db.Entry(SelectAplication).State = EntityState.Modified;
                   db.SaveChanges();
               }
                UpdateModel();
            }

       }

        public void DeleteApplication()
        {
            if (SelectAplication == null)
            {
                MessageBox.Show(@"Ошибка не выбран объект");
            }
            else
            {
                using (DbTest db = new DbTest())
                {
                    db.Entry(SelectAplication).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                UpdateModel();
            }
        }


        public void CreateApplication()
        {
            if (IsValidation())
            {
                var application = new Model.Aplication()
                {
                    Name = Name,
                    Adress = Adress,
                    Surname = Surname,
                    MiddleName = MiddleName,
                    Problem = Problem,
                    Status = true
                };

                using (DbTest db = new DbTest())
                {
                    db.Aplication.Add(application);
                    db.SaveChanges();
                    MessageDb = "Сохранили В БД";
                    UpdateModel();
                }
            }
            else
            {
                MessageBox.Show(@"Не введены данные");
            }
        }

       /// <summary>
       /// Сбор статистики
       /// </summary>
       public void SeathStatistics()
       {
           if (!IsValidationDateStatistics())
           {
                MessageBox.Show("Ошибки в дате диопазона!!!");
           }
           else
           {
                IQueryable<Aplication>[] iqveryarray = new IQueryable<Aplication>[3];
                using (DbTest db = new DbTest())
                {
                    var allapp  = db.Aplication.Where(appl => appl.DateCreate >= StartDateTime || appl.DateCreate <= FinishDateTime);
                    var trueapp = db.Aplication.Where(appl => appl.Status ==true);
                    var falseapp = db.Aplication.Where(appl => appl.Status == false);
                    iqveryarray[0] = allapp;
                    iqveryarray[1] = trueapp;
                    iqveryarray[2] = falseapp;
                    MainWindow(iqveryarray);
                    Statistic =$@"Количество заявок в диопазоне c {StartDateTime} по {FinishDateTime}";
                }
            }
       }

        ///Тестим
        private RecordCollection _records = null;
        public RecordCollection Records
        {
            get { return _records; }
            set
            {
                _records = value;
                RaisePropertyChanged();
            }
        }
        public void MainWindow(IQueryable<Aplication>[] arrayStatistics)
        {
            Records = null;
            List<Bar> _bar = new List<Bar>();
            _bar.Add(new Bar() { BarName = "Всего", Value = arrayStatistics[0].Count() });
            _bar.Add(new Bar() { BarName = "Окрыто", Value = arrayStatistics[1].Count() });
            _bar.Add(new Bar() { BarName = "Закрыто", Value = arrayStatistics[2].Count() });
            Records = new RecordCollection(_bar);
            
        }
    }

  public class RecordCollection : ObservableCollection<Record>
    {

        public RecordCollection(List<Bar> barvalues)
        {
            Random rand = new Random();
            BrushCollection brushcoll = new BrushCollection();

            foreach (Bar barval in barvalues)
            {
                int num = rand.Next(brushcoll.Count / 3);
                Add(new Record(barval.Value, brushcoll[num], barval.BarName));
            }
        }

    }

   public class BrushCollection : ObservableCollection<Brush>
    {
        public BrushCollection()
        {
            Type _brush = typeof(Brushes);
            PropertyInfo[] props = _brush.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                Brush _color = (Brush)prop.GetValue(null, null);
                if (_color != Brushes.LightSteelBlue && _color != Brushes.White &&
                     _color != Brushes.WhiteSmoke && _color != Brushes.LightCyan &&
                     _color != Brushes.LightYellow && _color != Brushes.Linen)
                    Add(_color);
            }
        }
    }

  public  class Bar
    {

        public string BarName { set; get; }

        public int Value { set; get; }

    }

  public  class Record : INotifyPropertyChanged
    {
        public Brush Color { set; get; }

        public string Name { set; get; }

        private int _data;
        public int Data
        {
            set
            {
                if (_data != value)
                {
                    _data = value;

                }
            }
            get
            {
                return _data;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Record(int value, Brush color, string name)
        {
            Data = value;
            Color = color;
            Name = name;
        }

        protected void PropertyOnChange(string propname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
            }
        }
    }
}
