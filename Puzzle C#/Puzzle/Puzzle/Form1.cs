using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baslangis();
        }
        int[] dizi = new int[16];
        Random r = new Random();
        private void baslangis()
        {
            pictureBox1.Image = ımageList1.Images[0];
            pictureBox2.Image = ımageList1.Images[1];
            pictureBox3.Image = ımageList1.Images[2];
            pictureBox4.Image = ımageList1.Images[3];
            pictureBox5.Image = ımageList1.Images[4];
            pictureBox6.Image = ımageList1.Images[5];
            pictureBox7.Image = ımageList1.Images[6];
            pictureBox8.Image = ımageList1.Images[7];
            pictureBox9.Image = ımageList1.Images[8];
            pictureBox10.Image = ımageList1.Images[9];
            pictureBox11.Image = ımageList1.Images[10];
            pictureBox12.Image = ımageList1.Images[11];
            pictureBox13.Image = ımageList1.Images[12];
            pictureBox14.Image = ımageList1.Images[13];
            pictureBox15.Image = ımageList1.Images[14];
            pictureBox16.Image = ımageList1.Images[15];

        }
        private void karistir()
        {
            for (int i = 0; i < 16; i++)
            {
                gitt:
                dizi[i] = r.Next(16);
                for (int j = 0; j < i; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        goto gitt;
                    }
                }
            }
            karisikres();

        }
        private void karisikres()
        {
            pictureBox1.Image = ımageList1.Images[dizi[0]];
            pictureBox2.Image = ımageList1.Images[dizi[1]];
            pictureBox3.Image = ımageList1.Images[dizi[2]];
            pictureBox4.Image = ımageList1.Images[dizi[3]];
            pictureBox5.Image = ımageList1.Images[dizi[4]];
            pictureBox6.Image = ımageList1.Images[dizi[5]];
            pictureBox7.Image = ımageList1.Images[dizi[6]];
            pictureBox8.Image = ımageList1.Images[dizi[7]];
            pictureBox9.Image = ımageList1.Images[dizi[8]];
            pictureBox10.Image = ımageList1.Images[dizi[9]];
            pictureBox11.Image = ımageList1.Images[dizi[10]];
            pictureBox12.Image = ımageList1.Images[dizi[11]];
            pictureBox13.Image = ımageList1.Images[dizi[12]];
            pictureBox14.Image = ımageList1.Images[dizi[13]];
            pictureBox15.Image = ımageList1.Images[dizi[14]];
            pictureBox16.Image = ımageList1.Images[dizi[15]];
            kont();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            groupBox1.Enabled = true;
            karistir();
        }
        private void kont()
        {
            int kontt = 0;
            for (int i = 0; i < 16; i++)
            {
                if (dizi[i]!=i)
                {
                    kontt = 1;
                }
            }
            if (kontt==0)
            {
                MessageBox.Show("Tebrikler");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int d;
            if (dizi[1]==15)
            {
                d = dizi[0];
                dizi[0] = dizi[1];
                dizi[1] = d;
            }
            else if (dizi[4] == 15)
            {
                d = dizi[0];
                dizi[0] = dizi[4];
                dizi[4] = d;
            }
            karisikres();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int d;
            if (dizi[0] == 15)
            {
                d = dizi[1];
                dizi[1] = dizi[0];
                dizi[0] = d;
            }
            else if (dizi[2] == 15)
            {
                d = dizi[1];
                dizi[1] = dizi[2];
                dizi[2] = d;
            }
            else if (dizi[5]==15)
            {
                d = dizi[1];
                dizi[1] = dizi[5];
                dizi[5] = d;
            }
            karisikres();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int d=dizi[2];
            if (dizi[1] == 15)
            {
                dizi[2] = dizi[1];
                dizi[1] = d;
            }
            else if (dizi[3] == 15)
            {
                dizi[2] = dizi[3];
                dizi[3] = d;
            }
            else if (dizi[6] == 15)
            {
                dizi[2] = dizi[6];
                dizi[6] = d;
            }
            karisikres();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int d = dizi[3];
            if (dizi[2] == 15)
            {
                dizi[3] = dizi[2];
                dizi[2] = d;
            }
            else if (dizi[7] == 15)
            {
                dizi[3] = dizi[7];
                dizi[7] = d;
            }
            karisikres();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int d = dizi[4];
            if (dizi[0] == 15)
            {
                dizi[4] = dizi[0];
                dizi[0] = d;
            }
            else if (dizi[5] == 15)
            {
                dizi[4] = dizi[5];
                dizi[5] = d;
            }
            else if (dizi[8] == 15)
            {
                dizi[4] = dizi[8];
                dizi[8] = d;
            }
            karisikres();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int d = dizi[5];
            if (dizi[1] == 15)
            {
                dizi[5] = dizi[1];
                dizi[1] = d;
            }
            else if (dizi[4] == 15)
            {
                dizi[5] = dizi[4];
                dizi[4] = d;
            }
            else if (dizi[6] == 15)
            {
                dizi[5] = dizi[6];
                dizi[6] = d;
            }
            else if (dizi[9] == 15)
            {
                dizi[5] = dizi[9];
                dizi[9] = d;
            }
            karisikres();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int d = dizi[6];
            if (dizi[2] == 15)
            {
                dizi[6] = dizi[2];
                dizi[2] = d;
            }
            else if (dizi[5] == 15)
            {
                dizi[6] = dizi[5];
                dizi[5] = d;
            }
            else if (dizi[7] == 15)
            {
                dizi[6] = dizi[7];
                dizi[7] = d;
            }
            else if (dizi[10] == 15)
            {
                dizi[6] = dizi[10];
                dizi[10] = d;
            }
            karisikres();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int d = dizi[7];
            if (dizi[3] == 15)
            {
                dizi[7] = dizi[3];
                dizi[3] = d;
            }
            else if (dizi[6] == 15)
            {
                dizi[7] = dizi[6];
                dizi[6] = d;
            }
            else if (dizi[11] == 15)
            {
                dizi[7] = dizi[11];
                dizi[11] = d;
            }
            karisikres();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int d = dizi[8];
            if (dizi[4] == 15)
            {
                dizi[8] = dizi[4];
                dizi[4] = d;
            }
            else if (dizi[9] == 15)
            {
                dizi[8] = dizi[9];
                dizi[9] = d;
            }
            else if (dizi[12] == 15)
            {
                dizi[8] = dizi[12];
                dizi[12] = d;
            }
            karisikres();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int d = dizi[9];
            if (dizi[5] == 15)
            {
                dizi[9] = dizi[5];
                dizi[5] = d;
            }
            else if (dizi[8] == 15)
            {
                dizi[9] = dizi[8];
                dizi[8] = d;
            }
            else if (dizi[10] == 15)
            {
                dizi[9] = dizi[10];
                dizi[10] = d;
            }
            else if (dizi[13] == 15)
            {
                dizi[9] = dizi[13];
                dizi[13] = d;
            }
            karisikres();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int d = dizi[10];
            if (dizi[6] == 15)
            {
                dizi[10] = dizi[6];
                dizi[6] = d;
            }
            else if (dizi[9] == 15)
            {
                dizi[10] = dizi[9];
                dizi[9] = d;
            }
            else if (dizi[11] == 15)
            {
                dizi[10] = dizi[11];
                dizi[11] = d;
            }
            else if (dizi[14] == 15)
            {
                dizi[10] = dizi[14];
                dizi[14] = d;
            }
            karisikres();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int d = dizi[11];
            if (dizi[7] == 15)
            {
                dizi[11] = dizi[7];
                dizi[7] = d;
            }
            else if (dizi[10] == 15)
            {
                dizi[11] = dizi[10];
                dizi[10] = d;
            }
            else if (dizi[15] == 15)
            {
                dizi[11] = dizi[15];
                dizi[15] = d;
            }
            karisikres();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            int d = dizi[12];
            if (dizi[8] == 15)
            {
                dizi[12] = dizi[8];
                dizi[8] = d;
            }
            else if (dizi[13] == 15)
            {
                dizi[12] = dizi[13];
                dizi[13] = d;
            }
            karisikres();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            int d = dizi[13];
            if (dizi[9] == 15)
            {
                dizi[13] = dizi[9];
                dizi[9] = d;
            }
            else if (dizi[12] == 15)
            {
                dizi[13] = dizi[12];
                dizi[12] = d;
            }
            else if (dizi[14] == 15)
            {
                dizi[13] = dizi[14];
                dizi[14] = d;
            }
            karisikres();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            int d = dizi[14];
            if (dizi[10] == 15)
            {
                dizi[14] = dizi[10];
                dizi[10] = d;
            }
            else if (dizi[13] == 15)
            {
                dizi[14] = dizi[13];
                dizi[13] = d;
            }
            else if (dizi[15] == 15)
            {
                dizi[14] = dizi[15];
                dizi[15] = d;
            }
            karisikres();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            int d = dizi[15];
            if (dizi[11] == 15)
            {
                dizi[15] = dizi[11];
                dizi[11] = d;
            }
            else if (dizi[14] == 15)
            {
                dizi[15] = dizi[14];
                dizi[14] = d;
            }
            karisikres();
        }
        Form2 frm2 = new Form2();
        private void button2_Click(object sender, EventArgs e)
        {
            frm2.Show();
            button2.Enabled = false;
        }
    }
}
