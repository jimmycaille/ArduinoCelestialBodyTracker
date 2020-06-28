using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelestialBodyTracker
{
    public partial class Form1 : Form
    {
        const Double EARTH_RADIUS = 6371;
        Thread t;
        Boolean tContinue;
        Bitmap img1, img2, img2s;

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            pic1.Controls.Add(pic2);
            pic2.Location = new Point(0, 0);
            pic2.BackColor = Color.Transparent;

            img1 = new Bitmap(@"C:\Users\Jimmy\Desktop\kindpng_116024.png");
            pic1.Image = new Bitmap(img1, new Size(80, 80));

            img2 = new Bitmap(@"C:\Users\Jimmy\Desktop\AAAAA.png");
            img2s = new Bitmap(img2, new Size(80, 80));
        }
        //https://stackoverflow.com/questions/2163829/how-do-i-rotate-a-picture-in-winforms
        public static Image RotateImage(Image img, float rotationAngle) {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
        private void Form1_Closing(object sender, FormClosingEventArgs e) {
            if (t != null) {
                tContinue = false;
                t.Join();
            }
        }
        public static double ConvToRad(double angle) {
            return Math.PI / 180 * angle;
        }
        public static double ConvToDeg(double radians) {
            double degrees = (180 / Math.PI) * radians;
            return degrees;
        }
        private void ThreadMethod() {
            int tsleep=1000;
            this.Invoke((MethodInvoker)delegate {
                tsleep = boxFreq.SelectedIndex == 0 ? 5000 :
                         boxFreq.SelectedIndex == 1 ? 10000 :
                         boxFreq.SelectedIndex == 2 ? 30000 :
                         boxFreq.SelectedIndex == 3 ? 60000 : 0;
            });
            while (tContinue) {

                try {
                    String txt = new WebClient().DownloadString(txtURL.Text);
                    JObject json = JObject.Parse(txt);

                    double lat = Double.Parse(json.GetValue("latitude").ToString());
                    double lon = Double.Parse(json.GetValue("longitude").ToString());
                    double alt = Double.Parse(json.GetValue("altitude").ToString());

                    double φ1 = ConvToRad(Double.Parse(txtOlat.Text)); // Phi1
                    double λ1 = ConvToRad(Double.Parse(txtOlon.Text)); // Lambda1
                    double φ2 = ConvToRad(lat); // Phi2
                    double λ2 = ConvToRad(lon); // Lambda2

                    // Azimuth measured clockwise from true north
                    double ψ = ConvToDeg(Math.Atan2(Math.Sin(λ2 - λ1) * Math.Cos(φ2),
                            Math.Cos(φ1) * Math.Sin(φ2) - Math.Sin(φ1) * Math.Cos(φ2) * Math.Cos(λ2 - λ1)
                            ));
                    double azimuth = (ψ < 0) ? 360 + ψ : ψ;

                    double rS = alt + EARTH_RADIUS; // Radius from the center of the earth to the station (km)
                    double γ = Math.Acos(Math.Sin(φ1) * Math.Sin(φ2) + Math.Cos(φ1) * Math.Cos(φ2) * Math.Cos(λ1 - λ2));  // earth central angle

                    double d = Math.Sqrt((1 + Math.Pow((EARTH_RADIUS / rS), 2)) - (2 * (EARTH_RADIUS / rS) * Math.Cos(γ))); // distance to the iss
                    double El = ConvToDeg(Math.Acos(Math.Sin(γ) / d) * ((d > 0.34) ? -1 : 1));

                    this.Invoke((MethodInvoker)delegate {

                        pic2.Image = RotateImage(img2s, (float)azimuth+180f);

                        txtIlat.Text = lat.ToString("0.##");
                        txtIlon.Text = lon.ToString("0.##");
                        txtIalt.Text = alt.ToString("0.##");
                        txtAzimuth.Text = azimuth.ToString("0.##");
                        txtElevation.Text = El.ToString("0.##");
                    });
                } catch {
                    this.Invoke((MethodInvoker)delegate {
                        txtIlat.Text = "ERROR";
                        txtIlon.Text = "ERROR";
                        txtIalt.Text = "ERROR";
                        txtAzimuth.Text = "ERROR";
                        txtElevation.Text = "ERROR";
                    });
                    tContinue = false;
                }
                Thread.Sleep(tsleep);
            }
        }
        private void button1_Click(object sender, EventArgs e) {

            btnConnect.Enabled = false;
            if (t == null) {
                tContinue = true;
                t = new Thread(new ThreadStart(ThreadMethod));
                t.Start();
                btnConnect.Text = "Stop";
                btnConnect.Enabled = true;
                boxFreq.Enabled = false;
                txtOlat.Enabled = false;
                txtOlon.Enabled = false;
                txtOalt.Enabled = false;
                comboBox2.Enabled = false;
            } else {
                tContinue = false;
                t.Join();
                t = null;
                btnConnect.Text = "Start";
                btnConnect.Enabled = true;
                boxFreq.Enabled = true;
                txtOlat.Enabled = true;
                txtOlon.Enabled = true;
                txtOalt.Enabled = true;
                comboBox2.Enabled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {

        }
    }
}
