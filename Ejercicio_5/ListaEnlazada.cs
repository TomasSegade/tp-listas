using System;

namespace TP4_Listas
{
    class ListaEnlazada
    {
        public Nodo NodoInicial; //Declaro un nodo que va a estar inicializado en null
        

        public void AgregarCola(string nombre, string importe)
        {
            Nodo nodo = new Nodo();
            nodo.Codigo = ProximoNumero();
            nodo.Nombre = nombre;
            nodo.Importe = Convert.ToDouble(importe);
            nodo.FechaHora = DateTime.Now;
            

            if (NodoInicial == null)
            {
                NodoInicial = nodo;
            }
            else
            {
                Nodo aux = NodoInicial;
                NodoInicial = nodo;
                nodo.Siguiente = aux;

            }
        }


        public void Cobrar (string importe)
        {
            //para eliminar necesito que cambiar la direccion del nodo anterior al actual seleccionado apunte al siguiente.siguiente 
            double totalRecaudado =+ Convert.ToDouble(importe);
            //ME QUEDE ACA

        }

        
        
        private int BuscarMaximo(Nodo nodo, int codigo)
        {
            int max = nodo.Codigo > codigo ? nodo.Codigo : codigo;
            if (nodo.Siguiente != null) //no es el ultimo
            {
                return BuscarMaximo(nodo.Siguiente, max);
            }
            else
            {
                return max;
            }
        }

        private int ProximoNumero()
        {
            if (NodoInicial == null)
            {
                return 1;
            }
            int max = BuscarMaximo(NodoInicial, NodoInicial.Codigo);
            return max + 1;
        }

       
        private Nodo BuscarAnterior(Nodo nodo, int numero)
        {
            if (nodo.Siguiente != null && nodo.Siguiente.Codigo == numero)
                return nodo;
            if (nodo.Siguiente != null)
                return BuscarAnterior(nodo.Siguiente, numero);
            return null; //es el ultimo...

        }
    }
}
