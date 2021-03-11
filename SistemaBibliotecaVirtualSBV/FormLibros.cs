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
    public partial class FormLibro : Form
    {
        public FormLibro()
        {
            InitializeComponent();
        }

        private string Conexion()
        {
            string con = "Data Source=WIZJUANRD\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
            return con;
        }

        private void IngresarNuevoLibro()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarLibro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Titulo", txtNombreLibro.Text);
                cmd.Parameters.AddWithValue("@IdAutor1", txtAutor.Text);
                cmd.Parameters.AddWithValue("@IdCategoria1", txtCategoria.Text);
                cmd.Parameters.AddWithValue("@NumeroPaginas", txtNumPagina.Text);
                cmd.Parameters.AddWithValue("@IdEditorial1", txtCodigoEditorial.Text);
                cmd.Parameters.AddWithValue("@FechaEdicion", txtFechaEdicion.Text);
                cmd.Parameters.AddWithValue("@FechaPublicacion", txtFechaPublicacion.Text);
                cmd.Parameters.AddWithValue("@Edicion", txtEdicion.Text);
                cmd.Parameters.AddWithValue("@Idioma", txtIdioma.Text);
                cmd.Parameters.AddWithValue("@NumeroEjemplares", txtEjemplares.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e.Message);
                con.Close();
            }
        }

        private void ModificarLibro()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("ModificarLibro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLibro", txtIdLibro.Text);
                cmd.Parameters.AddWithValue("@Titulo", txtNombreLibro.Text);
                cmd.Parameters.AddWithValue("@IdAutor1", txtAutor.Text);
                cmd.Parameters.AddWithValue("@IdCategoria1", txtCategoria.Text);
                cmd.Parameters.AddWithValue("@NumeroPaginas", txtNumPagina.Text);
                cmd.Parameters.AddWithValue("@IdEditorial1", txtCodigoEditorial.Text);
                cmd.Parameters.AddWithValue("@FechaEdicion", txtFechaEdicion.Text);
                cmd.Parameters.AddWithValue("@FechaPublicacion", txtFechaPublicacion.Text);
                cmd.Parameters.AddWithValue("@Edicion", txtEdicion.Text);
                cmd.Parameters.AddWithValue("@Idioma", txtIdioma.Text);
                cmd.Parameters.AddWithValue("@NumeroEjemplares", txtEjemplares.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e.Message);
                con.Close();
            }
        }

        private void EliminarLibro()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarLibro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLibro", txtIdLibro.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro eliminado exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e.Message);
                con.Close();
            }
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

        private void LimpiarTxt()
        {
            txtAutor.Clear();
            txtCategoria.Text = "";
            txtCodigoEditorial.Clear();
            txtEdicion.Text = "";
            txtEjemplares.Clear();
            txtFechaEdicion.Text = "";
            txtFechaPublicacion.Text = "";
            txtIdioma.Clear();
            txtIdLibro.Clear();
            txtNombreLibro.Clear();
            txtNumPagina.Clear();
        }

        private void BuscarLibro(DataGridView dg)
        {
            SqlConnection con = new SqlConnection(Conexion());
            SqlCommand cmd = new SqlCommand("BuscarLibro", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Titulo", txtBuscar.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;
            if (txtBuscar.Text == "")
            {
                MostrarLibros(dataGridView1);
            }
        }

        private void SeleccionarDatosDg()
        {
            txtIdLibro.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombreLibro.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txtAutor.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            txtCategoria.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            txtNumPagina.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            txtCodigoEditorial.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            txtFechaEdicion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            txtFechaPublicacion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            txtEdicion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            txtIdioma.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
            txtEjemplares.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString();
            txtIdLibro.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarNuevoLibro();
            LimpiarTxt();
            MostrarLibros(dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarLibro();
            LimpiarTxt();
            MostrarLibros(dataGridView1);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ModificarLibro();
            LimpiarTxt();
            MostrarLibros(dataGridView1);
        }

        private void FormLibro_Load(object sender, EventArgs e)
        {
            MostrarLibros(dataGridView1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarLibro(dataGridView1);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarDatosDg();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal MenPri = new MenuPrincipal();
            this.Close();
            MenPri.Show();
        }
    }
}
