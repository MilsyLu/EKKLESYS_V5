﻿namespace GUI
{
    partial class FrmPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalAdmin));
            this.pnMenuLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnVerPerfil = new FontAwesome.Sharp.IconButton();
            this.btnVerUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnEventos = new FontAwesome.Sharp.IconButton();
            this.btnCursos = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.iconFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.pnSeparador = new System.Windows.Forms.Panel();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.pnMenuLateral.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormActual)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuLateral
            // 
            this.pnMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.pnMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.pnMenuLateral.Controls.Add(this.btnVerPerfil);
            this.pnMenuLateral.Controls.Add(this.btnVerUsuarios);
            this.pnMenuLateral.Controls.Add(this.btnDashboard);
            this.pnMenuLateral.Controls.Add(this.btnEventos);
            this.pnMenuLateral.Controls.Add(this.btnCursos);
            this.pnMenuLateral.Controls.Add(this.panelLogo);
            this.pnMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnMenuLateral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMenuLateral.Name = "pnMenuLateral";
            this.pnMenuLateral.Size = new System.Drawing.Size(194, 569);
            this.pnMenuLateral.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Cyan;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Cyan;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 32;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 519);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(194, 50);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerPerfil.FlatAppearance.BorderSize = 0;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerPerfil.ForeColor = System.Drawing.Color.Cyan;
            this.btnVerPerfil.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnVerPerfil.IconColor = System.Drawing.Color.Cyan;
            this.btnVerPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerPerfil.IconSize = 32;
            this.btnVerPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPerfil.Location = new System.Drawing.Point(0, 351);
            this.btnVerPerfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnVerPerfil.Size = new System.Drawing.Size(194, 50);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Mi Perfil";
            this.btnVerPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerUsuarios.FlatAppearance.BorderSize = 0;
            this.btnVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerUsuarios.ForeColor = System.Drawing.Color.Cyan;
            this.btnVerUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnVerUsuarios.IconColor = System.Drawing.Color.Cyan;
            this.btnVerUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerUsuarios.IconSize = 32;
            this.btnVerUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerUsuarios.Location = new System.Drawing.Point(0, 301);
            this.btnVerUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnVerUsuarios.Size = new System.Drawing.Size(194, 50);
            this.btnVerUsuarios.TabIndex = 7;
            this.btnVerUsuarios.Text = "Usuarios";
            this.btnVerUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerUsuarios.UseVisualStyleBackColor = true;
            this.btnVerUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.Cyan;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnDashboard.IconColor = System.Drawing.Color.Cyan;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 251);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnDashboard.Size = new System.Drawing.Size(194, 50);
            this.btnDashboard.TabIndex = 8;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnEventos
            // 
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnEventos.ForeColor = System.Drawing.Color.Cyan;
            this.btnEventos.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnEventos.IconColor = System.Drawing.Color.Cyan;
            this.btnEventos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEventos.IconSize = 32;
            this.btnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.Location = new System.Drawing.Point(0, 201);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnEventos.Size = new System.Drawing.Size(194, 50);
            this.btnEventos.TabIndex = 3;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEventos.UseVisualStyleBackColor = true;
            this.btnEventos.Click += new System.EventHandler(this.btnEventos_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnCursos.ForeColor = System.Drawing.Color.Cyan;
            this.btnCursos.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnCursos.IconColor = System.Drawing.Color.Cyan;
            this.btnCursos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCursos.IconSize = 32;
            this.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.Location = new System.Drawing.Point(0, 151);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnCursos.Size = new System.Drawing.Size(194, 50);
            this.btnCursos.TabIndex = 2;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblBienvenido);
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(194, 151);
            this.panelLogo.TabIndex = 0;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(9, 125);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(84, 17);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenid@";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(22, 16);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(142, 98);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.pnTitleBar.Controls.Add(this.lblTitulo);
            this.pnTitleBar.Controls.Add(this.iconFormActual);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(194, 0);
            this.pnTitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(757, 65);
            this.pnTitleBar.TabIndex = 1;
            this.pnTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(50, 32);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Panel Administrativo";
            // 
            // iconFormActual
            // 
            this.iconFormActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            this.iconFormActual.ForeColor = System.Drawing.Color.Cyan;
            this.iconFormActual.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.iconFormActual.IconColor = System.Drawing.Color.Cyan;
            this.iconFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormActual.IconSize = 30;
            this.iconFormActual.Location = new System.Drawing.Point(15, 19);
            this.iconFormActual.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconFormActual.Name = "iconFormActual";
            this.iconFormActual.Size = new System.Drawing.Size(30, 32);
            this.iconFormActual.TabIndex = 0;
            this.iconFormActual.TabStop = false;
            // 
            // pnSeparador
            // 
            this.pnSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSeparador.Location = new System.Drawing.Point(194, 65);
            this.pnSeparador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnSeparador.Name = "pnSeparador";
            this.pnSeparador.Size = new System.Drawing.Size(757, 4);
            this.pnSeparador.TabIndex = 2;
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.Color.White;
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(194, 69);
            this.pnContenedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(757, 500);
            this.pnContenedor.TabIndex = 3;
            // 
            // FrmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 569);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pnSeparador);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.pnMenuLateral);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Administrativo - Sistema de Gestión de Iglesia";
            this.Load += new System.EventHandler(this.FrmPrincipalAdmin_Load);
            this.pnMenuLateral.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuLateral;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnEventos;
        private FontAwesome.Sharp.IconButton btnVerPerfil;
        private FontAwesome.Sharp.IconButton btnCursos;
        private FontAwesome.Sharp.IconButton btnVerUsuarios; // NUEVO
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconFormActual;
        private System.Windows.Forms.Panel pnSeparador;
        private System.Windows.Forms.Panel pnContenedor;
    }
}
