using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_Listas
{
    public partial class Form1 : Form
    {
        ListaEnlazada _lista = new ListaEnlazada();

        public Form1()
        {
            InitializeComponent();
        }

        public void AgregarItemLista(Nodo unNodo)
        {
            if (unNodo != null)
            {
                lst_listaEnla.Items.Add(unNodo.Datos);

                AgregarItemLista(unNodo.Siguiente);
            }
        }
        public void MostrarLista()
        {
            lst_listaEnla.Items.Clear();

            if (_lista.Inicio != null)
            {
                AgregarItemLista(_lista.Inicio);
            }

          
        }


        private void btn_regi_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text.Length > 0 && txt_ape.Text.Length > 0 && txt_cod.Text.Length > 0 && txt_dir.Text.Length > 0 && txt_tel.Text.Length >0 )
            {
                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Datos = $"Código: '{txt_cod.Text}'\n " +
                                   $"Nombre: '{txt_nom.Text}'\n " +
                                   $"Apellido: '{txt_ape.Text}'\n " +
                                   $"Dirección: '{txt_dir.Text}'\n " +
                                   $"Teléfono: '{txt_tel.Text}' ";
                _lista.Registrar(unNuevoNodo);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Datos invalidos");
            }
        }

        private void btn_elim_Click(object sender, EventArgs e)
        {
            //lst_listaEnla.SelectedItem
        }
    }
}
