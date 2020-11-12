using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtomikhErgasia1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // pio periploko akoma kai to change button gia na ginoun swsta oi allages akoma kai an o xristis patisei change thn wra pou trexei se Auto mode.
            if (pictureBox1.ImageLocation == "red.png")
            {
                pictureBox1.ImageLocation = "green.png";
                if (timer1.Enabled)  //valame kai auth th sinthiki giati ean alliws patousame to change me adeia ta textboxes tha crashare efoson den tha mporouse na metatrepsei to keno se int k na to pollaplasiasei kiolas parakatw.Epishs voithaei kathws den diavazei sinexeia alla mono otan ta xreiazetai (diladi otan to auto trexei)
                {
                    string greentime = textBox3.Text;
                    int greent = Math.Abs(Convert.ToInt32(greentime));
                    timer1.Interval = greent * 1000;
                }
            }
            else if (pictureBox1.ImageLocation == "green.png")
            {
                pictureBox1.ImageLocation = "orange.png";
                if (timer1.Enabled)
                {
                    string orangetime = textBox2.Text;
                    int oranget = Math.Abs(Convert.ToInt32(orangetime));
                    timer1.Interval = oranget * 1000;
                }
            }
            else
            {
                pictureBox1.ImageLocation = "red.png";
                if (timer1.Enabled)
                {
                    string redtime = textBox1.Text;
                    int redt = Math.Abs(Convert.ToInt32(redtime));
                    timer1.Interval = redt * 1000;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "red.png";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.ImageLocation == "red.png")
            {
                string greentime = textBox3.Text;                      // gia na mh diavazei ta panta kathe fora diavazei opote prepei auta pou xreiazontai mono.
                int greent = Math.Abs(Convert.ToInt32(greentime));
                timer1.Interval = greent * 1000;
                pictureBox1.ImageLocation = "green.png";
            }
            else if (pictureBox1.ImageLocation == "green.png")
            {
                string orangetime = textBox2.Text;
                int oranget = Math.Abs(Convert.ToInt32(orangetime));
                timer1.Interval = oranget * 1000;
                pictureBox1.ImageLocation = "orange.png";
            }
            else
            {
                string redtime = textBox1.Text;
                int redt = Math.Abs(Convert.ToInt32(redtime));
                timer1.Interval = redt * 1000;
                pictureBox1.ImageLocation = "red.png";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(textBox3.Text))) MessageBox.Show("Please fill all fields!");
            else
           { 

            if (!timer1.Enabled)
            {
                button3.BackColor = Color.Lime;

                if (pictureBox1.ImageLocation == "red.png")        // ola auta ginontai wste kai sto 1o patima na xoume swsto interval
                {
                    string redtime = textBox1.Text;
                    int redt = Math.Abs(Convert.ToInt32(redtime));
                    timer1.Interval = redt * 1000;
                }
                if (pictureBox1.ImageLocation == "green.png")
                {
                    string greentime = textBox3.Text;
                    int greent = Math.Abs(Convert.ToInt32(greentime));
                    timer1.Interval = greent * 1000;
                }
                if (pictureBox1.ImageLocation == "orange.png")
                {
                    string orangetime = textBox2.Text;
                    int oranget = Math.Abs(Convert.ToInt32(orangetime));
                    timer1.Interval = oranget * 1000;
                }

                timer1.Enabled = true;
            }
            else
            {
                button3.BackColor = Color.Red;
                timer1.Enabled = false;
            }
        }
    }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Stop();
            button3.BackColor = Color.Red;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox1.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can press the Change button even when the Auto Mode is enabled with no problems. Also, when you click the Auto, your set times will work even from the first click. Integers only are allowed in any field of this program!");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
   }

