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
using Microsoft.Win32;

namespace CsharpBuyPass
{
    /// <summary>
    /// Interaction logic for Peças.xaml
    /// </summary>
    public partial class Peças : Window
    {
        public Peças()
        {
            InitializeComponent();
        }
        public String Classficacao = "";
        public String Genero = "";

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtSegurança_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void txtSair_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Deseja retornar à tela inicial?", "", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {

            }
            else
            {
                MainWindow Window = new MainWindow();
                var myWindow = Peças.GetWindow(this);
                myWindow.Close();
                Window.Show();
            }
        }

        private void ImagemPeca_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.DefaultExt = ".png";
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                txtNomeImagem.Text = (System.IO.File.ReadAllText(openFileDialog.FileName)).ToString();
            
        }

        private void cbPeçasAds_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void cbPeçasVizu_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void cbPeças_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
           CadastrarPeca cad = new CadastrarPeca(txtSin.Text, Classficacao, txtNomePeca.Text, Genero, txtFic.Text, txtDur.Text, txtData.Text);
        }

        private void cbComedia_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Genero = "Comédia";
        }

        private void cbAventura_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Genero = "Aventura";
        }

        private void cbDrama_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Genero = "Drama";
        }

        private void cbMusical_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Genero = "Comédia";
        }

        private void cbOpera_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Genero = "Ópera";
        }

        private void cbMimica_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Genero = "Mímica";
        }

        private void cbLivre_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Classificacao = "Livre";
        }

        private void cb10_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Classificacao = "+10";
        }

        private void cb12_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Classificacao = "+12";
        }

        private void cb14_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Classificacao = "+14";
        }

        private void cb16_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Classificacao = "+16";
        }

        private void cb18_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            String Classificacao = "+18";
        }
    }
}