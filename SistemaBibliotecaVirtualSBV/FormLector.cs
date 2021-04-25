﻿using System;
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
    public partial class FormLector : Form
    {
        public FormLector()
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

        private void FormLector_Load(object sender, EventArgs e)
        {
            MostrarLectores(dataGridView1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IngresarNuevoLector();
            MostrarLectores(dataGridView1);
            LimpiarTxt();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarLector();
            MostrarLectores(dataGridView1);
            LimpiarTxt();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ModificarLector();
            MostrarLectores(dataGridView1);
            LimpiarTxt();
        }

        private string Conexion()
        {
            string con = "Data Source=WIZJUANRD\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
            return con;
        }

        private void SeleccionarLector()
        {
            txtId.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            txtCedula.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            txtTelefono.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            txtDireccion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
        }

        private void IngresarNuevoLector()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("NuevoLector", con);
                cmd.CommandType = CommandType.StoredProcedure;;
                cmd.Parameters.AddWithValue("@CedulaLector", txtCedula.Text);
                cmd.Parameters.AddWithValue("@NombreLector", txtNombre.Text);
                cmd.Parameters.AddWithValue("@TelefonoLector", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@DireccionLector", txtDireccion.Text);


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

        private void EliminarLector()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarLector", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLector", txtId.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Registro eliminado ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e.Message);
                con.Close();
            }
        }

        private void ModificarLector()
        {
            SqlConnection con = new SqlConnection(Conexion());
            try
            {
                SqlCommand cmd = new SqlCommand("ModificarLector", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdLector", txtId.Text);
                cmd.Parameters.AddWithValue("@CedulaLector", txtCedula.Text);
                cmd.Parameters.AddWithValue("@NombreLector", txtNombre.Text);
                cmd.Parameters.AddWithValue("@TelefonoLector", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@DireccionLector", txtDireccion.Text);
                con.Open();


                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ACTUALIZADO ", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
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

        private void BuscarLector(DataGridView dg)
        {
            SqlConnection con = new SqlConnection(Conexion());
            SqlCommand cmd = new SqlCommand("BuscarLector", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CedulaLector",txtBuscar.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dg.DataSource = dt;            
        }

        private void LimpiarTxt()
        {
            txtId.Clear();
            txtNombre.Text = "";
            txtCedula.Clear();
            txtDireccion.Text = "";
            txtBuscar.Clear();
            txtTelefono.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MostrarLectores(dataGridView1);
            }
            else
            {
            BuscarLector(dataGridView1);
            }
        }

        private void FormLector_FormClosing(object sender, FormClosingEventArgs e)
        {

            MenuPrincipal MP = new MenuPrincipal();
            MP.Show();
            this.Hide();
        }

        private void FormLector_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MenuPrincipal MP = new MenuPrincipal();
            //MP.Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarLector();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal MenPri = new MenuPrincipal();
            this.Hide();
            MenPri.Show();
        }
    }
}

