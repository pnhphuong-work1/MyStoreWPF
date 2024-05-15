using Services.Abstractions;
using Services.Services;
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

namespace Presentation
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly IAccountMemberService _iAccountMemberService;
        public Login()
        {
            InitializeComponent();
            _iAccountMemberService = new AccountMemberService();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var userName = TxtUsername.Text;
            var password = TxtPassword.Password;
            var checkAccount = _iAccountMemberService.getAccountMemberByEmail(userName);
            if (checkAccount == null)
            {
                MessageBox.Show("Account does not exist!", "Input Error"
                            , MessageBoxButton.OK, MessageBoxImage.Error);
                TxtUsername.Text = String.Empty;
                TxtPassword.Password = String.Empty;
                return;
            }
            if(!checkAccount.MemberPassword.Equals(password))
            {
                MessageBox.Show("Incorrect email or password!", "Incorrect email or password"
                        , MessageBoxButton.OK, MessageBoxImage.Error);
                TxtUsername.Text = String.Empty;
                TxtPassword.Password = String.Empty;
                return;
            }
            var productWindow = new ProductWindow();
            this.Close();
            productWindow.Show();
        }
    }
}
