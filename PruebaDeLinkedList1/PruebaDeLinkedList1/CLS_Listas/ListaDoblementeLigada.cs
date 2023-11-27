using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeLinkedList1.CLS_Listas
{
    public class ListaDoblementeLigada<T>
    {
        //Apuntadores
        public Foto<T> Primero { get; set; }

        public Foto<T> Ultimo { get; set; }

        //Propiedades
        protected int ContLDL { get; set; }

        public int TipoDeLista = 1;


        //Constructor
        public ListaDoblementeLigada()
        {
            Primero = null;
            Ultimo = null;
        }

        //Metodos
        //Agregar nodos al final de la lista
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
                NewNodo.Anterior = Ultimo;
                Ultimo = NewNodo;
            }
        }

        //Eliminar el primero dato de la lista
        public void Eliminar1()
        {
            //Se asegura de que la lista no esté vacía
            if (Primero == null || ContLDL == 0)
            {
                return;
            }
            // Se eliminan los vinvulos del primero con el segundo
            Primero = Primero.Siguiente;
            Primero.Anterior = null;
            //Se disminuye el contador
            ContLDL--;
        }

        //Eliminar cualquier nodo de la lista
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
