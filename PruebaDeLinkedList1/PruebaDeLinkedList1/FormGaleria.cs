using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeLinkedList1
{
    public partial class FormGaleria : Form
    {
        Album Lista = new Album();

        public string Ruta { get; set; }

        Foto<string> foto { get; set; }

        public FormGaleria(Album lista)
        {
            InitializeComponent();
            Lista = lista;
        }

        private void FormGaleria_Load(object sender, EventArgs e)
        {
            foto = Lista.MostrarFotoSiguiente();
            pictureBox1.ImageLocation = foto.RutaArchivo;
            labelDesc.Text = foto.Descripcion;
            labelRuta.Text = foto.RutaArchivo;
            if (Lista.TipoDeLista == 0) 
            {
                buttonAnt.Enabled = false;
            }
        }

        private void buttonSig_Click(object sender, EventArgs e)
        {
            foto = Lista.MostrarFotoSiguiente();
            pictureBox1.ImageLocation = foto.RutaArchivo;
            labelDesc.Text = foto.Descripcion;
            labelRuta.Text = foto.RutaArchivo;
        }

        private void buttonReinicio_Click(object sender, EventArgs e)
        {
            Lista.Cont = 0;
            FormGaleria galeria = new FormGaleria(Lista);
            galeria.ShowDialog();
        }

        private void buttonAnt_Click(object sender, EventArgs e)
        {
            foto = Lista.MostrarFotoAnterior();
            pictureBox1.ImageLocation = foto.RutaArchivo;
            labelDesc.Text = foto.Descripcion;
            labelRuta.Text = foto.RutaArchivo;
        }
    }
}
