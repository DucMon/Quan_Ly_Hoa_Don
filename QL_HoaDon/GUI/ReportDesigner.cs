using DevExpress.DataAccess.Sql;
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
    public partial class ReportDesigner : Form
    {
        public ReportDesigner()
        {
            InitializeComponent();
            SqlDataSource.DisableCustomQueryValidation = true;
        }
    }
}
