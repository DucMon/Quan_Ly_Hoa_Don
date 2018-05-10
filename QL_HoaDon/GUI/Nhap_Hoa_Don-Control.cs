using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_HoaDon.BLL;
using QL_HoaDon.DTO;

namespace QL_HoaDon.GUI
{
    public partial class Nhap_Hoa_Don_control : UserControl
    {
        public Nhap_Hoa_Don_control()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable _dshd = HoaDonBLL.LayDSHD();
            dgvHoaDon.DataSource = _dshd;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nhap_Hoa_Don_control_Load(object sender, EventArgs e)
        {
            DataTable _dshd = HoaDonBLL.LayDSHD();
            dgvHoaDon.DataSource = _dshd;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbSHD.Text = "";
            tbKHHD.Text = "";
            tbTenKH.Text = "";
            tbDC.Text = "";
            tbNMH.Text = "";
            tbMST.Text = "";
            tbSDT.Text = "";
            tbSTK.Text = "";
            tbTGTGT.Text = "";
            tbNVBH.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            tbSHD.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            try
            {
                hd.SHD = int.Parse(tbSHD.Text);
                hd.KyHieu = tbKHHD.Text;
                hd.TenDonViMuaHang = tbTenKH.Text;
                hd.MDVMH = tbMDVMH.Text;
                hd.NguoiMuaHang = tbNMH.Text;
                hd.MaSoThueMua = tbMST.Text;
                hd.DiaChiMua = tbDC.Text;
                hd.STKMua = tbSTK.Text;
                hd.NgayHD = dtpNgayBan.Value.ToString("dd/MM/yyyy");
                hd.HinhThucThanhToan = int.Parse(comboBox1.Text);
                hd.ThueSuat = int.Parse(tbTGTGT.Text);
                hd.TongTien = float.Parse(tbTCTTT.Text);
                bool kq1 = HoaDonBLL.ThemHD(hd);
                if (kq1 == true)
                {
                    MessageBox.Show("Thêm Đơn thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Hóa Đơn này đã có!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbKHHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayBan_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
