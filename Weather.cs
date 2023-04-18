using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.OleDb;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Development_Prototype
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
        }

        //making strings public for all pages
        public static string my_weather;
        public static double my_temp;
        public static double my_humid;

        //setting the api key and pulling local string from login page
        string APIKey = "2276af3ef55b7f3aeaf799579a8deb36";
        string value = Login.local;

        private void btnweatherstat_Click(object sender, EventArgs e)
        {

        }


        public void getWeather()
        {
           
            using(WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", value, APIKey);
                var json = web.DownloadString(url.ToString());
                weatherinfo.root Info = JsonConvert.DeserializeObject<weatherinfo.root>(json);

                //Adds information to labels about weather, wind, temp, and also picture of weather type
                picbox1.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";

                string the_condition = Info.weather[0].main;
                lblConditions.Text = "Conditions: " + the_condition;

                lblLocationhome.Text = "Location: " + value;

                double the_temp = Math.Round(Info.main.temp);
                lblTemp.Text = "Tempreture: " + Math.Round(the_temp).ToString() + " °C";

                double the_speed = Math.Round(Info.wind.speed);
                llblSpeed.Text = "Wind Speed: " + the_speed.ToString() + " mph";

                double the_humid = Info.main.hummidity;

                //Sets the values of sunrise and sunset into the lables
                lblSunrise.Text = "Sunrise: " + convertDateTime(Info.sys.sunrise).ToShortTimeString();
                lblSunset.Text = "Sunset: " + convertDateTime(Info.sys.sunset).ToShortTimeString();


                //strings the longitude and latitude of the user
                double lat = Info.coord.lat;
                double lon = Info.coord.lon;

                //setting data for health advice generator
                my_humid = the_humid;
                my_weather = the_condition;
                my_temp = the_temp;

                //get data for air quality
                string url2 = string.Format("http://api.openweathermap.org/data/2.5/air_pollution?lat={0}&lon={1}&appid={2}&units=imperial", lat, lon, APIKey);
                var json2 = web.DownloadString(url2.ToString());
                AirQuality.Root info = JsonConvert.DeserializeObject<AirQuality.Root>(json2);

                lblAir.Text = info.list[0].main.aqi.ToString();

                string Air = lblAir.Text;
                
                //If statement to convert air quality to text
                if(Air == 1.ToString())
                {
                    lblAir.Text = "Air Quality: Good";
                }
                else if (Air == 2.ToString())
                {
                    lblAir.Text = "Air Quality: Fair";
                }
                else if (Air == 3.ToString())
                {
                    lblAir.Text = "Air Quality: Moderate";
                }
                else if (Air == 4.ToString())
                {
                    lblAir.Text = "Air Quality: Poor";
                }
                else if (Air == 5.ToString())
                {
                    lblAir.Text = "Air Quality: Very Poor";
                }
            }
        }



        //used to set the the time of sunset and sunrise
        DateTime convertDateTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();

            return day;
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            //opens new page closes other page
            Health hel = new Health();
            hel.Show();
            this.Hide();
        }

        private void btnFitness_Click(object sender, EventArgs e)
        {
            //opens new page closes other page
            Fitness fit = new Fitness();
            fit.Show();
            this.Hide();
        }

        private void Weather_Load(object sender, EventArgs e)
        {
            //load getweather method when page is open
            getWeather();
        }

        
    }
}

