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
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Collections;
using System.Data.Odbc;
using System.Net.Mail;
using System.Net;

namespace CsharpBuyPass
{
    /// <summary>
    /// Interaction logic for CadastroDeTeatro.xaml
    /// </summary>
    public partial class CadastroDeTeatro : Window
    {
        public CadastroDeTeatro()
        {
            InitializeComponent();
        }

        


        private void btnC_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow Wdw = new MainWindow();
            var my = CadastroDeTeatro.GetWindow(this);
            my.Close();
            Wdw.Show();

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

        

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtSenha.Password == txtConfSenha.Password && txtCNPJ.Text != "" && txtRazaoSocial.Text != "" && txtMarcaEmpr.Text != "" && txtComplemento.Text != "" && txtBairro.Text != "" && txtUF.Text != "" && txtMunicipio.Text != "" && txtEndereco.Text != "" && txtTel.Text != "" && txtEmail.Text != "" && txtSenha.Password != "")
            {
                Cadastrar cad = new Cadastrar(txtCNPJ.Text, txtRazaoSocial.Text, txtMarcaEmpr.Text, txtComplemento.Text, txtBairro.Text, txtUF.Text, txtMunicipio.Text, txtEndereco.Text, txtTel.Text, txtEmail.Text, txtSenha.Password);
                MessageBox.Show(cad.mensagem);
                int n = new Random().Next(999999);
                MailAddress remetente = new MailAddress("thebesttccb@gmail.com", "BuyPass");
                MailAddress destino = new MailAddress(txtEmail.Text, txtMarcaEmpr.Text);
                MailMessage msg = new MailMessage(remetente, destino);
                msg.Subject = "Código de Verificação - BuyPass";
                msg.Body = "Seu Código de Verificação é: " + n.ToString();
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 25;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(remetente.Address, "naomy1234567*");
                smtp.Send(msg);
                
                
                Verificacao V = new Verificacao();
                var m = CadastroDeTeatro.GetWindow(this);
                m.Close();
                V.Show();
            }
            else {
                MessageBox.Show("O campo de confirmação de senha deve conter o mesmo valor do campo de senha");
            }

        }

    }
}
