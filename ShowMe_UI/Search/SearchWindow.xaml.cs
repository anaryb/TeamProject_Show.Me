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
    /// Логика взаимодействия для SearchWindow.xaml
    /// </summary>
    public delegate void SearchParamMovie(IEnumerable sl);
    public partial class SearchWindow : Window
    {
        MovieCollectionPage MCP { get; set; }
        IEnumerable SearchList;
        public event SearchParamMovie SeaList;



        public SearchWindow(MovieCollectionPage mcp)
        {
            InitializeComponent();
        }

        private void buttonSearchinMovies_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                MessageBox.Show("Please input search paramentr");
                textBoxSearch.Focus();
                return;
            }
            using (TeamProject_ShowMe.MediaCenterContext db = new TeamProject_ShowMe.MediaCenterContext())
            {
                SearchList = db.MovieRepository.SearchMovie(textBoxSearch.Text);
                SeaList?.Invoke(SearchList);


            }
            

            
        }

    }
}
