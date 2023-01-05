using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosBasicos_07
{
    public partial class Form1 : Form
    {
        double n1, n2, n3, prome;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxMateria.Items.Add("PROGRAMACIÓN");
            cbxMateria.Items.Add("LABORATORIO");
            cbxMateria.Items.Add("MATEMÁTICAS");
            cbxMateria.Items.Add("INGLES");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                CalcProme();
            }
            catch (Exception)
            {
                 
                throw;
            }
            
        }
        void CalcProme()
        {
            try
            {
                n1 = Convert.ToDouble(txtNota1.Text);
                n2 = Convert.ToDouble(txtNota2.Text);
                n3 = Convert.ToDouble(txtNota3.Text);
                prome = (n1 + n2 + n3) / 3;
                Mostrar();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error!, Notas ingresar valores numéricos!!!");
            }
            
        }
        void Mostrar()
        {
            if (prome > 4.0)
            {
                MessageBox.Show("El alumno " + txtNombre.Text + "\nCódigo: " + txtCodAlu.Text + "\nMateria: " + cbxMateria.SelectedItem + "\nEstado: APROBADO");
            }else
            {
                MessageBox.Show("El alumno " + txtNombre.Text + "\nCódigo: " + txtCodAlu.Text + "\nMateria: " + cbxMateria.SelectedItem + "\nEstado: DESAPROBADO");
            }
        }
    }
}
/*Programa en el cual reciba como entradas la
siguiente información: Código del Estudiante,
Nombre del Estudiante, Nombre de la Materia y
Tres Notas de 1.0 a 5.0. Con esta información el
programa debe calcular la nota definitiva
(promedio) y determinar si el estudiante aprueba o
no la materia (Definitiva mayor a 4.0). Debe
imprimir coma salidas el nombre, el código, la
materia y si aprobó o no*/