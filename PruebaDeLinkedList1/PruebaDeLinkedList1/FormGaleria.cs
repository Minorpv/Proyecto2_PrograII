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
        //Album de fotos recolectadas en el menú
        Album Lista = new Album();

        //Propiedades
        public string Ruta { get; set; }
        Foto<string> foto { get; set; }

        //Constructor
        public FormGaleria(Album lista) //Pide el album que se creó en el menú
        {
            InitializeComponent();
            //Y se establece con la lista tipo album de esta pestala
            Lista = lista;
        }

        //Eventos

        //Al cargar el formulario
        private void FormGaleria_Load(object sender, EventArgs e)
        {
            foto = Lista.MostrarFoto1();
            pictureBox1.ImageLocation = foto.RutaArchivo;
            labelDesc.Text = foto.Descripcion;
            labelRuta.Text = foto.RutaArchivo;
            if (Lista.TipoDeLista !=1) 
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
