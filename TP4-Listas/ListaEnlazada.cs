using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Listas
{
    class ListaEnlazada
    {
        public Nodo Inicio;
        

        public void Registrar(Nodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = Inicio;
                Inicio = unNodo;
                Inicio.Siguiente = aux;
            }
        } 

        public void Eliminar (Nodo unNodo)
        {
                Nodo aux = Inicio;
                Inicio = unNodo;
                Inicio.Siguiente = aux;

        }


    }
}
