using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Registrodeactividades
{
    public partial class Form1 : Form
    {
        // Lista para almacenar las actividades
        private List<Actividad> listaActividades = new List<Actividad>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        // Configuración inicial del DataGridView
        private void ConfigurarDataGridView()
        {
            // Evitar que se agreguen filas manualmente
            dgvActividades.AllowUserToAddRows = false;

            // Estilo de encabezado
            dgvActividades.ColumnHeadersVisible = true;

            // Agregar columna para mostrar la información formateada
            dgvActividades.Columns.Add("Actividad", "Información de Actividad");

            // Ajustar ancho de columna
            dgvActividades.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        // Evento del botón Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear nueva actividad
            Actividad nuevaActividad = new Actividad(
                txtDescripcion.Text,
                txtResponsable.Text
            );

            // Agregar a la lista
            listaActividades.Add(nuevaActividad);

            // Actualizar el DataGridView
            ActualizarListaActividades();

            // Limpiar campos
            txtDescripcion.Clear();
            txtResponsable.Clear();
            txtDescripcion.Focus();
        }

        // Método para refrescar el DataGridView usando foreach
        private void ActualizarListaActividades()
        {
            // Limpiar filas existentes
            dgvActividades.Rows.Clear();

            // Recorrer la lista con foreach y agregar cada fila
            foreach (Actividad act in listaActividades)
            {
                dgvActividades.Rows.Add(act.Informacion);
            }
        }
    }
}