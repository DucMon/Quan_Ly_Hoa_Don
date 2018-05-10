namespace QL_HoaDon.GUI
{
    partial class frmNhapHangHoa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMHH = new System.Windows.Forms.TextBox();
            this.tbTHH = new System.Windows.Forms.TextBox();
            this.tbDVT = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbGC = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbTenHHTraCuu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.frmNhapHangHoalayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tbGCitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbGiaitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbDVTitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbTHHitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tbMHHitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.flowLayoutPanel2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmNhapHangHoalayoutControl1ConvertedLayout)).BeginInit();
            this.frmNhapHangHoalayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGCitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiaitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDVTitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTHHitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMHHitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayoutPanel2item)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMHH
            // 
            this.tbMHH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMHH.Location = new System.Drawing.Point(16, 36);
            this.tbMHH.Margin = new System.Windows.Forms.Padding(4);
            this.tbMHH.Name = "tbMHH";
            this.tbMHH.Size = new System.Drawing.Size(363, 25);
            this.tbMHH.TabIndex = 0;
            // 
            // tbTHH
            // 
            this.tbTHH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTHH.Location = new System.Drawing.Point(385, 36);
            this.tbTHH.Margin = new System.Windows.Forms.Padding(4);
            this.tbTHH.Name = "tbTHH";
            this.tbTHH.Size = new System.Drawing.Size(571, 25);
            this.tbTHH.TabIndex = 1;
            // 
            // tbDVT
            // 
            this.tbDVT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDVT.Location = new System.Drawing.Point(16, 87);
            this.tbDVT.Margin = new System.Windows.Forms.Padding(4);
            this.tbDVT.Name = "tbDVT";
            this.tbDVT.Size = new System.Drawing.Size(363, 25);
            this.tbDVT.TabIndex = 2;
            // 
            // tbGia
            // 
            this.tbGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbGia.Location = new System.Drawing.Point(385, 87);
            this.tbGia.Margin = new System.Windows.Forms.Padding(4);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(571, 25);
            this.tbGia.TabIndex = 3;
            this.tbGia.Text = "0";
            this.tbGia.Click += new System.EventHandler(this.tbGia_Click);
            this.tbGia.TextChanged += new System.EventHandler(this.tbGia_TextChanged);
            // 
            // tbGC
            // 
            this.tbGC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGC.Location = new System.Drawing.Point(16, 138);
            this.tbGC.Margin = new System.Windows.Forms.Padding(4);
            this.tbGC.Name = "tbGC";
            this.tbGC.Size = new System.Drawing.Size(940, 151);
            this.tbGC.TabIndex = 4;
            this.tbGC.Text = "";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAdd);
            this.flowLayoutPanel2.Controls.Add(this.btnDel);
            this.flowLayoutPanel2.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(16, 295);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(940, 75);
            this.flowLayoutPanel2.TabIndex = 11;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 65);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(165, 4);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(153, 65);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(326, 4);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 65);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(487, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 65);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHangHoa);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.tbTenHHTraCuu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(16, 376);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 327);
            this.panel1.TabIndex = 12;
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHangHoa.Location = new System.Drawing.Point(265, 63);
            this.dgvHangHoa.MainView = this.gridView1;
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(707, 241);
            this.dgvHangHoa.TabIndex = 15;
            this.dgvHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvHangHoa.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.dgvHangHoa_FocusedViewChanged);
            this.dgvHangHoa.Click += new System.EventHandler(this.dgvHangHoa_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvHangHoa;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(4, 110);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(253, 65);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(4, 176);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(253, 65);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbTenHHTraCuu
            // 
            this.tbTenHHTraCuu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTenHHTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTenHHTraCuu.Location = new System.Drawing.Point(47, 79);
            this.tbTenHHTraCuu.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenHHTraCuu.Name = "tbTenHHTraCuu";
            this.tbTenHHTraCuu.Size = new System.Drawing.Size(163, 23);
            this.tbTenHHTraCuu.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(75, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tìm Kiếm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(359, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thông Tin Hàng Hóa";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmNhapHangHoalayoutControl1ConvertedLayout
            // 
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Controls.Add(this.tbGC);
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Controls.Add(this.tbGia);
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Controls.Add(this.tbDVT);
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Controls.Add(this.tbTHH);
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Controls.Add(this.tbMHH);
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Controls.Add(this.panel1);
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Controls.Add(this.flowLayoutPanel2);
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Name = "frmNhapHangHoalayoutControl1ConvertedLayout";
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.frmNhapHangHoalayoutControl1ConvertedLayout.Size = new System.Drawing.Size(972, 719);
            this.frmNhapHangHoalayoutControl1ConvertedLayout.TabIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tbGCitem,
            this.tbGiaitem,
            this.tbDVTitem,
            this.tbTHHitem,
            this.tbMHHitem,
            this.panel1item,
            this.flowLayoutPanel2item});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(972, 719);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tbGCitem
            // 
            this.tbGCitem.Control = this.tbGC;
            this.tbGCitem.Location = new System.Drawing.Point(0, 102);
            this.tbGCitem.Name = "tbGCitem";
            this.tbGCitem.Size = new System.Drawing.Size(946, 177);
            this.tbGCitem.Text = "Ghi Chú";
            this.tbGCitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.tbGCitem.TextSize = new System.Drawing.Size(81, 16);
            // 
            // tbGiaitem
            // 
            this.tbGiaitem.Control = this.tbGia;
            this.tbGiaitem.Location = new System.Drawing.Point(369, 51);
            this.tbGiaitem.Name = "tbGiaitem";
            this.tbGiaitem.Size = new System.Drawing.Size(577, 51);
            this.tbGiaitem.Text = "Giá Bán";
            this.tbGiaitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.tbGiaitem.TextSize = new System.Drawing.Size(81, 16);
            // 
            // tbDVTitem
            // 
            this.tbDVTitem.Control = this.tbDVT;
            this.tbDVTitem.Location = new System.Drawing.Point(0, 51);
            this.tbDVTitem.Name = "tbDVTitem";
            this.tbDVTitem.Size = new System.Drawing.Size(369, 51);
            this.tbDVTitem.Text = "Đơn Vị Tính";
            this.tbDVTitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.tbDVTitem.TextSize = new System.Drawing.Size(81, 16);
            // 
            // tbTHHitem
            // 
            this.tbTHHitem.Control = this.tbTHH;
            this.tbTHHitem.Location = new System.Drawing.Point(369, 0);
            this.tbTHHitem.Name = "tbTHHitem";
            this.tbTHHitem.Size = new System.Drawing.Size(577, 51);
            this.tbTHHitem.Text = "Tên Hàng Hóa";
            this.tbTHHitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.tbTHHitem.TextSize = new System.Drawing.Size(81, 16);
            // 
            // tbMHHitem
            // 
            this.tbMHHitem.Control = this.tbMHH;
            this.tbMHHitem.Location = new System.Drawing.Point(0, 0);
            this.tbMHHitem.Name = "tbMHHitem";
            this.tbMHHitem.Size = new System.Drawing.Size(369, 51);
            this.tbMHHitem.Text = "Mã Hàng Hóa";
            this.tbMHHitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.tbMHHitem.TextSize = new System.Drawing.Size(81, 16);
            // 
            // panel1item
            // 
            this.panel1item.Control = this.panel1;
            this.panel1item.Location = new System.Drawing.Point(0, 360);
            this.panel1item.Name = "panel1item";
            this.panel1item.Size = new System.Drawing.Size(946, 333);
            this.panel1item.TextSize = new System.Drawing.Size(0, 0);
            this.panel1item.TextVisible = false;
            // 
            // flowLayoutPanel2item
            // 
            this.flowLayoutPanel2item.Control = this.flowLayoutPanel2;
            this.flowLayoutPanel2item.Location = new System.Drawing.Point(0, 279);
            this.flowLayoutPanel2item.Name = "flowLayoutPanel2item";
            this.flowLayoutPanel2item.Size = new System.Drawing.Size(946, 81);
            this.flowLayoutPanel2item.TextSize = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2item.TextVisible = false;
            // 
            // frmNhapHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmNhapHangHoalayoutControl1ConvertedLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapHangHoa";
            this.Size = new System.Drawing.Size(972, 719);
            this.Load += new System.EventHandler(this.Nhap_Hang_Hoa_Control_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmNhapHangHoalayoutControl1ConvertedLayout)).EndInit();
            this.frmNhapHangHoalayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGCitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiaitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDVTitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTHHitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMHHitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayoutPanel2item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMHH;
        private System.Windows.Forms.TextBox tbTHH;
        private System.Windows.Forms.TextBox tbDVT;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.RichTextBox tbGC;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.GridControl dgvHangHoa;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbTenHHTraCuu;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl frmNhapHangHoalayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem tbGCitem;
        private DevExpress.XtraLayout.LayoutControlItem tbGiaitem;
        private DevExpress.XtraLayout.LayoutControlItem tbDVTitem;
        private DevExpress.XtraLayout.LayoutControlItem tbTHHitem;
        private DevExpress.XtraLayout.LayoutControlItem tbMHHitem;
        private DevExpress.XtraLayout.LayoutControlItem panel1item;
        private DevExpress.XtraLayout.LayoutControlItem flowLayoutPanel2item;
    }
}
