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

        private void AddNewMovieAdmin_Click(object sender, RoutedEventArgs e)
        {
            var w = new ShowMe_UI.AddNewMovieWindow(this);
            w.Show();
        }
    }
}
