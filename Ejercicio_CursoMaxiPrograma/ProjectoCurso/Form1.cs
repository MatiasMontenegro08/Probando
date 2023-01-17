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
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Edad");
        }
        private void dgvPlanilla_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlanilla.CurrentRow != null)
            {
                Jugador seleccionado = (Jugador)dgvPlanilla.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.UrlImagen);
            }
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
                pbxFoto.Load("C:\\Users\\matia\\OneDrive\\Escritorio\\MAXIPROGRAMA\\Nueva carpeta\\nodisponible.png");
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
            ocultarColumnas();
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
        private void ocultarColumnas()
        {
            dgvPlanilla.Columns["UrlImagen"].Visible = false;
            dgvPlanilla.Columns["Id"].Visible = false;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Jugador> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != null)
            {
                listaFiltrada = listaJugador.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.Posicion.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaJugador;
            }

            dgvPlanilla.DataSource = null;
            dgvPlanilla.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Nombre")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            Planilla planilla = new Planilla();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroDB.Text;
                dgvPlanilla.DataSource = planilla.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
