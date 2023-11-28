using PruebaDeLinkedList1.CLS_Listas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeLinkedList1
{
    public class Album
    {
        //Las tres instancias de las clases de cada lista
        public ListaSimplementeEnlazada<string> LSM = new ListaSimplementeEnlazada<string>();
        public ListaDoblementeLigada<string> LDL = new ListaDoblementeLigada<string>();
        public ListaCircular<string> LCL = new ListaCircular<string>();

        //Nodo actual
        Foto<string> Actual = new Foto<string>();

        //Propiedades extras
        public int Cont = 0;
        public int TipoDeLista { get; set; }

        //Constructor
        public Album()
        {
        }

        //Metodos

        // Lógica para agregar una foto de cada lista
        public void AgregarFoto(Foto<string> foto)
        {
            //Lista Simplemente Enlazada
            LSM.Agregar(foto);
            //Lista Doblemente Enlazada
            LDL.Agregar(foto);
            //Lista Circular
            LCL.Agregar(foto);
        }

        // Lógica para eliminar una foto de cada lista
        public void EliminarFoto(int id)
        {
            Foto<string> DelNodo = new Foto<string>();
            DelNodo.ID = id;
            //Se llaman los procesos que buscan la id en la lista y lo eliminar cuando lo encuentran
            //Lista Simplemente Enlazada
            LSM.Eliminar(DelNodo);
            //Lista Doblemente Enlazada
            LDL.Eliminar(DelNodo);
            //Lista Circular
            LCL.Eliminar(DelNodo);
        }

        // Lógica para mostrar la foto siguiente de cada lista
        public Foto<string> MostrarFotoSiguiente()
        {
            //Lista Simplemente Ligada
            if (TipoDeLista == 0) 
            {
                Actual = LSM.MostrarFotos();
                if (Cont != LSM.ContLSMMax) 
                {
                    Cont++;
                }
                
            }
            //Lista Doblemente Ligada
            if (TipoDeLista == 1) 
            {
                Actual = LDL.MostrarFotoSiguiente();
                if (Cont != LDL.ContLDLMax)
                {
                    Cont++;
                }

            }
            //Lista Circular
            if (TipoDeLista == 2)
            {
                Actual = LCL.MostrarFotos();
                if (Cont == LCL.ContLCLMax)
                {
                    Cont = 0;
                }
                else Cont++;
            }
            return Actual;
        }

        public Foto<string> MostrarFotoAnterior()
        {
            //Lista Doblemente Ligada
            if (TipoDeLista == 1) 
            {
                Actual = LDL.MostrarFotoAnterior();
                Cont--;

            }
            return Actual;
        }

        public void reinicioListas() 
        {
            LSM.ContActual = 0;
            LDL.ContActual = 0;
            LCL.ContActual = 0;
        }
    }
}
