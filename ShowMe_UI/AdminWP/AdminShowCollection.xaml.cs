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

namespace ShowMe_UI
{
    /// <summary>
    /// Логика взаимодействия для AdminShowCollection.xaml
    /// </summary>
    public partial class AdminShowCollection : Page
    {
        TeamProject_ShowMe.MediaCenterContext context = new TeamProject_ShowMe.MediaCenterContext();
        public AdminShowCollection()
        {
            InitializeComponent();
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.ShowRepository.Load();
                adminShowList.ItemsSource = db.ShowRepository.Shows;

            }
        }

        private void AddNew(TeamProject_ShowMe.Show.Show show)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.ShowRepository.Load();
                db.ShowRepository.AddShow(show);
                adminShowList.ItemsSource = db.ShowRepository.Shows;
            }
        }

        private void Edit(TeamProject_ShowMe.Show.Show show)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.ShowRepository.UpdateShow(show);
            }
        }

        private void Delete(TeamProject_ShowMe.Show.Show show)
        {
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                db.ShowRepository.RemoveShow(show);
                adminShowList.ItemsSource = db.ShowRepository.Shows;
                db.ShowRepository.Load();
            }
        }

        private void AddNewShowAdmin_Click(object sender, RoutedEventArgs e)
        {
            var w = new AddNewShowWindow(new TeamProject_ShowMe.Show.Show(), AddNew);
            w.ShowDialog();///////////////////////
        }

        private void buttonSaveChangesMovies_Click(object sender, RoutedEventArgs e)
        {
            Edit((TeamProject_ShowMe.Show.Show)adminShowList.SelectedItem);
            RefrechList();
        }



        private void RefrechList()
        {
            context.Shows.Load();
            var tab = context.Shows.Local.ToBindingList();
            adminShowList.ItemsSource = null;
            adminShowList.ItemsSource = tab;
        }

        private void DeleteShowAdmin_Click(object sender, RoutedEventArgs e)
        {
            Delete((TeamProject_ShowMe.Show.Show)adminShowList.SelectedItem);
            RefrechList();
        }
    }
}