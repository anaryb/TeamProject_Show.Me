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
using System.Windows.Shapes;

namespace ShowMe_UI
{
    public delegate void MovieAction(TeamProject_ShowMe.Movie.Movie movie);
    /// <summary>
    /// Логика взаимодействия для AddNewMovieWindow.xaml
    /// </summary>
    public partial class AddNewMovieWindow : Window
    {
        public MovieAction OkAction { get; set; }
        public TeamProject_ShowMe.Movie.Movie Movie { get; set; }

        private string _oldName;

        public AddNewMovieWindow(TeamProject_ShowMe.Movie.Movie movie, MovieAction okActiom)

        {
            InitializeComponent();
            _oldName = movie.Name;
            Movie = movie;
            OkAction = okActiom;
            DataContext = movie;
        }

        private void buttonAddNewMovie_Click(object sender, RoutedEventArgs e)
        {
            OkAction(Movie);
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Movie.Name = _oldName;
            Close();
        }
    }
}




