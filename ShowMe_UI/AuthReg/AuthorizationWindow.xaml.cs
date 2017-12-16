using ShowMe_UI;
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
using TeamProject_ShowMe;
using TeamProject_ShowMe.User;

namespace ShowMe_UI
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        MainWindow MW { get; set; }
        MediaCenterContext context = new MediaCenterContext();

        public AuthorizationWindow(MainWindow mw)
        {
            InitializeComponent();
        }

        private void buttonAuthorisation_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;

            if (string.IsNullOrWhiteSpace(textboxAuthLogin.Text))
            {
                MessageBox.Show("Input Your Login, Please");
                textboxAuthLogin.Focus();
                return;
            }
            if (passwordboxAuthPassword.Password == "")
            {
                MessageBox.Show("Please, enter password!");
            }

            const string adminpassword = "admin12345";
            var adminhash = context.UserRepository.CalculateHash(adminpassword);

            foreach (var au in context.Users)
            {
                if ((textboxAuthLogin.Text == "admin") && (context.UserRepository.CalculateHash(passwordboxAuthPassword.Password) == adminhash))
                {
                    MessageBox.Show("Admin Authorisation successful");
                    var w = new AdminMediaCentreWindow(this);
                    w.Show();
                    i = 1;
                    this.Close();
                    break;

                }
                if ((textboxAuthLogin.Text == au.UserLogin) && (context.UserRepository.CalculateHash(passwordboxAuthPassword.Password)== au.UserPassword))
                {
                    MessageBox.Show("Authorisation successful");
                    var w = new MediaCenterWindow(this);
                    w.Show();
                    this.Close();
                    i = 1;
                    
                }
            }
            if (i ==0)
                MessageBox.Show("Wrong login or password");

        }
    }
}
