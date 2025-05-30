using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLL;
using ENTITY;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class FrmDetalleCursoAdmin : Form
    {
        private readonly CursoService _cursoService;
        private readonly int _cursoId;
        private Curso _curso;
        private CursoDTO _cursoDto;
        private bool _isProcessing = false;

        public FrmDetalleCursoAdmin(int cursoId)
        {
            InitializeComponent();
            _cursoService = new CursoService();
            _cursoId = cursoId;
            ConfigurarBotonEliminar();
            ConfigurarBotonEditar();
            btnEliminarCurso.Click -= btnEliminarCurso_Click;
            btnEliminarCurso.Click += btnEliminarCurso_Click;
            btnEditarCurso.Click -= btnEditarCurso_Click;
            btnEditarCurso.Click += btnEditarCurso_Click;
            Console.WriteLine("btnEliminarCurso.Click and btnEditarCurso.Click handlers subscribed");
            CargarCurso();
        }

        private void CargarCurso()
        {
            try
            {
                _curso = _cursoService.BuscarPorId(_cursoId);
                if (_curso == null)
                {
                    MessageBox.Show("El curso no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                if (!string.IsNullOrEmpty(_curso.ruta_imagen_curso) && File.Exists(_curso.ruta_imagen_curso))
                {
                    try
                    {
                        using (var originalImage = Image.FromFile(_curso.ruta_imagen_curso))
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

                var cursosDto = _cursoService.ConsultarDTO();
                _cursoDto = cursosDto.Find(c => c.id_curso == _cursoId);

                lblTitulo.Text = _curso.nombre_curso;
                lblFechas.Text = $"Del {_curso.fecha_inicio_curso:dd/MM/yyyy} al {_curso.fecha_fin_curso:dd/MM/yyyy}";
                txtDescripcion.Text = _curso.descripcion_curso;
                lblInscritos.Text = $"Inscritos: {_cursoDto?.NumeroInscritos ?? 0}/{_curso.capacidad_max_curso}";

                ConfigurarVisibilidadBotones();
                Console.WriteLine($"btnEliminarCurso.Visible: {btnEliminarCurso.Visible}, Enabled: {btnEliminarCurso.Enabled}");
                Console.WriteLine($"btnEditarCurso.Visible: {btnEditarCurso.Visible}, Enabled: {btnEditarCurso.Enabled}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el curso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ConfigurarVisibilidadBotones()
        {
            bool isAdmin = Session.CurrentUser?.es_administrador == "S";
            btnEliminarCurso.Visible = isAdmin;
            btnEliminarCurso.Enabled = isAdmin;
            btnEditarCurso.Visible = isAdmin;
            btnEditarCurso.Enabled = isAdmin;
            Console.WriteLine($"ConfigurarVisibilidadBotones: isAdmin={isAdmin}");
        }

        private void ConfigurarBotonEliminar()
        {
            btnEliminarCurso.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarCurso.FlatAppearance.BorderSize = 0;
            btnEliminarCurso.FlatStyle = FlatStyle.Flat;
            btnEliminarCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarCurso.ForeColor = Color.White;
            btnEliminarCurso.IconChar = IconChar.TrashAlt;
            btnEliminarCurso.IconColor = Color.White;
            btnEliminarCurso.IconSize = 24;
            btnEliminarCurso.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void ConfigurarBotonEditar()
        {
            btnEditarCurso.BackColor = Color.FromArgb(255, 193, 7);
            btnEditarCurso.FlatAppearance.BorderSize = 0;
            btnEditarCurso.FlatStyle = FlatStyle.Flat;
            btnEditarCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditarCurso.ForeColor = Color.White;
            btnEditarCurso.IconChar = IconChar.PencilAlt;
            btnEditarCurso.IconColor = Color.White;
            btnEditarCurso.IconSize = 24;
            btnEditarCurso.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            if (_isProcessing) return;
            _isProcessing = true;
            btnEditarCurso.Enabled = false;

            try
            {
                if (_curso == null)
                {
                    MessageBox.Show("No se pudo cargar el curso para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Session.CurrentUser?.es_administrador != "S")
                {
                    MessageBox.Show("Solo los administradores pueden editar cursos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var frmEditar = new FrmCrearCurso(_curso))
                {
                    frmEditar.Text = "Editar Curso";
                    if (frmEditar.ShowDialog() == DialogResult.OK)
                    {
                        CargarCurso();
                        MessageBox.Show("Curso actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                btnEditarCurso.Enabled = btnEditarCurso.Visible;
            }
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"btnEliminarCurso_Click triggered at: {DateTime.Now:HH:mm:ss.fff}");
            if (_isProcessing) return;
            _isProcessing = true;
            btnEliminarCurso.Enabled = false;

            try
            {
                if (Session.CurrentUser?.es_administrador != "S")
                {
                    MessageBox.Show("Solo los administradores pueden eliminar cursos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea eliminar permanentemente el curso: {_curso.nombre_curso}?\n\nEsta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (confirmacion == DialogResult.Yes)
                {
                    var resultado = _cursoService.Eliminar(_cursoId);
                    if (resultado.StartsWith("Error"))
                    {
                        MessageBox.Show(resultado, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Curso eliminado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                btnEliminarCurso.Enabled = btnEliminarCurso.Visible;
            }
        }

        private void btnVerEstudiantes_Click(object sender, EventArgs e)
        {
            FrmInscritosCurso frmInscritosCurso = new FrmInscritosCurso(_cursoId);
            frmInscritosCurso.Show();
        }

        private void FrmDetalleCursoAdmin_Load(object sender, EventArgs e)
        {
        }
    }
}