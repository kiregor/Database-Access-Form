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

namespace HappyTechLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if (!usernameTB.Text.Equals("") && !PasswordBoxPB.Password.Equals(""))
            {
                if (usernameTB.Text.Equals("admin") && PasswordBoxPB.Password.Equals("password"))
                {
                    logoImage.Visibility = Visibility.Visible;
                    LoginBTN.Visibility = Visibility.Collapsed;
                    LogoutBTN.Visibility = Visibility.Visible;
                }
                else
                    MessageBox.Show("Incorrect Password");
            }
            else
                MessageBox.Show("User not found");
        }

        private void LogoutBTN_Click(object sender, RoutedEventArgs e)
        {
            logoImage.Visibility = Visibility.Visible; LoginBTN.Visibility = Visibility.Visible; LogoutBTN.Visibility = Visibility.Collapsed;
        }
    }
}
