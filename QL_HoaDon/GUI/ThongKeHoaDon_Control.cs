using DevExpress.XtraBars;
using QL_HoaDon.BLL;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;

namespace QL_HoaDon.GUI
{
    public partial class ThongKeHoaDon_Control : DevExpress.XtraEditors.XtraUserControl
    {
        HoaDonBLL hdbll = new HoaDonBLL();
        public ThongKeHoaDon_Control()
        {
            InitializeComponent();



        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        void LoadDSTKbyDate(DateTime fromDate, DateTime toDate)
        {
            dtgvThongKe.DataSource = HoaDonBLL.LoadDSHDbyDate(fromDate, toDate);

        }

        private void btnSearchdtd_Click(object sender, EventArgs e)
        {
            LoadDSTKbyDate(cbFromdate.DateTime,cbTodate.DateTime);
        }

        private void xtraTabPage1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void ThongKeHoaDon_Control_Load(object sender, EventArgs e)
        {
            LoadDSHD();
            LoadCustomer();
        }
        void LoadCustomer()
        {
            cbGetCustomer.DataSource = HoaDonBLL.LoadCustomer();
            cbGetCustomer.DisplayMember = "NguoiMuaHang";
        }

        private void btnSearchuser_Click(object sender, EventArgs e)
        {
            LoadDSHDbyCustomer(cbGetCustomer.Text);
        }
        void LoadDSHDbyCustomer(string name)
        {
            dtgvThongKe.DataSource = HoaDonBLL.LoadDSHDbyCustomer(name);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDSHD();
        }
        void LoadDSHD()
        {
            DataTable _dshd = HoaDonBLL.LayDSHD();
            dtgvThongKe.DataSource = _dshd;
        }
    }
}
