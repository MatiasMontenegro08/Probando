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
    public partial class frmPrincipal : Form
    {
        private List<Jugador> listaJugador;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarPlanilla();
        }
        private void dgvPlanilla_SelectionChanged(object sender, EventArgs e)
        {
            Jugador seleccionado = (Jugador)dgvPlanilla.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.UrlImagen);
        }

        //MÉTODOS
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmIngresoJugador nuevo = new frmIngresoJugador();
            nuevo.ShowDialog();
            CargarPlanilla();
        }
        public void CargarPlanilla()
        {
            //Probamos la nueva clase de conexion "ACCESODATOS"
            Planilla conectar = new Planilla();
            listaJugador = conectar.Listar();
            dgvPlanilla.DataSource = listaJugador;
            dgvPlanilla.Columns["UrlImagen"].Visible = false;
            dgvPlanilla.Columns["Id"].Visible = false;
            CargarImagen(listaJugador[0].UrlImagen);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Jugador seleccionado;
            seleccionado = (Jugador)dgvPlanilla.CurrentRow.DataBoundItem;
            frmIngresoJugador modificar = new frmIngresoJugador(seleccionado);
            modificar.ShowDialog();
            CargarPlanilla();
        }
        private void btnEliminarFijo_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void btnEliminarLog_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }
        private void Eliminar(bool logico = false)
        {
            Planilla negocio = new Planilla();
            Jugador seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Jugador)dgvPlanilla.CurrentRow.DataBoundItem;
                    if (logico)
                    {
                        negocio.eliminarLogico(seleccionado.Id);
                    }
                    else
                    {
                        negocio.eliminarFijo(seleccionado.Id);
                    }
                    CargarPlanilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
