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
using WeatherAPI.Core;
using WeatherAPI.Core.Services;
using WeatherAPI.Core.Domain;
using System.IO;

namespace _10_WeatherApp
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

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                ConditionsResults Weather = new ConditionsResults();
                Weather = WeatherService.GetWeatherFor(zipcodeEntryBox.Text);
                cityBlock.Text = Weather.Display_Location.full;


                latBlock.Text = "Latitude: " + Weather.Display_Location.latitude;

                longBlock.Text = "Longiture: " + Weather.Display_Location.longitude;

                elevationBlock.Text = "Elevation: " + Weather.Display_Location.elevation;

                weatherBlock.Text = Weather.weather;

                temperatureBlock.Text = "Temperature: " + Weather.temperature_string;

                humidityBlock.Text = "Humidity: " + Weather.relative_humidity;

                windBlock.Text = "Wind: " + Weather.wind_string;

                visibilityBlock.Text = "Visibility: " + Weather.visibility_mi;

                uvBlock.Text = "UV: " + Weather.UV;

                feelsLikeBlock.Text = "Feels like: " + Weather.feelslike_string;

                precepBlock.Text = "Precipitation: " + Weather.precip_today_string;

                lastUpdateBlock.Text = Weather.observation_time;



                image.Source = new BitmapImage(new Uri(Weather.icon_url));
            }
            catch
            {

                MessageBox.Show("Please enter a valid zip code.");
                zipcodeEntryBox.Clear();

            }
        }
    }
}
