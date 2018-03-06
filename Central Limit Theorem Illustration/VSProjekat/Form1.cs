using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VSProjekat
{
    public partial class Form1 : Form
    {
        Bitmap dd;
        int n = 0, kor = 0, m = 0;
        double l = 0, sum = 0, rr = 0, ssum = 0;
        int per = 5;
        float x;
        Graphics g;
        double pp;
        public Form1()
        {
            InitializeComponent();
            dd = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = dd;
            g = Graphics.FromImage(pictureBox1.Image);
            Image i3 = Image.FromFile("cloud.png");
            pictureBox3.Image = i3;
            Image i4 = Image.FromFile("einstein.jpg");
            pictureBox4.Image = i4;
            Image i5 = Image.FromFile("stick.png");
            pictureBox5.Image = i5;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseAgrs = (MouseEventArgs)e;
            x = pictureBox2.Location.X - mouseAgrs.X;
            label4.Text = "Od početka ribe do kursora je: " + x / 234;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sum = 0; ssum = 0;
            if (n <= 0 || l <= 0 || l > 1)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Unos podataka je pogresan";
            }
            else
            {

                double s1 = 0, s2 = 0;
                if (l <= 0.1)
                {
                    Image i2 = Image.FromFile("fish1.png");
                    pictureBox2.Image = i2;
                    s1 = 0.1 * 234;
                    s2 = 0.1 * 112;
                }
                else if (l <= 0.2)
                {
                    Image i2 = Image.FromFile("fish2.png");
                    pictureBox2.Image = i2;
                    s1 = 0.2 * 234;
                    s2 = 0.2 * 112;
                }
                else if (l <= 0.3)
                {
                    Image i2 = Image.FromFile("fish3.png");
                    pictureBox2.Image = i2;
                    s1 = 0.3 * 234;
                    s2 = 0.3 * 112;
                }
                else if (l <= 0.4)
                {
                    Image i2 = Image.FromFile("fish4.png");
                    pictureBox2.Image = i2;
                    s1 = 0.4 * 234;
                    s2 = 0.4 * 112;
                }
                else if (l <= 0.5)
                {
                    Image i2 = Image.FromFile("fish5.png");
                    pictureBox2.Image = i2;
                    s1 = 0.5 * 234;
                    s2 = 0.5 * 112;
                }
                else if (l <= 0.6)
                {
                    Image i2 = Image.FromFile("fish6.png");
                    pictureBox2.Image = i2;
                    s1 = 0.6 * 234;
                    s2 = 0.6 * 112;
                }
                else if (l <= 0.7)
                {
                    Image i2 = Image.FromFile("fish7.png");
                    pictureBox2.Image = i2;
                    s1 = 0.7 * 234;
                    s2 = 0.7 * 112;
                }
                else if (l <= 0.8)
                {
                    Image i2 = Image.FromFile("fish8.png");
                    pictureBox2.Image = i2;
                    s1 = 0.8 * 234;
                    s2 = 0.8 * 112;
                }
                else if (l <= 0.9)
                {
                    Image i2 = Image.FromFile("fish9.png");
                    pictureBox2.Image = i2;
                    s1 = 0.9 * 234;
                    s2 = 0.9 * 112;
                }
                else if (l <= 1)
                {
                    Image i2 = Image.FromFile("fish10.png");
                    pictureBox2.Image = i2;
                    s1 = 1 * 234;
                    s2 = 1 * 112;
                }
                pictureBox2.Size = new Size((int)s1, (int)s2);
                for (int i = 0; i < n; i++)
                {
                    Random r = new Random();
                    double p = r.Next(1, 100001);
                    p = (double)p / 100000;
                    if (p <= l / 2) { sum = sum + l / 2 - p; ssum++; }
                    if (p >= 1 - l / 2) { sum = sum + p - (1 - l / 2); ssum++; }
                    pictureBox2.Location = new Point(280, 33);
                    for (int j = 0; j < (int)((396 - 33 - l * 112) / 18); j++)
                    {
                        int k = (int)((p - l / 2) * 234) / ((int)((396 - 33 - l * 112) / 18));
                        pictureBox2.Location = new Point(pictureBox2.Location.X + k, pictureBox2.Location.Y + 18);
                    }
                }
                sum = sum / n;
                label3.ForeColor = Color.Green;
                label3.Text = "Riba je " + sum + " van štapa u proseku";
                label5.Text = "Duzina ribe je " + (double)(ssum/n);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (kor == 0)
            {
                if (n <= 0 || l <= 0 || l > 1)
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Unos podataka je pogresan";
                    return;
                }
                ssum = 0;
                sum = 0;
                double s1 = 0, s2 = 0;
                if (l <= 0.1)
                {
                    Image i2 = Image.FromFile("fish1.png");
                    pictureBox2.Image = i2;
                    s1 = 0.1 * 234;
                    s2 = 0.1 * 112;
                }
                else if (l <= 0.2)
                {
                    Image i2 = Image.FromFile("fish2.png");
                    pictureBox2.Image = i2;
                    s1 = 0.2 * 234;
                    s2 = 0.2 * 112;
                }
                else if (l <= 0.3)
                {
                    Image i2 = Image.FromFile("fish3.png");
                    pictureBox2.Image = i2;
                    s1 = 0.3 * 234;
                    s2 = 0.3 * 112;
                }
                else if (l <= 0.4)
                {
                    Image i2 = Image.FromFile("fish4.png");
                    pictureBox2.Image = i2;
                    s1 = 0.4 * 234;
                    s2 = 0.4 * 112;
                }
                else if (l <= 0.5)
                {
                    Image i2 = Image.FromFile("fish5.png");
                    pictureBox2.Image = i2;
                    s1 = 0.5 * 234;
                    s2 = 0.5 * 112;
                }
                else if (l <= 0.6)
                {
                    Image i2 = Image.FromFile("fish6.png");
                    pictureBox2.Image = i2;
                    s1 = 0.6 * 234;
                    s2 = 0.6 * 112;
                }
                else if (l <= 0.7)
                {
                    Image i2 = Image.FromFile("fish7.png");
                    pictureBox2.Image = i2;
                    s1 = 0.7 * 234;
                    s2 = 0.7 * 112;
                }
                else if (l <= 0.8)
                {
                    Image i2 = Image.FromFile("fish8.png");
                    pictureBox2.Image = i2;
                    s1 = 0.8 * 234;
                    s2 = 0.8 * 112;
                }
                else if (l <= 0.9)
                {
                    Image i2 = Image.FromFile("fish9.png");
                    pictureBox2.Image = i2;
                    s1 = 0.9 * 234;
                    s2 = 0.9 * 112;
                }
                else if (l <= 1)
                {
                    Image i2 = Image.FromFile("fish10.png");
                    pictureBox2.Image = i2;
                    s1 = 1 * 234;
                    s2 = 1 * 112;
                }
                pictureBox2.Size = new Size((int)s1, (int)s2);
            }
            if (kor % n == 0 && n > (int)((396 - 33 - l * 112) / 18)) { m = kor / n;}
            if (kor % (int)((396 - 33 - l * 112) / 18) == 0 && n < (int)((396 - 33 - l * 112) / 18)) { m = kor / (int)((396 - 33 - l * 112) / 18); }
            if ((kor % n == 0 && n > (int)((396 - 33 - l * 112) / 18)) || (kor % (int)((396 - 33 - l * 112) / 18) == 0 && n < (int)((396 - 33 - l * 112) / 18)))
            {
                Random r = new Random();
                pp = r.Next(1, 100001);
                pp = (double)pp / 100000;
                if (pp <= l / 2) { sum = sum + l / 2 - pp; rr = l / 2 - pp; if (kor != 0) { ssum++; } }
                else if (pp >= 1 - l / 2) { sum = sum + pp - (1 - l / 2); if (kor != 0) { ssum++; } rr = pp - (1 - l / 2); }
                else { rr = 0; }
                pictureBox2.Location = new Point(280, 33);
            }
            if (kor < n * (int)((396 - 33 - l * 112) / 18))
            {
                int k = (int)((pp - l / 2) * 234) / ((int)((396 - 33 - l * 112) / 18));
                pictureBox2.Location = new Point(pictureBox2.Location.X + k, pictureBox2.Location.Y + 18);
                label3.ForeColor = Color.Purple;
                label3.Text = "U " + (m + 1) + ". bacanju riba je " + rr + " van štapa";
                if (rr > 0)
                {
                    label5.Text = "U " + (m + 1) + ". bacanju riba je izašla van štapa";
                }
                else { label5.Text = "U " + (m + 1) + ". bacanju riba je nije izašla van štapa"; }
            }
            else if (kor == n * (int)((396 - 33 - l * 112) / 18))
            {
                sum = sum / n;
                label3.ForeColor = Color.Green;
                label3.Text = "Riba je " + sum + " van štapa u proseku";
                label5.Text = "Duzina ribe je: " + (double)(ssum/n);
            }
            kor++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            try
            {
                n = int.Parse(textBox1.Text);
                kor = 0;
                m = 0;
            }
            catch (Exception ee)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Unos podataka je pogresan";
                return;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            try
            {
                l = double.Parse(textBox2.Text);
                kor = 0;
                m = 0;
            }
            catch (Exception ee)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Unos podataka je pogresan";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            sum *= sum * n; ssum = ssum * n;
            n++;
            textBox1.Text = n + "";
            if (n <= 0 || l <= 0 || l > 1)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Unos podataka je pogresan";
            }
            else
            {
                double s1 = 0, s2 = 0;
                if (l <= 0.1)
                {
                    Image i2 = Image.FromFile("fish1.png");
                    pictureBox2.Image = i2;
                    s1 = 0.1 * 234;
                    s2 = 0.1 * 112;
                }
                else if (l <= 0.2)
                {
                    Image i2 = Image.FromFile("fish2.png");
                    pictureBox2.Image = i2;
                    s1 = 0.2 * 234;
                    s2 = 0.2 * 112;
                }
                else if (l <= 0.3)
                {
                    Image i2 = Image.FromFile("fish3.png");
                    pictureBox2.Image = i2;
                    s1 = 0.3 * 234;
                    s2 = 0.3 * 112;
                }
                else if (l <= 0.4)
                {
                    Image i2 = Image.FromFile("fish4.png");
                    pictureBox2.Image = i2;
                    s1 = 0.4 * 234;
                    s2 = 0.4 * 112;
                }
                else if (l <= 0.5)
                {
                    Image i2 = Image.FromFile("fish5.png");
                    pictureBox2.Image = i2;
                    s1 = 0.5 * 234;
                    s2 = 0.5 * 112;
                }
                else if (l <= 0.6)
                {
                    Image i2 = Image.FromFile("fish6.png");
                    pictureBox2.Image = i2;
                    s1 = 0.6 * 234;
                    s2 = 0.6 * 112;
                }
                else if (l <= 0.7)
                {
                    Image i2 = Image.FromFile("fish7.png");
                    pictureBox2.Image = i2;
                    s1 = 0.7 * 234;
                    s2 = 0.7 * 112;
                }
                else if (l <= 0.8)
                {
                    Image i2 = Image.FromFile("fish8.png");
                    pictureBox2.Image = i2;
                    s1 = 0.8 * 234;
                    s2 = 0.8 * 112;
                }
                else if (l <= 0.9)
                {
                    Image i2 = Image.FromFile("fish9.png");
                    pictureBox2.Image = i2;
                    s1 = 0.9 * 234;
                    s2 = 0.9 * 112;
                }
                else if (l <= 1)
                {
                    Image i2 = Image.FromFile("fish10.png");
                    pictureBox2.Image = i2;
                    s1 = 1 * 234;
                    s2 = 1 * 112;
                }
                pictureBox2.Size = new Size((int)s1, (int)s2);
                Random r = new Random();
                double p = r.Next(1, 100001);
                p = (double)p / 100000;
                if (p <= l / 2) { sum = sum + l / 2 - p; ssum++; }
                if (p >= 1 - l / 2) { sum = sum + p - (1 - l / 2); ssum++; }
                pictureBox2.Location = new Point(280, 33);
                for (int j = 0; j < (int)((396 - 33 - l * 112) / 18); j++)
                {
                    int k = (int)((p - l / 2) * 234) / ((int)((396 - 33 - l * 112) / 18));
                    pictureBox2.Location = new Point(pictureBox2.Location.X + k, pictureBox2.Location.Y + 18);
                }
                sum = sum / n;
                label3.ForeColor = Color.Green;
                label3.Text = "Riba je " + sum + " van štapa u proseku"; //this calculation has issue
                label5.Text = "Duzina ribe je " + (double)(ssum/n);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (per < 0 || per > 100 || l <= 0 || l > 1)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Unos podataka je pogresan";
            }
            else
            {
                double s1 = 0, s2 = 0;
                if (l <= 0.1)
                {
                    Image i2 = Image.FromFile("fish1.png");
                    pictureBox2.Image = i2;
                    s1 = 0.1 * 234;
                    s2 = 0.1 * 112;
                }
                else if (l <= 0.2)
                {
                    Image i2 = Image.FromFile("fish2.png");
                    pictureBox2.Image = i2;
                    s1 = 0.2 * 234;
                    s2 = 0.2 * 112;
                }
                else if (l <= 0.3)
                {
                    Image i2 = Image.FromFile("fish3.png");
                    pictureBox2.Image = i2;
                    s1 = 0.3 * 234;
                    s2 = 0.3 * 112;
                }
                else if (l <= 0.4)
                {
                    Image i2 = Image.FromFile("fish4.png");
                    pictureBox2.Image = i2;
                    s1 = 0.4 * 234;
                    s2 = 0.4 * 112;
                }
                else if (l <= 0.5)
                {
                    Image i2 = Image.FromFile("fish5.png");
                    pictureBox2.Image = i2;
                    s1 = 0.5 * 234;
                    s2 = 0.5 * 112;
                }
                else if (l <= 0.6)
                {
                    Image i2 = Image.FromFile("fish6.png");
                    pictureBox2.Image = i2;
                    s1 = 0.6 * 234;
                    s2 = 0.6 * 112;
                }
                else if (l <= 0.7)
                {
                    Image i2 = Image.FromFile("fish7.png");
                    pictureBox2.Image = i2;
                    s1 = 0.7 * 234;
                    s2 = 0.7 * 112;
                }
                else if (l <= 0.8)
                {
                    Image i2 = Image.FromFile("fish8.png");
                    pictureBox2.Image = i2;
                    s1 = 0.8 * 234;
                    s2 = 0.8 * 112;
                }
                else if (l <= 0.9)
                {
                    Image i2 = Image.FromFile("fish9.png");
                    pictureBox2.Image = i2;
                    s1 = 0.9 * 234;
                    s2 = 0.9 * 112;
                }
                else if (l <= 1)
                {
                    Image i2 = Image.FromFile("fish10.png");
                    pictureBox2.Image = i2;
                    s1 = 1 * 234;
                    s2 = 1 * 112;
                }
                pictureBox2.Size = new Size((int)s1, (int)s2);
                double p = 0; ;
                n = 1; ssum = 0; sum = 0;
                double d=(double)ssum/n;
                double gr=(double)per*l / 100;
                double sssum = 0;
                int nn = 0;
                Random r = new Random();
                for (int kk = 0; kk < 1000; kk++)
                {
                   ssum = 0;
                   d = (double)ssum / (nn-kk*1000);
                   n = 1;
                   while (Math.Abs(d - l) > gr || n == 1)
                   {
                        for (int jj = 0; jj < 1000; jj++)
                        {
                            
                            p = r.Next(1, 100001);
                            p = (double)p / 100000;
                            if (p <= l / 2) { sum = sum + l / 2 - p; ssum++; }
                            if (p >= 1 - l / 2) { sum = sum + p - (1 - l / 2); ssum++; }
                        }
                        n += 1000;
                        d = (double)ssum / n;
                 }
                   nn += n;
                   sssum += ssum;
                }
                pictureBox2.Location = new Point(280, 33);
                for (int j = 0; j < (int)((396 - 33 - l * 112) / 18); j++)
                {
                    int k = (int)((p - l / 2) * 234) / ((int)((396 - 33 - l * 112) / 18));
                    pictureBox2.Location = new Point(pictureBox2.Location.X + k, pictureBox2.Location.Y + 18);
                }
                sum = sum / n;
                label3.ForeColor = Color.Green;
                label3.Text = "Riba je " + sum + " van štapa u proseku";
                label4.Text = "Broj potrebnih bacanja je " + (int)(nn * (1 - l) / 220);
                label5.Text = "Duzina ribe je " + sssum/nn;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            try
            {
                per = int.Parse(textBox3.Text);
                kor = 0;
                m = 0;
            }
            catch (Exception ee)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Unos podataka je pogresan";
                return;
            }
        }
    }
}
