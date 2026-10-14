using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicioproductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Producto miProducto = new Producto();
            miProducto.SetNombre("Laptop HP");
            miProducto.SetPrecio(850000.00m);
            MessageBox.Show(miProducto.MostrarInformacion(), "Información del Producto");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto miProducto = new Producto();

            miProducto.SetNombre(txtNombre.Text);

            if (decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                miProducto.SetPrecio(precio);
                MessageBox.Show(miProducto.MostrarInformacion(), "Producto Guardado");
                txtNombre.Clear();
                txtPrecio.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido para el precio", "Error");
            }
        }
    }
}

