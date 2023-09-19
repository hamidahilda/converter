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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuImageButton3.Click += new EventHandler(bunifuImageButton3_Click);
            Controls.Add(bunifuImageButton3);
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuImageButton2.Click += new EventHandler(bunifuImageButton2_Click);
            Controls.Add(bunifuImageButton2);
            Form4 fm4 = new Form4();
            fm4.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Click += new EventHandler(bunifuImageButton1_Click);
            Controls.Add(bunifuImageButton1);
            Form5 fm5 = new Form5();
            fm5.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            bunifuImageButton4.Click += new EventHandler(bunifuImageButton4_Click);
            Controls.Add(bunifuImageButton4);
            Form6 fm6 = new Form6();
            fm6.Show();
            this.Hide();
        }
    }
}
