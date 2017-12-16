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
    /// Логика взаимодействия для AdminShowCollection.xaml
    /// </summary>
    public partial class AdminShowCollection : Page
    {
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

        private void AddNewShowAdmin_Click(object sender, RoutedEventArgs e)
        {
            var w = new AddNewShowWindow(new TeamProject_ShowMe.Show.Show(), AddNew);
            w.ShowDialog();
        }


    }
}