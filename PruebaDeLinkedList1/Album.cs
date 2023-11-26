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

        Foto<string> Actual = new Foto<string>();

        public int Cont { get; set; } = 0;

        public Album()
        {
        }

        public void AgregarFoto(Foto<string> foto)
        {
            //Lista Simplemente Enlazada
            LSM.Agregar(foto);
        }

        public void EliminarFoto(int fotoID)
        {
            // Lógica para eliminar una foto de cada lista
            Foto<string> DelNodo = new Foto<string>();
            DelNodo.ID = fotoID;
            LSM.Eliminar(DelNodo);
        }
        public Foto<string> MostrarFotos()
        {
            // Lógica para mostrar todas las fotos de cada lista
            Foto<string> foto = new Foto<string>();
            if (Cont == 0)
            {
                Actual = LSM.Primero;
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
            return Actual;
        }

        // Otros métodos según sea necesario

    }
}
