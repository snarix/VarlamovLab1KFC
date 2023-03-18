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

namespace VarlamovLab1SKFC
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

        private void Guesting(object sender, RoutedEventArgs e)
        {
            Programm.IsEnabled = true;
            int X = 1,
                Y = 2,
                Z = 3,
                V = 4,
                W;

            if (X - Y <= Z - V)
            {
                if (Z <= V)
                {
                    W = V;
                }
                else W = (Y + Z) / 2;
            }
            else
            {
                if (X <= Y)
                {
                    W = (Y + Z) / 2;
                }
                else W = X;
            }
            Textik.Text = "X = " + X + "\nY = " + Y + "\nZ = " + Z + "\nV = " + V;
            MessageBox.Show(Convert.ToString(W));
        }

        private void WindowStart(object sender, RoutedEventArgs e)
        {
            Login password = new();
            password.Owner = this;
            password.ShowDialog();
        }

        private void Usering(object sender, RoutedEventArgs e)
        {
            Login password = new();
            password.Owner = this;
            password.ShowDialog();
            Programm.IsEnabled = true;

            if (int.TryParse(X.Text, out int x) & int.TryParse(Y.Text, out int y) & int.TryParse(Z.Text, out int z) & int.TryParse(V.Text, out int v))
            {
                int w;
                if (x - y <= z - v)
                {
                    if (z <= v)
                    {
                        w = v;
                    }
                    else w = (y + z) / 2;
                }
                else
                {
                    if (x <= y)
                    {
                        w = (y + z) / 2;
                    }
                    else w = x;
                }
                Textik.Text = "X = " + x + "\nY = " + y + "\nZ = " + z + "\nV = " + v;
                MessageBox.Show(Convert.ToString(w));
            }
        }

        private void Admining(object sender, RoutedEventArgs e)
        {
            LoginAdmin password = new();
            password.Owner = this;
            password.ShowDialog();
            Programm.IsEnabled = true;
            if (int.TryParse(X1.Text, out int x) & int.TryParse(Y1.Text, out int y) & int.TryParse(Z1.Text, out int z) & int.TryParse(V1.Text, out int v))
            {
                int w;
                if (x - y <= z - v)
                {
                    if (z <= v)
                    {
                        w = v;
                    }
                    else w = (y + z) / 2;
                }
                else
                {
                    if (x <= y)
                    {
                        w = (y + z) / 2;
                    }
                    else w = x;
                }
                Textik.Text = "X = " + x + "\nY = " + y + "\nZ = " + z + "\nV = " + v;
                MessageBox.Show(Convert.ToString(w));
            }
        }
    }
}
