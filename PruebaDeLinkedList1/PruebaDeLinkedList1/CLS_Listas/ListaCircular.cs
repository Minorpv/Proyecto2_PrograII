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

        public void Eliminar(Foto<string> DelNodo)
        {
            Foto<T> anterior = null;
            Foto<T> Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null && Actual.ID != DelNodo.ID)
                {
                    if (Actual.ID == DelNodo.ID)
                    {
                        //Se elimina al primero
                        if (Primero.ID == DelNodo.ID)
                        {
                            //Se elimina todo vinvulo del primero nodo con los demás elementos de la lista
                            Primero = Primero.Siguiente;
                            Ultimo.Siguiente = Primero;
                            //Se disminuye el contador
                            ContLCLMax--;
                        }
                        else if (Ultimo.ID == DelNodo.ID)
                        {
                            anterior.Siguiente = Primero;
                            Ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = Actual.Siguiente;
                        }
                    }
                    anterior = Actual;
                    Actual = Actual.Siguiente;
                }
            }
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
