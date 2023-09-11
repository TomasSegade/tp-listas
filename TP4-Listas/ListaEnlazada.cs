namespace TP4_Listas
{
    class ListaEnlazada
    {
        public Nodo NodoInicial; //Declaro un nodo que va a estar inicializado en null


        public void Registrar(string nombre, string apellido, string direccion, string telefono)
        {
            Nodo nodo = new Nodo();
            nodo.Codigo = ProximoNumero();
            nodo.Nombre = nombre;
            nodo.Apellido = apellido;
            nodo.Direccion = direccion;
            nodo.Telefono = telefono;

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


        public void EliminarSeleccionado(int codigo)
        {
            //para eliminar necesito que cambiar la direccion del nodo anterior al actual seleccionado apunte al siguiente.siguiente 

            if (NodoInicial != null)
            {
                if (NodoInicial.Codigo == codigo)
                {
                    NodoInicial = NodoInicial.Siguiente;
                }
                else
                {
                    Nodo nodoAnteriorAlElegido = BuscarAnterior(NodoInicial, codigo);
                    if (nodoAnteriorAlElegido != null)
                    {
                        nodoAnteriorAlElegido.Siguiente = nodoAnteriorAlElegido.Siguiente.Siguiente;
                    }
                }
            }

        }

        public void ActualizarDatos(string nombre, string apellido, string direccion, string telefono, Nodo nodoSeleccionado)
        {
            
            if (NodoInicial != null)
            {
                nodoSeleccionado.Nombre = nombre;
                nodoSeleccionado.Apellido = apellido;
                nodoSeleccionado.Direccion = direccion;
                nodoSeleccionado.Telefono = telefono;
            }

        }


        private int ProximoNumero()
        {
            if (NodoInicial == null)
            {
                return 1;
            }

            return (NodoInicial.Codigo + 1);

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
