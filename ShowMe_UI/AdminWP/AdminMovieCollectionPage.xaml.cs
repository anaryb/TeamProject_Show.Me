using System;
using System.Collections.Generic;
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

namespace ShowMe_UI
{
    /// <summary>
    /// Логика взаимодействия для AdminMovieCollectionPage.xaml
    /// </summary>
    public partial class AdminMovieCollectionPage : Page
    {
        TeamProject_ShowMe.MediaCenterContext context = new TeamProject_ShowMe.MediaCenterContext();
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
        //private void Edit(TeamProject_ShowMe.Movie.Movie movie)
        //{
        //    using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
        //    {
        //        db.MovieRepository.UpdateMovie(movie);
        //    }
        //}
        private void Delete(TeamProject_ShowMe.Movie.Movie movie)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.MovieRepository.RemoveMovie(movie);
                adminMoviesList.ItemsSource = db.MovieRepository.Movies;
                db.MovieRepository.Load();

            }
        }


        private void AddNewMovieAdmin_Click(object sender, RoutedEventArgs e)
        {
            var w = new ShowMe_UI.AddNewMovieWindow(new TeamProject_ShowMe.Movie.Movie(), AddNew);
            w.ShowDialog();//////////////////////////
        }

        private void DeleteMovieAdmin_Click(object sender, RoutedEventArgs e)
        {
            //Delete((TeamProject_ShowMe.Movie.Movie)adminMoviesList.SelectedItem);
           
                context.MovieRepository.RemoveMovie((Movie)adminMoviesList.SelectedItem);
            context.SaveChanges();
            context.Movies.Load();
            adminMoviesList.ItemsSource = null;
            adminMoviesList.ItemsSource = context.Movies.Local.ToBindingList();
            context.SaveChanges();
            
        }

        private void buttonSaveChangesMovies_Click(object sender, RoutedEventArgs e)
        {
            //Edit((TeamProject_ShowMe.Movie.Movie)adminMoviesList.SelectedItem);

            RefrechList();
        }

        private void RefrechList()
        {
            using (var db = new TeamProject_ShowMe.MediaCenterContext())
            {
                var tab = db.Movies.Local.ToBindingList();
                adminMoviesList.ItemsSource = null;
                adminMoviesList.ItemsSource = tab;

            }

        }
    }
}

