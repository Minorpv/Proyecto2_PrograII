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

        public Album()
        {
        }

        public void AgregarFoto()
        {
            //Lista Simplemente Enlazada
            Foto<string> NewNodo = new Foto<string>();
            LSM.Agregar(NewNodo);
        }

        public void Eliminar1()
        {
            //Eliminar nodo de la lista simplemente enlanzada
            LSM.Eliminar1();
        }

        public void EliminarFoto(int fotoID)
        {
            // Lógica para eliminar una foto de cada lista
            Foto<string> DelNodo = new Foto<string>();
            LSM.Eliminar(DelNodo);
        }
        public void MostrarFotos()
        {
            // Lógica para mostrar todas las fotos de cada lista
        }

        // Otros métodos según sea necesario

    }
}
