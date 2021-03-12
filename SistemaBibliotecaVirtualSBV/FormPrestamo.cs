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

        private void SeleccionarLector()
        {
            txtCodigoElector.Text = dataGridLectores.Rows[dataGridLectores.CurrentRow.Index].Cells[0].Value.ToString();
            txtElector.Text = dataGridLectores.Rows[dataGridLectores.CurrentRow.Index].Cells[2].Value.ToString();   
        }
        private void SeleccionarLibro()
        {
            txtCodigoLibro.Text = dataGridLibros.Rows[dataGridLibros.CurrentRow.Index].Cells[0].Value.ToString();
            txtLibro.Text = dataGridLibros.Rows[dataGridLibros.CurrentRow.Index].Cells[1].Value.ToString();
            cbbEdicion.Text = dataGridLibros.Rows[dataGridLibros.CurrentRow.Index].Cells[1].Value.ToString();
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

        private void GuardarPrestamo(DataGridView dg)
        {
            try
            {
                SqlConnection con = new SqlConnection(Conexion());
                SqlCommand cmd = new SqlCommand("GuardarPrestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaSalida", dateTimeSalida.Text);
                cmd.Parameters.AddWithValue("@IdLibro1", txtCodigoLibro.Text);
                cmd.Parameters.AddWithValue("@FechaDevolucion", dateTimeEntrega.Text);
                cmd.Parameters.AddWithValue("@IdLector1", txtElector.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
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
    }
}
