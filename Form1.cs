using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_dinhdang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbllaptrinh_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapten_TextChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Text = txtNhapten.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbRed_CheckedChanged(object sender, EventArgs e)
        {

            lbllaptrinh.ForeColor = Color.Red;
            txtNhapten.ForeColor = Color.Red;
        }

        private void rdbGreen_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Green;
            txtNhapten.ForeColor = Color.Green;
        }

        private void rdbBlue_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Blue;
            txtNhapten.ForeColor = Color.Blue;
        }

        private void rdbBlack_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Black;
            txtNhapten.ForeColor = Color.Black;
        }

        private void chkDam_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkNghien_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkGachchan_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Underline);
        }
    }
}
