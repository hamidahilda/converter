using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace converter
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(bunifuTextBox1.Text);

            double hasil = 0;

            if (value1 == "km")
            {
                if (value2 == "km")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "hm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 100000;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 1000000;
                }
            }

            if (value1 == "hm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "hm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 100000;
                }
            }

            if (value1 == "dam")
            {
                if (value2 == "km")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dam")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 10000;
                }

            }

            if (value1 == "m")
            {
                if (value2 == "km")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "m")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 1000;
                }

            }

            if (value1 == "dm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 100;
                }

            }

            if (value1 == "cm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "cm")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 10;
                }

            }

            if (value1 == "mm")
            {
                if (value2 == "km")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "hm")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "dam")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "m")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "dm")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "cm")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "mm")
                {
                    hasil = angka * 1;
                }

            }

            bunifuTextBox2.Text = " " + (hasil);
        
    }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuButton1.Click += new EventHandler(bunifuButton1_Click);
            Controls.Add(bunifuButton1);
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void bunifuTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }
    }
}
