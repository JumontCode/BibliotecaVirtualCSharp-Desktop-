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
    public partial class FormPrestamo : Form
    {
        public FormPrestamo()
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

        private void SeleccionarLector()
        {
            txtCodigoElector.Text = dataGridLectores.Rows[dataGridLectores.CurrentRow.Index].Cells[0].Value.ToString();
            txtElector.Text = dataGridLectores.Rows[dataGridLectores.CurrentRow.Index].Cells[2].Value.ToString();   
        }
        private void SeleccionarLibro()
        {
            txtCodigoLibro.Text = dataGridLibros.Rows[dataGridLibros.CurrentRow.Index].Cells[0].Value.ToString();
            txtLibro.Text = dataGridLibros.Rows[dataGridLibros.CurrentRow.Index].Cells[1].Value.ToString();
            cbbEdicion.Text = dataGridLibros.Rows[dataGridLibros.CurrentRow.Index].Cells[8].Value.ToString();
        }

        private void LimpiarTxt()
        {
            txtCodigoElector.Clear();
            txtCodigoLibro.Clear();
            txtBuscarLibro.Clear();
            txtBuscarElector.Clear();
            txtElector.Clear();
            txtLibro.Clear();
            cbbEdicion.SelectedValue = "";
        }

        private void MostrarLectores(DataGridView dg)
        {
            SqlConnection con = new SqlConnection(Conexion());
            SqlCommand cmd = new SqlCommand("select *from Lectores", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;
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

        private void GuardarPrestamoLibro()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {                
                SqlCommand cmd = new SqlCommand("GuardarPrestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLibro1", txtCodigoLibro.Text);
                cmd.Parameters.AddWithValue("@FechaSalida", dateTimeSalida.Value);
                cmd.Parameters.AddWithValue("@FechaDevolucion", dateTimeEntrega.Value);
                cmd.Parameters.AddWithValue("@IdLector1", txtCodigoElector.Text);
                //cmd.Parameters.AddWithValue("@IdUsuario", txtCodigoLibro.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se ha generado el Prestamo del libro. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show("Error al guardar el prestamo. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelecLibro_Click(object sender, EventArgs e)
        {
            SeleccionarLibro();
        }

        private void btnSelecElector_Click(object sender, EventArgs e)
        {
            SeleccionarLector();
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            MostrarLectores(dataGridLectores);
            MostrarLibros(dataGridLibros);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal MenPri = new MenuPrincipal();
            this.Hide();
            MenPri.Show();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            //TextBox NumEjem = new TextBox();
            //string cmd = string.Format($"SELECT *FROM Libros WHERE='{NumEjem.Text}'");
            //DataSet ds = Libreria.Utilidades.Ejecutar(cmd);

            //string NumEjemplares = ds.Tables[0].Rows[0]["NumeroEjemplares"].ToString().Trim();
            //if (Convert.ToInt32(NumEjemplares) <= 0)
            //{
            //    MessageBox.Show("Libro no disponible");
            //}
            //else
            //{
                GuardarPrestamoLibro();
                MostrarLectores(dataGridLectores);
                MostrarLibros(dataGridLibros);
                LimpiarTxt();
            //}
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
            MostrarLectores(dataGridLectores);
            MostrarLibros(dataGridLibros);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLibrosPrestados FLP = new FormLibrosPrestados();
            FLP.Show();
        }

        private void panelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }
    }
}
