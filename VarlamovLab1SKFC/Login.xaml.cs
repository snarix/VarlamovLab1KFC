﻿using System;
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

namespace VarlamovLab1SKFC
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtPas.Focus();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            if (txtPas.Password == "123") Close();
            else
            {
                MessageBox.Show("Пароль неверен, попробуй еще раз");
                txtPas.Focus();
            }
        }

        private void Esc(object sender, RoutedEventArgs e)
        {
            this.Owner.Close();
        }
    }
}
