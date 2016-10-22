using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace LogIn_design.Consultas
{
    public partial class MedicinasReportViewer : Form
    {
        public MedicinasReportViewer()
        {
            InitializeComponent();
        }

        private void MedicinasReportViewer_Load(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = @"E:\aplicada 1\Tarea1\Capitulo 8\LogIn design\LogIn design\Reportes\ReporteMedicinas.rdlc";

            ReportDataSource source = new ReportDataSource("MedicinasDataSet", MedsBLL.GetLista());

            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
