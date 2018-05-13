using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlListasDobles
{
    public partial class Form1 : Form
    {
        ListaDoble lista;
        public Form1()
        {
            lista = new ListaDoble();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            int costo = int.Parse(txtCosto.Text);
            Producto producto = new Producto(codigo, txtNombre.Text, txtDescripcion.Text, cantidad, costo);
        
            lista.Agregar(producto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            lista.Buscar(codigo);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);


            lista.Eliminar(codigo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.EliminarUltimo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lista.EliminarPrimero();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lista.InvertirLista();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lista.ReoprteInverso();
        }
    }
}
