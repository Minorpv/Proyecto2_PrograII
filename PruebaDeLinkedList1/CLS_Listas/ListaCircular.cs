using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeLinkedList1.CLS_Listas
{
    public class ListaCircular<T>
    {
        //Apuntadores
        public Foto<T> Primero { get; set; }
        public Foto<T> Ultimo { get; set; }
        public Foto<T> actual { get; set; }

        //Propiedades
        public int ContLCLMax { get; set; }

        public int ContActual { get; set; }


        //Constructor
        public ListaCircular()
        {
            Primero = null;
            Ultimo = null;
        }

        //Metodos

        //Metodo para agregar nodos al final de la lista
        public void Agregar(Foto<T> NewNodo)
        {
            if (Primero == null) //Lista vacía
            {
                Primero = NewNodo;
                Primero.Siguiente = Primero;
                Ultimo = Primero;
                
                
            }
            else //Se añade un nuevo nodo despues del ultimo
            {
                Ultimo.Siguiente = NewNodo;
                NewNodo.Siguiente = Primero;
                Ultimo = NewNodo;
            }
            ContLCLMax++;
        }

        public bool Eliminar(Foto<T> DelNodo)
        {
            bool encontrado = false;
            Foto<T> anterior = null;
            Foto<T> Actual = Primero;

            if (Primero != null)
            {
                while (Actual.Siguiente != Primero && !Actual.Equals(DelNodo))
                {
                    anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (Actual != null)
                {
                    //Se elimina al primero
                    if (Primero.Equals(DelNodo))
                    {
                        //Se elimina todo vinvulo del primero nodo con los demás elementos de la lista
                        Primero = Primero.Siguiente;
                        Ultimo.Siguiente = Primero;
                        //Se disminuye el contador
                        
                    }
                    else if (Ultimo.Equals(DelNodo))
                    {
                        anterior.Siguiente = Primero;
                        Ultimo = anterior;
                    }
                    else
                    {
                        anterior.Siguiente = Actual.Siguiente;
                    }
                    encontrado = true;
                    ContLCLMax--;
                }
            }
            return encontrado;
        }

        public Foto<T> MostrarFotos()
        {
            //La lista no está vacía
            if (Primero != null)
            {
                //Ultimo de la lista
                if (ContActual == ContLCLMax)
                {
                    actual = Primero;
                    ContActual = 1;
                }
                // Cualquier otro de la lista
                else if (ContActual != 0 && ContActual != ContLCLMax)
                {
                    actual = actual.Siguiente;
                    ContActual++;
                }
                else if (ContActual == 0)
                {
                    actual = Primero;
                    ContActual++;
                }
            }
            return actual;
        }
    }
}
