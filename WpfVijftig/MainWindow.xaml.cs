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

namespace WpfVijftig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Vijftig";
        }

        #region

        int totaalscoreSpeler1;
        int totaalscoreSpeler2;


        public void btnSpel_Click(object sender, RoutedEventArgs e)
        {
            lblScoreSpeler2.Content = "Score speler 2 : ";
            lblScoreSpeler1.Content = "Score speler 1 : ";

            SpeelSpel();

        }

        private void SpeelSpel()
        {
            if ((string)btnSpel.Content == " Gooien speler 1 ")
            {
                btnSpel.Background = Brushes.Green;

                Vijftig speler1 = new Vijftig();

                Image Imworp1 = new Image();
                switch (speler1.x.worp)
                {
                    case 1:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/1.png", UriKind.Relative));
                        break;
                    case 2:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/2.png", UriKind.Relative));
                        break;
                    case 3:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/3.png", UriKind.Relative));
                        break;
                    case 4:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/4.png", UriKind.Relative));
                        break;
                    case 5:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/5.png", UriKind.Relative));
                        break;
                    case 6:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/6.png", UriKind.Relative));
                        break;
                }

                Image Imworp2 = new Image();
                switch (speler1.y.worp)
                {
                    case 1:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/1.png", UriKind.Relative));
                        break;
                    case 2:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/2.png", UriKind.Relative));
                        break;
                    case 3:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/3.png", UriKind.Relative));
                        break;
                    case 4:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/4.png", UriKind.Relative));
                        break;
                    case 5:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/5.png", UriKind.Relative));
                        break;
                    case 6:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/6.png", UriKind.Relative));
                        break;

                }

                totaalscoreSpeler1 += speler1.score;
                if (speler1.score == 0)
                    totaalscoreSpeler1 = 0;
                lblScore.Content = totaalscoreSpeler1;

                btnSpel.Content = " Gooien speler 2 ";
                btnSpel.Background = Brushes.Red;

                if (totaalscoreSpeler1 >= 50 && totaalscoreSpeler2 < 50)

                {
                    lblSpelerGewonnen.Content = " Speler 1 wint!!! ";
                    btnSpel.Content = " Herstart het spel";
                    btnSpel.Background = Brushes.Cyan;
                    return;
                }
            }

            else if ((string)btnSpel.Content == " Gooien speler 2 ")
            {

                btnSpel.Background = Brushes.Red; ;

                Vijftig speler2 = new Vijftig();

                Image Imworp1 = new Image();
                switch (speler2.x.worp)
                {
                    case 1:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/1.png", UriKind.Relative));
                        break;
                    case 2:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/2.png", UriKind.Relative));
                        break;
                    case 3:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/3.png", UriKind.Relative));
                        break;
                    case 4:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/4.png", UriKind.Relative));
                        break;
                    case 5:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/5.png", UriKind.Relative));
                        break;
                    case 6:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/6.png", UriKind.Relative));
                        break;
                }

                Image Imworp2 = new Image();
                switch (speler2.y.worp)
                {
                    case 1:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/1.png", UriKind.Relative));
                        break;
                    case 2:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/2.png", UriKind.Relative));
                        break;
                    case 3:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/3.png", UriKind.Relative));
                        break;
                    case 4:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/4.png", UriKind.Relative));
                        break;
                    case 5:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/5.png", UriKind.Relative));
                        break;
                    case 6:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/6.png", UriKind.Relative));
                        break;

                }

                totaalscoreSpeler2 += speler2.score;
                if (speler2.score == 0)
                    totaalscoreSpeler2 = 0;

                lblScore2.Content = totaalscoreSpeler2;

                btnSpel.Content = " Gooien speler 1 ";
                btnSpel.Background = Brushes.Green;

                if (totaalscoreSpeler2 >= 50 && totaalscoreSpeler1 < 50)

                {
                    lblSpelerGewonnen.Content = " Speler 2 wint!!!";
                    btnSpel.Content = " Herstart het spel";
                    btnSpel.Background = Brushes.Cyan;

                    return;
                }
            }
            else if ((string)btnSpel.Content == " Herstart het spel")
            {
                if ((string)lblSpelerGewonnen.Content == " Speler 1 wint!!! ")
                {
                    Reset();
                    btnSpel.Content = " Gooien speler 2 ";
                    btnSpel.Background = Brushes.Red;

                }
                else
                {
                    Reset();
                    btnSpel.Content = " Gooien speler 1 ";
                    btnSpel.Background = Brushes.Green;
                }

            }
        }

        private void Reset()
        {
            totaalscoreSpeler1 = 0;
            totaalscoreSpeler2 = 0;
            lblScore.Content = 0;
            lblScore2.Content = 0;
            lblSpelerGewonnen.Content = "";
        }

        private string BepaalInstelworp(string instelworp1)
        {

            switch (instelworp1)

            {

                case "0":
                    return "1";
                case "1":
                    return "2";
                case "2":
                    return "3";
                case "3":
                    return "4";
                case "4":
                    return "5";
                case "5":
                    return "6";

                default:
                    return "Ongekend";
            }
        }
        #endregion

        #region
        private void btnTest_Click(object sender, RoutedEventArgs e)

        {
            btnSpel.Content = " Herstart het spel";
            lblScoreSpeler2.Content = "";
            lblScoreSpeler1.Content = " Test scores : ";
            lblScore2.Content = "";
            lblSpelerGewonnen.Content = "";

            try
            {
                string instelworp1 = ((ListBoxItem)listBox.SelectedItem).Content.ToString();
                int worp1 = Convert.ToInt32(instelworp1);

                Vijftig test = new Vijftig(worp1);

                Image Imworp1 = new Image();

                switch (worp1)
                {
                    case 1:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/1.png", UriKind.Relative));
                        break;
                    case 2:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/2.png", UriKind.Relative));
                        break;
                    case 3:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/3.png", UriKind.Relative));
                        break;
                    case 4:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/4.png", UriKind.Relative));
                        break;
                    case 5:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/5.png", UriKind.Relative));
                        break;
                    case 6:
                        imWorp1.Source = new BitmapImage(new Uri("/Afbeeldingen/6.png", UriKind.Relative));
                        break;

                }


                Image Imworp2 = new Image();
                switch (worp1)
                {
                    case 1:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/1.png", UriKind.Relative));
                        break;
                    case 2:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/2.png", UriKind.Relative));
                        break;
                    case 3:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/3.png", UriKind.Relative));
                        break;
                    case 4:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/4.png", UriKind.Relative));
                        break;
                    case 5:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/5.png", UriKind.Relative));
                        break;
                    case 6:
                        imWorp2.Source = new BitmapImage(new Uri("/Afbeeldingen/6.png", UriKind.Relative));
                        break;

                }

                lblScore.Content = test.score;
            }
            catch
            {
                lblScore.Content = "";
                MessageBox.Show("Selecteer één waarde 1-6 uit de keuzelijst ");
            }


        }
        #endregion

    }
    /*Zelfstandig opzoekwerk :
    Hoe kan je in WPF een afbeelding tonen en aanpassen vanuit de code ? :
    1. Tonen via de control 'IMAGE' gelinkt aan de de source, ic map afbeeldingen
    2. aanpassen code = aanpassen van de 'SOURCE' ahv 'new BitmapImage(new Uri(+ verwijzing naar het betreffende pad). 
    Wat me in deze solution niet heel duidelijk was, is de nood van de verwijzing tot "C:/...."en "/Afbeeldingen/1.png " niet aanvaard werd
    DUS MET URIKIND.RELATIVE.*/
}
