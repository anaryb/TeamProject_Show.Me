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
    /// Логика взаимодействия для AdminMediaCentreWindow.xaml
    /// </summary>
    public partial class AdminMediaCentreWindow : Window
    {
        AuthorizationWindow AW { get; set; }

        public AdminMediaCentreWindow(AuthorizationWindow aw)
        {
            InitializeComponent();
            NavigationService nav;
            nav = NavigationService.GetNavigationService(this);
            AdminMovieCollectionPage mcp = new AdminMovieCollectionPage();
            //nav.Navigate(mcp);
            frameMediaCenterAdmin.Navigate(mcp);
        }

        private void buttonMovieCollAdmin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav;
            nav = NavigationService.GetNavigationService(this);
            AdminMovieCollectionPage mcp = new AdminMovieCollectionPage();
            //nav.Navigate(mcp);
            frameMediaCenterAdmin.Navigate(mcp);
        }

        private void buttonShowCollAdmin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav;
            nav = NavigationService.GetNavigationService(this);
            AdminShowCollection scp = new AdminShowCollection();
            //nav.Navigate(mcp);
            frameMediaCenterAdmin.Navigate(scp);
        }
    }
}
