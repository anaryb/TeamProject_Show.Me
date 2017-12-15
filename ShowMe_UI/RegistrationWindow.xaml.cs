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
using System.Windows.Shapes;
using TeamProject_ShowMe;
using TeamProject_ShowMe.User;

namespace ShowMe_UI
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        MainWindow MW { get; set; }
        MediaCenterContext context = new MediaCenterContext();
        

        

        public RegistrationWindow(MainWindow mw)
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxRegName.Text))
            {
                MessageBox.Show("Input Your Name, Please");
                textboxRegName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textboxRegLogin.Text))
            {
                MessageBox.Show("Input Your Login, Please");
                textboxRegLogin.Focus();
                return;
            }
            if (passwordboxRegPassword.Password == "")
            {
                MessageBox.Show("Please, enter password!");
            }

            if (passwordboxRepeatRegPassword.Password == "")
            {
                MessageBox.Show("Please, repeat password!");
            }

            if (passwordboxRegPassword.Password != passwordboxRepeatRegPassword.Password)
            {
                MessageBox.Show("Passwords are not the same! \n Reenter, please");
                
            }
            foreach (var ru in context.Users)
            {
                if (textboxRegLogin.Text == ru.UserLogin)
                {
                    MessageBox.Show("Such login is already exsists");
                    textboxRegLogin.Focus();
                    return;
                }
                    
            }


            var u = new User();
            u.UserName = textboxRegName.Text;
            u.UserLogin = textboxRegLogin.Text;
            var hash = context.UserRepository.CalculateHash(passwordboxRepeatRegPassword.Password);
            u.UserPassword = hash;

            context.UserRepository.AddUser(u);
            context.SaveChanges();

            this.Close();

            MessageBox.Show("Registration succsessfull! \n Please authorise in app!");









        }




    }
}
