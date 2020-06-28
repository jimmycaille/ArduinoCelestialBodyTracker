using System;
using System.Windows.Forms;

namespace CelestialBodyTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.boxFreq = new System.Windows.Forms.ComboBox();
            this.txtOlat = new System.Windows.Forms.TextBox();
            this.txtOlon = new System.Windows.Forms.TextBox();
            this.txtOalt = new System.Windows.Forms.TextBox();
            this.txtIlon = new System.Windows.Forms.TextBox();
            this.txtIlat = new System.Windows.Forms.TextBox();
            this.txtIalt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtAzimuth = new System.Windows.Forms.TextBox();
            this.txtElevation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(53, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(285, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "https://api.wheretheiss.at/v1/satellites/25544";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(516, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxFreq
            // 
            this.boxFreq.FormattingEnabled = true;
            this.boxFreq.Items.AddRange(new object[] {
            "5 sec",
            "10 sec",
            "30 sec",
            "1 min"});
            this.boxFreq.Location = new System.Drawing.Point(448, 6);
            this.boxFreq.Name = "boxFreq";
            this.boxFreq.Size = new System.Drawing.Size(62, 21);
            this.boxFreq.TabIndex = 2;
            this.boxFreq.Text = "10 sec";
            // 
            // txtOlat
            // 
            this.txtOlat.Location = new System.Drawing.Point(94, 70);
            this.txtOlat.Name = "txtOlat";
            this.txtOlat.Size = new System.Drawing.Size(100, 20);
            this.txtOlat.TabIndex = 3;
            this.txtOlat.Text = "46.8";
            // 
            // txtOlon
            // 
            this.txtOlon.Location = new System.Drawing.Point(94, 97);
            this.txtOlon.Name = "txtOlon";
            this.txtOlon.Size = new System.Drawing.Size(100, 20);
            this.txtOlon.TabIndex = 4;
            this.txtOlon.Text = "7.15";
            // 
            // txtOalt
            // 
            this.txtOalt.Location = new System.Drawing.Point(94, 124);
            this.txtOalt.Name = "txtOalt";
            this.txtOalt.Size = new System.Drawing.Size(100, 20);
            this.txtOalt.TabIndex = 5;
            this.txtOalt.Text = "610";
            // 
            // txtIlon
            // 
            this.txtIlon.Location = new System.Drawing.Point(201, 70);
            this.txtIlon.Name = "txtIlon";
            this.txtIlon.ReadOnly = true;
            this.txtIlon.Size = new System.Drawing.Size(100, 20);
            this.txtIlon.TabIndex = 6;
            // 
            // txtIlat
            // 
            this.txtIlat.Location = new System.Drawing.Point(201, 97);
            this.txtIlat.Name = "txtIlat";
            this.txtIlat.ReadOnly = true;
            this.txtIlat.Size = new System.Drawing.Size(100, 20);
            this.txtIlat.TabIndex = 7;
            // 
            // txtIalt
            // 
            this.txtIalt.Location = new System.Drawing.Point(201, 124);
            this.txtIalt.Name = "txtIalt";
            this.txtIalt.ReadOnly = true;
            this.txtIalt.Size = new System.Drawing.Size(100, 20);
            this.txtIalt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "URL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Update frequency :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "latitude :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "longitude :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "altitude :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "OBSERVER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ISS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "City : ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Fribourg"});
            this.comboBox2.Location = new System.Drawing.Point(94, 153);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Fribourg";
            // 
            // txtAzimuth
            // 
            this.txtAzimuth.Location = new System.Drawing.Point(381, 70);
            this.txtAzimuth.Name = "txtAzimuth";
            this.txtAzimuth.ReadOnly = true;
            this.txtAzimuth.Size = new System.Drawing.Size(100, 20);
            this.txtAzimuth.TabIndex = 18;
            // 
            // txtElevation
            // 
            this.txtElevation.Location = new System.Drawing.Point(381, 96);
            this.txtElevation.Name = "txtElevation";
            this.txtElevation.ReadOnly = true;
            this.txtElevation.Size = new System.Drawing.Size(100, 20);
            this.txtElevation.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Azimuth :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Elevation :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(499, 70);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(114, 104);
            this.pic1.TabIndex = 22;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Transparent;
            this.pic2.Location = new System.Drawing.Point(499, 70);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(114, 104);
            this.pic2.TabIndex = 24;
            this.pic2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 281);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtElevation);
            this.Controls.Add(this.txtAzimuth);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIalt);
            this.Controls.Add(this.txtIlat);
            this.Controls.Add(this.txtIlon);
            this.Controls.Add(this.txtOalt);
            this.Controls.Add(this.txtOlon);
            this.Controls.Add(this.txtOlat);
            this.Controls.Add(this.boxFreq);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox boxFreq;
        private System.Windows.Forms.TextBox txtOlat;
        private System.Windows.Forms.TextBox txtOlon;
        private System.Windows.Forms.TextBox txtOalt;
        private System.Windows.Forms.TextBox txtIlon;
        private System.Windows.Forms.TextBox txtIlat;
        private System.Windows.Forms.TextBox txtIalt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtAzimuth;
        private System.Windows.Forms.TextBox txtElevation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pic1;
        private PictureBox pic2;
    }
}

