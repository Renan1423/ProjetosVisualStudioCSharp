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


namespace CsharpBuyPass
{
    /// <summary>
    /// Interaction logic for Verificacao.xaml
    /// </summary>
    public partial class Verificacao : Window
    {

        
        
        public Verificacao()
        {
            InitializeComponent();
            MessageBox.Show("O código de verificação foi enviado para o email cadastrado", "", MessageBoxButton.OK, MessageBoxImage.Warning);

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

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            CadastroDeTeatro c = new CadastroDeTeatro();
            
            /*if (txtVerif.Password == c.n.ToString())
            {
                MainWindow Window = new MainWindow();
                var myWindow = Verificacao.GetWindow(this);
                myWindow.Close();
                Window.Show();
            }
            else
            {
                MessageBox.Show("Código incorreto!");
            }*/
        }
    }
}
