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
    public partial class FormLibrosPrestados : Form
    {
        public FormLibrosPrestados()
        {
            InitializeComponent();
        }

        private string Conexion()
        {
            string con = "Data Source=WIZJUANRD\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
            return con;
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
        private void MostrarLibrosPrestados(DataGridView dg)
        {
            SqlConnection con = new SqlConnection(Conexion());
            SqlCommand cmd = new SqlCommand("select *from Prestamo", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;
        }
        private void BuscarLibroPrestado(DataGridView dg)
        {
            SqlConnection con = new SqlConnection(Conexion());
            SqlCommand cmd = new SqlCommand("BuscarPrestamo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdPrestamo", txtBuscarPrestamo.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;
        }

        private void FormLibrosPrestados_Load(object sender, EventArgs e)
        {
            MostrarLibrosPrestados(dataGridPrestamoLibros);
        }

        private void FormLibrosPrestados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            if(txtBuscarPrestamo.Text == "")
            {
                MessageBox.Show("El campo no puede estar vacio. ", "AVISO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                MostrarLibrosPrestados(dataGridPrestamoLibros);
            }
            else
            {
            BuscarLibroPrestado(dataGridPrestamoLibros);
            }
        }

        private void FormLibrosPrestados_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
