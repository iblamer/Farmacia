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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            var Rep = new Nuevo();
            Rep.LabId = 1;
            Rep.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroUsuario r = new RegistroUsuario();

            if (r.Name == nomBox.Text)
                MessageBox.Show("Successful login");
            else
                MessageBox.Show("Unsuccessful login");
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario r = new RegistroUsuario();
            r.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario rUsuarios = new RegistroUsuario();
            rUsuarios.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuario cUsuario = new Consultas.ConsultaUsuario();
            cUsuario.Show();
        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroLabs rLaboratorios = new RegistroLabs();
            rLaboratorios.Show();
        }

        private void tiposDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroTiposDeUsuario rTipos = new RegistroTiposDeUsuario();
            rTipos.Show();
        }

        private void medicinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroMeds rMeds = new RegistroMeds();
            rMeds.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaLaboratorios cLaboratorios = new Consultas.ConsultaLaboratorios();
            cLaboratorios.Show();
        }

        private void tiposDeUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaTiposDeUsuario cTipos = new Consultas.ConsultaTiposDeUsuario();
            cTipos.Show();
        }
    }
}
