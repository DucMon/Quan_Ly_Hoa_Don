﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_HoaDon.GUI;

namespace QL_HoaDon.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        private void StartForm()
        {
            Application.Run(new frmLazyLoading());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
