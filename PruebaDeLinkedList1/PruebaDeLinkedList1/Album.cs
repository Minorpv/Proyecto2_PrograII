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
        ListaSimplementeEnlazada<string> LSM = new ListaSimplementeEnlazada<string>();
        ListaDoblementeLigada<string> LDL = new ListaDoblementeLigada<string>();

        Foto<string> Actual = new Foto<string>();

        public int Cont = 0;

        public int TipoDeLista { get; set; }

        public Album()
        {
        }

        public void AgregarFoto(Foto<string> foto)
        {
            //Lista Simplemente Enlazada
            LSM.Agregar(foto);
            LDL.Agregar(foto);
        }

        public void EliminarFoto(int fotoID)
        {
            // Lógica para eliminar una foto de cada lista
            Foto<string> DelNodo = new Foto<string>();
            DelNodo.ID = fotoID;
            LSM.Eliminar(DelNodo);
            LDL.Eliminar(DelNodo);
        }
        public Foto<string> MostrarFotoSiguiente()
        {
            // Lógica para mostrar todas las fotos de cada lista
            Foto<string> foto = new Foto<string>();
            //Lista Simplemente Enlazada
            if (TipoDeLista == 0) 
            {
                if (Cont == 0)
                {
                    Actual = LSM.Primero;
                    Cont++;
                }
                if (Actual.Siguiente == null)
                {
                    foto.Descripcion = "Fin de la lista";
                    return foto;
                }
                else
                {
                    Actual = Actual.Siguiente;
                    Cont++;
                }
            }

            //Lista Doblemente Enlazada
            if (TipoDeLista == 1) 
            {
                if (Cont == 0) 
                {
                    Actual = LDL.Primero;
                    Cont++;
                }
                if (Actual.Siguiente == null) 
                {
                    foto.Descripcion = "Fin de la lista";
                    return foto;
                }
                else
                {
                    Actual = Actual.Siguiente;
                    Cont++;
                }
            }
            

            //Lista Circular

            return Actual;
        }

        public Foto<string> MostrarFotoAnterior() 
        {
            Foto<string> foto = new Foto<string>();
            if (TipoDeLista == 1) 
            {
                if (Cont == 0) 
                {
                    Actual = LDL.Primero;
                    Cont = 0;
                }
                if (Actual.Anterior == null)
                {
                    foto.Descripcion = "Fin de la lista";
                    return foto;
                }
                else
                {
                    Actual = Actual.Anterior;
                    Cont--;
                }

            }
            return Actual;
        }


    }
}
