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
using System.Windows.Shapes;

namespace WPF_Rassokhin_PR6
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                if (!datePicker1.SelectedDate.HasValue || !datePicker2.SelectedDate.HasValue)
                {
                    textBlock1.Text = "Select dates";
                    return;
                }

                DateTime start = datePicker1.SelectedDate.Value.Date;
                DateTime finish = datePicker2.SelectedDate.Value.Date;
                TimeSpan difference = finish.Subtract(start);
                textBlock1.Text = difference.TotalDays.ToString();
            }
        }
        }
    }

