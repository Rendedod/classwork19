using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF19._1
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
            polotno.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            polotno.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            polotno.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            polotno.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            polotno.DefaultDrawingAttributes.Color = Colors.Aqua;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            polotno.DefaultDrawingAttributes.Width = 1;
            polotno.DefaultDrawingAttributes.Height = 1;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            polotno.DefaultDrawingAttributes.Width = 5;
            polotno.DefaultDrawingAttributes.Height = 5;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            polotno.DefaultDrawingAttributes.Width = 10;
            polotno.DefaultDrawingAttributes.Height = 10;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            polotno.DefaultDrawingAttributes.Width = 100;
            polotno.DefaultDrawingAttributes.Height = 100;
        }
    }
}
