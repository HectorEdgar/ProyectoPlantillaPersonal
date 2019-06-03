using ProyectoPlantillaPersonal.Formularios.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlantillaPersonal.Formularios
{
    public partial class MenuPrincipalAdministrador : Form
    {
        public MenuPrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void cerrarSesion() {
            Application.OpenForms["Loggin"].Visible = true;
            this.Visible = false;
            this.Dispose();
        }
        private void cerrarAplicacion(FormClosedEventArgs e) {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void MenuPrincipalAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            cerrarAplicacion(e);
        }

        private void agregarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentaAgregar form = new CuentaAgregar();
            form.Visible = true;
            this.Visible = false;
        }
    }
}
