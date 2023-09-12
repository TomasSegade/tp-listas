namespace Ejercicio_2
{
    public class Nodo
    {
        public int Codigo;
        public string Nombre;
        public string Apellido;
        public string Direccion;
        public string Telefono;
        public string Documento;
        public string FechaNa;
        public Nodo Siguiente;

        public override string ToString()
        {
            return string.Format(" 'Codigo': {0} \t 'Nombre': {1} \t 'Apellido': {2} \t 'Direccion': {3} \t 'Telefono:' {4}\t 'Documento:' {5}\t 'Fecha de nacimiento:' {6}", Codigo, Nombre, Apellido, Direccion, Telefono, Documento, FechaNa);
        }
    }
}
