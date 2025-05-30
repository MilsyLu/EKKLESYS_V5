﻿namespace GUI
{
    partial class FrmDetalleEventoAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarEvento = new FontAwesome.Sharp.IconButton();
            this.btnEditarEvento = new FontAwesome.Sharp.IconButton();
            this.btnVerAsistentes = new System.Windows.Forms.Button();
            this.lblAsistentes = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechas = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título del Evento";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Location = new System.Drawing.Point(0, 60);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(781, 267);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnEliminarEvento);
            this.panel2.Controls.Add(this.btnEditarEvento);
            this.panel2.Controls.Add(this.btnVerAsistentes);
            this.panel2.Controls.Add(this.lblAsistentes);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblFechas);
            this.panel2.Controls.Add(this.lblLugar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 327);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(781, 301);
            this.panel2.TabIndex = 2;
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnEliminarEvento.FlatAppearance.BorderSize = 0;
            this.btnEliminarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEvento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEvento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEvento.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarEvento.IconColor = System.Drawing.Color.White;
            this.btnEliminarEvento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarEvento.IconSize = 24;
            this.btnEliminarEvento.Location = new System.Drawing.Point(614, 241);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(147, 40);
            this.btnEliminarEvento.TabIndex = 8;
            this.btnEliminarEvento.Text = "Eliminar";
            this.btnEliminarEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarEvento.UseVisualStyleBackColor = false;
            this.btnEliminarEvento.Click += new System.EventHandler(this.btnEliminarEvento_Click);
            // 
            // btnEditarEvento
            // 
            this.btnEditarEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEditarEvento.FlatAppearance.BorderSize = 0;
            this.btnEditarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEvento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEditarEvento.ForeColor = System.Drawing.Color.White;
            this.btnEditarEvento.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditarEvento.IconColor = System.Drawing.Color.White;
            this.btnEditarEvento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarEvento.IconSize = 24;
            this.btnEditarEvento.Location = new System.Drawing.Point(450, 241);
            this.btnEditarEvento.Name = "btnEditarEvento";
            this.btnEditarEvento.Size = new System.Drawing.Size(147, 40);
            this.btnEditarEvento.TabIndex = 9;
            this.btnEditarEvento.Text = "Editar";
            this.btnEditarEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarEvento.UseVisualStyleBackColor = false;
            this.btnEditarEvento.Click += new System.EventHandler(this.btnEditarEvento_Click); // Ensure event handler is set
            // 
            // btnVerAsistentes
            // 
            this.btnVerAsistentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnVerAsistentes.FlatAppearance.BorderSize = 0;
            this.btnVerAsistentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerAsistentes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerAsistentes.ForeColor = System.Drawing.Color.White;
            this.btnVerAsistentes.Location = new System.Drawing.Point(20, 241);
            this.btnVerAsistentes.Name = "btnVerAsistentes";
            this.btnVerAsistentes.Size = new System.Drawing.Size(147, 40);
            this.btnVerAsistentes.TabIndex = 7;
            this.btnVerAsistentes.Text = "Ver Asistentes";
            this.btnVerAsistentes.UseVisualStyleBackColor = false;
            this.btnVerAsistentes.Click += new System.EventHandler(this.btnVerAsistentes_Click);
            // 
            // lblAsistentes
            // 
            this.lblAsistentes.AutoSize = true;
            this.lblAsistentes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAsistentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblAsistentes.Location = new System.Drawing.Point(20, 211);
            this.lblAsistentes.Name = "lblAsistentes";
            this.lblAsistentes.Size = new System.Drawing.Size(76, 23);
            this.lblAsistentes.TabIndex = 5;
            this.lblAsistentes.Text = "Asistentes: 0";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(20, 114);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(741, 64);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 84);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(148, 23);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción del evento:";
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblFechas.Location = new System.Drawing.Point(20, 20);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(55, 23);
            this.lblFechas.TabIndex = 0;
            this.lblFechas.Text = "Fechas:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblLugar.Location = new System.Drawing.Point(20, 50);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(45, 23);
            this.lblLugar.TabIndex = 9;
            this.lblLugar.Text = "Lugar:";
            // 
            // FrmDetalleEventoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(781, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDetalleEventoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del Evento";
            this.Load += new System.EventHandler(this.FrmDetalleEventoAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnEliminarEvento;
        private FontAwesome.Sharp.IconButton btnEditarEvento;
        private System.Windows.Forms.Button btnVerAsistentes;
        private System.Windows.Forms.Label lblAsistentes;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label lblLugar;
    }
}