
namespace Development_Prototype
{
    partial class Health
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
            this.btnFitness = new System.Windows.Forms.Button();
            this.btnWeather = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.txtAdvice = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Health Advice Group - Health";
            // 
            // btnFitness
            // 
            this.btnFitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFitness.Location = new System.Drawing.Point(257, 329);
            this.btnFitness.Name = "btnFitness";
            this.btnFitness.Size = new System.Drawing.Size(91, 38);
            this.btnFitness.TabIndex = 11;
            this.btnFitness.Text = "Fitness";
            this.btnFitness.UseVisualStyleBackColor = true;
            this.btnFitness.Click += new System.EventHandler(this.btnFitness_Click);
            // 
            // btnWeather
            // 
            this.btnWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeather.Location = new System.Drawing.Point(160, 329);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(91, 38);
            this.btnWeather.TabIndex = 10;
            this.btnWeather.Text = "Weather";
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(26, 69);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 16);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location:";
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvice.Location = new System.Drawing.Point(29, 117);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(95, 16);
            this.lblAdvice.TabIndex = 13;
            this.lblAdvice.Text = "Health Advice:";
            // 
            // txtAdvice
            // 
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(130, 144);
            this.txtAdvice.Multiline = true;
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(348, 162);
            this.txtAdvice.TabIndex = 14;
            this.txtAdvice.Text = "Select weather to get heap";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cold Weather",
            "Hot Weather",
            "Humid Weather"});
            this.comboBox1.Location = new System.Drawing.Point(130, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Health
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtAdvice);
            this.Controls.Add(this.lblAdvice);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnFitness);
            this.Controls.Add(this.btnWeather);
            this.Controls.Add(this.label1);
            this.Name = "Health";
            this.Text = "Health";
            this.Load += new System.EventHandler(this.Health_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFitness;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.TextBox txtAdvice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}