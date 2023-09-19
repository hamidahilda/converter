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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(bunifuTextBox1.Text);

            double hasil = 0;

            if (value1 == "kg")
            {
                if (value2 == "kg")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "hg")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "dg")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "cg")
                {
                    hasil = angka * 100000;
                }
                else if (value2 == "mg")
                {
                    hasil = angka * 1000000;
                }
            }

            if (value1 == "hg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "hg")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "dg")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "cg")
                {
                    hasil = angka * 10000;
                }
                else if (value2 == "mg")
                {
                    hasil = angka * 100000;
                }
            }

            if (value1 == "dag")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dag")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "dg")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "cg")
                {
                    hasil = angka * 1000;
                }
                else if (value2 == "mg")
                {
                    hasil = angka * 10000;
                }

            }

            if (value1 == "g")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "g")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "dg")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "cg")
                {
                    hasil = angka * 100;
                }
                else if (value2 == "mg")
                {
                    hasil = angka * 1000;
                }

            }

            if (value1 == "dg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "g")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "dg")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "cg")
                {
                    hasil = angka * 10;
                }
                else if (value2 == "mg")
                {
                    hasil = angka * 100;
                }

            }

            if (value1 == "cg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "g")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "dg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "cg")
                {
                    hasil = angka * 1;
                }
                else if (value2 == "mg")
                {
                    hasil = angka * 10;
                }

            }

            if (value1 == "mg")
            {
                if (value2 == "kg")
                {
                    hasil = angka / 1000000;
                }
                else if (value2 == "hg")
                {
                    hasil = angka / 100000;
                }
                else if (value2 == "dag")
                {
                    hasil = angka / 10000;
                }
                else if (value2 == "g")
                {
                    hasil = angka / 1000;
                }
                else if (value2 == "dg")
                {
                    hasil = angka / 100;
                }
                else if (value2 == "cg")
                {
                    hasil = angka / 10;
                }
                else if (value2 == "mg")
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

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
