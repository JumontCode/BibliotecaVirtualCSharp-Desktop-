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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,
        int wParam, int lParam);
        
        private void Mover()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLector_Click(object sender, EventArgs e)
        {
            FormLector FL = new FormLector();
            this.Hide();
            FL.Show();
        }

        private string Conexion()
        {
            string con = "Data Source=WIZJUANRD\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
            return con;
        }

        private void MostrarLibros(DataGridView dg)
        {
            SqlConnection con = new SqlConnection(Conexion());
            SqlCommand cmd = new SqlCommand("select *from Libros", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            MostrarLibros(dataGridView1);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (panelSubMenuRegistrar.Visible == true)
            {
                //CerrarPanel();
                panelSubMenuRegistrar.Visible = false;
            }
            else
            {
                //AbrirPanel();
                panelSubMenuRegistrar.Visible = true;
            }
        }

        

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FormLibro FL = new FormLibro();
            this.Hide();
            FL.Show();
        }

        private void btnDevolverLibro_Click(object sender, EventArgs e)
        {
            FormDevolucion FormDev = new FormDevolucion();
            this.Hide();
            FormDev.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuario FormUsu = new FormUsuario();
            this.Hide();
            FormUsu.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            FormPrestamo FP = new FormPrestamo();
            FP.Show();
            this.Hide();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            FormLogin FL = new FormLogin();
            FL.Show();
            this.Hide();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }
    }
}
