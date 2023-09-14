using System;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form2 : Form
    {
        ListaEnlazada _lista = new ListaEnlazada();
        Nodo nodoSeleccionado;
        public Form2()
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


        private void btn_regi_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text.Length > 0 && txt_ape.Text.Length > 0 && txt_dir.Text.Length > 0 && txt_tel.Text.Length > 0 && txt_doc.Text.Length > 0 && txt_fechaNa.Text.Length >0)
            {
                _lista.Registrar(this.txt_nom.Text, this.txt_ape.Text, this.txt_dir.Text, this.txt_tel.Text, this.txt_doc.Text, this.txt_fechaNa.Text);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Datos invalidos");
            }
        }

        private void btn_elim_Click(object sender, EventArgs e)
        {

            if (nodoSeleccionado != null)
            {
                _lista.EliminarSeleccionado(nodoSeleccionado.Codigo);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nodo");
            }


        }

        private void lst_ListaEnla_SelectedIndexChanged(object sender, EventArgs e)
        {
            nodoSeleccionado = (Nodo)this.lst_listaEnla.SelectedItem;

        }

        private void btn_act_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                _lista.ActualizarDatos(txt_nom.Text, txt_ape.Text, txt_dir.Text, txt_tel.Text, txt_doc.Text, txt_fechaNa.Text, nodoSeleccionado);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nodo");
            }
        }

        private void btn_agr_sig_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                if (txt_nom.Text.Length > 0 && txt_ape.Text.Length > 0 && txt_dir.Text.Length > 0 && txt_tel.Text.Length > 0 && txt_doc.Text.Length > 0 && txt_fechaNa.Text.Length > 0)
                {
                    _lista.AgregarSiguiente(this.txt_nom.Text, this.txt_ape.Text, this.txt_dir.Text, this.txt_tel.Text, this.txt_doc.Text, this.txt_fechaNa.Text, nodoSeleccionado);
                    MostrarLista();
                }
                else
                {
                    MessageBox.Show("Datos invalidos");
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un nodo");
            }
        }

        private void btn_agr_ant_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado != null)
            {
                if (txt_nom.Text.Length > 0 && txt_ape.Text.Length > 0 && txt_dir.Text.Length > 0 && txt_tel.Text.Length > 0 && txt_doc.Text.Length > 0 && txt_fechaNa.Text.Length > 0)
                {
                    _lista.AgregarAnterior(this.txt_nom.Text, this.txt_ape.Text, this.txt_dir.Text, this.txt_tel.Text, this.txt_doc.Text, this.txt_fechaNa.Text, nodoSeleccionado);
                    MostrarLista();
                }
                else
                {
                    MessageBox.Show("Datos invalidos");
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un nodo");
            }
        }
    }
}
