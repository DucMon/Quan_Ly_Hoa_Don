﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using System.Text;

namespace QL_HoaDon.GUI
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {

        public XtraReport1()
        {
            InitializeComponent();
            
        }

        private void XtraReport1_DataSourceDemanded(object sender, EventArgs e)
        {
           
        }
    }
}
