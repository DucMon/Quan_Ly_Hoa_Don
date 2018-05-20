using QL_HoaDon.BLL;
using QL_HoaDon.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HoaDon.GUI
{
    public partial class frmNhap_Khach_Hang : Form
    {
        public frmNhap_Khach_Hang()
        {
            InitializeComponent();
        }

   

        private void frmNhap_Khach_Hang_Load(object sender, EventArgs e)
        {
            DataTable dt = DVMHBLL.LayDSDVMH();
            dgvKH.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DVMH kh = new DVMH();
            try
            {
                kh.MDVMH = tbMKH.Text;
                kh.TenDVMH = tbTKH.Text;
                kh.MSTMua = tbMST.Text;
                kh.STKMua = float.Parse(tbSTK.Text);
                kh.DiaChiMua = tbDC.Text;
                kh.SDTMua = tbSDT.Text;
                bool kq1 = DVMHBLL.ThemKH(kh);
                if (kq1 == true)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("khách hàng này đã tồn tại!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu nhập không chính xác! Vui lòng nhập lại");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvKH.CurrentCell.RowIndex;
                string rs = dgvKH.Rows[rowindex].Cells[0].Value.ToString();
                try
                {
                    DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    if (result == DialogResult.Yes)
                    {
                        bool kq1;
                        try
                        {
                            kq1 = DVMHBLL.XoaKHTheoMa(rs);
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
                    MessageBox.Show("Chưa chọn khách hàng cần xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn khách hàng cần xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvKH.CurrentCell.RowIndex;
                DVMH kh = new DVMH();
                int icountSelectedRow = dgvKH.SelectedRows.Count;
                if (icountSelectedRow == 0)
                    MessageBox.Show("Bạn hãy chọn dòng cần cập nhật lại dữ liệu!");
                else if (icountSelectedRow == 1)
                {
                    kh.MDVMH = dgvKH.Rows[rowindex].Cells[0].Value.ToString();
                    kh.TenDVMH = tbTKH.Text;
                    kh.MSTMua = tbMST.Text;
                    kh.SDTMua = tbSDT.Text;
                    kh.STKMua = float.Parse(tbSTK.Text);
                    kh.DiaChiMua = tbDC.Text;
                    bool kq1 = DVMHBLL.UpdateKH(kh);
                    if (kq1 == true)
                    {
                        MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("khách hàng đã tồn tại!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Bạn chỉ có thể chọn 1 dòng để cập nhật lại dữ liệu!");
            }
            catch
            {
                MessageBox.Show("Nhập Sai Định Dạng!");
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMKH.Text = dgvKH.Rows[e.RowIndex].Cells["MDVMH"].FormattedValue.ToString();
            tbTKH.Text = dgvKH.Rows[e.RowIndex].Cells["TenDonViMuaHang"].FormattedValue.ToString();
            tbSDT.Text = dgvKH.Rows[e.RowIndex].Cells["SDTMua"].FormattedValue.ToString();
            tbMST.Text = dgvKH.Rows[e.RowIndex].Cells["MaSoThueMua"].FormattedValue.ToString();
            tbDC.Text = dgvKH.Rows[e.RowIndex].Cells["DiaChiMua"].FormattedValue.ToString();
            tbSTK.Text = dgvKH.Rows[e.RowIndex].Cells["STKMua"].FormattedValue.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbMKH.Text = "";
            tbTKH.Text = "";
            tbSDT.Text = "";
            tbMST.Text = "";
            tbDC.Text = "";
            tbSTK.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = DVMHBLL.LayDSDVMH();
            dgvKH.DataSource = dt;
        }

        private void frmNhap_Khach_Hang_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
