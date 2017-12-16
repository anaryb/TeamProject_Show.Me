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
        public TeamProject_ShowMe.Show.Show Show { get; set; }

        private string _oldName;


        public AddNewShowWindow(TeamProject_ShowMe.Show.Show show, ShowAction okAction)
        {
            InitializeComponent();
            _oldName = show.Name;
            Show = show;
            OkAction = okAction;
            DataContext = show;
        }

        private void buttonAddNewShow_Click(object sender, RoutedEventArgs e)
        {
            OkAction(Show);
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Show.Name = _oldName;
            Close();
        }
    }
}

