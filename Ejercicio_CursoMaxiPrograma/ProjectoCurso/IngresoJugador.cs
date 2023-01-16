using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ProjectoCurso
{
    public partial class frmIngresoJugador : Form
    {
        private Jugador jugador = null;
        public frmIngresoJugador()
        {
            InitializeComponent();
        }
        public frmIngresoJugador(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;
            Text = "Modificar Jugador";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Planilla planilla = new Planilla();

            try
            {
                if (jugador == null) 
                    jugador= new Jugador();

                jugador.Nombre = txtNombre.Text;
                jugador.Edad = Convert.ToInt32(txtEdad.Text);
                jugador.UrlImagen = txtFoto.Text;
                jugador.Posicion = (Posicion)cboPosicion.SelectedItem;
                jugador.Peso = Convert.ToDouble(txtPeso.Text);
                jugador.Altura = Convert.ToDouble(txtAltura.Text);

                if (jugador.Id != 0)
                {
                    planilla.modificar(jugador);
                    MessageBox.Show("Jugador Modificado!");
                }
                else
                {
                    planilla.agregar(jugador);
                    MessageBox.Show("Jugador agregado!!!");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmIngresoJugador_Load(object sender, EventArgs e)
        {
            PosicionNegocio planilla = new PosicionNegocio();
            try
            {
                cboPosicion.DataSource = planilla.Listar();
                cboPosicion.ValueMember = "Id";
                cboPosicion.DisplayMember = "Descripcion";
                if (jugador != null)
                {
                    cboPosicion.SelectedValue = jugador.Posicion.Id;
                    txtNombre.Text = jugador.Nombre;
                    txtEdad.Text = jugador.Edad.ToString();
                    txtAltura.Text = jugador.Altura.ToString();
                    txtPeso.Text = jugador.Peso.ToString();
                    txtFoto.Text = jugador.UrlImagen;
                    CargarImagen(jugador.UrlImagen); 
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txtFoto_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtFoto.Text);
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                pbxFoto.Load(imagen);
            }
            catch (Exception)
            {
                pbxFoto.Load("C:\\Users\\matia\\Downloads\\nodisponible.png");
            }
        }
    }
}
