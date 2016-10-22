using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace LogIn_design.Consultas
{
    public partial class ConsultaMedicinas : Form
    {
        public ConsultaMedicinas()
        {
            InitializeComponent();
        }

        List<Meds> lista = new List<Meds>();

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(FiltrotextBox.Text))
            {
                lista = MedsBLL.GetLista(Utilidades.StringToInt(FiltrotextBox.Text));
            }
            else
            {
                lista = MedsBLL.GetLista();
            }

            DatosdataGridView.DataSource = lista;

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            MedicinasReportViewer rMedicinas = new MedicinasReportViewer();
            rMedicinas.Show();
                
        }
    }
}
