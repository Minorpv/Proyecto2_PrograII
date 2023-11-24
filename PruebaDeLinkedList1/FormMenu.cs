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
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxID.Text = "0";
            textBoxDesc.Focus();
        }

        private void simplementeEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            id = int.Parse(textBoxID.Text);
            string desc = textBoxDesc.Text;
            string Ruta = textBoxRuta.Text;
            string item = string.Concat($"ID: {id}  |  Descripción: {desc}|Ruta: {Ruta}");
            Foto<string> foto = new Foto<string>
            {
                ID = id.ToString(),
                Descripcion = desc,
                RutaArchivo = Ruta
            };
            LSM.Agregar(foto);
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = foto.ID;
            dataGridView1.Rows[n].Cells[1].Value = foto.Descripcion;
            dataGridView1.Rows[n].Cells[2].Value = foto.RutaArchivo;
            id++;
            limpiarTextBox();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {

        }



        private void buttonDel_Click(object sender, EventArgs e)
        {

        }

        private void limpiarTextBox() 
        {
            textBoxID.Text = id.ToString();
            textBoxDesc.Clear();
            textBoxRuta.Clear();
            textBoxDesc.Focus();
        }

        private void simplementeEnlazadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
