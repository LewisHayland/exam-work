using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Development_Prototype
{
    public partial class Fitness : Form
    {
        public Fitness()
        {
            InitializeComponent();
        }
        string value = Login.local;

        private void btnWeather_Click(object sender, EventArgs e)
        {
            //sends the user to weather page
            Weather weth = new Weather();
            weth.Show();
            this.Hide();
        }

        private void btnhealth_Click(object sender, EventArgs e)
        {
            //sends the user to health page
            Health hel = new Health();
            hel.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fitness_Load(object sender, EventArgs e)
        {
            //when page is loaded displays location to user
            lblLocation.Text = "Location: " + value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if a combo box is selected outputs a different answer to user
            string Adult = "Adult";
            string Child = "Child";

            if (cmbGender.Text == Adult)
            {
                txtAdvice.Text = "An adult should do at least 150 minutes of moderate intensity activity a week or 75 minutes of vigorous intensity activity a week. " +
                    "Spread exercise evenly over 4 to 5 days a week, or every day. reduce time spent sitting or lying down and break up long periods " +
                    "of not moving with some activity. " +
                    "As an adult you should be walking approxomatly 8000-9000 steps everyday to keep themselves healthy.";
            }
            else if (cmbGender.Text == Child)
            {
                txtAdvice.Text = "A child should aim for an average of at least 60 minutes of moderate or vigorous intensity physical activity a day across the week. " +
                    "Take part in a variety of types and intensities of physical activity across the week to develop movement skills, muscles and bones.";
            }
        }
    }
}
