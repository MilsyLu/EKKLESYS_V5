using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using ENTITY;
using FontAwesome.Sharp;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using DrawingColor = System.Drawing.Color;
using PdfColor = QuestPDF.Infrastructure.Color;
using DrawingSize = System.Drawing.Size;

namespace GUI
{
    public partial class FrmDashboard : Form
    {
        private readonly DashboardService _dashboardService;
        private DashboardDTO _datosActuales;

        public FrmDashboard()
        {
            InitializeComponent();
            _dashboardService = new DashboardService();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            this.BackColor = DrawingColor.FromArgb(240, 242, 247);
            this.Padding = new Padding(20);
            ConfigurarDataGridViews();
            ConfigurarGraficos();
            // Configurar QuestPDF
            QuestPDF.Settings.License = LicenseType.Community;
        }

        private void ConfigurarDataGridViews()
        {
            // Configurar DataGridView de Cursos Populares
            ConfigurarDgvCursosPopulares();

            // Configurar DataGridView de Eventos Próximos
            ConfigurarDgvEventosProximos();

            // Configurar DataGridView de Usuarios Recientes
            ConfigurarDgvUsuariosRecientes();
        }

        private void ConfigurarGraficos()
        {
            // Configurar panel de estadísticas
            //pnlEstadisticasGrafico.BackColor = DrawingColor.White;
            //pnlEstadisticasGrafico.BorderStyle = BorderStyle.FixedSingle;

            // Configurar panel de distribución de usuarios
            //pnlDistribucionGrafico.BackColor = DrawingColor.White;
            //pnlDistribucionGrafico.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ConfigurarDgvCursosPopulares()
        {
            dgvCursosPopulares.EnableHeadersVisualStyles = false;
            dgvCursosPopulares.ColumnHeadersDefaultCellStyle.BackColor = DrawingColor.FromArgb(23, 37, 84);
            dgvCursosPopulares.ColumnHeadersDefaultCellStyle.ForeColor = DrawingColor.White;
            dgvCursosPopulares.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dgvCursosPopulares.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCursosPopulares.DefaultCellStyle.Font = new Font("Century Gothic", 8F);
            dgvCursosPopulares.DefaultCellStyle.BackColor = DrawingColor.White;
            dgvCursosPopulares.DefaultCellStyle.ForeColor = DrawingColor.Black;
            dgvCursosPopulares.DefaultCellStyle.SelectionBackColor = DrawingColor.FromArgb(0, 191, 255);
            dgvCursosPopulares.DefaultCellStyle.SelectionForeColor = DrawingColor.White;
            dgvCursosPopulares.DefaultCellStyle.Padding = new Padding(5, 2, 5, 2);

            dgvCursosPopulares.AlternatingRowsDefaultCellStyle.BackColor = DrawingColor.FromArgb(240, 242, 247);
            dgvCursosPopulares.GridColor = DrawingColor.FromArgb(200, 200, 200);
            dgvCursosPopulares.BorderStyle = BorderStyle.None;

            // Configurar tooltips para las celdas
            dgvCursosPopulares.CellToolTipTextNeeded += DgvCursosPopulares_CellToolTipTextNeeded;
        }

        private void ConfigurarDgvEventosProximos()
        {
            dgvEventosProximos.EnableHeadersVisualStyles = false;
            dgvEventosProximos.ColumnHeadersDefaultCellStyle.BackColor = DrawingColor.FromArgb(23, 37, 84);
            dgvEventosProximos.ColumnHeadersDefaultCellStyle.ForeColor = DrawingColor.White;
            dgvEventosProximos.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dgvEventosProximos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvEventosProximos.DefaultCellStyle.Font = new Font("Century Gothic", 8F);
            dgvEventosProximos.DefaultCellStyle.BackColor = DrawingColor.White;
            dgvEventosProximos.DefaultCellStyle.ForeColor = DrawingColor.Black;
            dgvEventosProximos.DefaultCellStyle.SelectionBackColor = DrawingColor.FromArgb(0, 255, 191);
            dgvEventosProximos.DefaultCellStyle.SelectionForeColor = DrawingColor.Black;
            dgvEventosProximos.DefaultCellStyle.Padding = new Padding(5, 2, 5, 2);

            dgvEventosProximos.AlternatingRowsDefaultCellStyle.BackColor = DrawingColor.FromArgb(240, 242, 247);
            dgvEventosProximos.GridColor = DrawingColor.FromArgb(200, 200, 200);
            dgvEventosProximos.BorderStyle = BorderStyle.None;

            // Configurar tooltips para las celdas
            dgvEventosProximos.CellToolTipTextNeeded += DgvEventosProximos_CellToolTipTextNeeded;
        }

        private void ConfigurarDgvUsuariosRecientes()
        {
            dgvUsuariosRecientes.EnableHeadersVisualStyles = false;
            dgvUsuariosRecientes.ColumnHeadersDefaultCellStyle.BackColor = DrawingColor.FromArgb(23, 37, 84);
            dgvUsuariosRecientes.ColumnHeadersDefaultCellStyle.ForeColor = DrawingColor.White;
            dgvUsuariosRecientes.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            dgvUsuariosRecientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvUsuariosRecientes.DefaultCellStyle.Font = new Font("Century Gothic", 8F);
            dgvUsuariosRecientes.DefaultCellStyle.BackColor = DrawingColor.White;
            dgvUsuariosRecientes.DefaultCellStyle.ForeColor = DrawingColor.Black;
            dgvUsuariosRecientes.DefaultCellStyle.SelectionBackColor = DrawingColor.FromArgb(255, 191, 0);
            dgvUsuariosRecientes.DefaultCellStyle.SelectionForeColor = DrawingColor.Black;
            dgvUsuariosRecientes.DefaultCellStyle.Padding = new Padding(5, 2, 5, 2);

            dgvUsuariosRecientes.AlternatingRowsDefaultCellStyle.BackColor = DrawingColor.FromArgb(240, 242, 247);
            dgvUsuariosRecientes.GridColor = DrawingColor.FromArgb(200, 200, 200);
            dgvUsuariosRecientes.BorderStyle = BorderStyle.None;

            // Configurar tooltips para las celdas
            dgvUsuariosRecientes.CellToolTipTextNeeded += DgvUsuariosRecientes_CellToolTipTextNeeded;
        }

        // Event handlers para tooltips
        private void DgvCursosPopulares_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dgvCursosPopulares.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                if (!string.IsNullOrEmpty(cellValue))
                {
                    e.ToolTipText = cellValue;
                }
            }
        }

        private void DgvEventosProximos_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dgvEventosProximos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                if (!string.IsNullOrEmpty(cellValue))
                {
                    e.ToolTipText = cellValue;
                }
            }
        }

        private void DgvUsuariosRecientes_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cellValue = dgvUsuariosRecientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                if (!string.IsNullOrEmpty(cellValue))
                {
                    e.ToolTipText = cellValue;
                }
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            CargarDatosDashboard();
        }

        private void CargarDatosDashboard()
        {
            try
            {
                // Mostrar indicador de carga
                lblEstado.Text = "Cargando datos...";
                lblEstado.ForeColor = DrawingColor.Blue;

                // Obtener datos
                _datosActuales = _dashboardService.ObtenerDatosDashboard();

                // Actualizar controles
                ActualizarEstadisticasGenerales();
                ActualizarListaCursosPopulares();
                ActualizarListaEventosProximos();
                ActualizarListaUsuariosRecientes();
                ActualizarIndicadoresClave();
                //ActualizarGraficos();

                lblEstado.Text = $"Última actualización: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
                lblEstado.ForeColor = DrawingColor.Green;
            }
            catch (Exception ex)
            {
                lblEstado.Text = $"Error al cargar datos: {ex.Message}";
                lblEstado.ForeColor = DrawingColor.Red;
                MessageBox.Show($"Error al cargar el dashboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void ActualizarGraficos()
        //{
        //    ActualizarGraficoEstadisticas();
        //    ActualizarGraficoDistribucionUsuarios();
        //}

        //private void ActualizarGraficoEstadisticas()
        //{
        //    try
        //    {
        //        // Mostrar estadísticas en el panel
        //        lblEstadisticas.Text = $"Total Usuarios: {_datosActuales.TotalUsuarios}\n" +
        //                                $"Total Cursos: {_datosActuales.TotalCursos}\n" +
        //                                $"Total Eventos: {_datosActuales.TotalEventos}\n" +
        //                                $"Total Inscripciones: {_datosActuales.TotalInscripciones}\n" +
        //                                $"Total Asistencias: {_datosActuales.TotalAsistencias}";
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error al actualizar gráfico de estadísticas: {ex.Message}");
        //    }
        //}

        //private void ActualizarGraficoDistribucionUsuarios()
        //{
        //    try
        //    {
        //        // Calcular usuarios regulares (no miembros ni administradores)
        //        int usuariosRegulares = _datosActuales.TotalUsuarios - _datosActuales.TotalMiembros - _datosActuales.TotalAdministradores;
        //        if (usuariosRegulares < 0) usuariosRegulares = 0;

        //        // Mostrar distribución de usuarios en el panel
        //        lblDistribucionUsuarios.Text = $"Miembros: {_datosActuales.TotalMiembros}\n" +
        //                                        $"Administradores: {_datosActuales.TotalAdministradores}\n" +
        //                                        $"Usuarios Regulares: {usuariosRegulares}";
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error al actualizar gráfico de distribución: {ex.Message}");
        //    }
        //}

        private void ActualizarEstadisticasGenerales()
        {
            // Usuarios
            lblTotalUsuarios.Text = _datosActuales.TotalUsuarios.ToString();
            lblTotalMiembros.Text = _datosActuales.TotalMiembros.ToString();
            lblTotalAdministradores.Text = _datosActuales.TotalAdministradores.ToString();
            lblUsuariosEsteMes.Text = _datosActuales.UsuariosRegistradosEsteMes.ToString();

            // Cursos
            lblTotalCursos.Text = _datosActuales.TotalCursos.ToString();
            lblCursosActivos.Text = _datosActuales.CursosActivos.ToString();
            lblTotalInscripciones.Text = _datosActuales.TotalInscripciones.ToString();
            lblInscripcionesEsteMes.Text = _datosActuales.InscripcionesEsteMes.ToString();

            // Eventos
            lblTotalEventos.Text = _datosActuales.TotalEventos.ToString();
            lblEventosProximos.Text = _datosActuales.EventosProximos.ToString();
            lblTotalAsistencias.Text = _datosActuales.TotalAsistencias.ToString();
            lblAsistenciasEsteMes.Text = _datosActuales.AsistenciasEsteMes.ToString();
        }

        private void ActualizarListaCursosPopulares()
        {
            dgvCursosPopulares.Rows.Clear();

            foreach (var curso in _datosActuales.CursosMasPopulares)
            {
                var nombreCorto = curso.NombreCurso.Length > 25 ?
                    curso.NombreCurso.Substring(0, 22) + "..." : curso.NombreCurso;

                dgvCursosPopulares.Rows.Add(
                    nombreCorto,
                    curso.NumeroInscripciones.ToString(),
                    curso.CapacidadMaxima.ToString(),
                    $"{curso.PorcentajeOcupacion:F1}%",
                    curso.FechaInicio.ToString("dd/MM/yy")
                );

                // Colorear la fila según el porcentaje de ocupación
                var ultimaFila = dgvCursosPopulares.Rows[dgvCursosPopulares.Rows.Count - 1];
                if (curso.PorcentajeOcupacion >= 80)
                {
                    ultimaFila.Cells[3].Style.BackColor = DrawingColor.LightGreen;
                    ultimaFila.Cells[3].Style.ForeColor = DrawingColor.DarkGreen;
                }
                else if (curso.PorcentajeOcupacion >= 50)
                {
                    ultimaFila.Cells[3].Style.BackColor = DrawingColor.LightYellow;
                    ultimaFila.Cells[3].Style.ForeColor = DrawingColor.DarkOrange;
                }
                else
                {
                    ultimaFila.Cells[3].Style.BackColor = DrawingColor.LightCoral;
                    ultimaFila.Cells[3].Style.ForeColor = DrawingColor.DarkRed;
                }
            }
        }

        private void ActualizarListaEventosProximos()
        {
            dgvEventosProximos.Rows.Clear();

            foreach (var evento in _datosActuales.ProximosEventos)
            {
                var nombreCorto = evento.NombreEvento.Length > 20 ?
                    evento.NombreEvento.Substring(0, 17) + "..." : evento.NombreEvento;

                var lugarCorto = evento.Lugar.Length > 15 ?
                    evento.Lugar.Substring(0, 12) + "..." : evento.Lugar;

                var tiempoTexto = evento.DiasRestantes == 0 ? "Hoy" :
                                 evento.DiasRestantes == 1 ? "Mañana" :
                                 $"{evento.DiasRestantes}d";

                dgvEventosProximos.Rows.Add(
                    nombreCorto,
                    evento.FechaInicio.ToString("dd/MM/yy"),
                    lugarCorto,
                    evento.NumeroAsistentes.ToString(),
                    tiempoTexto
                );

                // Colorear la fila según los días restantes
                var ultimaFila = dgvEventosProximos.Rows[dgvEventosProximos.Rows.Count - 1];
                if (evento.DiasRestantes <= 1)
                {
                    ultimaFila.Cells[4].Style.BackColor = DrawingColor.LightCoral;
                    ultimaFila.Cells[4].Style.ForeColor = DrawingColor.DarkRed;
                    ultimaFila.Cells[4].Style.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
                }
                else if (evento.DiasRestantes <= 7)
                {
                    ultimaFila.Cells[4].Style.BackColor = DrawingColor.LightYellow;
                    ultimaFila.Cells[4].Style.ForeColor = DrawingColor.DarkOrange;
                }
            }
        }

        private void ActualizarListaUsuariosRecientes()
        {
            dgvUsuariosRecientes.Rows.Clear();

            foreach (var usuario in _datosActuales.UsuariosRecientes)
            {
                var nombreCorto = usuario.NombreCompleto.Length > 18 ?
                    usuario.NombreCompleto.Substring(0, 15) + "..." : usuario.NombreCompleto;

                var emailCorto = usuario.Email.Length > 20 ?
                    usuario.Email.Substring(0, 17) + "..." : usuario.Email;

                dgvUsuariosRecientes.Rows.Add(
                    nombreCorto,
                    emailCorto,
                    usuario.EsMiembro == "Sí" ? "✓" : "✗",
                    usuario.EsAdministrador == "Sí" ? "✓" : "✗"
                );

                // Colorear las celdas de miembro y admin
                var ultimaFila = dgvUsuariosRecientes.Rows[dgvUsuariosRecientes.Rows.Count - 1];

                // Columna Miembro
                if (usuario.EsMiembro == "Sí")
                {
                    ultimaFila.Cells[2].Style.BackColor = DrawingColor.LightGreen;
                    ultimaFila.Cells[2].Style.ForeColor = DrawingColor.DarkGreen;
                }
                else
                {
                    ultimaFila.Cells[2].Style.BackColor = DrawingColor.LightGray;
                    ultimaFila.Cells[2].Style.ForeColor = DrawingColor.DarkGray;
                }

                // Columna Admin
                if (usuario.EsAdministrador == "Sí")
                {
                    ultimaFila.Cells[3].Style.BackColor = DrawingColor.LightBlue;
                    ultimaFila.Cells[3].Style.ForeColor = DrawingColor.DarkBlue;
                }
                else
                {
                    ultimaFila.Cells[3].Style.BackColor = DrawingColor.LightGray;
                    ultimaFila.Cells[3].Style.ForeColor = DrawingColor.DarkGray;
                }
            }
        }

        private void ActualizarIndicadoresClave()
        {
            try
            {
                var indicadores = _dashboardService.ObtenerIndicadoresClave();

                lblPorcentajeMiembros.Text = $"{indicadores["PorcentajeMiembros"]}%";
                lblTasaOcupacionCursos.Text = $"{indicadores["TasaOcupacionCursos"]}%";
                lblPromedioAsistentes.Text = indicadores["PromedioAsistentesPorEvento"].ToString();
                lblActividadMensual.Text = indicadores["ActividadMensual"].ToString();

                // Cambiar colores según los valores
                ActualizarColoresIndicadores(indicadores);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar indicadores: {ex.Message}");
            }
        }

        private void ActualizarColoresIndicadores(System.Collections.Generic.Dictionary<string, object> indicadores)
        {
            // Porcentaje de miembros
            var porcentajeMiembros = Convert.ToDecimal(indicadores["PorcentajeMiembros"]);
            lblPorcentajeMiembros.ForeColor = porcentajeMiembros >= 50 ? DrawingColor.Green :
                                 porcentajeMiembros >= 25 ? DrawingColor.Orange : DrawingColor.Red;

            // Tasa de ocupación de cursos
            var tasaOcupacion = Convert.ToDecimal(indicadores["TasaOcupacionCursos"]);
            lblTasaOcupacionCursos.ForeColor = tasaOcupacion >= 70 ? DrawingColor.Green :
                                              tasaOcupacion >= 40 ? DrawingColor.Orange : DrawingColor.Red;

            // Actividad mensual
            var actividad = Convert.ToInt32(indicadores["ActividadMensual"]);
            lblActividadMensual.ForeColor = actividad >= 20 ? DrawingColor.Green :
                                           actividad >= 10 ? DrawingColor.Orange : DrawingColor.Red;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDatosDashboard();
        }

        private void btnExportarResumen_Click(object sender, EventArgs e)
        {
            try
            {
                var saveDialog = new SaveFileDialog
                {
                    Filter = "Archivos PDF (*.pdf)|*.pdf",
                    FileName = $"Dashboard_Reporte_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    GenerarReportePDF(saveDialog.FileName);
                    MessageBox.Show("Reporte PDF generado exitosamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte PDF: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarReportePDF(string rutaArchivo)
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10));

                    page.Header()
                        .Text("REPORTE DASHBOARD - SISTEMA DE GESTIÓN DE IGLESIA")
                        .SemiBold().FontSize(16).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(column =>
                        {
                            // Información general
                            column.Item().Text($"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm:ss}")
                                .FontSize(10).FontColor(Colors.Grey.Medium);

                            column.Item().PaddingVertical(5, Unit.Millimetre);

                            // Estadísticas generales
                            column.Item().Text("ESTADÍSTICAS GENERALES").SemiBold().FontSize(14);

                            // Tabla de estadísticas
                            column.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.ConstantColumn(120);
                                    columns.RelativeColumn(1);
                                    columns.RelativeColumn(1);
                                    columns.RelativeColumn(1);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Element(CellStyle).Text("Categoría").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Total").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Activos").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Este Mes").SemiBold();
                                });

                                table.Cell().Element(CellStyle).Text("Usuarios");
                                table.Cell().Element(CellStyle).Text(_datosActuales.TotalUsuarios.ToString());
                                table.Cell().Element(CellStyle).Text(_datosActuales.TotalMiembros.ToString());
                                table.Cell().Element(CellStyle).Text(_datosActuales.UsuariosRegistradosEsteMes.ToString());

                                table.Cell().Element(CellStyle).Text("Cursos");
                                table.Cell().Element(CellStyle).Text(_datosActuales.TotalCursos.ToString());
                                table.Cell().Element(CellStyle).Text(_datosActuales.CursosActivos.ToString());
                                table.Cell().Element(CellStyle).Text(_datosActuales.InscripcionesEsteMes.ToString());

                                table.Cell().Element(CellStyle).Text("Eventos");
                                table.Cell().Element(CellStyle).Text(_datosActuales.TotalEventos.ToString());
                                table.Cell().Element(CellStyle).Text(_datosActuales.EventosProximos.ToString());
                                table.Cell().Element(CellStyle).Text(_datosActuales.AsistenciasEsteMes.ToString());
                            });

                            column.Item().PaddingVertical(10, Unit.Millimetre);

                            // Cursos más populares
                            column.Item().Text("CURSOS MÁS POPULARES").SemiBold().FontSize(12);
                            column.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(1);
                                    columns.RelativeColumn(1);
                                    columns.RelativeColumn(1);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Element(CellStyle).Text("Curso").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Inscritos").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Capacidad").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Ocupación").SemiBold();
                                });

                                foreach (var curso in _datosActuales.CursosMasPopulares)
                                {
                                    table.Cell().Element(CellStyle).Text(curso.NombreCurso);
                                    table.Cell().Element(CellStyle).Text(curso.NumeroInscripciones.ToString());
                                    table.Cell().Element(CellStyle).Text(curso.CapacidadMaxima.ToString());
                                    table.Cell().Element(CellStyle).Text($"{curso.PorcentajeOcupacion:F1}%");
                                }
                            });

                            column.Item().PaddingVertical(10, Unit.Millimetre);

                            // Próximos eventos
                            column.Item().Text("PRÓXIMOS EVENTOS").SemiBold().FontSize(12);
                            column.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(2);
                                    columns.RelativeColumn(1);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Element(CellStyle).Text("Evento").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Fecha").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Lugar").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Asistentes").SemiBold();
                                });

                                foreach (var evento in _datosActuales.ProximosEventos)
                                {
                                    table.Cell().Element(CellStyle).Text(evento.NombreEvento);
                                    table.Cell().Element(CellStyle).Text(evento.FechaInicio.ToString("dd/MM/yyyy"));
                                    table.Cell().Element(CellStyle).Text(evento.Lugar);
                                    table.Cell().Element(CellStyle).Text(evento.NumeroAsistentes.ToString());
                                }
                            });

                            column.Item().PaddingVertical(10, Unit.Millimetre);

                            // Usuarios recientes
                            column.Item().Text("USUARIOS RECIENTES").SemiBold().FontSize(12);
                            column.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(3);
                                    columns.RelativeColumn(1);
                                    columns.RelativeColumn(1);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Element(CellStyle).Text("Nombre").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Email").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Miembro").SemiBold();
                                    header.Cell().Element(CellStyle).Text("Admin").SemiBold();
                                });

                                foreach (var usuario in _datosActuales.UsuariosRecientes)
                                {
                                    table.Cell().Element(CellStyle).Text(usuario.NombreCompleto);
                                    table.Cell().Element(CellStyle).Text(usuario.Email);
                                    table.Cell().Element(CellStyle).Text(usuario.EsMiembro);
                                    table.Cell().Element(CellStyle).Text(usuario.EsAdministrador);
                                }
                            });
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                            x.Span(" de ");
                            x.TotalPages();
                        });
                });
            });

            document.GeneratePdf(rutaArchivo);
        }

        static IContainer CellStyle(IContainer container)
        {
            return container.DefaultTextStyle(x => x.FontSize(9)).PaddingVertical(5).PaddingHorizontal(10).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                var resumen = _dashboardService.GenerarResumenEjecutivo();
                var frmResumen = new Form
                {
                    Text = "Resumen Ejecutivo",
                    Size = new DrawingSize(600, 500),
                    StartPosition = FormStartPosition.CenterParent
                };

                var txtResumen = new TextBox
                {
                    Multiline = true,
                    ScrollBars = ScrollBars.Vertical,
                    ReadOnly = true,
                    Dock = DockStyle.Fill,
                    Font = new Font("Consolas", 9F),
                    Text = resumen
                };

                frmResumen.Controls.Add(txtResumen);
                frmResumen.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar detalles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
