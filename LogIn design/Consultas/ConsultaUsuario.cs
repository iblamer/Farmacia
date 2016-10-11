using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace LogIn_design.Consultas
{
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DatosdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public List<Usuarios> lista = new List<Usuarios>();

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(idTextBox.Text))
            {
                lista = BLL.UsuariosBLL.GetLista(Utilidades.StringToInt(idTextBox.Text));             
            }
            else
            {
                lista = BLL.UsuariosBLL.GetLista();
            }

            DatadataGridView.DataSource = lista;
        }
    }
}
