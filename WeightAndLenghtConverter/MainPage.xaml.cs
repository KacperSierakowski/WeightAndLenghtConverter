using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace WeightAndLengthConverter
{

    public sealed partial class MainPage : Page
    {
        public static string choosenQuantity = "Centimeters";
        public static float enteredValue = 0f;

        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(580, 250);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

            // if you want not to have any window smaller than this size...
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(580, 250));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Booba, Booba, Love me!");
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private void listViewQuantities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            choosenQuantity = listViewQuantities.SelectedItem.ToString();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            switch (choosenQuantity)
            {
                case "Centimeters"://Zamień CENTYMETRY
                    {
                        Centimeter centimeter = new Centimeter(enteredValue);
                        string returnedReults = centimeter.ConvertCentimetersToFeets().ToString() + " FEETS\n" + "\n" +
                            centimeter.ConvertCentimetersToInches().ToString() + " INCHES\n" + "\n" +
                            centimeter.ConvertCentimetersToFeetsAndInches();
                        resultTextBlock.Text = returnedReults;
                    }
                    break;
                case "Inches"://Zamień CALE
                    {
                        Inch inch = new Inch(enteredValue);
                        string returnedReults =
                        inch.ConvertInchesToCentimeters().ToString() + " CM\n" + "\n"+
                        inch.ConvertInchesToMeters().ToString() + " M\n" + "\n" +
                        inch.ConvertInchesToFeets() + " FEETS\n";
                        resultTextBlock.Text = returnedReults;
                    }
                    break;
                case "Kilograms"://Zamień KILOGRAMY
                    {
                        Kilogram kilogram = new Kilogram(enteredValue);
                        string returnedReults = kilogram.ConvertKilogramsToLbs().ToString() + " LBS\n";
                        resultTextBlock.Text = returnedReults;
                    }
                    break;
                case "Pounds"://Zamień FUNTY
                    {
                        Pound pound = new Pound(enteredValue);
                        string returnedReults = pound.ConvertLbsToKg().ToString() + " KG\n";
                        resultTextBlock.Text = returnedReults;
                    }
                    break;
                case "Feets"://Zamień STOPY
                    {
                        Feet feet = new Feet(enteredValue);
                        string returnedReults = feet.ConvertFeetsToCentimeters().ToString() + " CM\n" + "\n" +
                                                feet.ConvertInchesToMeters().ToString() + " M\n" + "\n" +
                                                feet.ConvertFeetsToInches().ToString() + " INCHES\n";
                        resultTextBlock.Text = returnedReults;
                    }
                    break;
                default:
                    resultTextBlock.Text = "Nie wybrano jednostki";
                    break;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                enteredValue = float.Parse(enteredValueTextBox.Text.ToString());
            }
            catch (System.FormatException ee)
            {
                string error = ee.ToString();
                enteredValue = 0;
            }



        }
    }
}
