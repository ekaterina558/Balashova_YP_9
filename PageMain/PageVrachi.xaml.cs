﻿using Balashova_YP_9.ApplicationData;
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

namespace Balashova_YP_9.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageVrachi.xaml
    /// </summary>
    public partial class PageVrachi : Page
    {
        public PageVrachi()
        {
            InitializeComponent();
            DtGridTovar.ItemsSource = ObshestvoEntities.GetContext().Vrachi.ToList();
        }

        private void ButBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.GoBack();
        }

        private void ButZr_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageClient(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ObshestvoEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DtGridTovar.ItemsSource = ObshestvoEntities.GetContext().Vrachi.ToList();
        }
    }
}
