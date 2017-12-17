using System;
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
using TeamProject_ShowMe.Movie;
using TeamProject_ShowMe;

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

        private void buttonSearchMovie_Click(object sender, RoutedEventArgs e)
        {
            var w = new SearchWindow(this);
            w.SeaList += UpdateList;
            w.Show();

        }

        private void UpdateList(IEnumerable l)
        {
            MovieCollectionList.ItemsSource = null;
            MovieCollectionList.ItemsSource = l;
        }

        private void buttonListMovie_Click(object sender, RoutedEventArgs e)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.MovieRepository.Load();
                MovieCollectionList.ItemsSource = null;
                MovieCollectionList.ItemsSource = db.MovieRepository.Movies;

            }
        }

        private void buttonListMoviebyRating_Click(object sender, RoutedEventArgs e)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new MediaCenterContext())
            {
                db.MovieRepository.Load();
                MovieCollectionList.ItemsSource = null;
                MovieCollectionList.ItemsSource = db.RatingSort();
            }
        }
    }
}
