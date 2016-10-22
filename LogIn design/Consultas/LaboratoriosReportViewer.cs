using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace LogIn_design.Consultas
{
    public partial class LaboratoriosReportViewer : Form
    {
        public LaboratoriosReportViewer()
        {
            InitializeComponent();
        }

        private void LaboratoriosReportViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = @"E:\aplicada 1\Tarea1\Capitulo 8\LogIn design\LogIn design\Reportes\ReporteLaboratorios.rdlc";

            ReportDataSource source = new ReportDataSource("LaboratoriosDataSet", LaboratoriosBLL.GetLista());

            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}
