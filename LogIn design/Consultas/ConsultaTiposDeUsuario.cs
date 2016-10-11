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
using DAL;

namespace LogIn_design.Consultas
{
    public partial class ConsultaTiposDeUsuario : Form
    {
        public ConsultaTiposDeUsuario()
        {
            InitializeComponent();
        }

        public List<TipoUsuarios> lista = new List<TipoUsuarios>();

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            var db = new FarmaciaDB();

            if(!String.IsNullOrEmpty(FiltrotextBox.Text))
            {
                lista = TiposBLL.GetList(Utilidades.StringToInt(FiltrotextBox.Text));
            }
            else
            {
                lista = TiposBLL.GetList();
            }
            DatosdataGridView.DataSource = lista;

        }
    }
}
