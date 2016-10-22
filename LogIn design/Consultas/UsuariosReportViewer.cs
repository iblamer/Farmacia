using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BLL;
using Entidades;

namespace LogIn_design.Consultas
{
    public partial class UsuariosReportViewer : Form
    {
        public UsuariosReportViewer()
        {
            InitializeComponent();
        }

        public void UsuariosReportViewer_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = @"E:\aplicada 1\Tarea1\Capitulo 8\LogIn design\LogIn design\Reportes\ReporteUsuarios.rdlc";

            ReportDataSource source = new ReportDataSource("UsuariosDataSet", UsuariosBLL.GetLista());

            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
