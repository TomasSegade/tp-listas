namespace Ejercicio_5
{
    public class Nodo
    {
        public int Codigo;
        public string Nombre;
        public string Apellido;
        public string Direccion;
        public string Telefono;
        public Nodo Siguiente;
        public Nodo Anterior;

        public override string ToString()
        {
            return string.Format(" 'Codigo': {0} \t 'Nombre': {1} \t 'Apellido': {2} \t 'Direccion': {3} \t 'Telefono:' {4}", Codigo, Nombre, Apellido, Direccion, Telefono);
        }
    }
}
