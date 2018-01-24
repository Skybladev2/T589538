using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomWorkTimeExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region #CustomWorkTime
        private void SchedulerControl_CustomWorkTime(object sender, DevExpress.Xpf.Scheduling.CustomWorkTimeEventArgs e)
        {
            if (e.Resource.Id.Equals("1"))
            {
                if (e.Interval.Start.Day % 2 == 0)
                {
                    List<TimeSpanRange> workTimes = new List<TimeSpanRange>();
                    workTimes.Add(new TimeSpanRange(TimeSpan.FromHours(0), TimeSpan.FromHours(3)));
                    workTimes.Add(new TimeSpanRange(TimeSpan.FromHours(5), TimeSpan.FromHours(8)));
                    workTimes.Add(new TimeSpanRange(TimeSpan.FromHours(10), TimeSpan.FromHours(11)));
                    e.WorkTimes = workTimes;
                }
                else
                    e.WorkTime = new TimeSpanRange(TimeSpan.FromHours(8), TimeSpan.FromHours(20));
            }
            if (e.Resource.Id.Equals("2"))
            {
                if (e.Interval.Start.Day % 2 == 0)
                    e.WorkTime = new TimeSpanRange(TimeSpan.FromHours(14), TimeSpan.FromHours(18));
                else
                    e.WorkTime = new TimeSpanRange(TimeSpan.FromHours(8), TimeSpan.FromHours(12));
            }
            if (e.Resource.Id.Equals("3"))
                e.WorkTime = new TimeSpanRange(TimeSpan.FromHours(14), TimeSpan.FromHours(21));
            if (e.Resource.Id.Equals("4"))
            {
                List<TimeSpanRange> workTimes = new List<TimeSpanRange>();
                workTimes.Add(new TimeSpanRange(TimeSpan.FromHours(8), TimeSpan.FromHours(11)));
                workTimes.Add(new TimeSpanRange(TimeSpan.FromHours(13), TimeSpan.FromHours(17)));
                e.WorkTimes = workTimes;
            }
        }
        #endregion #CustomWorkTime
    }
}
