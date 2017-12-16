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

namespace ShowMe_UI
{
    /// <summary>
    /// Логика взаимодействия для AdminMovieCollectionPage.xaml
    /// </summary>
    public partial class AdminMovieCollectionPage : Page
    {
        public AdminMovieCollectionPage()
        {
            InitializeComponent();
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.MovieRepository.Load();
                adminMoviesList.ItemsSource = db.MovieRepository.Movies;

            }
        }

        private void AddNew(TeamProject_ShowMe.Movie.Movie movie)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.MovieRepository.Load();
                db.MovieRepository.AddMovie(movie);
                adminMoviesList.ItemsSource = db.MovieRepository.Movies;


            }
        }
        private void Edit(TeamProject_ShowMe.Movie.Movie movie)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.MovieRepository.UpdateMovie(movie);
            }
        }


        private void AddNewMovieAdmin_Click(object sender, RoutedEventArgs e)
        {
            var w = new ShowMe_UI.AddNewMovieWindow(new TeamProject_ShowMe.Movie.Movie(), AddNew);
            w.Show();
        }
    }
}

