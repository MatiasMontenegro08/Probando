using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensajeria
{
    public partial class Mensajeria : Form
    {
        double resultado, recargo;
        string  aviso, extra;

        //Podremos mover la aplicación con el mouse
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        public Mensajeria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbtNormal.Checked)
            {
                Calcular();
                resultado = 150 + recargo;
                aviso = "ENVÍO NORMAL";
                Mostrar();
            }
            if (rbtPaqNormal.Checked)
            {
                Calcular();
                resultado = 200 + recargo;
                aviso = "PAQUETERÍA NORMAL";
                Mostrar();
            }
            if (rbtUrgente.Checked)
            {
                Calcular();
                resultado = 300 + recargo;
                aviso = "PARQUETERÍA URGENTE";
                Mostrar();
            }
        }

        private void pnlBarra_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        void Calcular()
        {
            recargo = 0;
            extra = "";
            if (chkEmail.Checked)
            {
                recargo += 10;
                extra += "Email.-";
            }
            if (chkTel.Checked)
            {
                recargo += 30;
                extra += "Teléfono.-";
            }
            if (chkFax.Checked)
            {
                recargo += 50;
                extra += "Fax.";
            }
        }
        void Mostrar()
        {
            if (extra != "")
            {
                MessageBox.Show("Usted seleccionó el envío por " + aviso + " y notificar por " + extra + "\nEl total del envío es de: $" + resultado.ToString("N2"));
            }
            else
            {
                MessageBox.Show("Usted seleccionó el envío por " + aviso + " y no soleccionó notificación.-\nEl total del envío es de: $" + resultado.ToString("N2"));
            }
            
        }
    }
}
