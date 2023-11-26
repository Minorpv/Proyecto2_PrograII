using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeLinkedList1
{
    public partial class FormMenu : Form
    {

        int id = 0;

        ListaSimplementeEnlazada<string> LSM = new ListaSimplementeEnlazada<string>();

        Album album = new Album();

        public int tipoDeLista { get; set; }
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxID.Text = "0";
            textBoxDesc.Focus();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            id = int.Parse(textBoxID.Text);
            string desc = textBoxDesc.Text;
            string Ruta = textBoxRuta.Text;
            Foto<string> foto = new Foto<string>
            {
                ID = id,
                Descripcion = desc,
                RutaArchivo = Ruta
            };
            album.AgregarFoto(foto);
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = foto.ID;
            dataGridView1.Rows[n].Cells[1].Value = foto.Descripcion;
            dataGridView1.Rows[n].Cells[2].Value = foto.RutaArchivo;
            id++;
            limpiarTextBox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs ID)
        {
            id = ID.RowIndex;
            textBoxID.Text = id.ToString();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (id != -1) 
            {
                if (textBoxID.Text is null) 
                {
                    return;
                }
                dataGridView1.Rows.RemoveAt(id);   
            }
            album.EliminarFoto(id);
            limpiarTextBox();
        }

        private void limpiarTextBox() 
        {
            textBoxID.Text = id.ToString();
            textBoxDesc.Clear();
            textBoxRuta.Clear();
            textBoxDesc.Focus();
        }


        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Codigo para abrir y guardar la ruta de acceso del archivo
                textBoxRuta.Text = openFileDialog1.FileName;
                //"C:\Users\minor\Archivos VS Code\R.jpg"
                textBoxDesc.Text = openFileDialog1.SafeFileName;
                //"R.jpg"
            }
        }

        private void simplementeEnlazadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormGaleria galeria = new FormGaleria(album);
            galeria.ShowDialog();
        }



    }
}
