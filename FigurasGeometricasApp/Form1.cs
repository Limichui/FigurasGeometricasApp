using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace FigurasGeometricasApp
{
    public partial class Form1 : Form
    {
        Stack<FiguraGeometrica> pilaPoligonos = new Stack<FiguraGeometrica>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            // Validar que las cajas no estén vacías
            if (string.IsNullOrWhiteSpace(txtRadioMayorElipse.Text) ||
                string.IsNullOrWhiteSpace(txtRadioMenorElipse.Text))
            {
                MessageBox.Show("Debe ingresar valores en Radio menor y Radio mayor",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Detener ejecución si falta algún valor
            }

            double radioMayor = double.Parse(txtRadioMayorElipse.Text);
            double radioMenor = double.Parse(txtRadioMenorElipse.Text);

            Elipse e1 = new Elipse(radioMayor, radioMenor);
            //double area = e1.Area(radioMayor, radioMenor);

            pilaPoligonos.Push(e1);
            //lbPila.Text = $"Elipse creada – Área: {area}";
            MessageBox.Show($"Elipse - Área: PI * {radioMenor} * {radioMayor} = {Math.Round(e1.Area(radioMayor, radioMenor), 2)}");
            txtRadioMayorElipse.Clear();
            txtRadioMenorElipse.Clear();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBaseTriangulo.Text) ||
                string.IsNullOrWhiteSpace(txtAlturaTriangulo.Text))
            {
                MessageBox.Show("Debe ingresar valores en Base y Altura.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; 
            }

            double baseT = double.Parse(txtBaseTriangulo.Text);
            double altura = double.Parse(txtAlturaTriangulo.Text);

            Triangulo t = new Triangulo(baseT, altura);
            pilaPoligonos.Push(t);

            MessageBox.Show($"Triángulo - Área: ({baseT} * {altura}) / 2 = {t.Area(baseT, altura):F2}");
            txtBaseTriangulo.Clear();
            txtAlturaTriangulo.Clear();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            // Validar que las cajas no estén vacías
            if (string.IsNullOrWhiteSpace(txtBaseRectangulo.Text) ||
                string.IsNullOrWhiteSpace(txtAlturaRectangulo.Text))
            {
                MessageBox.Show("Debe ingresar valores en Base y Altura.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Detener ejecución si falta algún valor
            }

            double ancho = double.Parse(txtBaseRectangulo.Text);
            double alto = double.Parse(txtAlturaRectangulo.Text);

            Rectangulo r = new Rectangulo(ancho, alto);
            pilaPoligonos.Push(r);

            MessageBox.Show($"Rectángulo - Área: {ancho} * {alto} = {r.Area(ancho, alto):F2}");

            txtBaseRectangulo.Clear();
            txtAlturaRectangulo.Clear();
        }

        private void lbMostrarPila_Click(object sender, EventArgs e)
        {
            lbPila.Text = string.Join("\n", pilaPoligonos);
        }

        private void SoloEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control (Backspace, Delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir solo dígitos
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

