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
    public partial class frmNhapHangHoa : UserControl
    {
        
        public frmNhapHangHoa()
        {
            InitializeComponent();
        }

        private void Nhap_Hang_Hoa_Control_Load(object sender, EventArgs e)
        {
            DataTable _dshh = HangHoaBLL.LayDSHH();
            dgvHangHoa.DataSource = _dshh;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            try
            {
                hh.MaHang = tbMHH.Text;
                hh.TenHang = tbTHH.Text;
                hh.DVT = tbDVT.Text;
                hh.DonGia = float.Parse(tbGia.Text);
                hh.GhiChu = tbGC.Text;
                bool kq1 = HangHoaBLL.ThemHH(hh);
                if (kq1 == true)
                { 
                        MessageBox.Show("Thêm hàng hóa thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("hàng hóa này đã có!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu nhập không chính xác! Vui lòng nhập lại");
                tbMHH.Text = "";
                tbTHH.Text = "";
                tbDVT.Text = "";
                tbGia.Text = "0";
                tbGC.Text = "";
            }
        }

        private void tbGia_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbGia_Click(object sender, EventArgs e)
        {
            tbGia.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable _dshh = HangHoaBLL.LayDSHH();
            dgvHangHoa.DataSource = _dshh;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string maHH = tbMHH.Text;
                DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    bool kq1;
                    try
                    {
                        kq1 = HangHoaBLL.XoaHHTheoMa(maHH);
                        if (kq1 == true)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        }
                        else
                            MessageBox.Show("Xóa thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn thực đơn cần xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHangHoa_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }

        private void dgvHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                tbMHH.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "MaHang").ToString();
                tbTHH.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "TenHang").ToString();
                tbDVT.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "DVT").ToString();
                tbGia.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "DonGia").ToString();
                tbGC.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "GhiChu").ToString();
            }
            catch
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbMHH.Text = "";
            tbTHH.Text = "";
            tbDVT.Text = "";
            tbGia.Text = "0";
            tbGC.Text = "";
            tbMHH.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            int icountSelectedRow = gridView1.SelectedRowsCount;
            if (icountSelectedRow == 0)
                MessageBox.Show("Bạn hãy chọn dòng cần cập nhật lại dữ liệu!");
            else if (icountSelectedRow == 1)
            {
                hh.MaHang = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"MaHang").ToString();
                hh.TenHang = tbTHH.Text;
                hh.DVT = tbDVT.Text;
                hh.DonGia = float.Parse(tbGia.Text);
                hh.GhiChu = tbGC.Text;
                bool kq1 = HangHoaBLL.UpdateHH(hh);
                if (kq1 == true)
                {
                    MessageBox.Show("Cập nhật hàng hóa thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("hàng hóa này đã có!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
                MessageBox.Show("Bạn chỉ có thể chọn 1 dòng để cập nhật lại dữ liệu!");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbTenHHTraCuu.Text == "")
                MessageBox.Show("Chưa nhập tên hàng hóa cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable kq = HangHoaBLL.TraCuuHHTheoTen(tbTenHHTraCuu.Text);
                dgvHangHoa.DataSource = kq;
            }
        }
    }
}
