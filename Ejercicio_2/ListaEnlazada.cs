namespace Ejercicio_2
{
    class ListaEnlazada
    {
        public Nodo NodoInicial; //Declaro un nodo que va a estar inicializado en null


        public void Registrar(string nombre, string apellido, string direccion, string telefono, string documento, string fechaNa)
        {
            Nodo nodo = new Nodo();
            nodo.Codigo = ProximoNumero();
            nodo.Nombre = nombre;
            nodo.Apellido = apellido;
            nodo.Direccion = direccion;
            nodo.Telefono = telefono;
            nodo.Documento = documento;
            nodo.FechaNa = fechaNa;

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

        public void ActualizarDatos(string nombre, string apellido, string direccion, string telefono, string documento, string fechaNa, Nodo nodoSeleccionado)
        {
            
            if (NodoInicial != null)
            {
                nodoSeleccionado.Nombre = nombre;
                nodoSeleccionado.Apellido = apellido;
                nodoSeleccionado.Direccion = direccion;
                nodoSeleccionado.Telefono = telefono;
                nodoSeleccionado.Documento = documento;
                nodoSeleccionado.FechaNa = fechaNa;
            }

        }

        public void AgregarSiguiente(string nombre, string apellido, string direccion, string telefono, string documento, string fechaNa, Nodo nodoSeleccionado)
        {
            Nodo nodo = new Nodo();
            nodo.Codigo = ProximoNumero();
            nodo.Nombre = nombre;
            nodo.Apellido = apellido;
            nodo.Direccion = direccion;
            nodo.Telefono = telefono;
            nodo.Documento = documento;
            nodo.FechaNa = fechaNa;

            Nodo nodoSiguienteAlElegido = nodoSeleccionado.Siguiente;
            if (nodoSiguienteAlElegido != null)
            {
                nodo.Siguiente = nodoSiguienteAlElegido;
                nodoSeleccionado.Siguiente = nodo;
            }
            else
            {
                nodoSeleccionado.Siguiente = nodo;
            }
        }
        public void AgregarAnterior(string nombre, string apellido, string direccion, string telefono, string documento, string fechaNa, Nodo nodoSeleccionado)
        {
            Nodo nodo = new Nodo();
            nodo.Codigo = ProximoNumero();
            nodo.Nombre = nombre;
            nodo.Apellido = apellido;
            nodo.Direccion = direccion;
            nodo.Telefono = telefono;
            nodo.Documento = documento;
            nodo.FechaNa = fechaNa;

            Nodo nodoAnteriorAlSeleccionado = BuscarAnterior(NodoInicial, nodoSeleccionado.Codigo);
            if (nodoAnteriorAlSeleccionado != null)
            {
                nodoAnteriorAlSeleccionado.Siguiente = nodo;
                nodo.Siguiente = nodoSeleccionado;
            }
            else
            {
                Nodo aux = NodoInicial;
                NodoInicial = nodo;
                nodo.Siguiente = aux;
            }

        }

        private int BuscarMaximo(Nodo nodo, int codigo)
        {
            //condition ? consequent : alternative
            // La funcion maximo debe recorrer los nodos hasta que siguiente sea null y de ese nodo, extraer el codigo

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

            //busco el maximo y le sumo uno

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
