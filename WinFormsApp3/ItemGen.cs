using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class ItemGen : Form
    {
        public ItemGen()
        {
            InitializeComponent();
        }

        int[] smm2 = [65535, 65535];
        string[] smm2d = ["FFFF", "FFFF"];

        public void updateInfo()
        {

            for (int i = 0; i < 2; i++)
            {
                string x = Convert.ToString(smm2[i], 16);
                x = x.ToUpper();
                smm2d[i] = x;

            }

            if (smm2d[1].Length == 1)
            {
                smm2d[1] = "000" + smm2d[1];
            }
            else if (smm2d[1].Length == 2)
            {
                smm2d[1] = "00" + smm2d[1];
            }
            else if (smm2d[1].Length == 3)
            {
                smm2d[1] = "0" + smm2d[1];
            }
            if (comboBox2.SelectedIndex == 133)
            {
                smm2d[0] = "FFFF";
            }
            else
            {
                if (smm2d[0].Length == 1)
                {
                    smm2d[0] = "000" + smm2d[0];
                }
                else if (smm2d[0].Length == 2)
                {
                    smm2d[0] = "00" + smm2d[0];
                }
                else if (smm2d[0].Length == 3)
                {
                    smm2d[0] = "0" + smm2d[0];
                }
            }
            textBox1.Text = string.Join("", smm2d);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            smm2[1] = comboBox1.SelectedIndex;
            updateInfo();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            smm2[0] = comboBox2.SelectedIndex;
            updateInfo();
        }

        private void ItemGen_Load(object sender, EventArgs e)
        {

        }
    }
}
