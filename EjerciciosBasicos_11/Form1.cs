namespace EjerciciosBasicos_11
{
    public partial class fmrAceptacion : Form
    {
        public fmrAceptacion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarDatos();
            }
            catch (Exception)
            {

                throw;
            }
        }
        void VerificarDatos()
        {
            string nombre;
            int edad;
            double estatura, peso;
            try
            {
                nombre = txtNombre.Text;
                edad = Convert.ToInt32(txtEdad.Text);
                estatura = Convert.ToDouble(txtEstatura.Text);
                peso = Convert.ToDouble(txtPeso.Text);
                if (edad <= 18 && estatura >= 180 && estatura < 250 && peso <= 80)
                {
                    MessageBox.Show("JUGADOR ACEPTADO!!!");
                }
                else
                {
                    MessageBox.Show("NO ACEPTADO, NO CUMPLE TODOS LOS REQUISITOS...");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error al ingresar datos!");
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
/*Programa para determinar si un deportista es
aceptado en el quipo de baloncesto.
Las condiciones para ser aceptado son:
a) La edad debe ser menor o igual a 18 años
b) La estatura debe ser mayor a 180 cm
c) El peso debe ser menor o igual a 80 kg
Si el aspirante cumple las 3 condiciones aceptarlo
si no rechazarlo.*/