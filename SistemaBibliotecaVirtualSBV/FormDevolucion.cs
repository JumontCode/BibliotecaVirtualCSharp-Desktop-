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
    public partial class FormDevolucion : Form
    {
        public FormDevolucion()
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

        private string Conexion()
        {
            string con = "Data Source=WIZJUANRD\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
            return con;
        }

        private void SeleccionarPrestamo()
        {
            FormSeleccionarPrestamo FormSelecPres = new FormSeleccionarPrestamo();
            lblNumeroPrestamo.Text = FormSelecPres.dataGridPrestamoLibros.Rows[FormSelecPres.dataGridPrestamoLibros.CurrentRow.Index].Cells[0].Value.ToString();
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

        private void DevolverLibro()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("DevolverLibro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPrestamo1",lblNumeroPrestamo.Text);
                cmd.Parameters.AddWithValue("@IdLibro2",lblIdLibro.Text);
                cmd.Parameters.AddWithValue("@FechaDevolucion", dateTimeEntrega.Value);
                cmd.Parameters.AddWithValue("@ObservacionDevolucion", txtObservacion.Text);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Libro devuelto a la biblioteca. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show("Error al devolver el libro. ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarLibro()
        {
            SqlConnection con = new SqlConnection(Conexion());
  
                SqlCommand cmd = new SqlCommand("EliminarPrestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPrestamo1", lblNumeroPrestamo.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
        }

        private void FormDevolucion_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnSelecPrestamo_Click(object sender, EventArgs e)
        {
            FormSeleccionarPrestamo fsp = new FormSeleccionarPrestamo();
            fsp.ShowDialog();

            if (fsp.DialogResult == DialogResult.OK)
            {
                lblNumeroPrestamo.Text = fsp.dataGridPrestamoLibros.Rows[fsp.dataGridPrestamoLibros.CurrentRow.Index].Cells[0].Value.ToString();
                lblIdLibro.Text = fsp.dataGridPrestamoLibros.Rows[fsp.dataGridPrestamoLibros.CurrentRow.Index].Cells[1].Value.ToString();
                txtObservacion.Focus();
            }
        }

        private void LimpiarDatos()
        {
            txtObservacion.Clear();
            lblIdLibro.Text = "";
            lblNumeroPrestamo.Text = "";
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            DevolverLibro();
            LimpiarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal MenPri = new MenuPrincipal();
            this.Hide();
            MenPri.Show();
        }

        private void FormDevolucion_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal MenPri = new MenuPrincipal();
            this.Hide();
            MenPri.Show();
        }

        private void panelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            Mover();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialDevoluciones FHD = new FormHistorialDevoluciones();
            FHD.Show();
            this.Hide();
        }
    }
}
