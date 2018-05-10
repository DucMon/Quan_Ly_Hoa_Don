using DevExpress.XtraBars;
using QL_HoaDon.BLL;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
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
        }
    }
}
