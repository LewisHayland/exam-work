
namespace Development_Prototype
{
    partial class Fitness
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
            this.btnhealth = new System.Windows.Forms.Button();
            this.btnWeather = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAdvice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Health Advice Group - Fitness";
            // 
            // btnhealth
            // 
            this.btnhealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhealth.Location = new System.Drawing.Point(257, 329);
            this.btnhealth.Name = "btnhealth";
            this.btnhealth.Size = new System.Drawing.Size(91, 38);
            this.btnhealth.TabIndex = 16;
            this.btnhealth.Text = "Health";
            this.btnhealth.UseVisualStyleBackColor = true;
            this.btnhealth.Click += new System.EventHandler(this.btnhealth_Click);
            // 
            // btnWeather
            // 
            this.btnWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeather.Location = new System.Drawing.Point(160, 329);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(91, 38);
            this.btnWeather.TabIndex = 15;
            this.btnWeather.Text = "Weather";
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(29, 70);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 16);
            this.lblLocation.TabIndex = 17;
            this.lblLocation.Text = "Location:";
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvice.Location = new System.Drawing.Point(29, 117);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(77, 16);
            this.lblAdvice.TabIndex = 18;
            this.lblAdvice.Text = "Select Age:";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.SystemColors.Window;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.ForeColor = System.Drawing.Color.Silver;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Adult",
            "Child"});
            this.cmbGender.Location = new System.Drawing.Point(130, 117);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(251, 24);
            this.cmbGender.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdvice
            // 
            this.txtAdvice.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvice.Location = new System.Drawing.Point(130, 144);
            this.txtAdvice.Multiline = true;
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(348, 162);
            this.txtAdvice.TabIndex = 21;
            this.txtAdvice.Text = "Please select your age to get advice";
            // 
            // Fitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.txtAdvice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblAdvice);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnhealth);
            this.Controls.Add(this.btnWeather);
            this.Controls.Add(this.label1);
            this.Name = "Fitness";
            this.Text = "Fitness";
            this.Load += new System.EventHandler(this.Fitness_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhealth;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdvice;
    }
}