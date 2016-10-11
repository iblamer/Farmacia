using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Entidades;
using BLL;

namespace LogIn_design
{
    public partial class RegistroMeds : Form
    {
        public RegistroMeds()
        {
            InitializeComponent();
            ListarLaboratorios();
            NoradioButton.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        string lab = " ";

        private void LaboratoriocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab = LaboratoriocomboBox.SelectedValue.ToString();
        }

        FarmaciaDB db = new FarmaciaDB();

        private void ListarLaboratorios()
        {
            var lista = db.Laboratorio.ToList();

            LaboratoriocomboBox.DataSource = lista;
            LaboratoriocomboBox.DisplayMember = ("labName");
            LaboratoriocomboBox.ValueMember = ("labId");
        }

        private void SiradioButton_CheckedChanged(object sender, EventArgs e)
        {
            PrecioDetalletextBox.Enabled = true;
        }

        private void NoradioButton_CheckedChanged(object sender, EventArgs e)
        {
            PrecioDetalletextBox.Enabled = false;
        }
    }
}
