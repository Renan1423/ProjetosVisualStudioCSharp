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

namespace Menuzin
{
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void MudarImagem() {
            if (sliderFilme.Value == 0) {
                Filme1.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Jumanji.jpg"));
                Filme2.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Star Wars.jpg"));
                Filme3.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Sonic.jpg"));
                Filme4.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Animais.jpg"));
            }
            if (sliderFilme.Value == 1)
            {
                Filme1.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/BokuNoHero.jpg"));
                Filme2.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Aranha.jpg"));
                Filme3.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Vingadores.jpg"));
                Filme4.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Wifi.jpg"));
            }
            if (sliderFilme.Value == 2)
            {
                Filme1.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/DragonBall.jpg"));
                Filme2.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Assassin.jpg"));
                Filme3.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Bumblebee.jpg"));
                Filme4.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Mulan.jpg"));
            }
            if (sliderFilme.Value == 3)
            {
                Filme1.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Quiet.jpg"));
                Filme2.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/ViuvaNegra.jpg"));
                Filme3.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Scooby.jpg"));
                Filme4.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Maria.jpg"));
            }
        }

        public void MudarImagemPeca()
        {
            if (sliderPeca.Value == 0)
            {
                Peca1.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Naruto.jpeg"));
                Peca2.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Hamlet.png"));
                Peca3.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Inferno.jpeg"));
                Peca4.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/RJ.jpg"));
            }
            if (sliderPeca.Value == 1)
            {
                Peca1.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/BokuNoHero.jpg"));
                Peca2.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Aranha.jpg"));
                Peca3.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Vingadores.jpg"));
                Peca4.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Wifi.jpg"));
            }
            if (sliderPeca.Value == 2)
            {
                Peca1.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/DragonBall.jpg"));
                Peca2.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Assassin.jpg"));
                Peca3.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Bumblebee.jpg"));
                Peca4.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Mulan.jpg"));
            }
            if (sliderPeca.Value == 3)
            {
                Peca1.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Quiet.jpg"));
                Peca2.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/ViuvaNegra.jpg"));
                Peca3.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Scooby.jpg"));
                Peca4.Source = new BitmapImage(new Uri("C:/Users/samir/Documents/Visual Studio 2015/Projects/Menuzin/Menuzin/Imagem/Maria.jpg"));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Close Application?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
               //do no stuff
            }
            else
            {
               Application.Current.Shutdown();    //do yes stuff
            }
        }

        private void Proximo_Click(object sender, RoutedEventArgs e)
        {
            if (sliderFilme.Value < 3)
            {
                sliderFilme.Value++;
                MudarImagem();
            }
            else {
            }
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            if (sliderFilme.Value > 0)
            {
                sliderFilme.Value--;
                MudarImagem();
            }
            else
            {
            }
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ProximoPeca_Click(object sender, RoutedEventArgs e)
        {
            if (sliderPeca.Value < 3)
            {
                sliderPeca.Value++;
                MudarImagemPeca();
            }
            else
            {
            }
        }

        private void AnteriorPeca_Click(object sender, RoutedEventArgs e)
        {
            if (sliderPeca.Value > 0)
            {
                sliderPeca.Value--;
                MudarImagemPeca();
            }
            else
            {
            }
        }
    }
}
