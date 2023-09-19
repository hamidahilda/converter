using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = cbnSuhu.SelectedItem.ToString();
            string value2 = cbhSuhu.SelectedItem.ToString();

            double angka = double.Parse(tbnSuhu.Text);

            double hasil = 0;

            if (value1 == "celcius")
            {
                if(value2 == "celcius")
                {
                    hasil = angka;
                }else if(value2 == "reamur")
                {
                    hasil = angka * 4/5;
                }else if (value2 == "farenheit")
                {
                    hasil = angka * 9/5 + 32;
                }
                else if (value2 == "kelvin")
                {
                    hasil = angka + 273.15;
                }
            }
            else if(value1 == "reamur")
            {
                if (value2 == "celcius")
                {
                    hasil = angka * 5 / 4;
                }
                else if (value2 == "reamur")
                {
                    hasil = angka;
                }
                else if (value2 == "farenheit")
                {
                    hasil = angka * 9/4 + 32;
                }
                else if (value2 == "kelvin")
                {
                    hasil = angka * 5/4 + 273;
                }
            }
            else if(value1 == "farenheit")
            {
                if(value2 == "celcius")
                {
                    hasil = (angka - 32)* 5 / 9 ;
                }
                else if (value2 == "reamur")
                {
                    hasil = (angka - 32) * 4 / 9;
                }
                else if (value2 == "farenheit")
                {
                    hasil = angka;
                }
                else if (value2 == "kelvin")
                {
                    hasil = (angka - 32) * 5 / 9 + 273.15;
                }
            }
            else if(value1 == "kelvin")
            {
                if(value2 == "celcius")
                {
                    hasil = angka * 5 / 4;
                }
                else if(value2 == "reamur")
                {
                    hasil = (angka - 273.15) * 4 / 5;
                }
                else if(value2 == "farenheit")
                {
                    hasil = (angka - 273.15) * 9 / 5 + 32;
                }
                else if (value2 == "kelvin")
                {
                    hasil = angka;
                }
            }

            tbh_suhu.Text = " " + (hasil);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuButton1.Click += new EventHandler(bunifuButton1_Click);
            Controls.Add(bunifuButton1);
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void tbnSuhu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }

        private void tbh_suhu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back;
        }
    }
}
