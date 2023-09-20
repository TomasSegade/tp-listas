using System;
namespace TP4_Listas
{ 
    public class Nodo
    {
        public int Codigo;
        public string Nombre;
        public double Importe;
        public DateTime FechaHora;
        public Nodo Siguiente;

        public override string ToString()
        {
            return string.Format(" 'Codigo': {0} \t 'Nombre': {1} \t 'Importe': {2} \t 'Fecha y Hora': {3} ", Codigo, Nombre, Importe, FechaHora);
        }
    }
}
