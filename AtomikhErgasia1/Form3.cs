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
    public partial class Form3 : Form
    {
        
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "red.png";
            pictureBox2.ImageLocation = "green.png";
        }

        private void button2_Click(object sender, EventArgs e) // change 1o fanari. einai periploko gia na douleuoun swsta oi allages kai sto auto. (apo kokkino se prasino omws mono den siberiferetai swsta para thn swsth sinthiki kai to settarisma tou interval se 1 gia na fygei...)
        {
            
            if (pictureBox1.ImageLocation == "red.png")
            {

                pictureBox1.ImageLocation = "green.png";
                if (timer1.Enabled || timer2.Enabled)            
                {
                      
                    if (pictureBox2.ImageLocation != "red.png") 
                    {
                        timer1.Interval = 1;
                        
                    }
                    else
                    {

                        string greentime = textBox3.Text;
                        int greent = Math.Abs(Convert.ToInt32(greentime));
                        timer1.Interval = greent * 1000;
                    }
                    
                }
            }
            else if (pictureBox1.ImageLocation == "green.png")
            {
                pictureBox1.ImageLocation = "orange.png";
                if (timer1.Enabled || timer2.Enabled)
                {

                    if (pictureBox2.ImageLocation != "red.png")  
                    {
                        timer1.Interval = 1;
                    }
                    else
                    {

                        string orangetime = textBox2.Text;
                        int oranget = Math.Abs(Convert.ToInt32(orangetime));
                        timer1.Interval = oranget * 1000;
                    }
                    
                }
            }
            else
            {
                pictureBox1.ImageLocation = "red.png";
                if (timer1.Enabled || timer2.Enabled)
                {

                    if (pictureBox2.ImageLocation == "red.png")  
                    {
                        timer1.Interval = 1;
                    }
                    else
                    {
                        string redtime = textBox1.Text;
                        int redt = Math.Abs(Convert.ToInt32(redtime));
                        timer1.Interval = redt * 1000;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)  // change 2o fanari (omoia me 1o)
        {
            if (pictureBox2.ImageLocation == "red.png")
            {

                pictureBox2.ImageLocation = "green.png";
                if (timer1.Enabled || timer2.Enabled)
                {

                    if (pictureBox1.ImageLocation != "red.png")
                    {
                        timer2.Interval = 1;

                    }
                    else
                    {

                        string greentime = textBox6.Text;
                        int greent = Math.Abs(Convert.ToInt32(greentime));
                        timer2.Interval = greent * 1000;
                    }

                }
            }
            else if (pictureBox2.ImageLocation == "green.png")
            {
                pictureBox2.ImageLocation = "orange.png";
                if (timer1.Enabled || timer2.Enabled)
                {

                    if (pictureBox1.ImageLocation != "red.png")
                    {
                        timer2.Interval = 1;
                    }
                    else
                    {

                        string orangetime = textBox5.Text;
                        int oranget = Math.Abs(Convert.ToInt32(orangetime));
                        timer2.Interval = oranget * 1000;
                    }

                }
            }
            else
            {
                pictureBox2.ImageLocation = "red.png";
                if (timer1.Enabled || timer2.Enabled)
                {

                    if (pictureBox1.ImageLocation == "red.png")
                    {
                        timer2.Interval = 1;
                    }
                    else
                    {
                        string redtime = textBox4.Text;
                        int redt = Math.Abs(Convert.ToInt32(redtime));
                        timer2.Interval = redt * 1000;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)  // timer 1ou fanariou
        {
            if (pictureBox1.ImageLocation == "red.png") 
            {
                timer2.Start();
                if (pictureBox2.ImageLocation == "red.png")
                {
                    timer2.Interval = 1;
                    timer2.Stop();
                }

                    string greentime = textBox3.Text;
                    int greent = Math.Abs(Convert.ToInt32(greentime));
                    timer1.Interval = greent * 1000;
                    pictureBox1.ImageLocation = "green.png";
             
            }
            else if (pictureBox1.ImageLocation == "green.png") 
            {
                timer2.Start();
                if (pictureBox2.ImageLocation == "red.png")
                {
                    timer2.Interval = 1;
                    timer2.Stop();
                }

                    string orangetime = textBox2.Text;
                    int oranget = Math.Abs(Convert.ToInt32(orangetime));
                    timer1.Interval = oranget * 1000;
                    pictureBox1.ImageLocation = "orange.png";
                
             
            }
            else    
            {
                timer2.Start();
                if (pictureBox2.ImageLocation != "red.png")
                {
                    timer2.Interval = 1;
                    timer2.Stop();
                }

                    string redtime = textBox1.Text;
                    int redt = Math.Abs(Convert.ToInt32(redtime));
                    timer1.Interval = redt * 1000;
                    pictureBox1.ImageLocation = "red.png";
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)  //timer tou 2ou fanariou
        {
            if (pictureBox2.ImageLocation == "red.png")
            {
                timer1.Start();
                if (pictureBox1.ImageLocation == "red.png")
                {
                    timer1.Interval = 1;
                    timer1.Stop();
                }

                string greentime = textBox6.Text;
                int greent = Math.Abs(Convert.ToInt32(greentime));
                timer2.Interval = greent * 1000;
                pictureBox2.ImageLocation = "green.png";

            }
            else if (pictureBox2.ImageLocation == "green.png")
            {
                timer1.Start();
                if (pictureBox1.ImageLocation == "red.png")
                {
                    timer1.Interval = 1;
                    timer1.Stop();
                }

                string orangetime = textBox5.Text;
                int oranget = Math.Abs(Convert.ToInt32(orangetime));
                timer2.Interval = oranget * 1000;
                pictureBox2.ImageLocation = "orange.png";


            }
            else
            {
                timer1.Start();
                if (pictureBox1.ImageLocation != "red.png")
                {
                    timer1.Interval = 1;
                    timer1.Stop();
                }

                string redtime = textBox4.Text;
                int redt = Math.Abs(Convert.ToInt32(redtime));
                timer2.Interval = redt * 1000;
                pictureBox2.ImageLocation = "red.png";

            }
        }

        private void button4_Click(object sender, EventArgs e)      
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(textBox3.Text)) || (string.IsNullOrEmpty(textBox4.Text)) || (string.IsNullOrEmpty(textBox5.Text)) || (string.IsNullOrEmpty(textBox6.Text))) MessageBox.Show("Please fill all fields!");
            else
            {
                if ((timer1.Enabled == false) && (timer2.Enabled == false))  
                {
                    button4.BackColor = Color.Lime;                   // opws kai sto intermediate kai edw, olh auth h "fasaria" sto Auto! button einai gia na exoume swsta intervals kai me to 1o mas click.


                    if (pictureBox1.ImageLocation == "red.png")        // diavazoume mia fora ola ta intervals tou 1ou.
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


                    if (pictureBox2.ImageLocation == "red.png")        // diavazoume mia fora ola ta intervals tou 2ou.
                    {
                        string redtime = textBox4.Text;
                        int redt = Math.Abs(Convert.ToInt32(redtime));
                        timer2.Interval = redt * 1000;
                    }
                    if (pictureBox2.ImageLocation == "green.png")
                    {
                        string greentime = textBox6.Text;
                        int greent = Math.Abs(Convert.ToInt32(greentime));
                        timer2.Interval = greent * 1000;
                    }
                    if (pictureBox2.ImageLocation == "orange.png")
                    {
                        string orangetime = textBox5.Text;
                        int oranget = Math.Abs(Convert.ToInt32(orangetime));
                        timer2.Interval = oranget * 1000;
                    }
                                                                  // kai gia na settaristoun swsta ta intervals mas kai thn 1h fora xrishmopoioume tous kwdikes apo tous timers mas (xwris omws tis entoles pou allazoun tis eikones giati mono ta intervals mas endiaferoun).
                    if (pictureBox1.ImageLocation == "red.png")   // kwdikas apo timer1.
                    {
                        timer2.Start();
                        if (pictureBox2.ImageLocation == "red.png")
                        {
                            timer2.Interval = 1;
                            timer2.Stop();
                        }

                        string greentime = textBox3.Text;
                        int greent = Math.Abs(Convert.ToInt32(greentime));
                        timer1.Interval = greent * 1000;
                        

                    }
                    else if (pictureBox1.ImageLocation == "green.png")
                    {
                        timer2.Start();
                        if (pictureBox2.ImageLocation == "red.png")
                        {
                            timer2.Interval = 1;
                            timer2.Stop();
                        }

                        string orangetime = textBox2.Text;
                        int oranget = Math.Abs(Convert.ToInt32(orangetime));
                        timer1.Interval = oranget * 1000;
                        


                    }
                    else
                    {
                        timer2.Start();
                        if (pictureBox2.ImageLocation != "red.png")
                        {
                            timer2.Interval = 1;
                            timer2.Stop();
                        }

                        string redtime = textBox1.Text;
                        int redt = Math.Abs(Convert.ToInt32(redtime));
                        timer1.Interval = redt * 1000;
                        

                    }

                    if (pictureBox2.ImageLocation == "red.png")  // kwdikas apo timer2.
                    {
                        timer1.Start();
                        if (pictureBox1.ImageLocation == "red.png")
                        {
                            timer1.Interval = 1;
                            timer1.Stop();
                        }

                        string greentime = textBox6.Text;
                        int greent = Math.Abs(Convert.ToInt32(greentime));
                        timer2.Interval = greent * 1000;
                        

                    }
                    else if (pictureBox2.ImageLocation == "green.png")
                    {
                        timer1.Start();
                        if (pictureBox1.ImageLocation == "red.png")
                        {
                            timer1.Interval = 1;
                            timer1.Stop();
                        }

                        string orangetime = textBox5.Text;
                        int oranget = Math.Abs(Convert.ToInt32(orangetime));
                        timer2.Interval = oranget * 1000;
                        


                    }
                    else
                    {
                        timer1.Start();
                        if (pictureBox1.ImageLocation != "red.png")
                        {
                            timer1.Interval = 1;
                            timer1.Stop();
                        }

                        string redtime = textBox4.Text;
                        int redt = Math.Abs(Convert.ToInt32(redtime));
                        timer2.Interval = redt * 1000;
                        

                    }
                    // den kanoume edw to enable alla ginete swsta mesa apo tous kwdikes twn timers pou xrhsimopoihsame parapanw.

                }
                else
                {
                    button4.BackColor = Color.Red;
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer2.Interval = 1;
            timer1.Stop();
            timer2.Stop();
            button4.BackColor = Color.Red;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            pictureBox1.ImageLocation = "red.png";
            pictureBox2.ImageLocation = "green.png";
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Auto! button works ok everywhere like Intermediate Level. Change button can be pressed in most of the situations while Auto Mode is running but it's not recommended. Integers only are allowed in any field of this program!");
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
