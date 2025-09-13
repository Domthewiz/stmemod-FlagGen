using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp3
{
    public partial class smm2stuffgen : Form
    {
        int nb1v1 = 0;
        int nb1v2 = 1;
        int nb1v4 = 1;
        int nb1v8 = 0;
        int nb2v1 = 0;
        int nb2v2 = 0;
        int nb2v4 = 0;
        int nb2v8 = 0;
        int nb3v1 = 0;
        int nb3v2 = 0;
        int nb3v4 = 0;
        int nb3v8 = 0;
        int nb4v1 = 0;
        int nb4v2 = 0;
        int nb4v4 = 0;
        int nb4v8 = 0;
        int nb5v1 = 0;
        int nb5v2 = 0;
        int nb5v4 = 0;
        int nb5v8 = 0;
        int nb7v1 = 0;
        int nb7v2 = 0;
        int nb7v4 = 0;
        int nb7v8 = 0;
        int[] smm2 = [0, 6, 0, 0, 0, 0, 4, 0];
        string[] smm2d = ["0", "6", "0", "0", "0", "0", "4", "0"];
        // valuez     0  1  2  3  4  5  6  7
        public smm2stuffgen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void smm2stuffgen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateValueDisplay();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            smm2[6] = i * 2;
            updateValueDisplay();
        }
        //t[] smm2 = [0, 6, 0, 0, 0, 0, 4, 0];
        // valuez     0  1  2  3  4  5  6  7
        public void updateValueDisplay()
        {
            smm2[7] = nb7v1 + 2 * nb7v2 + 4 * nb7v4 + 8 * nb7v8;
            smm2[5] = nb5v1 + 2 * nb5v2 + 4 * nb5v4 + 8 * nb5v8;
            smm2[4] = nb4v1 + 2 * nb4v2 + 4 * nb4v4 + 8 * nb4v8;
            smm2[3] = nb3v1 + 2 * nb3v2 + 4 * nb3v4 + 8 * nb3v8;
            smm2[2] = nb2v1 + 2 * nb2v2 + 4 * nb2v4 + 8 * nb2v8;
            smm2[1] = nb1v1 + 2 * nb1v2 + 4 * nb1v4 + 8 * nb1v8;
            for (int i = 0; i < 8; i++)
            {
                string x = Convert.ToString(smm2[i], 16);
                x = x.ToUpper();
                smm2d[i] = x;

            }
            textBox1.Text = string.Join("", smm2d);
        }

        public void updateValueDisplayo()
        {
            updateValueDisplay();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                nb7v1 = 1;
            }
            else { nb7v1 = 0; }
            updateValueDisplay();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                nb7v2 = 1;
            }
            else { nb7v2 = 0; }
            updateValueDisplay();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                nb7v4 = 1;
            }
            else { nb7v4 = 0; }
            updateValueDisplay();
        }

        private void smm2stuffgen_Click(object sender, EventArgs e)
        {

        }

        private void smm2stuffgen_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                nb5v1 = 1;
            }
            else { nb5v1 = 0; }
            updateValueDisplay();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                nb5v2 = 1;
            }
            else { nb5v2 = 0; }
            updateValueDisplay();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                nb5v4 = 1;
            }
            else { nb5v4 = 0; }
            updateValueDisplay();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                nb4v1 = 1;
            }
            else { nb4v1 = 0; }
            updateValueDisplay();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                nb4v2 = 1;
            }
            else { nb4v2 = 0; }
            updateValueDisplay();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                nb4v4 = 1;
            }
            else { nb4v4 = 0; }
            updateValueDisplay();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                nb4v8 = 1;
            }
            else { nb4v8 = 0; }
            updateValueDisplay();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                nb3v1 = 1;
            }
            else { nb3v1 = 0; }
            updateValueDisplay();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                nb3v2 = 1;
            }
            else { nb3v2 = 0; }
            updateValueDisplay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                nb3v4 = 1;
                checkBox14.Checked = false;
            }
            else { nb3v4 = 0; }
            updateValueDisplay();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                nb3v8 = 1;
                checkBox13.Checked = false;
            }
            else { nb3v8 = 0; }
            updateValueDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nb1v2 = 1;
            nb1v4 = 1;
            nb2v1 = 1;
            nb2v2 = 0;
            nb2v4 = 0;
            updateValueDisplayo();
        }
        //t[] smm2 = [0, 6, 0, 0, 0, 0, 4, 0];
        // valuez     0  1  2  3  4  5  6  7
        private void button1_Click_1(object sender, EventArgs e)
        {
            nb1v2 = 1;
            nb1v4 = 1;
            nb2v1 = 0;
            nb2v2 = 0;
            nb2v4 = 0;
            updateValueDisplayo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nb1v2 = 1;
            nb1v4 = 1;
            nb2v1 = 0;
            nb2v2 = 1;
            nb2v4 = 0;
            updateValueDisplayo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nb1v2 = 1;
            nb1v4 = 1;
            nb2v1 = 1;
            nb2v2 = 1;
            nb2v4 = 0;
            updateValueDisplayo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nb1v2 = 1;
            nb1v4 = 1;
            nb2v1 = 0;
            nb2v2 = 0;
            nb2v4 = 1;
            updateValueDisplayo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nb1v2 = 1;
            nb1v4 = 1;
            nb2v1 = 1;
            nb2v2 = 0;
            nb2v4 = 1;
            updateValueDisplayo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nb1v2 = 1;
            nb1v4 = 1;
            nb2v1 = 1;
            nb2v2 = 1;
            nb2v4 = 1;
            updateValueDisplayo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nb1v2 = 1;
            nb1v4 = 1;
            nb2v1 = 0;
            nb2v2 = 1;
            nb2v4 = 1;
            updateValueDisplayo();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                nb1v2 = 0;
                nb1v4 = 0;
                nb2v1 = 0;
                nb2v2 = 0;
                nb2v4 = 0;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                nb1v2 = 1;
                nb1v4 = 0;
                nb2v1 = 0;
                nb2v2 = 0;
                nb2v4 = 0;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                nb1v2 = 0;
                nb1v4 = 1;
                nb2v1 = 0;
                nb2v2 = 0;
                nb2v4 = 0;
            }
            else
            {
                nb1v2 = 1;
                nb1v4 = 1;
                nb2v1 = 0;
                nb2v2 = 0;
                nb2v4 = 0;
            }
            updateValueDisplayo();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                nb1v8 = 1;
            }
            else { nb1v8 = 0; }
            updateValueDisplay();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form f2 = new ItemGen();
            f2.Show();
        }
    }
}
