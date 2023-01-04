using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosBasicos_08
{
    public partial class Form1 : Form
    {
        int cant;
        double precio, subt, desc, total;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                CalcSub();
                Descuento();
                Mostrar();
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        void CalcSub()
        {
            try
            {
                cant = 0; precio = 0; subt = 0;
                cant = Convert.ToInt32(txtCant.Text);
                precio = Convert.ToDouble(txtPU.Text);
                subt = precio * cant;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números.!!!");
            }
            
        }
        double Descuento()
        {
            desc = 0;
            if (subt >= 20000)
            {
                desc = subt * 0.35;
                lblDesc.Text = "DESCUENTO 35%:";
                return desc;
            }else
            {
                desc = subt * 0.15;
                lblDesc.Text = "DESCUENTO 15%:";
                return desc;
            }
        }
        void Mostrar()
        {
            total = 0;
            total = subt - desc;
            txtSubT.Text = subt.ToString("N2") + ".-";
            txtDesc.Text = desc.ToString("N2") + ".-";
            txtTotal.Text = total.ToString("N2") + ".-";
        }
    }
}
/*Programa que permita determinar el total a pagar
por una compra del la cual se sabe el valor unitario
y la cantidad. Se debe tener en cuanta que se
realiza un descuento del 15% por compra
inferiores a $20000 y del 35% por compras
mayores o iguales a $20000*/