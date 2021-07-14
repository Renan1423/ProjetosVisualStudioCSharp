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

namespace CsharpBuyPass
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

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            Controle con = new Controle();
            con.acessar(txtEmail.Text, txtSenha.Password);
            if(con.tem)
            {
                Peças Window = new Peças();
                var myWindow = MainWindow.GetWindow(this);
                myWindow.Close();
                Window.Show();
            }
            else
            {
                MessageBox.Show("Login ou Senha incorretos", "" , MessageBoxButton.OK, MessageBoxImage.Information);
                txtEmail.Text = "";
                txtSenha.Password = "";
            }

        }

        private void btnCadastrar_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            CadastroDeTeatro Window = new CadastroDeTeatro();
            var myWindow = MainWindow.GetWindow(this);
            myWindow.Close();
            Window.Show();
        }

        private void btnRelembrar_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}
