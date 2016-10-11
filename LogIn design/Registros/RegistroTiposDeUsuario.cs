using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using Entidades;

namespace LogIn_design
{
    public partial class RegistroTiposDeUsuario : Form
    {
        public RegistroTiposDeUsuario()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (Search())
                FillBoxes(TiposBLL.Buscar(Utilidades.StringToInt(idBox.Text)));
        }

        private bool Search()
        {
            if (TiposBLL.Buscar(Utilidades.StringToInt(idBox.Text)) == null)
            {
                MessageBox.Show("El id no existe");
                return false;
            }
            return true;
        }

        private void FillBoxes(TipoUsuarios tipo)
        {
            idBox.Text = tipo.Id.ToString();
            nameBox.Text = tipo.NomTipo;

        }

        private void LlenarClase(TipoUsuarios tipo)
        {
            tipo.NomTipo = nameBox.Text;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            TipoUsuarios tipo = new TipoUsuarios();
            LlenarClase(tipo);

            if (TiposBLL.Insertar(tipo))
            {
                MessageBox.Show("Se guardo el tipo de usuario!");
                nameBox.Clear();
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Search())
                {
                    TiposBLL.Eliminar(Utilidades.StringToInt(idBox.Text));
                    MessageBox.Show("El tipo de usuario se a eliminado");
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
