using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogIn_design
{
    public partial class Nuevo : Form
    {
        public Nuevo()
        {
            InitializeComponent();
        }
        public int LabId { get; set; }
        private void Nuevo_Load(object sender, EventArgs e)
        {
            LaboratoriosBindingSource.DataSource = BLL.LaboratoriosBLL.Buscar(LabId);
            this.reportViewer1.RefreshReport();
        }
    }
}
