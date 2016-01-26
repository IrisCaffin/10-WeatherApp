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
            ConditionsResults Weather = new ConditionsResults();
            Weather = WeatherService.GetWeatherFor(zipcodeEntryBox.Text);
            textBlock.Text = Weather.Display_Location.full;

            textBlock.Text = Weather.Display_Location.latitude;

            textBlock.Text = Weather.Display_Location.longitude;

            textBlock.Text = Weather.Display_Location.elevation;

            textBlock.Text = Weather.weather;

            textBlock.Text = Weather.temperature_string;

            textBlock.Text = Weather.relative_humidity;

            textBlock.Text = Weather.wind_string;

            textBlock.Text = Weather.visibility_mi;

            textBlock.Text = Weather.UV;

            textBlock.Text = Weather.feelslike_string;

            textBlock.Text = Weather.precip_today_string;

            textBlock.Text = Weather.observation_time;

            textBlock.Text = Weather.icon_url;

        }
    }
}
