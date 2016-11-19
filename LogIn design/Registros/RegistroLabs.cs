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

namespace LogIn_design
{
    public partial class RegistroLabs : Form
    {
        public RegistroLabs()
        {
            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if(Search())
            {
                FillBoxes(LaboratoriosBLL.Buscar(Utilidades.StringToInt(idTextbox.Text)));
            }
        }

        private bool Search()
        {
            if(LaboratoriosBLL.Buscar(Utilidades.StringToInt(idTextbox.Text)) == null)
            {
                MessageBox.Show("El id de este laboratorio no existe.");
                return false;
            }

            return true;
        }

        private void FillBoxes(Laboratorios lab)
        {
            idTextbox.Text = lab.labId.ToString();
            nameTextbox.Text = lab.labName.ToString();
        }


        private void LlenarClases(Laboratorios lab)
        {
            lab.labName = nameTextbox.Text;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            Laboratorios lab = new Laboratorios();

            LlenarClases(lab);

            if(LaboratoriosBLL.Insertar(lab))
            {
                MessageBox.Show("El laboratorio se a guardado");
                clean();
            }

        }

        private void clean()
        {
            idTextbox.Clear();
            nameTextbox.Clear();
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            Laboratorios lab = new Laboratorios();

            lab.labName = nameTextbox.Text;

            
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Search())
                {
                    LaboratoriosBLL.Borrar(Utilidades.StringToInt(idTextbox.Text));
                    MessageBox.Show("Se elimino el usuario");
                }
                else
                {
                    MessageBox.Show("El id no existe");
                    clean();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
