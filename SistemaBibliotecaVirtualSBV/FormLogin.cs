using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SistemaBibliotecaVirtualSBV
{
    public partial class FormLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,
        int wParam, int lParam);
        public FormLogin()
        {
            InitializeComponent();
        }
        private void Mover()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void Salir()
        {
            Application.Exit();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("SELECT * FROM Usuarios WHERE Cuenta='{0}' AND Contraseña='{1}'", txtUsuario.Text.Trim(), txtContraseña.Text.Trim());
                DataSet ds = Libreria.Utilidades.Ejecutar(cmd);

                string cuenta = ds.Tables[0].Rows[0]["Cuenta"].ToString().Trim();
                string contraseña = ds.Tables[0].Rows[0]["Contraseña"].ToString().Trim();

                if (cuenta == txtUsuario.Text.Trim() && contraseña == txtContraseña.Text.Trim())
                {
                    MenuPrincipal MenPri = new MenuPrincipal();
                    this.Hide();
                    MenPri.Show();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Usuario o contraseña incorrectos! ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
