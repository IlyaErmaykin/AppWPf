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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppWPF.Views
{
    /// <summary>
    /// Логика взаимодействия для ShowListView.xaml
    /// </summary>
    public partial class ShowListView : Window
    {
        /// <summary>
        /// Show list view default constructor
        /// </summary>
        public ShowListView()
        {
            this.DataContext = this;

            InitializeComponent();
        }
    }
}
