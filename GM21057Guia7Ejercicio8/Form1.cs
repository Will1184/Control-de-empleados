// Guía: #7
// Ejercicio:#8
// Fecha: 09/10/2022
// Autor: BRANDON WILLIAM GOMEZ MONGE
// Carnet: GM21057
// GD: #1
// Instructora: ING. NELLY LISSETTE HENRIQUEZ SANCHEZ

namespace GM21057Guia7Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Empleados(empleado, dataGridEmpleados, labelEntre, labelMas, labelMenos, labelPocentajeInferior, labelPorcentajeEntre, labelPocentajeSuperior);

        }
    }
}