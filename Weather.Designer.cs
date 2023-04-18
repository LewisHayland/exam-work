
namespace Development_Prototype
{
    partial class Weather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnFitness = new System.Windows.Forms.Button();
            this.lblConditions = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblLocationhome = new System.Windows.Forms.Label();
            this.lblAir = new System.Windows.Forms.Label();
            this.llblSpeed = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health Advice Group - Weather";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(24, 40);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(100, 25);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location:";
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(30, 80);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(78, 52);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox1.TabIndex = 4;
            this.picbox1.TabStop = false;
            // 
            // picbox2
            // 
            this.picbox2.Image = global::Development_Prototype.Properties.Resources.Image_for_development;
            this.picbox2.Location = new System.Drawing.Point(163, 49);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(331, 275);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox2.TabIndex = 7;
            this.picbox2.TabStop = false;
            // 
            // btnHealth
            // 
            this.btnHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealth.Location = new System.Drawing.Point(163, 330);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(91, 38);
            this.btnHealth.TabIndex = 8;
            this.btnHealth.Text = "Health";
            this.btnHealth.UseVisualStyleBackColor = true;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnFitness
            // 
            this.btnFitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFitness.Location = new System.Drawing.Point(260, 330);
            this.btnFitness.Name = "btnFitness";
            this.btnFitness.Size = new System.Drawing.Size(91, 38);
            this.btnFitness.TabIndex = 9;
            this.btnFitness.Text = "Fitness";
            this.btnFitness.UseVisualStyleBackColor = true;
            this.btnFitness.Click += new System.EventHandler(this.btnFitness_Click);
            // 
            // lblConditions
            // 
            this.lblConditions.AutoSize = true;
            this.lblConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConditions.Location = new System.Drawing.Point(30, 165);
            this.lblConditions.Name = "lblConditions";
            this.lblConditions.Size = new System.Drawing.Size(67, 16);
            this.lblConditions.TabIndex = 10;
            this.lblConditions.Text = "Condition:";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(30, 185);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(81, 16);
            this.lblTemp.TabIndex = 11;
            this.lblTemp.Text = "Tempreture:";
            // 
            // lblLocationhome
            // 
            this.lblLocationhome.AutoSize = true;
            this.lblLocationhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationhome.Location = new System.Drawing.Point(30, 140);
            this.lblLocationhome.Name = "lblLocationhome";
            this.lblLocationhome.Size = new System.Drawing.Size(62, 16);
            this.lblLocationhome.TabIndex = 12;
            this.lblLocationhome.Text = "Location:";
            // 
            // lblAir
            // 
            this.lblAir.AutoSize = true;
            this.lblAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAir.Location = new System.Drawing.Point(30, 205);
            this.lblAir.Name = "lblAir";
            this.lblAir.Size = new System.Drawing.Size(71, 16);
            this.lblAir.TabIndex = 13;
            this.lblAir.Text = "Air Quality:";
            // 
            // llblSpeed
            // 
            this.llblSpeed.AutoSize = true;
            this.llblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSpeed.Location = new System.Drawing.Point(30, 225);
            this.llblSpeed.Name = "llblSpeed";
            this.llblSpeed.Size = new System.Drawing.Size(86, 16);
            this.llblSpeed.TabIndex = 14;
            this.llblSpeed.Text = "Wind Speed:";
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunrise.Location = new System.Drawing.Point(30, 245);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(56, 16);
            this.lblSunrise.TabIndex = 15;
            this.lblSunrise.Text = "Sunrise:";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunset.Location = new System.Drawing.Point(30, 265);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(52, 16);
            this.lblSunset.TabIndex = 16;
            this.lblSunset.Text = "Sunset:";
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(500, 391);
            this.Controls.Add(this.lblSunset);
            this.Controls.Add(this.lblSunrise);
            this.Controls.Add(this.llblSpeed);
            this.Controls.Add(this.lblAir);
            this.Controls.Add(this.lblLocationhome);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblConditions);
            this.Controls.Add(this.btnFitness);
            this.Controls.Add(this.btnHealth);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.label1);
            this.Name = "Weather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Weather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.PictureBox picbox2;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Button btnFitness;
        private System.Windows.Forms.Label lblConditions;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblLocationhome;
        private System.Windows.Forms.Label lblAir;
        private System.Windows.Forms.Label llblSpeed;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label lblSunset;
    }
}