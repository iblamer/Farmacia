using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using DAL;
using BLL;

namespace LogIn_design.Consultas
{
    public partial class ConsultaLaboratorios : Form
    {
        public ConsultaLaboratorios()
        {
            InitializeComponent();
        }

        public List<Laboratorios> lista = new List<Laboratorios>();

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(idTextBox.Text))
            {
                lista = LaboratoriosBLL.GetLista(Utilidades.StringToInt(idTextBox.Text));
            }
            else
            {
                lista = LaboratoriosBLL.GetLista();
            }
            DatosdataGridView.DataSource = lista;
        }
    }
}
