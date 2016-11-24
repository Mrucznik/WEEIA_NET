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

namespace Dotnety2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x3, x2, x1, x, r;
            x3 = int.Parse(Skladnik1.Text);
            x2 = int.Parse(Skladnik2.Text);
            x1 = int.Parse(Skladnik3.Text);
            r = int.Parse(Skladnik4.Text);
            x = int.Parse(TbX.Text);
            Wynik.Text = $"={x3*x3*x3*x + x2*x2*x + x1*x + r}";
        }
    }
}
