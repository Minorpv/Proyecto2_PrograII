﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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

        public Foto<T> actual { get; set; }

        //Propiedades
        public int ContLDLMax { get; set; }
        public int ContActual { get; set; }



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
                NewNodo.Siguiente = null;
                NewNodo.Anterior = Ultimo;
                Ultimo = NewNodo;
            }
            ContLDLMax++;
        }

        //Eliminar cualquier nodo de la lista
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
                            Primero = Primero.Siguiente;
                            Primero.Anterior = null;
                        }
                        else if (Ultimo.ID == DelNodo.ID)
                        {
                            anterior.Siguiente = null;
                            Ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = Actual.Siguiente;
                            Actual.Siguiente.Anterior = anterior;
                        }
                        ContLDLMax--;
                    }
                    anterior = Actual;
                    Actual = Actual.Siguiente;
                }
            }
        }

        public Foto<T> MostrarFotoSiguiente() 
        {
            //Lista no está vacía
            if (Primero != null) 
            {
                if (actual == Ultimo)
                {
                    return actual;
                }
                //Estamos en el último nodo
                else if (ContActual == ContLDLMax)
                {
                    actual = Ultimo;
                }
                //No estamo ni en el el primero ni en el último
                else if (ContActual != 0 && ContActual != ContLDLMax)
                {
                    actual = actual.Siguiente;
                    ContActual++;
                }
                //Estamos en el primero
                else if (ContActual == 0)
                {
                    actual = Primero;
                    ContActual++;
                }
                
            }
            return actual;
        }

        public Foto<T> MostrarFotoAnterior() 
        {
            //La lista no está vacía
            if (Primero != null) 
            {
                //Estamos ya en en último nodo y queremos regresar al anterior
                if (ContActual == ContLDLMax)
                {
                    actual = Ultimo.Anterior;
                    ContActual--;
                }
                //Estamos en cuelaquier otro nodo que no sea el primero ni el ultimo
                else if (ContActual != 0 && ContActual != ContLDLMax)
                {
                    actual = actual.Anterior;
                    ContActual--;
                }
                //Estamos en el primer nodo
                else if (ContActual == 0) 
                {
                    actual = Primero;
                }
                
            }
            return actual;
        }
    }
}
