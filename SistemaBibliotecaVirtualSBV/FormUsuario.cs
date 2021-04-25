using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaBibliotecaVirtualSBV
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private string Conexion()
        {
            string con = "Data Source=WIZJUANRD\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
            return con;
        }
        private void SeleccionarUsuario()
        {
            txtCodigo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txtCuenta.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
        }
        private void mostrarUsuarios(DataGridView dg)
        {
            SqlConnection con = new SqlConnection("Data Source=WIZJUANRD\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select IdUsuario,NombreUsuario,Cuenta from Usuarios", con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dg.DataSource = dt;
        }

        private void InsertarUsuario()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreUsuario", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Cuenta", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtNombre.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show("Ha ocurrido un error. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarUsuario()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@NombreUsuario", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Cuenta", txtCuenta.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro actualizado exitosamente. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show("Ha ocurrido un error. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EliminarUsuario()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", txtCodigo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro Eliminado exitosamente. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show("Ha ocurrido un error. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarUsuario(DataGridView dg)
        {
            SqlConnection con = new SqlConnection(Conexion());
            SqlCommand cmd = new SqlCommand("BuscarUsuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreUsuario", txtBuscar.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;
        }

        private void LimpiarTxt()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCuenta.Clear();
            txtContraseña.Clear();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            mostrarUsuarios(dataGridView1);
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarUsuario();
            mostrarUsuarios(dataGridView1);
            LimpiarTxt();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
            mostrarUsuarios(dataGridView1);
            LimpiarTxt();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
            mostrarUsuarios(dataGridView1);
            LimpiarTxt();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;

            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarUsuario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuario(dataGridView1);
            if (txtBuscar.Text == "")
            {
                mostrarUsuarios(dataGridView1);
            }
            else
            {
                BuscarUsuario(dataGridView1);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal MenPri = new MenuPrincipal();
            this.Hide();
            MenPri.Show();
        }

        private void FormUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal MenPri = new MenuPrincipal();
            this.Close();
            MenPri.Show();
        }
    }
}
