using PruebaDeLinkedList1.CLS_Listas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeLinkedList1
{
    public class Album
    {
        //Las tres instancias de las clases de cada lista
        ListaSimplementeEnlazada<string> LSM = new ListaSimplementeEnlazada<string>();
        ListaDoblementeLigada<string> LDL = new ListaDoblementeLigada<string>();
        ListaCircular<string> LCL = new ListaCircular<string>();

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
        public void EliminarFoto(int fotoID)
        {
            //Se crea una nueva foto
            Foto<string> DelNodo = new Foto<string>();
            //Asignamos el id que queremos eliminar a esta foto
            DelNodo.ID = fotoID;
            //Se llaman los procesos que buscan la id en la lista y lo eliminar cuando lo encuentran
            //Lista Simplemente Enlazada
            LSM.Eliminar(DelNodo);
            //Lista Doblemente Enlazada
            LDL.Eliminar(DelNodo);
            //Lista Circular
            LCL.Eliminar(DelNodo);
        }

        // Lógica para mostrar la foto siguiente de cada lista
        public Foto<string> MostrarFoto1()
        {
            Cont = 0;
            //Lista Simplemente Enlazada
            if (TipoDeLista == 0)
            {
                if (Cont == 0)  //Se está iniciando el proceso
                {
                    Actual = LSM.Primero;
                }

            }

            //Lista Doblemente Enlazada
            if (TipoDeLista == 1)
            {
                if (Cont == 0)  //Se está iniciando el proceso
                {
                    Actual = LDL.Primero;
                    Cont++;
                }
            }

            //Lista Circular
            if (TipoDeLista == 2)
            {
                if (Cont == 0)  //Se está iniciando el proceso
                {
                    Actual = LCL.Primero;
                    Cont++;
                }
            }
            return Actual;
        }

        // Lógica para mostrar la foto siguiente de cada lista
        public Foto<string> MostrarFotoSiguiente()
        {
            Foto<string> foto = new Foto<string>();
            //Lista Simplemente Enlazada
            if (TipoDeLista == 0)
            {
                if (Cont == 0)  //Primer nodo
                {
                    Actual = LSM.Primero;
                    Cont = 0;
                }
                if (Actual.Siguiente == null) //Ultimo nodo
                {
                    foto.Descripcion = "Fin de la lista";
                    return foto;
                }
                else //Los demás nodos de la lista
                {
                    Actual = Actual.Siguiente;
                    Cont++;
                }

            }

            //Lista Doblemente Enlazada
            if (TipoDeLista == 1)
            {
                if (Cont == 0)  //Primer nodo
                {
                    Actual = LDL.Primero;
                    Cont = 0;
                }
                if (Actual.Siguiente == null) //Ultimo nodo
                {
                    foto.Descripcion = "Fin de la lista";
                    return foto;
                }
                else //Los demás nodos de la lista
                {
                    Actual = Actual.Siguiente;
                    Cont++;
                }

            }

            //Lista Circular
            if (TipoDeLista == 2)
            {
                if (Cont == 0)  //Se está iniciando el proceso
                {
                    Actual = LCL.Primero;
                }
                if (Actual.Siguiente == null) //La lista se acabó
                {
                    foto.Descripcion = "Fin de la lista";
                    return foto;
                }
                else //Estamos en medio de la lista
                {
                    Actual = Actual.Siguiente;
                    Cont++;
                }
            }
            return Actual;
        }

        // Lógica para mostrar la foto anterior de cada lista
        // Excepto de la simplemente ligada
        public Foto<string> MostrarFotoAnterior() 
        {
            //Nueva foto
            Foto<string> foto = new Foto<string>();
            //Lista Doblemente Enlazada
            if (Cont == 0)  //Primer nodo
            {
                Actual = LDL.Primero;
                return Actual;
            }
            if (Actual.Anterior == null) //Ultimo nodo
            {
                foto.Descripcion = "Fin de la lista";
                return foto;
                    
            }
            else //Los demás nodos de la lista
            {
                Actual = Actual.Anterior;
                Cont--;
                return Actual;
            }
        }
    }
}
