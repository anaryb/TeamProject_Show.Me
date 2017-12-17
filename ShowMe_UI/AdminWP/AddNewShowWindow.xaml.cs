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
    public delegate void ShowAction(TeamProject_ShowMe.Show.Show show);
    /// <summary>
    /// Логика взаимодействия для AddNewShowWindow.xaml
    /// </summary>
    public partial class AddNewShowWindow : Window
    {


        public ShowAction OkAction { get; set; }
        public TeamProject_ShowMe.Show.Show ShowC { get; set; }

        private string _oldName;
        private double _oldRating;
        private int _oldYear;
        private string _oldDescription;


        public AddNewShowWindow(TeamProject_ShowMe.Show.Show show, ShowAction okAction)
        {
            InitializeComponent();
            _oldName = show.Name;
            _oldRating = show.Rating;
            _oldYear = show.Year;
            _oldDescription = show.Description;
            ShowC = show;
            OkAction = okAction;
            DataContext = show;
        }

        private void buttonAddNewShow_Click(object sender, RoutedEventArgs e)
        {
            OkAction(ShowC);
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            ShowC.Name = _oldName;
            ShowC.Rating = _oldRating;
            ShowC.Year = _oldYear;
            ShowC.Description = _oldDescription;
            Close();
        }

       
    }
}

