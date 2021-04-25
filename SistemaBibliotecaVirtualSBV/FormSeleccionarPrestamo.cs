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
    public partial class FormSeleccionarPrestamo : Form
    {
        public FormSeleccionarPrestamo()
        {
            InitializeComponent();
        }

        private void FormSeleccionarPrestamo_Load(object sender, EventArgs e)
        {
            MostrarLibrosPrestados(dataGridPrestamoLibros);
        }
        private string Conexion()
        {
            string con = "Data Source=WIZJUANRD\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
            return con;
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

        //public string MostrarValorEnLBL(Label tb)
        //{
        //    tb.Text = dataGridPrestamoLibros.Rows[dataGridPrestamoLibros.CurrentRow.Index].Cells[0].Value.ToString();
        //    //= dataGridPrestamoLibros.Rows[dataGridPrestamoLibros.CurrentRow.Index].Cells[0].Value.ToString();
        //    return tb.Text;
        //    this.Close();
        //}

        FormDevolucion FD = new FormDevolucion();
        private void btnSelecPrestamo_Click(object sender, EventArgs e)
        {

            if (dataGridPrestamoLibros.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            BuscarLibroPrestado(dataGridPrestamoLibros);
        }
    }
}
