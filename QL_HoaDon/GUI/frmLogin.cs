using QL_HoaDon.BLL;
using QL_HoaDon.DTO;
using QL_HoaDon.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HoaDon
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            textBox2.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được rỗng!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Mật khẩu không được rỗng!");
            }
            else
            {
                DataTable _ds = HoaDonBLL.Verify();
                bool flag = false;
                for (int i = 0; i < _ds.Rows.Count; i++)
                {
                    if (textBox1.Text == _ds.Rows[i]["TenDangNhap"].ToString() && textBox2.Text == _ds.Rows[i]["MatKhau"].ToString())
                    {
                        frmMain frmM = new frmMain();
                        frmM.Show();
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    this.Show();
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "username";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "password";
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
