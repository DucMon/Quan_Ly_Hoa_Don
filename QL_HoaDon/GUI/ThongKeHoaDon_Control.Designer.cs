namespace QL_HoaDon.GUI
{
    partial class ThongKeHoaDon_Control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeHoaDon_Control));
            this.tctTKHD = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.cbGetCustomer = new System.Windows.Forms.ComboBox();
            this.btnSearchuser = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchdtd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtgvThongKe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbFromdate = new DevExpress.XtraEditors.DateEdit();
            this.cbTodate = new DevExpress.XtraEditors.DateEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tctTKHD)).BeginInit();
            this.tctTKHD.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFromdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFromdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTodate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTodate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tctTKHD
            // 
            this.tctTKHD.Location = new System.Drawing.Point(0, 0);
            this.tctTKHD.Name = "tctTKHD";
            this.tctTKHD.SelectedTabPage = this.xtraTabPage1;
            this.tctTKHD.Size = new System.Drawing.Size(966, 713);
            this.tctTKHD.TabIndex = 0;
            this.tctTKHD.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.cbGetCustomer);
            this.xtraTabPage1.Controls.Add(this.btnSearchuser);
            this.xtraTabPage1.Controls.Add(this.btnRefresh);
            this.xtraTabPage1.Controls.Add(this.btnSearchdtd);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.dtgvThongKe);
            this.xtraTabPage1.Controls.Add(this.cbFromdate);
            this.xtraTabPage1.Controls.Add(this.cbTodate);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(959, 678);
            this.xtraTabPage1.Text = "Thống Kê Hóa Đơn";
            this.xtraTabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage1_Paint);
            // 
            // cbGetCustomer
            // 
            this.cbGetCustomer.FormattingEnabled = true;
            this.cbGetCustomer.Location = new System.Drawing.Point(4, 227);
            this.cbGetCustomer.Name = "cbGetCustomer";
            this.cbGetCustomer.Size = new System.Drawing.Size(166, 24);
            this.cbGetCustomer.TabIndex = 5;
            // 
            // btnSearchuser
            // 
            this.btnSearchuser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchuser.ImageOptions.Image")));
            this.btnSearchuser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearchuser.Location = new System.Drawing.Point(176, 231);
            this.btnSearchuser.Name = "btnSearchuser";
            this.btnSearchuser.Size = new System.Drawing.Size(66, 22);
            this.btnSearchuser.TabIndex = 4;
            this.btnSearchuser.Click += new System.EventHandler(this.btnSearchuser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnRefresh.Location = new System.Drawing.Point(153, 283);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 46);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearchdtd
            // 
            this.btnSearchdtd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchdtd.ImageOptions.Image")));
            this.btnSearchdtd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnSearchdtd.Location = new System.Drawing.Point(95, 126);
            this.btnSearchdtd.Name = "btnSearchdtd";
            this.btnSearchdtd.Size = new System.Drawing.Size(89, 46);
            this.btnSearchdtd.TabIndex = 4;
            this.btnSearchdtd.Click += new System.EventHandler(this.btnSearchdtd_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 208);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(171, 17);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Thống kê theo khách hàng:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Đến ngày:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Từ ngày:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(130, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thống kê theo ngày:";
            // 
            // dtgvThongKe
            // 
            this.dtgvThongKe.Location = new System.Drawing.Point(248, 40);
            this.dtgvThongKe.MainView = this.gridView1;
            this.dtgvThongKe.Name = "dtgvThongKe";
            this.dtgvThongKe.Size = new System.Drawing.Size(711, 638);
            this.dtgvThongKe.TabIndex = 0;
            this.dtgvThongKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dtgvThongKe.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dtgvThongKe;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cbFromdate
            // 
            this.cbFromdate.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.cbFromdate.EditValue = null;
            this.cbFromdate.Location = new System.Drawing.Point(95, 70);
            this.cbFromdate.Name = "cbFromdate";
            this.cbFromdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFromdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFromdate.Properties.DisplayFormat.FormatString = "";
            this.cbFromdate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbFromdate.Properties.EditFormat.FormatString = "";
            this.cbFromdate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbFromdate.Size = new System.Drawing.Size(147, 22);
            this.cbFromdate.TabIndex = 3;
            // 
            // cbTodate
            // 
            this.cbTodate.EditValue = null;
            this.cbTodate.Location = new System.Drawing.Point(95, 98);
            this.cbTodate.Name = "cbTodate";
            this.cbTodate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTodate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTodate.Properties.DisplayFormat.FormatString = "";
            this.cbTodate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbTodate.Properties.EditFormat.FormatString = "";
            this.cbTodate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbTodate.Size = new System.Drawing.Size(147, 22);
            this.cbTodate.TabIndex = 3;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(959, 678);
            this.xtraTabPage2.Text = "Report";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(420, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(345, 33);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Hóa Đơn Giá Trị Gia Tăng";
            // 
            // ThongKeHoaDon_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tctTKHD);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThongKeHoaDon_Control";
            this.Size = new System.Drawing.Size(972, 719);
            this.Load += new System.EventHandler(this.ThongKeHoaDon_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tctTKHD)).EndInit();
            this.tctTKHD.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFromdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFromdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTodate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTodate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tctTKHD;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnSearchuser;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnSearchdtd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dtgvThongKe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit cbFromdate;
        private DevExpress.XtraEditors.DateEdit cbTodate;
        private System.Windows.Forms.ComboBox cbGetCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}
