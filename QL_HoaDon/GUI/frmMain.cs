using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_HoaDon.GUI;

namespace QL_HoaDon.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(1000);
            InitializeComponent();
            t.Abort();
        }
        private void StartForm()
        {
            Application.Run(new frmLazyLoading());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmNhapHangHoa1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhapHangHoa1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmHome.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Size = new Size(159, 98);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(159, 44);
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Size = new Size(159, 98);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Size = new Size(159, 44);
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Size = new Size(159, 98);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Size = new Size(159, 44);
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            btnClose.Size = new Size(159, 98);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Size = new Size(159, 44);
        }

<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e)
        {

        }
=======
        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNhapHoaDon.BringToFront();
        }
>>>>>>> fa7411e0660a087799097e873f82931902a50172
    }
}
