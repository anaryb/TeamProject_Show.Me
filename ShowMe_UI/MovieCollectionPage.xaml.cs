﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.Entity;
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
    /// Логика взаимодействия для MovieCollectionPage.xaml
    /// </summary>
    public partial class MovieCollectionPage : Page
    {
        public MovieCollectionPage()
        {
            InitializeComponent();
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.MovieRepository.Load();
                MovieCollectionList.ItemsSource = db.MovieRepository.Movies;

            }
            
            
        }
    }
}
