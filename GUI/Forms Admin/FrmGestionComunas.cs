using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace GUI
{
    public partial class FrmGestionComunas : Form
    {
        private readonly ComunaService comunaService;
        private Comuna comunaSeleccionada;

        public FrmGestionComunas()
        {
            InitializeComponent();
            comunaService = new ComunaService();
            CargarComunas();
        }

        private void CargarComunas()
        {
            var comunas = comunaService.ConsultarTodas();
            dgvComunas.Rows.Clear();
            foreach (var comuna in comunas)
            {
                dgvComunas.Rows.Add(comuna.id_comuna, comuna.nombre_comuna);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreComuna.Text = string.Empty;
            comunaSeleccionada = null;
            btnGuardar.Text = "Guardar";
            btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreComuna.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la comuna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string resultado;
                if (comunaSeleccionada == null)
                {
                    // Crear nueva comuna
                    Comuna comuna = new Comuna
                    {
                        nombre_comuna = txtNombreComuna.Text
                    };
                    resultado = comunaService.Guardar(comuna);
                }
                else
                {
                    // Modificar comuna existente
                    comunaSeleccionada.nombre_comuna = txtNombreComuna.Text;
                    resultado = comunaService.Modificar(comunaSeleccionada);
                }

                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!resultado.StartsWith("Error"))
                {
                    CargarComunas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comunaSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione una comuna para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar la comuna '{comunaSeleccionada.nombre_comuna}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string resultado = comunaService.Eliminar(comunaSeleccionada.id_comuna);
                    MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!resultado.StartsWith("Error"))
                    {
                        CargarComunas();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvComunas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idComuna = Convert.ToInt32(dgvComunas.Rows[e.RowIndex].Cells["IdComuna"].Value);
                comunaSeleccionada = comunaService.BuscarPorId(idComuna);

                if (comunaSeleccionada != null)
                {
                    txtNombreComuna.Text = comunaSeleccionada.nombre_comuna;
                    btnGuardar.Text = "Modificar";
                    btnEliminar.Enabled = true;
                }
            }
        }
    }
}
