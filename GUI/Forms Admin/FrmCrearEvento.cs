using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace GUI
{
    public partial class FrmCrearEvento : Form
    {
        private readonly EventoService eventoService;
        private string rutaImagen;
        private Evento eventoToEdit;

        public FrmCrearEvento() : this(null)
        {
        }

        public FrmCrearEvento(Evento evento)
        {
            InitializeComponent();
            eventoService = new EventoService();
            eventoToEdit = evento;

            if (eventoToEdit != null)
            {
                txtNombreEvento.Text = eventoToEdit.nombre_evento;
                txtLugar.Text = eventoToEdit.lugar_evento;
                txtDescripcion.Text = eventoToEdit.descripcion_evento;
                dtpFechaInicio.Value = eventoToEdit.fecha_inicio_evento;
                dtpFechaFin.Value = eventoToEdit.fecha_fin_evento;
                nudCapacidad.Value = eventoToEdit.capacidad_max_evento;
                rutaImagen = eventoToEdit.ruta_imagen_evento;

                if (!string.IsNullOrEmpty(rutaImagen) && File.Exists(rutaImagen))
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(rutaImagen);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                dtpFechaInicio.Value = DateTime.Now;
                dtpFechaFin.Value = DateTime.Now.AddDays(1);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    string carpetaImagenes = Path.Combine(Application.StartupPath, "Imagenes", "Eventos");
                    if (!Directory.Exists(carpetaImagenes))
                    {
                        Directory.CreateDirectory(carpetaImagenes);
                    }

                    string rutaImagenGuardada = rutaImagen;
                    if (!string.IsNullOrEmpty(rutaImagen) && (eventoToEdit == null || rutaImagen != eventoToEdit.ruta_imagen_evento))
                    {
                        string nombreArchivo = $"evento_{DateTime.Now.ToString("yyyyMMddHHmmss")}_{Path.GetFileName(rutaImagen)}";
                        rutaImagenGuardada = Path.Combine(carpetaImagenes, nombreArchivo);
                        try
                        {
                            File.Copy(rutaImagen, rutaImagenGuardada, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al copiar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    Evento evento = new Evento
                    {
                        nombre_evento = txtNombreEvento.Text,
                        lugar_evento = txtLugar.Text,
                        descripcion_evento = txtDescripcion.Text,
                        fecha_inicio_evento = dtpFechaInicio.Value,
                        fecha_fin_evento = dtpFechaFin.Value,
                        capacidad_max_evento = (int)nudCapacidad.Value,
                        ruta_imagen_evento = rutaImagenGuardada
                    };

                    // Log the dates for debugging
                    Console.WriteLine($"Guardando evento - fecha_inicio_evento: {evento.fecha_inicio_evento} (Type: {evento.fecha_inicio_evento.GetType().Name})");
                    Console.WriteLine($"Guardando evento - fecha_fin_evento: {evento.fecha_fin_evento} (Type: {evento.fecha_fin_evento.GetType().Name})");

                    string resultado;
                    if (eventoToEdit != null)
                    {
                        evento.id_evento = eventoToEdit.id_evento; // Set for WHERE clause in UPDATE
                        evento.id_administrador = eventoToEdit.id_administrador; // Preserve existing admin
                        resultado = eventoService.Modificar(evento);
                    }
                    else
                    {
                        resultado = eventoService.GuardarEventoComoAdmin(evento, Session.CurrentUser.id_usuario);
                    }

                    MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!resultado.StartsWith("Error"))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombreEvento.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLugar.Text))
            {
                MessageBox.Show("Por favor, ingrese el lugar del evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingrese la descripción del evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nudCapacidad.Value < 1)
            {
                MessageBox.Show("La capacidad debe ser al menos 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Seleccionar imagen del evento";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = openFileDialog.FileName;
                    try
                    {
                        pictureBox1.Image = Image.FromFile(rutaImagen);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}