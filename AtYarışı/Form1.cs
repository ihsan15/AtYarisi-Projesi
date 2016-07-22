using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int at1, at2, at3, at4, at5;
        int sayı = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            at1 = pictureBox1.Left;
            at2 = pictureBox2.Left;
            at3 = pictureBox3.Left;
            at4 = pictureBox4.Left;
            at5 = pictureBox5.Left;
        }

        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            at1 = pictureBox1.Width;
            at2 = pictureBox2.Width;
            at3 = pictureBox3.Width;
            at4 = pictureBox4.Width;
            at5 = pictureBox5.Width;
            label9.Text = sayı.ToString();
            sayı++;
            label9.Text = sayı.ToString();


            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 10);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 10);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 10);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(5, 10);
            pictureBox5.Left = pictureBox5.Left + rastgele.Next(5, 10);

            /* if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left && pictureBox1.Left > pictureBox4.Left && pictureBox1.Left > pictureBox5.Left)
            {
                label8.Text = "1 numaralı at önde";
            }
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left && pictureBox2.Left > pictureBox4.Left && pictureBox2.Left > pictureBox5.Left)
            {
                label8.Text = "2 numaralı at öne geçti";
            }
            if (pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox4.Left && pictureBox3.Left > pictureBox5.Left)
            {
                label8.Text = "3 numaralı at iyi bir atakla yaptı";
            }
            if (pictureBox4.Left > pictureBox2.Left && pictureBox4.Left > pictureBox3.Left && pictureBox4.Left > pictureBox1.Left && pictureBox4.Left > pictureBox5.Left)
            {
                label8.Text = "4 numaradan at geliyor";
            }
            if (pictureBox5.Left > pictureBox2.Left && pictureBox5.Left > pictureBox3.Left && pictureBox5.Left > pictureBox4.Left && pictureBox5.Left > pictureBox1.Left)
            {
                label8.Text = "5 numaralı at arkadan gelerek kazanmaya gidiyor";
            }*/

            if (pictureBox1.Left + at1 == label7.Left )
            {
                timer1.Stop();
                label8.Text="1. At yarışı kazandı";
            }
            if (pictureBox2.Left + at2 == label7.Left)
            {
                timer1.Stop();
                label8.Text = "2. At yarışı kazandı";
            }
            if (pictureBox3.Left + at3 == label7.Left)
            {
                timer1.Stop();
                label8.Text = "3. At yarışı kazandı";
            }
            if (pictureBox4.Left + at4 == label7.Left)
            {
                timer1.Stop();
                label8.Text = "4. At yarışı kazandı";
            }
            if (pictureBox4.Left + at4 == label7.Left)
            {
                timer1.Stop();
                label8.Text = "5. At yarışı kazandı";
            } 
        }
    }
}
