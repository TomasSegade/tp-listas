namespace Ejercicio_3
{
    public class Nodo
    {
        public int Codigo;
        public string Nombre;
        public string Apellido;
        public int Edad;
        public string Genero;
        public Nodo Siguiente;

        public override string ToString()
        {
            return string.Format(" 'Codigo': {0} \t 'Nombre': {1} \t 'Apellido': {2} \t 'Edad': {3} \t 'Genero:' {4}", Codigo, Nombre, Apellido, Edad, Genero);
        }
    }
}
