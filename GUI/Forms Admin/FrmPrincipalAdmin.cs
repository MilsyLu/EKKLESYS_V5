using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class FrmPrincipalAdmin : Form
    {
        // Servicios
        private readonly UsuarioService _usuarioService = new UsuarioService();
        private readonly CursoService _cursoService = new CursoService();
        private readonly EventoService _eventoService = new EventoService();
        
        // Variables para el control de botones activos
        private IconButton _currentBtn;
        private readonly Panel _leftBorderBtn;
        private Form _activeForm = null;

        public FrmPrincipalAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Configuración inicial del formulario
            _leftBorderBtn = new Panel { Size = new Size(7, 60) };
            pnMenuLateral.Controls.Add(_leftBorderBtn);
            
            // Verificar permisos
            if (Session.CurrentUser == null || Session.CurrentUser.es_administrador != "S")
            {
                MessageBox.Show("Acceso denegado: no tiene permisos de administrador", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Configuración inicial
            lblBienvenido.Text = $"Bienvenid@, {Session.CurrentUser.nombre}";
            //ActivarBoton(btnUsuarios, RGBColors.Color1);
            //AbrirFormularioHijo(new FrmUsuarios());
            AbrirFormularioHijo(new FrmEventosAdmin());
        }

        #region Métodos para el manejo de la interfaz

        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn == null) return;
            
            DesactivarBoton();
            
            // Configurar el botón activo
            _currentBtn = (IconButton)senderBtn;
            _currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            _currentBtn.ForeColor = color;
            _currentBtn.IconColor = color;
            _currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            _currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            
            // Borde izquierdo
            _leftBorderBtn.BackColor = color;
            _leftBorderBtn.Location = new Point(0, _currentBtn.Location.Y);
            _leftBorderBtn.Visible = true;
            _leftBorderBtn.BringToFront();
            
            // Icono del formulario actual
            iconFormActual.IconChar = _currentBtn.IconChar;
            iconFormActual.IconColor = color;
            
            // Título del formulario
            lblTitulo.Text = _currentBtn.Text;
        }

        private void DesactivarBoton()
        {
            if (_currentBtn == null) return;
            _currentBtn.BackColor = Color.FromArgb(23, 37, 84);
            _currentBtn.ForeColor = Color.Cyan;
            _currentBtn.IconColor = Color.Cyan;
            _currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; // Corrected enum value  
            _currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void AbrirFormularioHijo(Form childForm)
        {
            _activeForm?.Close();
            _activeForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            pnContenedor.Controls.Clear();
            pnContenedor.Controls.Add(childForm);
            pnContenedor.Tag = childForm;
            
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        #region Eventos de los botones del menú

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.Color1);
            AbrirFormularioHijo(new FrmUsuarios());
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.Color2);
            AbrirFormularioHijo(new FrmCursosAdmin());
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.Color3);
            AbrirFormularioHijo(new FrmEventosAdmin());
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.Color4);

            // Verificar si hay un usuario en sesión
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("No hay usuario logueado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Abrir el formulario de perfil como ventana normal
            //PerfilForm perfilForm = new PerfilForm();
            //perfilForm.Show();
            AbrirFormularioHijo(new PerfilForm());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmar", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.CurrentUser = null;
                var login = new FrmLogin();
                login.Show();
                this.Close();
            }
        }

        #endregion

        #region Eventos de los controles de ventana

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void btnMaximizar_Click(object sender, EventArgs e)
        //{
        //    WindowState = WindowState == FormWindowState.Normal 
        //        ? FormWindowState.Maximized 
        //        : FormWindowState.Normal;
            
        //    btnMaximizar.IconChar = WindowState == FormWindowState.Maximized 
        //        ? IconChar.WindowRestore 
        //        : IconChar.WindowMaximize;
        //}

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        #endregion

        // Estructura para colores RGB
        private struct RGBColors
        {
            public static Color Color1 = Color.FromArgb(0, 191, 255);  // Azul claro
            public static Color Color2 = Color.FromArgb(0, 255, 191);  // Verde azulado
            public static Color Color3 = Color.FromArgb(255, 191, 0);  // Amarillo
            public static Color Color4 = Color.FromArgb(191, 0, 255);  // Morado
            public static Color Color5 = Color.FromArgb(255, 99, 71);  // Rojo coral - NUEVO
        }

        private void FrmPrincipalAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, RGBColors.Color5);
            AbrirFormularioHijo(new FrmDashboard());
        }

        private void FrmPrincipalAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}