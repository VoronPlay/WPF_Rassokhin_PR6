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

namespace WPF_Rassokhin_PR6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (pwBox.Password.ToString() == "12345" && logBox.Password.ToString() == "Deniska")
            {
                statusText.Text = "Пароль и логин верны";
                Window1 window1 = new Window1();
                window1.Show();
            }
            else if (pwBox.Password.ToString() != "12345")
            {
                MessageBox.Show("Пароль не верный");
            }
            else if (logBox.Password.ToString() != "Deniska")
            {
                MessageBox.Show("Логин не верный");
            }











        }

    }
    }

