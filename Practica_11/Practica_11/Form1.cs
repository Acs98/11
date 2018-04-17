using System;
using System.Drawing;
using System.Windows.Forms;
using Practica11Libreria;

namespace Practica_11
{
    public partial class Form1 : Form
    {
        Operaciones misOperaciones;
        public Form1()
        {
            InitializeComponent();
            misOperaciones = new Operaciones();
            lbAleatoria.Text = misOperaciones.FechaAleatoria();
            
        }

        private void btnQuien_Click(object sender, EventArgs e)
        {
            LecturaDatos nuevaLecturaDatos = new LecturaDatos(txtbNombre.Text, txtbCiudad.Text, int.Parse(txtbEdad.Text));
            lbQuien.Text = nuevaLecturaDatos.QuienEres(txtbNombre.Text, txtbCiudad.Text, int.Parse(txtbEdad.Text));
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            lbDiferencia.Text = misOperaciones.DiferenciaFechas(txtbFechaAgregada.Text, lbAleatoria.Text);
        }

        private void btnCumpleaños_Click(object sender, EventArgs e)
        {
            lbCumpleaños.Text = misOperaciones.Cumpleanios(txtbCumpleaños.Text);
        }
    }
}
