using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteCrud
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa emp = new frmEmpresa();
            emp.Show();
        }
    }
}
