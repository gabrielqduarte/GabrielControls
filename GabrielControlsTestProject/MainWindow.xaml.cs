﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace GabrielControlsTestProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            vm = new ViewModel();
            vm.Text = "Teste";
            vm.Valor = 350.20m;
            vm.MaxLength = 500;
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.MaxLength = 10;
        }
    }

    public class ViewModel
    {
        private string _Text;

        public string Text { get { return _Text; } set { _Text = value; OnPropertyChanged(); } }

        private decimal _Valor;

        public decimal Valor { get { return _Valor; } set { _Valor = value; OnPropertyChanged(); } }

        private int _MaxLength;

        public int MaxLength { get { return _MaxLength; } set { _MaxLength = value; OnPropertyChanged(); } }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName]string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged Members
    }
}