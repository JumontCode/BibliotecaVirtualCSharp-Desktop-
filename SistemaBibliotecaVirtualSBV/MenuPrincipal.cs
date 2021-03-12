using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibliotecaVirtualSBV
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnLector_Click(object sender, EventArgs e)
        {
            FormLector FL = new FormLector();            
            FL.Show();
            this.Hide();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

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
    }
}
