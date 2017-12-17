using System;
using System.Collections;
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
    /// <summary>
    /// Логика взаимодействия для SearchShowWindow.xaml
    /// </summary>
    public delegate void SearchParamShow(IEnumerable sl);
    public partial class SearchShowWindow : Window
    {
        ShowCollectionPage SCP { get; set; }
        IEnumerable SearchShowList;
        public event SearchParamShow SearchShList;

        public SearchShowWindow(ShowCollectionPage scp)
        {
            InitializeComponent();
        }

        private void buttonSearchinShows_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearchShow.Text))
            {
                MessageBox.Show("Please input search paramentr");
                textBoxSearchShow.Focus();
                return;
            }
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                SearchShowList = db.ShowRepository.SearchShow(textBoxSearchShow.Text);
                SearchShList?.Invoke(SearchShowList);
                this.Close();

            }

        }
    }
}
