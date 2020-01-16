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

namespace Zadanie5
{
    /// <summary>
    /// Interaction logic for DodajStudenta.xaml
    /// </summary>
    public partial class DodajStudenta : Window
    {
        public DodajStudenta()
        {
            InitializeComponent();

            Cmb.ItemsSource = Models.Studies._StudiesList;
            Lb.ItemsSource = Models.Subject._SubjectList;
        }
    }
}
