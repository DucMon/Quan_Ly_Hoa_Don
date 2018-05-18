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
using System.Data.SqlClient;
using QL_HoaDon.DAO;

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
            lbTCTTT.Text = So_chu(double.Parse(tbTCTTT.Text));
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
            List<String> dshh = HangHoaBLL.LayListHH();
            comboBox2.DataSource = dshh;
            comboBox2.DisplayMember = "MaHang";
            comboBox2.SelectedIndex = -1;
            DataTable listHTTT = HinhThucTTBLL.LayListHTTT();
            comboBox1.DataSource = listHTTT;
            comboBox1.DisplayMember = "TenHTTT";
            comboBox1.ValueMember = "MaHTTT";
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbSHD.Text = "";
            tbKHHD.Text = "";
            comboBoxDVM.EditValue = "";
            tbMDVMH.Text = "";
            tbDC.Text = "";
            tbNMH.Text = "";
            tbMST.Text = "";
            tbSDT.Text = "";
            tbSTK.Text = "";
            TGTGT.Text = "";
            tbNVBH.Text = "";
            comboBox2.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            tbSHD.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvHHTT.DataSource = null;
            dgvHHTT.Rows.Clear();
            tbCTH.Text = "";
            tbTTGTGT.Text = "";
            tbTCTTT.Text = "0";
            HoaDon hd = new HoaDon();
            try
            {
                hd.SHD = int.Parse(tbSHD.Text);
                hd.KyHieu = tbKHHD.Text;
                hd.TenDonViMuaHang = comboBoxDVM.Text;
                hd.MDVMH = tbMDVMH.Text;
                hd.NguoiMuaHang = tbNMH.Text;
                hd.MaSoThueMua = tbMST.Text;
                hd.DiaChiMua = tbDC.Text;
                hd.STKMua = tbSTK.Text;
                hd.NgayHD = dtpNgayBan.Value.ToString("dd/MM/yyyy");
                hd.HinhThucThanhToan = Convert.ToInt32(comboBox1.SelectedValue);
                hd.ThueSuat = int.Parse(TGTGT.Text);
                hd.TongTien = 0;
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvHoaDon.CurrentCell.RowIndex;
                string rs = dgvHoaDon.Rows[rowindex].Cells[0].Value.ToString();
                try
                {
                    string sHD = rs;
                    DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    if (result == DialogResult.Yes)
                    {
                        bool kq1;
                        try
                        {
                            kq1 = HoaDonBLL.XoaHDTheoMa(sHD);
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
                    MessageBox.Show("Chưa chọn hóa đơn cần xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Chưa chọn hóa đơn cần xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "") 
            {
                string maHH = comboBox2.SelectedValue.ToString();
                DataTable dt = HangHoaBLL.LayDuLieuChoTB(maHH);
                tbTHH.Text = dt.Rows[0][1].ToString();
                tbDVT.Text = dt.Rows[0][2].ToString();
                DonGia.Text = dt.Rows[0][3].ToString();
            }
            else
            {
                tbTHH.Text = "";
                tbDVT.Text = "";
                DonGia.Text = "";
            }
        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (tbSoLuong.Text != "")
            {
                float S = 0;
                S = int.Parse(tbSoLuong.Text) * float.Parse(DonGia.Text);
                ThanhTien.Text = S.ToString();
            }
            else
                ThanhTien.Text = "";
        }

        private void dgvHHTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvHoaDon.CurrentCell.RowIndex;
            string result = dgvHoaDon.Rows[rowindex].Cells[0].Value.ToString();
            DataTable _dshhtt = HangHoaTTBLL.LayDSHHTT(result);
            dgvHHTT.DataSource = _dshhtt;
            tbTCTTT.Text = dgvHoaDon.Rows[rowindex].Cells[11].Value.ToString();
            tbCTH.Text = TinhTong().ToString();
            tbTTGTGT.Text = TinhThue().ToString();
            tbTCTTT.Text = (TinhTong() - TinhThue()).ToString();
            TGTGT.Value = int.Parse(dgvHoaDon.Rows[rowindex].Cells[10].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int rowindex = dgvHoaDon.CurrentCell.RowIndex;
            int columnindex = dgvHoaDon.CurrentCell.ColumnIndex;
            string result = dgvHoaDon.Rows[rowindex].Cells[0].Value.ToString();
            HangHoaTrucTiep httt = new HangHoaTrucTiep();
            HoaDon hd = new HoaDon();
            try
            {
                httt.SoHD = int.Parse(dgvHoaDon.Rows[rowindex].Cells[0].Value.ToString());
                httt.MaHang = comboBox2.SelectedValue.ToString();
                httt.TenHang = tbTHH.Text;
                httt.DVT = tbDVT.Text;
                httt.SoLuong = int.Parse(tbSoLuong.Text);
                httt.DonGia = float.Parse(DonGia.Text);
                httt.ThanhTien = float.Parse(ThanhTien.Text);
                bool kq1 = HangHoaTTBLL.ThemHHVaoHD(httt);
                if (kq1 == true)
                {
                    MessageBox.Show("Thêm Đơn thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TinhTong();
                    hd.TongTien = float.Parse (tbTCTTT.Text);
                    HoaDonBLL.UpdateHD(hd);
                }
                else
                    MessageBox.Show("Hóa Đơn này đã có!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Nhập sai định dạng", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbCTH_TextChanged(object sender, EventArgs e)
        {

        }
        private float TinhTong()
        {
            float S = 0;
            for (int i = 0; i < dgvHHTT.Rows.Count; ++i)
            {
                S += Convert.ToInt32(dgvHHTT.Rows[i].Cells[6].Value);
            }
            return S;
        }
        private double TinhThue()
        {
            double S = 0, T = TinhTong();
            int i = dgvHoaDon.CurrentCell.RowIndex;
            S = Convert.ToDouble(dgvHoaDon.Rows[i].Cells[10].Value.ToString()) / 100;
            return T * S;
        }

        private void dgvHHTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = dgvHHTT.CurrentCell.RowIndex;
            int columnindex = dgvHHTT.CurrentCell.ColumnIndex;
            string rs = dgvHHTT.Rows[rowindex].Cells[1].Value.ToString();
            int rs1 = int.Parse(dgvHHTT.Rows[rowindex].Cells[0].Value.ToString());
            try
            {
                DialogResult result = MessageBox.Show("Chắn chắn xóa?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {
                    bool kq1;
                    try
                    {
                        kq1 = HangHoaTTBLL.XoaHHTTTheoMa(rs, rs1);
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
                MessageBox.Show("Chưa chọn hh cần xóa!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbTenHDTraCuu.Text == "")
                MessageBox.Show("Chưa nhập tên hóa đơn cần tra cứu!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataTable kq = HoaDonBLL.TraCuuHDTheoKyHieu(tbTenHDTraCuu.Text);
                dgvHoaDon.DataSource = kq;
            }
        }

        private void tbTenHDTraCuu_TextChanged(object sender, EventArgs e)
        {
            DataTable kq = HoaDonBLL.TraCuuHDTheoKyHieu(tbTenHDTraCuu.Text);
            dgvHoaDon.DataSource = kq;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvHoaDon.CurrentCell.RowIndex;
                HoaDon hd = new HoaDon();
                int icountSelectedRow = dgvHoaDon.SelectedRows.Count;
                if (icountSelectedRow == 0)
                    MessageBox.Show("Bạn hãy chọn dòng cần cập nhật lại dữ liệu!");
                else if (icountSelectedRow == 1)
                {
                    hd.SHD = int.Parse(dgvHoaDon.Rows[rowindex].Cells[0].Value.ToString());
                    hd.ThueSuat = int.Parse(TGTGT.Value.ToString());
                    hd.TongTien = float.Parse(tbTCTTT.Text);
                    bool kq1 = HoaDonBLL.UpdateHD(hd);
                    if (kq1 == true)
                    {
                        MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("hàng hóa này đã có!", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Bạn chỉ có thể chọn 1 dòng để cập nhật lại dữ liệu!");
            }
            catch
            {
                MessageBox.Show("Nhập Sai Định Dạng!");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbMDVMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDVM_EditValueChanged(object sender, EventArgs e)
        {
            if (comboBoxDVM.EditValue.ToString() != "")
            {
                DataRowView dv = (DataRowView)comboBoxDVM.GetSelectedDataRow();
                tbMDVMH.Text = dv.DataView[comboBoxDVM.ItemIndex]["MDVMH"].ToString();
                tbDC.Text = dv.DataView[comboBoxDVM.ItemIndex]["DiaChiMua"].ToString();
                tbMST.Text = dv.DataView[comboBoxDVM.ItemIndex]["MaSoThueMua"].ToString();
                tbSDT.Text = dv.DataView[comboBoxDVM.ItemIndex]["SDTMua"].ToString();
                tbSTK.Text = dv.DataView[comboBoxDVM.ItemIndex]["STKMua"].ToString();
            }
        }

        private void dgvHoaDon_Leave(object sender, EventArgs e)
        {
        }

        private void dgvHoaDon_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
        }

        private void tbSHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSHD_MouseClick(object sender, MouseEventArgs e)
        {
            dgvHHTT.DataSource = null;
            dgvHHTT.Rows.Clear();
            tbCTH.Text = "";
            tbTTGTGT.Text = "";
            tbTCTTT.Text = "0";
        }

        private void label27_Click(object sender, EventArgs e)
        {
            frmNhap_Khach_Hang f = new frmNhap_Khach_Hang();
            f.Show();
        }

        private void comboBoxDVM_Click(object sender, EventArgs e)
        {
            DataTable listDVMH = DVMHBLL.LayDSDVMH();
            comboBoxDVM.Properties.DataSource = listDVMH;
            comboBoxDVM.Properties.DisplayMember = "TenDonViMuaHang";
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
        public static string So_chu(double gNum)
        {
            if (gNum == 0)
                return "Không đồng";

            string lso_chu = "";
            string tach_mod = "";
            string tach_conlai = "";
            double Num = Math.Round(gNum, 0);
            string gN = Convert.ToString(Num);
            int m = Convert.ToInt32(gN.Length / 3);
            int mod = gN.Length - m * 3;
            string dau = "[+]";

            // Dau [+ , - ]
            if (gNum < 0)
                dau = "[-]";
            dau = "";

            // Tach hang lon nhat
            if (mod.Equals(1))
                tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
            if (mod.Equals(2))
                tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
            if (mod.Equals(0))
                tach_mod = "000";
            // Tach hang con lai sau mod :
            if (Num.ToString().Length > 2)
                tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

            ///don vi hang mod
            int im = m + 1;
            if (mod > 0)
                lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
            /// Tach 3 trong tach_conlai

            int i = m;
            int _m = m;
            int j = 1;
            string tach3 = "";
            string tach3_ = "";

            while (i > 0)
            {
                tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
                tach3_ = tach3;
                lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
                m = _m + 1 - j;
                if (!tach3_.Equals("000"))
                    lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
                tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

                i = i - 1;
                j = j + 1;
            }
            if (lso_chu.Trim().Substring(0, 1).Equals("k"))
                lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
            if (lso_chu.Trim().Substring(0, 1).Equals("l"))
                lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
            if (lso_chu.Trim().Length > 0)
                lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim() + " đồng chẵn.";

            return lso_chu.ToString().Trim();

        }
        private static string Tach(string tach3)
        {
            string Ktach = "";
            if (tach3.Equals("000"))
                return "";
            if (tach3.Length == 3)
            {
                string tr = tach3.Trim().Substring(0, 1).ToString().Trim();
                string ch = tach3.Trim().Substring(1, 1).ToString().Trim();
                string dv = tach3.Trim().Substring(2, 1).ToString().Trim();
                if (tr.Equals("0") && ch.Equals("0"))
                    Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
                if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
                if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                    Ktach = " không trăm mười ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                    Ktach = " không trăm mười lăm ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";

            }


            return Ktach;

        }
        private static string Donvi(string so)
        {
            string Kdonvi = "";

            if (so.Equals("1"))
                Kdonvi = "";
            if (so.Equals("2"))
                Kdonvi = "nghìn";
            if (so.Equals("3"))
                Kdonvi = "triệu";
            if (so.Equals("4"))
                Kdonvi = "tỷ";
            if (so.Equals("5"))
                Kdonvi = "nghìn tỷ";
            if (so.Equals("6"))
                Kdonvi = "triệu tỷ";
            if (so.Equals("7"))
                Kdonvi = "tỷ tỷ";

            return Kdonvi;
        }
        private static string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }

        private void tbTTGTGT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
