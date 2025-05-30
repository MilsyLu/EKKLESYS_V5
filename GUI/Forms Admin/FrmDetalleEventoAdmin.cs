using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLL;
using ENTITY;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class FrmDetalleEventoAdmin : Form
    {
        private readonly EventoService _eventoService;
        private readonly int _eventoId;
        private Evento _evento;
        private EventoDTO _eventoDto;
        private bool _isProcessing = false;

        public FrmDetalleEventoAdmin(int eventoId)
        {
            InitializeComponent();
            _eventoService = new EventoService();
            _eventoId = eventoId;
            ConfigurarBotonEliminar();
            ConfigurarBotonEditar();
            btnEliminarEvento.Click -= btnEliminarEvento_Click;
            btnEliminarEvento.Click += btnEliminarEvento_Click;
            btnEditarEvento.Click -= btnEditarEvento_Click;
            btnEditarEvento.Click += btnEditarEvento_Click;
            Console.WriteLine("btnEliminarEvento.Click and btnEditarEvento.Click handlers subscribed");
            CargarEvento();
        }

        private void CargarEvento()
        {
            try
            {
                _evento = _eventoService.BuscarPorId(_eventoId);
                if (_evento == null)
                {
                    MessageBox.Show("El evento no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                if (!string.IsNullOrEmpty(_evento.ruta_imagen_evento) && File.Exists(_evento.ruta_imagen_evento))
                {
                    try
                    {
                        using (var originalImage = Image.FromFile(_evento.ruta_imagen_evento))
                        {
                            pictureBox.Image = new Bitmap(originalImage);
                        }
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al cargar la imagen: {ex.Message}");
                    }
                }

                var eventosDto = _eventoService.ConsultarDTO();
                _eventoDto = eventosDto.Find(e => e.id_evento == _eventoId);

                lblTitulo.Text = _evento.nombre_evento;
                lblFechas.Text = $"Del {_evento.fecha_inicio_evento:dd/MM/yyyy} al {_evento.fecha_fin_evento:dd/MM/yyyy}";
                lblLugar.Text = $"Lugar: {_evento.lugar_evento}";
                txtDescripcion.Text = _evento.descripcion_evento;
                lblAsistentes.Text = $"Asistentes: {_eventoDto?.NumeroAsistentes ?? 0}/{_evento.capacidad_max_evento}";

                ConfigurarVisibilidadBotones();
                Console.WriteLine($"btnEliminarEvento.Visible: {btnEliminarEvento.Visible}, Enabled: {btnEliminarEvento.Enabled}");
                Console.WriteLine($"btnEditarEvento.Visible: {btnEditarEvento.Visible}, Enabled: {btnEditarEvento.Enabled}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ConfigurarVisibilidadBotones()
        {
            bool isAdmin = Session.CurrentUser?.es_administrador == "S" || Session.CurrentUser == null;
            btnEliminarEvento.Visible = isAdmin;
            btnEliminarEvento.Enabled = isAdmin;
            btnEditarEvento.Visible = isAdmin;
            btnEditarEvento.Enabled = isAdmin;
            Console.WriteLine($"ConfigurarVisibilidadBotones: isAdmin={isAdmin}");
        }

        private void ConfigurarBotonEliminar()
        {
            btnEliminarEvento.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarEvento.FlatAppearance.BorderSize = 0;
            btnEliminarEvento.FlatStyle = FlatStyle.Flat;
            btnEliminarEvento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarEvento.ForeColor = Color.White;
            btnEliminarEvento.IconChar = IconChar.TrashAlt;
            btnEliminarEvento.IconColor = Color.White;
            btnEliminarEvento.IconSize = 24;
            btnEliminarEvento.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void ConfigurarBotonEditar()
        {
            btnEditarEvento.BackColor = Color.FromArgb(255, 193, 7);
            btnEditarEvento.FlatAppearance.BorderSize = 0;
            btnEditarEvento.FlatStyle = FlatStyle.Flat;
            btnEditarEvento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarEvento.ForeColor = Color.White;
            btnEditarEvento.IconChar = IconChar.PencilAlt;
            btnEditarEvento.IconColor = Color.White;
            btnEditarEvento.IconSize = 24;
            btnEditarEvento.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void btnEditarEvento_Click(object sender, EventArgs e)
        {
            if (_isProcessing) return;
            _isProcessing = true;
            btnEditarEvento.Enabled = false;

            try
            {
                if (_evento == null)
                {
                    MessageBox.Show("No se pudo cargar el evento para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Session.CurrentUser?.es_administrador != "S")
                {
                    MessageBox.Show("Solo los administradores pueden editar eventos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var frmEditar = new FrmCrearEvento(_evento))
                {
                    frmEditar.Text = "Editar Evento";
                    if (frmEditar.ShowDialog() == DialogResult.OK)
                    {
                        CargarEvento();
                        MessageBox.Show("Evento actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la edición: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isProcessing = false;
                btnEditarEvento.Enabled = btnEditarEvento.Visible;
            }
        }

        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"btnEliminarEvento_Click triggered at: {DateTime.Now:HH:mm:ss.fff}");
            if (_isProcessing) return;
            _isProcessing = true;
            btnEliminarEvento.Enabled = false;

            try
            {
                if (Session.CurrentUser?.es_administrador != "S")
                {
                    MessageBox.Show("Solo los administradores pueden eliminar eventos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea eliminar permanentemente el evento: {_evento?.nombre_evento ?? "Desconocido"}?\n\nEsta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (confirmacion == DialogResult.Yes)
                {
                    var resultado = _eventoService.Eliminar(_eventoId);
                    if (resultado.StartsWith("Error"))
                    {
                        MessageBox.Show(resultado, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Evento eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la eliminación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isProcessing = false;
                btnEliminarEvento.Enabled = btnEliminarEvento.Visible;
            }
        }

        private void btnVerAsistentes_Click(object sender, EventArgs e)
        {
            FrmAsistentesEvento frmAsistentesEvento = new FrmAsistentesEvento(_eventoId);
            frmAsistentesEvento.Show();
        }

        private void FrmDetalleEventoAdmin_Load(object sender, EventArgs e)
        {
        }
    }
}