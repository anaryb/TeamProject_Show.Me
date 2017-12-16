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

namespace ShowMe_UI
{
    /// <summary>
    /// Логика взаимодействия для ShowCollectionPage.xaml
    /// </summary>
    public partial class ShowCollectionPage : Page
    {
        public ShowCollectionPage()
        {
            InitializeComponent();
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.ShowRepository.Load();
                ShowCollectionList.ItemsSource = db.ShowRepository.Shows;

            }
        }

        private void ShowCollectionList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
