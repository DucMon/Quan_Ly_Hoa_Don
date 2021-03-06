﻿using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.UI.Sql;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using QL_HoaDon.BLL;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QL_HoaDon.GUI
{
    public partial class ThongKeHoaDon_Control : DevExpress.XtraEditors.XtraUserControl
    {
        
        public ThongKeHoaDon_Control()
        {
            InitializeComponent();

            string connectionString = @"Data Source=.;Initial Catalog=QuanLyHoaDon;Integrated Security=True";
            CustomStringConnectionParameters connectionParameters = new CustomStringConnectionParameters(connectionString);
            SqlDataSource ds = new SqlDataSource(connectionParameters);

            // This line of code is generated by Data Source Configuration Wizard
            hoaDonBanTableAdapter1.Fill(quanLyHoaDonDataSet1.HoaDonBan);
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

        void LoadDSTKbyDate(DateTime fromDate, DateTime toDate)
        {
            dtgvThongKe.DataSource = HoaDonBLL.LoadDSHDbyDate(fromDate, toDate);

        }

        private void btnSearchdtd_Click(object sender, EventArgs e)
        {
            if (cbFromdate.Text !=""&& cbTodate.Text != "")
            {
                LoadDSTKbyDate(cbFromdate.DateTime, cbTodate.DateTime);
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng ngày tháng!!", "Error!!!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void ThongKeHoaDon_Control_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        void LoadCustomer()
        {
            cbGetCustomer.DataSource = HoaDonBLL.LoadCustomer();
            cbGetCustomer.DisplayMember = "NguoiMuaHang";
        }

        private void btnSearchuser_Click(object sender, EventArgs e)
        {
            dtgvThongKe.Refresh();
            LoadDSHDbyCustomer(cbGetCustomer.Text);
        }
        void LoadDSHDbyCustomer(string name)
        {
            dtgvThongKe.DataSource = HoaDonBLL.LoadDSHDbyCustomer(name);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }
        void LoadDSHD()
        {
            dtgvThongKe.DataSource = HoaDonBLL.LayDSHD();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraReport1 report = new XtraReport1();

            //report.Parameters["SoHD"].Value =Convert.ToInt32(resourcesComboBoxControl1.Text);
            //report.Parameters["SoHD"].Visible = false;

            //SqlDataSource rp = report.DataSource as SqlDataSource;

            ReportDesignTool designTool = new ReportDesignTool(report);
            
            designTool.ShowRibbonDesignerDialog();
        }


        private void dtgvThongKe_Click(object sender, EventArgs e)
        {

        }
    }
}
