using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ejerciciospracticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            //   lista de productos
            List<Producto> lista = new List<Producto>
            {
                new Producto { Nombre = "Cuaderno", Precio = 2500 },
                new Producto { Nombre = "Lápiz", Precio = 500 },
                new Producto { Nombre = "Borrador", Precio = 300 },
                new Producto { Nombre = "Regla", Precio = 750 }
            };

            //  Mostrar en el DataGridView
            dgvDatos.DataSource = lista;
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
        
        {
            //  estudiante
            Estudiante est = new Estudiante
            {
                Nombre = "Danna Moya",
                AnoNacimiento = 2008
            };

            // Mostrar los datos del estudiante en un MessageBox
            string texto = $"Nombre: {est.Nombre}\n" +
                           $"Año de nacimiento: {est.AnoNacimiento}\n" +
                           $"Edad calculada: {est.EdadCalculada} años";

            MessageBox.Show(texto, "Datos del Estudiante");

            // mostrar en la tabla
            dgvDatos.DataSource = new List<Estudiante> { est };
        }
    }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            // Preguntar al usuario
            DialogResult respuesta = MessageBox.Show(
                "¿Desea guardar los cambios?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Decidir según la respuesta dada por el usuario
            if (respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Guardando...", "Información");
                RecorrerLista(); //  método que recorre
            }
            else
            {
                MessageBox.Show("No se guardó nada.", "Información");
            }
        }

        //  recorrer la lista con foreach
        private void RecorrerLista()
        {
            List<string> datosGuardados = new List<string>
    {
        "Producto: Cuaderno - ₡2500",
        "Producto: Lápiz - ₡500",
        "Estudiante: Danna Moya - Edad: 18"
    };

            string reporte = "=== Lista recorrida ===\n";

            //  uso del foreach
            foreach (string item in datosGuardados)
            {
                reporte += "• " + item + "\n";
            }

            MessageBox.Show(reporte, "Contenido Guardado");
        }
    }
    }

