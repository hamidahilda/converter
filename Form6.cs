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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double angka = double.Parse(bunifuTextBox1.Text);

            double hasil = 0;

            if (value1 == "detik")
            {
                if (value2 == "detik")
                {
                    hasil = angka;
                }
                else if (value2 == "menit")
                {
                    hasil = angka * 1 / 60;
                }
                else if (value2 == "jam")
                {
                    hasil = angka * 1 / 3600;
                }
                else if (value2 == "hari")
                {
                    hasil = angka * 1 / 86400;
                }
                else if (value2 == "bulan")
                {
                    hasil = angka * 1 / 1728000;
                }
                else if (value2 == "tahun")
                {
                    hasil = angka * 1 / 31536000;
                }
            }
            else if (value1 == "menit")
            {
                if (value2 == "detik")
                {
                    hasil = angka * 60;
                }
                else if (value2 == "menit")
                {
                    hasil = angka;
                }
                else if (value2 == "jam")
                {
                    hasil = angka * 1 / 60;
                }
                else if (value2 == "hari")
                {
                    hasil = angka * 1 / 1440;
                }
                else if (value2 == "bulan")
                {
                    hasil = angka * 1 / 43800;
                }
                else if (value2 == "tahun")
                {
                    hasil = angka * 1 / 525600;
                }
            }
            else if (value1 == "jam")
            {
                if (value2 == "detik")
                {
                    hasil = angka * 3600;
                }
                else if (value2 == "menit")
                {
                    hasil = angka * 60;
                }
                else if (value2 == "jam")
                {
                    hasil = angka;
                }
                else if (value2 == "hari")
                {
                    hasil = angka * 1 / 24;
                }
                else if (value2 == "bulan")
                {
                    hasil = angka * 1 / 730;
                }
                else if (value2 == "tahun")
                {
                    hasil = angka * 1 / 8760;
                }
            }
            else if (value1 == "hari")
            {
                if (value2 == "detik")
                {
                    hasil = angka * 86400;
                }
                else if (value2 == "menit")
                {
                    hasil = angka * 1440;
                }
                else if (value2 == "jam")
                {
                    hasil = angka * 24;
                }
                else if (value2 == "hari")
                {
                    hasil = angka;
                }
                else if (value2 == "bulan")
                {
                    hasil = angka * 1 / 30;
                }
                else if (value2 == "tahun")
                {
                    hasil = angka * 1 / 365;
                }
            }
            else if (value1 == "bulan")
            {
                if (value2 == "detik")
                {
                    hasil = angka * 172800;
                }
                else if (value2 == "menit")
                {
                    hasil = angka * 43800;
                }
                else if (value2 == "jam")
                {
                    hasil = angka * 730;
                }
                else if (value2 == "hari")
                {
                    hasil = angka * 30;
                }
                else if (value2 == "bulan")
                {
                    hasil = angka;
                }
                else if (value2 == "tahun")
                {
                    hasil = angka * 1 / 12;
                }
            }else if (value1 == "tahun")
            {
                if (value2 == "detik")
                {
                    hasil = angka * 31536000;
                }
                else if (value2 == "menit")
                {
                    hasil = angka * 525600;
                }
                else if (value2 == "jam")
                {
                    hasil = angka * 8760;
                }
                else if (value2 == "hari")
                {
                    hasil = angka * 365;
                }
                else if (value2 == "bulan")
                {
                    hasil = angka * 12;
                }
                else if (value2 == "tahun")
                {
                    hasil = angka;
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
