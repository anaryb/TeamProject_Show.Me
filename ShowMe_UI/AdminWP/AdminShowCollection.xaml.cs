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

        private void AddNewShowAdmin_Click(object sender, RoutedEventArgs e)
        {
            var w = new AddNewShowWindow(this);
            w.Show();
        }
    }
}
