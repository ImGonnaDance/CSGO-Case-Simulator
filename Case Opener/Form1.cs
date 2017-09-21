using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case_Opener
{
    public partial class Form1 : Form
    {

        int gen;
        int blue;
        int purple;
        int pink;
        int red;
        int exotic;
        int total;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 1000;
            trackBar1.TickFrequency = 83;
            label1.Text = "Open a case to start!";
            label2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
            label1.Text = "Congrats you opened a";
            label3.Text = DateTime.Now.ToString();

            if (textBox1.Text == String.Empty)
            {
                timer2.Stop();
            }
            else if (Convert.ToInt32(textBox1.Text) <= 0)
            {
                timer2.Stop();
            }
            else if (Convert.ToInt32(textBox1.Text) > 0)
            {
                timer2.Interval = Convert.ToInt32(textBox1.Text);
                timer2.Start();
            }

            if (checkBox1.Checked == true)
            {
                timer1.Interval = 1;
                timer1.Start();
            }
            else if (checkBox1.Checked == false)
            {
                Random r = new Random();
                int rInt = r.Next(0, 10000); //for ints
                gen = rInt;
                total = blue + purple + pink + red + exotic;

                if (gen < 7880)
                {
                    label2.Text = "blue!";
                    label2.ForeColor = System.Drawing.Color.Blue;
                    listBox1.Items.Add("[" + DateTime.Now + "] " + "Blue");
                    blue = blue + 1;
                }
                else if (gen < 9500)
                {
                    label2.Text = "purple!";
                    label2.ForeColor = System.Drawing.Color.Purple;
                    listBox1.Items.Add("[" + DateTime.Now.ToString() + "] " + "Purple");
                    purple = purple + 1;
                }
                else if (gen < 9750)
                {
                    label2.Text = "pink!";
                    label2.ForeColor = System.Drawing.Color.Magenta;
                    listBox1.Items.Add("[" + DateTime.Now.ToString() + "] " + "Pink");
                    pink = pink + 1;
                }
                else if (gen < 9910)
                {
                    label2.Text = "red!";
                    label2.ForeColor = System.Drawing.Color.Red;
                    listBox1.Items.Add("[" + DateTime.Now.ToString() + "] " + "Red");
                    red = red + 1;
                }
                else if (gen < 10000)
                {
                    label2.Text = "exotic!";
                    label2.ForeColor = System.Drawing.Color.Gold;
                    listBox1.Items.Add("[" + DateTime.Now.ToString() + "] " + "Exotic");
                    exotic = exotic + 1;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0)
            {
                timer1.Interval = 1;
            }
            else if (trackBar1.Value > 0)
            {
                timer1.Interval = trackBar1.Value;
            }

            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
            label3.Text = DateTime.Now.ToString();

            if (checkBox1.Checked == true)
            {
                Random r = new Random();
                int rInt = r.Next(0, 10000); //for ints
                gen = rInt;
                total = blue + purple + pink + red + exotic;

                if (gen < 7880)
                {
                    label2.Text = "blue!";
                    label2.ForeColor = System.Drawing.Color.Blue;
                    listBox1.Items.Add("[" + DateTime.Now + "] " + "Blue");
                    blue = blue + 1;
                }
                else if (gen < 9500)
                {
                    label2.Text = "purple!";
                    label2.ForeColor = System.Drawing.Color.Purple;
                    listBox1.Items.Add("[" + DateTime.Now.ToString() + "] " + "Purple");
                    purple = purple + 1;
                }
                else if (gen < 9750)
                {
                    label2.Text = "pink!";
                    label2.ForeColor = System.Drawing.Color.Magenta;
                    listBox1.Items.Add("[" + DateTime.Now.ToString() + "] " + "Pink");
                    pink = pink + 1;
                }
                else if (gen < 9910)
                {
                    label2.Text = "red!";
                    label2.ForeColor = System.Drawing.Color.Red;
                    listBox1.Items.Add("[" + DateTime.Now.ToString() + "] " + "Red");
                    red = red + 1;
                }
                else if (gen < 10000)
                {
                    label2.Text = "exotic!";
                    label2.ForeColor = System.Drawing.Color.Gold;
                    listBox1.Items.Add("[" + DateTime.Now.ToString() + "] " + "Exotic");
                    exotic = exotic + 1;
                }
            }
            else if (checkBox1.Checked == false)
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tick Rate: " + trackBar1.Value + Environment.NewLine + "Blue: " + blue.ToString() + Environment.NewLine + "Purple: " + purple.ToString() + Environment.NewLine + "Pink: " + pink.ToString() + Environment.NewLine + "Red: " + red.ToString() + Environment.NewLine + "Exotic: " + exotic.ToString() + Environment.NewLine + "Total: " + total.ToString());
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Tick Rate: " + trackBar1.Value + Environment.NewLine + "Blue: " + blue.ToString() + Environment.NewLine + "Purple: " + purple.ToString() + Environment.NewLine + "Pink: " + pink.ToString() + Environment.NewLine + "Red: " + red.ToString() + Environment.NewLine + "Exotic: " + exotic.ToString() + Environment.NewLine + "Total: " + total.ToString() + Environment.NewLine + Environment.NewLine + "Stats by: Thaisen's C# Case Simulator (v1.0.0.4)");
            MessageBox.Show("Stats copied to your clipboard");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            blue = 0;
            purple = 0;
            pink = 0;
            red = 0;
            exotic = 0;
            total = 0;
            listBox1.Items.Clear();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("Complete");
        }
    }
}
