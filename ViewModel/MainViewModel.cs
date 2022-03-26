using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using O_PAY_O.View;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using O_PAY_O.Model;
using System.Windows.Media;
using System.Windows;
using O_PAY_O.Services.Classes;

namespace O_PAY_O.ViewModel
{

    public class SeriesData
    {
        //public static readonly DependencyProperty Color = DependencyProperty.RegisterAttached(
        //"Color", typeof(Brush), typeof(SeriesData), new PropertyMetadata(default(Brush)));

        //public static void SetFormatSegment1(DependencyObject element, string value)
        //{
        //    element.SetValue(FormatSegment1Property, value);
        //}

        //public static string GetFormatSegment1(DependencyObject element)
        //{
        //    return (string)element.GetValue(FormatSegment1Property);
        //}

        public Brush? Color { get; set; }
        public double Count { get; set; }
    }



    public class MainViewModel : ViewModelBase
    {

        //public static readonly DependencyProperty SelectedItemGUIDProperty = DependencyProperty.Register("Color", typeof(Guid?), typeof(UserControl), new FrameworkPropertyMetadata(null));

        //public Brush? Color
        //{
        //public Brush? Color
        //{
        //    get { return (Guid?)GetValue(SelectedItemGUIDProperty); }
        //    set { SetValue(Color, (Guid?)SelectedItem.GetType().GetProperty("GUID").GetValue(SelectedItem, null)); }
        //}
        //}
        //}


        public MainViewModel()
        {
            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "NULL",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(0) },
                    DataLabels = false
                },
            };
        }

        private RelayCommand<SeriesData> add;
        public RelayCommand<SeriesData> Add
        {
            get
            {
                if (add == null)
                    add = new RelayCommand<SeriesData>(AddSeries);
                return add;
            }
        }

        private void AddSeries(SeriesData obj)
        {
            var vals = new ChartValues<ObservableValue>();

            vals.Add(new ObservableValue(10));
            SeriesCollection.Add(new PieSeries
            {
                Values = vals,
                Fill = obj.Color,
            });
        }


        public SeriesCollection SeriesCollection { get; set; }

        public RelayCommand Balance
        {
            get => new RelayCommand(() =>
            {
                //NavigationService.NavigateTo<>();
            });
        }

        public RelayCommand Open
        {
            get => new RelayCommand(() =>
            {
                DialogView a = new();

                a.ShowDialog();
            });
        }

    }

}
