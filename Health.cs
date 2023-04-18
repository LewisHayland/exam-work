using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI_API;
using OpenAI_API.Completions;

namespace Development_Prototype
{
    public partial class Health : Form
    {
        public Health()
        {
            InitializeComponent();
        }
        //pulling local string from login page
        string value = Login.local;

        //pulling weather information from weather page
        public string weath = Weather.my_weather;
        public double temp = Weather.my_temp;
        public double humid = Weather.my_humid;

        private void btnHealth_Click(object sender, EventArgs e)
        {
            //opens new page closes other page
            Weather weth = new Weather();
            weth.Show();
            this.Hide();
        }

        private void btnFitness_Click(object sender, EventArgs e)
        {
            //opens new page closes other page
            Fitness fit = new Fitness();
            fit.Show();
            this.Hide();
        }

        private void Health_Load(object sender, EventArgs e)
        {
            lblLocation.Text = "Location: " + value;
            //getinfo();
            //gethealth();
        }

        void getinfo()
        {
            //used to test if weather information is being pulled correctly
            MessageBox.Show(weath);
            MessageBox.Show(temp.ToString());
            MessageBox.Show(humid.ToString());
        }

        public async void gethealth()
        {
            //string model = "text-davinci-002";
            //string prompt = "give Health advice for these weather conditions {@weath}, temp {@temp}, humidity {@humid}.";
            //int maxTokens = 100;

            OpenAIAPI api = new OpenAIAPI("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");
            var chat = api.Chat.CreateConversation();
            chat.AppendSystemMessage("If the weather is {@weath}, the tempreture is {@temp}, what should someone do?");

            string response = await chat.GetResponseFromChatbot();
            txtAdvice.Text = response;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Hot_Weather = "Hot Weather";
            string Cold_Weather = "Cold Weather";
            string Humid_Weather = "Humid Weather";

            if (comboBox1.Text == Hot_Weather)
            {
                txtAdvice.Text = "If the weather is hot then you shoud, drink lots of water to stay hiydrated. Making sure that if you are getting hot to keep out of the sun to avoid getting heat stroke.";
            }
            else if (comboBox1.Text == Cold_Weather)
            {
                txtAdvice.Text = "If the weather if cold, then make sure to wrap up in warm clothing to prevent hypothermia and make sure that if you are wet to get dries as it can affect their health.";
            }
            else if (comboBox1.Text == Humid_Weather)
            {
                txtAdvice.Text = "If the weather is humid make sure to stay hydrated and drink lots of water, make sure to wear suitable clothing and stay in air conditions rooms if it is too hot for you and you start to feel light headed.";
            }
        }
    }
}
