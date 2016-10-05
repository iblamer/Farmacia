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
    public partial class Reguistro : Form
    {
        public Reguistro()
        {
            InitializeComponent();
            ListarTipo();
        }

        string categoria = " ";

        private void button5_Click(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();           
            Usuario.Clave = pwBox.Text;
            Usuario.Nombre = nameBox.Text;
            Usuario.IdTipo = StringToInt(categoria);


            if (pwBox.Text != cpwBox.Text)
            {
                MessageBox.Show("Las contrasenas no coinciden");
            }
            else
            {

                UsuariosBLL.Insertar(Usuario);
                /*if (UsuariosBLL.Insertar(Usuario))
                {
                    MessageBox.Show("Se guardo!");
                }*/
            }
            
           
                
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Search())
                {
                    UsuariosBLL.Remove(StringToInt(IdBox.Text));
                    MessageBox.Show("Se elimino el usuario!");
                }
                else
                    MessageBox.Show("El id de este usuario no existe");
            }
            catch(Exception)
            {
                throw ;
            }
            clean();
          
        }        
            

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (Search())
                FillBoxes(UsuariosBLL.Buscar(StringToInt(IdBox.Text)));
        }

        private bool Search ()
        {
            if (UsuariosBLL.Buscar(StringToInt(IdBox.Text))== null)
             {
                MessageBox.Show("Id no existe");
                return false;
            }

            return true;
        }

        private int StringToInt(string text)
        {
            int n = 0;

            int.TryParse(text, out n);
            return n;
        }



        private void FillBoxes(Usuarios user)
        {
            IdBox.Text = user.UserID.ToString();
            nameBox.Text = user.Nombre.ToString();
            pwBox.Text = user.Clave.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.Nombre = nameBox.Text;
            user.Clave = pwBox.Text;
            
            UsuariosBLL.Update(StringToInt(IdBox.Text), user);

            MessageBox.Show("Se a actualizado el usuario");
            clean();
        }

       private void clean()
       {
            nameBox.Clear();
            pwBox.Clear();
            cpwBox.Clear();
            IdBox.Clear();
       }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoria = typeCBox.SelectedValue.ToString();
        }
        FarmaciaDB db = new FarmaciaDB();
        private void ListarTipo ()
        {
            var lista = db.Categoria.ToList();

            if(lista.Count > 0 )
            {
                typeCBox.DataSource = lista;
                typeCBox.DisplayMember = "NomCategoria";
                typeCBox.ValueMember = "Id";
               
            }

        }

   
    }
}
