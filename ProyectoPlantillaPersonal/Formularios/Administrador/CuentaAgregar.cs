using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPlantillaPersonal.Modelos;

namespace ProyectoPlantillaPersonal.Formularios.Administrador
{
    public partial class CuentaAgregar : Form
    {
        private ModeloCuenta modeloCuenta;
        public CuentaAgregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modeloCuenta = new ModeloCuenta();
            Cuenta cuenta = new Cuenta();
            cuenta.usuario = txtUsuario.Text;
            cuenta.nombre = txtNombre.Text;
            cuenta.apellidoMaterno = txtApellidoMaterno.Text;
            cuenta.apellidoPaterno = txtApellidoPaterno.Text;
            cuenta.tipo = cbTipo.SelectedText;
            cuenta.contrasenia = txtPassword.Text;
            try
            {
                modeloCuenta.AgregarCuenta(cuenta);
                MessageBox.Show("Cuenta agregada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error "+ex+"");
            }
            

        }
    }
}
