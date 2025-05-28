namespace GUI
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.btnExportarResumen = new FontAwesome.Sharp.IconButton();
            this.btnVerDetalles = new FontAwesome.Sharp.IconButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pnlEstadisticas = new System.Windows.Forms.Panel();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.lblTotalMiembros = new System.Windows.Forms.Label();
            this.lblTotalAdministradores = new System.Windows.Forms.Label();
            this.lblUsuariosEsteMes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.lblTotalCursos = new System.Windows.Forms.Label();
            this.lblCursosActivos = new System.Windows.Forms.Label();
            this.lblTotalInscripciones = new System.Windows.Forms.Label();
            this.lblInscripcionesEsteMes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpEventos = new System.Windows.Forms.GroupBox();
            this.lblTotalEventos = new System.Windows.Forms.Label();
            this.lblEventosProximos = new System.Windows.Forms.Label();
            this.lblTotalAsistencias = new System.Windows.Forms.Label();
            this.lblAsistenciasEsteMes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grpIndicadores = new System.Windows.Forms.GroupBox();
            this.lblPorcentajeMiembros = new System.Windows.Forms.Label();
            this.lblTasaOcupacionCursos = new System.Windows.Forms.Label();
            this.lblPromedioAsistentes = new System.Windows.Forms.Label();
            this.lblActividadMensual = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlDetalles = new System.Windows.Forms.Panel();
            this.pnlScrollContainer = new System.Windows.Forms.Panel();
            this.grpCursosPopulares = new System.Windows.Forms.GroupBox();
            this.dgvCursosPopulares = new System.Windows.Forms.DataGridView();
            this.colCursoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCursoInscripciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCursoCapacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCursoOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCursoFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEventosProximos = new System.Windows.Forms.GroupBox();
            this.dgvEventosProximos = new System.Windows.Forms.DataGridView();
            this.colEventoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventoFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventoLugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventoAsistentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEventoDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpUsuariosRecientes = new System.Windows.Forms.GroupBox();
            this.dgvUsuariosRecientes = new System.Windows.Forms.DataGridView();
            this.colUsuarioNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioMiembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlEstadisticas.SuspendLayout();
            this.grpUsuarios.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.grpEventos.SuspendLayout();
            this.grpIndicadores.SuspendLayout();
            this.pnlDetalles.SuspendLayout();
            this.pnlScrollContainer.SuspendLayout();
            this.grpCursosPopulares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosPopulares)).BeginInit();
            this.grpEventosProximos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosProximos)).BeginInit();
            this.grpUsuariosRecientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.btnActualizar);
            this.pnlHeader.Controls.Add(this.btnExportarResumen);
            this.pnlHeader.Controls.Add(this.btnVerDetalles);
            this.pnlHeader.Controls.Add(this.lblEstado);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1119, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(11, 12);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Dashboard Principal";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 20;
            this.btnActualizar.Location = new System.Drawing.Point(758, 13);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 28);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnExportarResumen
            // 
            this.btnExportarResumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.btnExportarResumen.FlatAppearance.BorderSize = 0;
            this.btnExportarResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarResumen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportarResumen.ForeColor = System.Drawing.Color.Black;
            this.btnExportarResumen.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnExportarResumen.IconColor = System.Drawing.Color.Black;
            this.btnExportarResumen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarResumen.IconSize = 20;
            this.btnExportarResumen.Location = new System.Drawing.Point(876, 13);
            this.btnExportarResumen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportarResumen.Name = "btnExportarResumen";
            this.btnExportarResumen.Size = new System.Drawing.Size(106, 28);
            this.btnExportarResumen.TabIndex = 2;
            this.btnExportarResumen.Text = "Exportar";
            this.btnExportarResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarResumen.UseVisualStyleBackColor = false;
            this.btnExportarResumen.Click += new System.EventHandler(this.btnExportarResumen_Click);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnVerDetalles.FlatAppearance.BorderSize = 0;
            this.btnVerDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalles.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerDetalles.ForeColor = System.Drawing.Color.Black;
            this.btnVerDetalles.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerDetalles.IconColor = System.Drawing.Color.Black;
            this.btnVerDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerDetalles.IconSize = 20;
            this.btnVerDetalles.Location = new System.Drawing.Point(999, 12);
            this.btnVerDetalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(105, 28);
            this.btnVerDetalles.TabIndex = 3;
            this.btnVerDetalles.Text = "Detalles";
            this.btnVerDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerDetalles.UseVisualStyleBackColor = false;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblEstado.ForeColor = System.Drawing.Color.LightGray;
            this.lblEstado.Location = new System.Drawing.Point(11, 45);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(114, 17);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Cargando datos...";
            // 
            // pnlEstadisticas
            // 
            this.pnlEstadisticas.Controls.Add(this.grpUsuarios);
            this.pnlEstadisticas.Controls.Add(this.grpCursos);
            this.pnlEstadisticas.Controls.Add(this.grpEventos);
            this.pnlEstadisticas.Controls.Add(this.grpIndicadores);
            this.pnlEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEstadisticas.Location = new System.Drawing.Point(0, 65);
            this.pnlEstadisticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlEstadisticas.Name = "pnlEstadisticas";
            this.pnlEstadisticas.Size = new System.Drawing.Size(1119, 163);
            this.pnlEstadisticas.TabIndex = 1;
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.lblTotalUsuarios);
            this.grpUsuarios.Controls.Add(this.lblTotalMiembros);
            this.grpUsuarios.Controls.Add(this.lblTotalAdministradores);
            this.grpUsuarios.Controls.Add(this.lblUsuariosEsteMes);
            this.grpUsuarios.Controls.Add(this.label1);
            this.grpUsuarios.Controls.Add(this.label2);
            this.grpUsuarios.Controls.Add(this.label3);
            this.grpUsuarios.Controls.Add(this.label4);
            this.grpUsuarios.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.grpUsuarios.Location = new System.Drawing.Point(73, 8);
            this.grpUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpUsuarios.Size = new System.Drawing.Size(188, 146);
            this.grpUsuarios.TabIndex = 0;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "👥 Usuarios";
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblTotalUsuarios.Location = new System.Drawing.Point(112, 24);
            this.lblTotalUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(21, 23);
            this.lblTotalUsuarios.TabIndex = 1;
            this.lblTotalUsuarios.Text = "0";
            // 
            // lblTotalMiembros
            // 
            this.lblTotalMiembros.AutoSize = true;
            this.lblTotalMiembros.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalMiembros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.lblTotalMiembros.Location = new System.Drawing.Point(112, 57);
            this.lblTotalMiembros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMiembros.Name = "lblTotalMiembros";
            this.lblTotalMiembros.Size = new System.Drawing.Size(21, 23);
            this.lblTotalMiembros.TabIndex = 3;
            this.lblTotalMiembros.Text = "0";
            // 
            // lblTotalAdministradores
            // 
            this.lblTotalAdministradores.AutoSize = true;
            this.lblTotalAdministradores.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAdministradores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblTotalAdministradores.Location = new System.Drawing.Point(112, 89);
            this.lblTotalAdministradores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAdministradores.Name = "lblTotalAdministradores";
            this.lblTotalAdministradores.Size = new System.Drawing.Size(21, 23);
            this.lblTotalAdministradores.TabIndex = 5;
            this.lblTotalAdministradores.Text = "0";
            // 
            // lblUsuariosEsteMes
            // 
            this.lblUsuariosEsteMes.AutoSize = true;
            this.lblUsuariosEsteMes.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblUsuariosEsteMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblUsuariosEsteMes.Location = new System.Drawing.Point(112, 122);
            this.lblUsuariosEsteMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuariosEsteMes.Name = "lblUsuariosEsteMes";
            this.lblUsuariosEsteMes.Size = new System.Drawing.Size(21, 23);
            this.lblUsuariosEsteMes.TabIndex = 7;
            this.lblUsuariosEsteMes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miembros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Administradores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label4.Location = new System.Drawing.Point(11, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Este mes:";
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.lblTotalCursos);
            this.grpCursos.Controls.Add(this.lblCursosActivos);
            this.grpCursos.Controls.Add(this.lblTotalInscripciones);
            this.grpCursos.Controls.Add(this.lblInscripcionesEsteMes);
            this.grpCursos.Controls.Add(this.label5);
            this.grpCursos.Controls.Add(this.label6);
            this.grpCursos.Controls.Add(this.label7);
            this.grpCursos.Controls.Add(this.label8);
            this.grpCursos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.grpCursos.Location = new System.Drawing.Point(343, 8);
            this.grpCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCursos.Size = new System.Drawing.Size(188, 146);
            this.grpCursos.TabIndex = 1;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "📚 Cursos";
            // 
            // lblTotalCursos
            // 
            this.lblTotalCursos.AutoSize = true;
            this.lblTotalCursos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblTotalCursos.Location = new System.Drawing.Point(112, 24);
            this.lblTotalCursos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCursos.Name = "lblTotalCursos";
            this.lblTotalCursos.Size = new System.Drawing.Size(21, 23);
            this.lblTotalCursos.TabIndex = 1;
            this.lblTotalCursos.Text = "0";
            // 
            // lblCursosActivos
            // 
            this.lblCursosActivos.AutoSize = true;
            this.lblCursosActivos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblCursosActivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.lblCursosActivos.Location = new System.Drawing.Point(112, 57);
            this.lblCursosActivos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCursosActivos.Name = "lblCursosActivos";
            this.lblCursosActivos.Size = new System.Drawing.Size(21, 23);
            this.lblCursosActivos.TabIndex = 3;
            this.lblCursosActivos.Text = "0";
            // 
            // lblTotalInscripciones
            // 
            this.lblTotalInscripciones.AutoSize = true;
            this.lblTotalInscripciones.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalInscripciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblTotalInscripciones.Location = new System.Drawing.Point(112, 89);
            this.lblTotalInscripciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalInscripciones.Name = "lblTotalInscripciones";
            this.lblTotalInscripciones.Size = new System.Drawing.Size(21, 23);
            this.lblTotalInscripciones.TabIndex = 5;
            this.lblTotalInscripciones.Text = "0";
            // 
            // lblInscripcionesEsteMes
            // 
            this.lblInscripcionesEsteMes.AutoSize = true;
            this.lblInscripcionesEsteMes.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblInscripcionesEsteMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblInscripcionesEsteMes.Location = new System.Drawing.Point(112, 122);
            this.lblInscripcionesEsteMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscripcionesEsteMes.Name = "lblInscripcionesEsteMes";
            this.lblInscripcionesEsteMes.Size = new System.Drawing.Size(21, 23);
            this.lblInscripcionesEsteMes.TabIndex = 7;
            this.lblInscripcionesEsteMes.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Activos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label7.Location = new System.Drawing.Point(11, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Inscripciones:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label8.Location = new System.Drawing.Point(11, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Este mes:";
            // 
            // grpEventos
            // 
            this.grpEventos.Controls.Add(this.lblTotalEventos);
            this.grpEventos.Controls.Add(this.lblEventosProximos);
            this.grpEventos.Controls.Add(this.lblTotalAsistencias);
            this.grpEventos.Controls.Add(this.lblAsistenciasEsteMes);
            this.grpEventos.Controls.Add(this.label9);
            this.grpEventos.Controls.Add(this.label10);
            this.grpEventos.Controls.Add(this.label11);
            this.grpEventos.Controls.Add(this.label12);
            this.grpEventos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.grpEventos.Location = new System.Drawing.Point(607, 8);
            this.grpEventos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEventos.Name = "grpEventos";
            this.grpEventos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEventos.Size = new System.Drawing.Size(188, 146);
            this.grpEventos.TabIndex = 2;
            this.grpEventos.TabStop = false;
            this.grpEventos.Text = "📅 Eventos";
            // 
            // lblTotalEventos
            // 
            this.lblTotalEventos.AutoSize = true;
            this.lblTotalEventos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalEventos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblTotalEventos.Location = new System.Drawing.Point(112, 24);
            this.lblTotalEventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalEventos.Name = "lblTotalEventos";
            this.lblTotalEventos.Size = new System.Drawing.Size(21, 23);
            this.lblTotalEventos.TabIndex = 0;
            this.lblTotalEventos.Text = "0";
            // 
            // lblEventosProximos
            // 
            this.lblEventosProximos.AutoSize = true;
            this.lblEventosProximos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblEventosProximos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.lblEventosProximos.Location = new System.Drawing.Point(112, 57);
            this.lblEventosProximos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventosProximos.Name = "lblEventosProximos";
            this.lblEventosProximos.Size = new System.Drawing.Size(21, 23);
            this.lblEventosProximos.TabIndex = 1;
            this.lblEventosProximos.Text = "0";
            // 
            // lblTotalAsistencias
            // 
            this.lblTotalAsistencias.AutoSize = true;
            this.lblTotalAsistencias.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAsistencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblTotalAsistencias.Location = new System.Drawing.Point(112, 89);
            this.lblTotalAsistencias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAsistencias.Name = "lblTotalAsistencias";
            this.lblTotalAsistencias.Size = new System.Drawing.Size(21, 23);
            this.lblTotalAsistencias.TabIndex = 2;
            this.lblTotalAsistencias.Text = "0";
            // 
            // lblAsistenciasEsteMes
            // 
            this.lblAsistenciasEsteMes.AutoSize = true;
            this.lblAsistenciasEsteMes.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblAsistenciasEsteMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblAsistenciasEsteMes.Location = new System.Drawing.Point(112, 122);
            this.lblAsistenciasEsteMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsistenciasEsteMes.Name = "lblAsistenciasEsteMes";
            this.lblAsistenciasEsteMes.Size = new System.Drawing.Size(21, 23);
            this.lblAsistenciasEsteMes.TabIndex = 7;
            this.lblAsistenciasEsteMes.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label9.Location = new System.Drawing.Point(11, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label10.Location = new System.Drawing.Point(11, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Próximos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label11.Location = new System.Drawing.Point(11, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Asistencias:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label12.Location = new System.Drawing.Point(11, 126);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Este mes:";
            // 
            // grpIndicadores
            // 
            this.grpIndicadores.Controls.Add(this.lblPorcentajeMiembros);
            this.grpIndicadores.Controls.Add(this.lblTasaOcupacionCursos);
            this.grpIndicadores.Controls.Add(this.lblPromedioAsistentes);
            this.grpIndicadores.Controls.Add(this.lblActividadMensual);
            this.grpIndicadores.Controls.Add(this.label13);
            this.grpIndicadores.Controls.Add(this.label14);
            this.grpIndicadores.Controls.Add(this.label15);
            this.grpIndicadores.Controls.Add(this.label16);
            this.grpIndicadores.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.grpIndicadores.Location = new System.Drawing.Point(865, 8);
            this.grpIndicadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpIndicadores.Name = "grpIndicadores";
            this.grpIndicadores.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpIndicadores.Size = new System.Drawing.Size(188, 146);
            this.grpIndicadores.TabIndex = 3;
            this.grpIndicadores.TabStop = false;
            this.grpIndicadores.Text = "📊 Indicadores";
            // 
            // lblPorcentajeMiembros
            // 
            this.lblPorcentajeMiembros.AutoSize = true;
            this.lblPorcentajeMiembros.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblPorcentajeMiembros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.lblPorcentajeMiembros.Location = new System.Drawing.Point(112, 24);
            this.lblPorcentajeMiembros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPorcentajeMiembros.Name = "lblPorcentajeMiembros";
            this.lblPorcentajeMiembros.Size = new System.Drawing.Size(37, 23);
            this.lblPorcentajeMiembros.TabIndex = 1;
            this.lblPorcentajeMiembros.Text = "0%";
            // 
            // lblTasaOcupacionCursos
            // 
            this.lblTasaOcupacionCursos.AutoSize = true;
            this.lblTasaOcupacionCursos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblTasaOcupacionCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.lblTasaOcupacionCursos.Location = new System.Drawing.Point(112, 57);
            this.lblTasaOcupacionCursos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTasaOcupacionCursos.Name = "lblTasaOcupacionCursos";
            this.lblTasaOcupacionCursos.Size = new System.Drawing.Size(37, 23);
            this.lblTasaOcupacionCursos.TabIndex = 2;
            this.lblTasaOcupacionCursos.Text = "0%";
            // 
            // lblPromedioAsistentes
            // 
            this.lblPromedioAsistentes.AutoSize = true;
            this.lblPromedioAsistentes.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblPromedioAsistentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.lblPromedioAsistentes.Location = new System.Drawing.Point(112, 89);
            this.lblPromedioAsistentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedioAsistentes.Name = "lblPromedioAsistentes";
            this.lblPromedioAsistentes.Size = new System.Drawing.Size(21, 23);
            this.lblPromedioAsistentes.TabIndex = 3;
            this.lblPromedioAsistentes.Text = "0";
            // 
            // lblActividadMensual
            // 
            this.lblActividadMensual.AutoSize = true;
            this.lblActividadMensual.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lblActividadMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblActividadMensual.Location = new System.Drawing.Point(112, 122);
            this.lblActividadMensual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividadMensual.Name = "lblActividadMensual";
            this.lblActividadMensual.Size = new System.Drawing.Size(21, 23);
            this.lblActividadMensual.TabIndex = 4;
            this.lblActividadMensual.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label13.Location = new System.Drawing.Point(11, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Miembros:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label14.Location = new System.Drawing.Point(11, 61);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ocupación:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label15.Location = new System.Drawing.Point(11, 93);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Promedio:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label16.Location = new System.Drawing.Point(11, 126);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "Actividad:";
            // 
            // pnlDetalles
            // 
            this.pnlDetalles.Controls.Add(this.pnlScrollContainer);
            this.pnlDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalles.Location = new System.Drawing.Point(0, 228);
            this.pnlDetalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDetalles.Name = "pnlDetalles";
            this.pnlDetalles.Size = new System.Drawing.Size(1119, 358);
            this.pnlDetalles.TabIndex = 2;
            // 
            // pnlScrollContainer
            // 
            this.pnlScrollContainer.AutoScroll = true;
            this.pnlScrollContainer.Controls.Add(this.grpCursosPopulares);
            this.pnlScrollContainer.Controls.Add(this.grpEventosProximos);
            this.pnlScrollContainer.Controls.Add(this.grpUsuariosRecientes);
            this.pnlScrollContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScrollContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlScrollContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlScrollContainer.Name = "pnlScrollContainer";
            this.pnlScrollContainer.Size = new System.Drawing.Size(1119, 358);
            this.pnlScrollContainer.TabIndex = 3;
            // 
            // grpCursosPopulares
            // 
            this.grpCursosPopulares.Controls.Add(this.dgvCursosPopulares);
            this.grpCursosPopulares.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.grpCursosPopulares.Location = new System.Drawing.Point(8, 8);
            this.grpCursosPopulares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCursosPopulares.Name = "grpCursosPopulares";
            this.grpCursosPopulares.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCursosPopulares.Size = new System.Drawing.Size(539, 228);
            this.grpCursosPopulares.TabIndex = 0;
            this.grpCursosPopulares.TabStop = false;
            this.grpCursosPopulares.Text = "🏆 Cursos Más Populares";
            // 
            // dgvCursosPopulares
            // 
            this.dgvCursosPopulares.AllowUserToAddRows = false;
            this.dgvCursosPopulares.AllowUserToDeleteRows = false;
            this.dgvCursosPopulares.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCursosPopulares.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursosPopulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosPopulares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCursoNombre,
            this.colCursoInscripciones,
            this.colCursoCapacidad,
            this.colCursoOcupacion,
            this.colCursoFecha});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursosPopulares.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursosPopulares.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursosPopulares.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dgvCursosPopulares.Location = new System.Drawing.Point(2, 19);
            this.dgvCursosPopulares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCursosPopulares.Name = "dgvCursosPopulares";
            this.dgvCursosPopulares.ReadOnly = true;
            this.dgvCursosPopulares.RowHeadersVisible = false;
            this.dgvCursosPopulares.RowTemplate.Height = 28;
            this.dgvCursosPopulares.Size = new System.Drawing.Size(535, 207);
            this.dgvCursosPopulares.TabIndex = 0;
            // 
            // colCursoNombre
            // 
            this.colCursoNombre.HeaderText = "Curso";
            this.colCursoNombre.MinimumWidth = 120;
            this.colCursoNombre.Name = "colCursoNombre";
            this.colCursoNombre.ReadOnly = true;
            this.colCursoNombre.Width = 180;
            // 
            // colCursoInscripciones
            // 
            this.colCursoInscripciones.HeaderText = "Inscritos";
            this.colCursoInscripciones.MinimumWidth = 50;
            this.colCursoInscripciones.Name = "colCursoInscripciones";
            this.colCursoInscripciones.ReadOnly = true;
            this.colCursoInscripciones.Width = 80;
            // 
            // colCursoCapacidad
            // 
            this.colCursoCapacidad.HeaderText = "Capacidad";
            this.colCursoCapacidad.MinimumWidth = 60;
            this.colCursoCapacidad.Name = "colCursoCapacidad";
            this.colCursoCapacidad.ReadOnly = true;
            this.colCursoCapacidad.Width = 90;
            // 
            // colCursoOcupacion
            // 
            this.colCursoOcupacion.HeaderText = "Ocupación";
            this.colCursoOcupacion.MinimumWidth = 60;
            this.colCursoOcupacion.Name = "colCursoOcupacion";
            this.colCursoOcupacion.ReadOnly = true;
            this.colCursoOcupacion.Width = 90;
            // 
            // colCursoFecha
            // 
            this.colCursoFecha.HeaderText = "Fecha";
            this.colCursoFecha.MinimumWidth = 70;
            this.colCursoFecha.Name = "colCursoFecha";
            this.colCursoFecha.ReadOnly = true;
            this.colCursoFecha.Width = 90;
            // 
            // grpEventosProximos
            // 
            this.grpEventosProximos.Controls.Add(this.dgvEventosProximos);
            this.grpEventosProximos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.grpEventosProximos.Location = new System.Drawing.Point(563, 6);
            this.grpEventosProximos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEventosProximos.Name = "grpEventosProximos";
            this.grpEventosProximos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEventosProximos.Size = new System.Drawing.Size(537, 228);
            this.grpEventosProximos.TabIndex = 1;
            this.grpEventosProximos.TabStop = false;
            this.grpEventosProximos.Text = "⏰ Próximos Eventos";
            // 
            // dgvEventosProximos
            // 
            this.dgvEventosProximos.AllowUserToAddRows = false;
            this.dgvEventosProximos.AllowUserToDeleteRows = false;
            this.dgvEventosProximos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEventosProximos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEventosProximos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventosProximos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEventoNombre,
            this.colEventoFecha,
            this.colEventoLugar,
            this.colEventoAsistentes,
            this.colEventoDias});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventosProximos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEventosProximos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventosProximos.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dgvEventosProximos.Location = new System.Drawing.Point(2, 19);
            this.dgvEventosProximos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEventosProximos.Name = "dgvEventosProximos";
            this.dgvEventosProximos.ReadOnly = true;
            this.dgvEventosProximos.RowHeadersVisible = false;
            this.dgvEventosProximos.RowTemplate.Height = 28;
            this.dgvEventosProximos.Size = new System.Drawing.Size(533, 207);
            this.dgvEventosProximos.TabIndex = 0;
            // 
            // colEventoNombre
            // 
            this.colEventoNombre.HeaderText = "Evento";
            this.colEventoNombre.MinimumWidth = 100;
            this.colEventoNombre.Name = "colEventoNombre";
            this.colEventoNombre.ReadOnly = true;
            this.colEventoNombre.Width = 160;
            // 
            // colEventoFecha
            // 
            this.colEventoFecha.HeaderText = "Fecha";
            this.colEventoFecha.MinimumWidth = 70;
            this.colEventoFecha.Name = "colEventoFecha";
            this.colEventoFecha.ReadOnly = true;
            this.colEventoFecha.Width = 90;
            // 
            // colEventoLugar
            // 
            this.colEventoLugar.HeaderText = "Lugar";
            this.colEventoLugar.MinimumWidth = 80;
            this.colEventoLugar.Name = "colEventoLugar";
            this.colEventoLugar.ReadOnly = true;
            this.colEventoLugar.Width = 120;
            // 
            // colEventoAsistentes
            // 
            this.colEventoAsistentes.HeaderText = "Asistentes";
            this.colEventoAsistentes.MinimumWidth = 60;
            this.colEventoAsistentes.Name = "colEventoAsistentes";
            this.colEventoAsistentes.ReadOnly = true;
            this.colEventoAsistentes.Width = 80;
            // 
            // colEventoDias
            // 
            this.colEventoDias.HeaderText = "Tiempo";
            this.colEventoDias.MinimumWidth = 60;
            this.colEventoDias.Name = "colEventoDias";
            this.colEventoDias.ReadOnly = true;
            this.colEventoDias.Width = 80;
            // 
            // grpUsuariosRecientes
            // 
            this.grpUsuariosRecientes.Controls.Add(this.dgvUsuariosRecientes);
            this.grpUsuariosRecientes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.grpUsuariosRecientes.Location = new System.Drawing.Point(8, 244);
            this.grpUsuariosRecientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpUsuariosRecientes.Name = "grpUsuariosRecientes";
            this.grpUsuariosRecientes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpUsuariosRecientes.Size = new System.Drawing.Size(758, 228);
            this.grpUsuariosRecientes.TabIndex = 2;
            this.grpUsuariosRecientes.TabStop = false;
            this.grpUsuariosRecientes.Text = "👤 Usuarios Recientes";
            // 
            // dgvUsuariosRecientes
            // 
            this.dgvUsuariosRecientes.AllowUserToAddRows = false;
            this.dgvUsuariosRecientes.AllowUserToDeleteRows = false;
            this.dgvUsuariosRecientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuariosRecientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuariosRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosRecientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsuarioNombre,
            this.colUsuarioEmail,
            this.colUsuarioMiembro,
            this.colUsuarioAdmin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosRecientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuariosRecientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuariosRecientes.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.dgvUsuariosRecientes.Location = new System.Drawing.Point(2, 19);
            this.dgvUsuariosRecientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsuariosRecientes.Name = "dgvUsuariosRecientes";
            this.dgvUsuariosRecientes.ReadOnly = true;
            this.dgvUsuariosRecientes.RowHeadersVisible = false;
            this.dgvUsuariosRecientes.RowTemplate.Height = 28;
            this.dgvUsuariosRecientes.Size = new System.Drawing.Size(754, 207);
            this.dgvUsuariosRecientes.TabIndex = 0;
            // 
            // colUsuarioNombre
            // 
            this.colUsuarioNombre.HeaderText = "Nombre";
            this.colUsuarioNombre.MinimumWidth = 100;
            this.colUsuarioNombre.Name = "colUsuarioNombre";
            this.colUsuarioNombre.ReadOnly = true;
            this.colUsuarioNombre.Width = 250;
            // 
            // colUsuarioEmail
            // 
            this.colUsuarioEmail.HeaderText = "Email";
            this.colUsuarioEmail.MinimumWidth = 120;
            this.colUsuarioEmail.Name = "colUsuarioEmail";
            this.colUsuarioEmail.ReadOnly = true;
            this.colUsuarioEmail.Width = 300;
            // 
            // colUsuarioMiembro
            // 
            this.colUsuarioMiembro.HeaderText = "Miembro";
            this.colUsuarioMiembro.MinimumWidth = 50;
            this.colUsuarioMiembro.Name = "colUsuarioMiembro";
            this.colUsuarioMiembro.ReadOnly = true;
            // 
            // colUsuarioAdmin
            // 
            this.colUsuarioAdmin.HeaderText = "Admin";
            this.colUsuarioAdmin.MinimumWidth = 45;
            this.colUsuarioAdmin.Name = "colUsuarioAdmin";
            this.colUsuarioAdmin.ReadOnly = true;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 586);
            this.Controls.Add(this.pnlDetalles);
            this.Controls.Add(this.pnlEstadisticas);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard - Sistema de Gestión de Iglesia";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlEstadisticas.ResumeLayout(false);
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.grpEventos.ResumeLayout(false);
            this.grpEventos.PerformLayout();
            this.grpIndicadores.ResumeLayout(false);
            this.grpIndicadores.PerformLayout();
            this.pnlDetalles.ResumeLayout(false);
            this.pnlScrollContainer.ResumeLayout(false);
            this.grpCursosPopulares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosPopulares)).EndInit();
            this.grpEventosProximos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosProximos)).EndInit();
            this.grpUsuariosRecientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRecientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private FontAwesome.Sharp.IconButton btnExportarResumen;
        private FontAwesome.Sharp.IconButton btnVerDetalles;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel pnlEstadisticas;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Label lblTotalMiembros;
        private System.Windows.Forms.Label lblTotalAdministradores;
        private System.Windows.Forms.Label lblUsuariosEsteMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpCursos;
        private System.Windows.Forms.Label lblTotalCursos;
        private System.Windows.Forms.Label lblCursosActivos;
        private System.Windows.Forms.Label lblTotalInscripciones;
        private System.Windows.Forms.Label lblInscripcionesEsteMes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpEventos;
        private System.Windows.Forms.Label lblTotalEventos;
        private System.Windows.Forms.Label lblEventosProximos;
        private System.Windows.Forms.Label lblTotalAsistencias;
        private System.Windows.Forms.Label lblAsistenciasEsteMes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpIndicadores;
        private System.Windows.Forms.Label lblPorcentajeMiembros;
        private System.Windows.Forms.Label lblTasaOcupacionCursos;
        private System.Windows.Forms.Label lblPromedioAsistentes;
        private System.Windows.Forms.Label lblActividadMensual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlDetalles;
        private System.Windows.Forms.GroupBox grpCursosPopulares;
        private System.Windows.Forms.DataGridView dgvCursosPopulares;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursoInscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursoCapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursoOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCursoFecha;
        private System.Windows.Forms.GroupBox grpEventosProximos;
        private System.Windows.Forms.DataGridView dgvEventosProximos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventoFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventoLugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventoAsistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEventoDias;
        private System.Windows.Forms.GroupBox grpUsuariosRecientes;
        private System.Windows.Forms.DataGridView dgvUsuariosRecientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioMiembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioAdmin;
        private System.Windows.Forms.Panel pnlScrollContainer;
    }
}
