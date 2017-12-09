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
using System.Windows.Navigation;

namespace ShowMe_UI
{
    /// <summary>
    /// Логика взаимодействия для MediaCenterWindow.xaml
    /// </summary>
    public partial class MediaCenterWindow : Window
    {
        public MediaCenterWindow()
        {
            InitializeComponent();
        }

        private void buttonMovieColl_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav;
            nav = NavigationService.GetNavigationService(this);
            MovieCollectionPage mcp = new MovieCollectionPage();
            //nav.Navigate(mcp);
            frameMediaCenter.Navigate(mcp);


        }

        private void buttonShowColl_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav;
            nav = NavigationService.GetNavigationService(this);
            ShowCollectionPage scp = new ShowCollectionPage();
            //nav.Navigate(mcp);
            frameMediaCenter.Navigate(scp);
        }


    }
}
