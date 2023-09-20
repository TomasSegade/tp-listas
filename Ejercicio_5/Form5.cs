using System;
using System.Windows.Forms;

namespace TP4_Listas
{
    public partial class Form5 : Form
    {
        ListaEnlazada _lista = new ListaEnlazada();
        public Form5()
        {
            InitializeComponent();
        }

        public void AgregarItemLista(Nodo nodo)
        {
            if (nodo != null)
            {
                lst_listaEnla.Items.Add(nodo);
                if (nodo.Siguiente != null)
                {
                    AgregarItemLista(nodo.Siguiente);
                }
            }
        }
        public void MostrarLista()
        {
            this.lst_listaEnla.Items.Clear();
            AgregarItemLista(_lista.NodoInicial);
        }


        private void btn_agregarCola_Click(object sender, EventArgs e)
        {
            //Validar que no se ingrese letras en el campo
            //agregar iconos y msj de warning

            if (txt_nom.Text.Length > 0 && txt_importe.Text.Length > 0 )
            {
                _lista.AgregarCola(this.txt_nom.Text, this.txt_importe.Text);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Datos invalidos");
            }
        }

        //Usar este elemento para eliminar de la cola, agregar que al eliminar el impoirte se vaya sumando y mostrando por pantalla
        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            
            // si no hay nadie en la cola que no se pueda cobrar
            
            if (_lista.NodoInicial != null)
            {
                _lista.Cobrar(txt_importe.Text);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("No hay nadie para cobrar");
            }

            
        }
        private void txt_importe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}

