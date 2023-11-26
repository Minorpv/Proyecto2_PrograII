using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeLinkedList1.CLS_Listas
{
    public class ListaDoblementeLigada<T>
    {
        public Foto<T> Primero { get; set; }

        public Foto<T> Ultimo { get; set; }

        protected int ContLDL { get; set; }

        public int TipoDeLista = 1;

        public ListaDoblementeLigada()
        {
            Primero = null;
            Ultimo = null;
        }

        public void Agregar(Foto<T> NewNodo)
        {
            if (Primero == null)
            {
                Primero = NewNodo;
                Primero.Siguiente = null;
                Primero.Anterior = null;
                Ultimo = Primero;
            }
            else 
            {
                Ultimo.Siguiente = NewNodo;
                NewNodo.Siguiente = null;
                NewNodo.Anterior = Ultimo;
                Ultimo = NewNodo;
            }
        }

        public void Eliminar1()
        {
            if (Primero == null || ContLDL == 0)
            {
                return;
            }
            Primero = Primero.Siguiente;
            Primero.Anterior = null;
            ContLDL--;
        }

        public void Eliminar(Foto<T> DelNodo)
        {
            Foto<T> Actual = Primero.Siguiente;
            Foto<T> Anterior = Primero.Siguiente;
            //Si no entra en ninguna de estas categorías se tiene que hacer la tramsversa de la lista
            while (Actual != null && Actual.ID != DelNodo.ID)
            {
                //Lista vacía
                if (Primero == null || ContLDL == 0)
                {
                    return;
                }

                //Se elimina al primero
                if (Primero.ID == DelNodo.ID)
                {
                    Eliminar1();
                }
                if (Ultimo.ID == DelNodo.ID)
                {
                    if (Primero == null || ContLDL == 0)
                    {
                        return;
                    }
                    Anterior.Siguiente = null;
                    Ultimo = Anterior;
                }
                //Si no entra en ninguna de estas categorías se tiene que hacer la tramsversa de la lista
                if (Actual != null && Actual.ID == DelNodo.ID)
                {
                    Anterior.Siguiente = Actual.Siguiente;
                    Actual.Siguiente.Anterior = Anterior;
                    ContLDL--;
                }
                Actual = Actual.Siguiente;
                Anterior = Actual;
            }


        }
    }
}
