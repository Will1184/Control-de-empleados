using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM21057Guia7Ejercicio8
{
    internal class Empleado
    {
        private string nombre;
        private double salario;

        private int id;
        public static int ContadorEmpleados = 0;

        public Empleado()
        {}

        public Empleado(string nombre, double salario)
        {
            this.id = ++ContadorEmpleados;
            this.nombre = nombre;
            this.salario = salario;
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public void Empleados(Empleado empleado, DataGridView dataGridEmpleados, Label labelEntre, Label labelMas, Label labelMenos, Label labelPocentajeInferior, Label labelPorcentajeEntre, Label labelPocentajeSuperior)
        {
            //CREACION Y DECLARACION DE VARIABLES Y VECTORES
            string[] nombres = new string[7];
            double[] salarios = new double[7];
            int salarioInferior = 0, salarioEntre = 0, salarioSuperior = 0;
            int porcSalarioInferior = 0, porcSalarioEntre = 0, porcSalarioSuperior = 0;

            //ASIGNARLE VALOR A LOS VECTORES
            nombres[0] = "Juan";
            nombres[1] = "Andrea";
            nombres[2] = "Zaira";
            nombres[3] = "Marcela";
            nombres[4] = "Roman";
            nombres[5] = "Denisse";
            nombres[6] = "Kevin";

            salarios[0] = 600.0;
            salarios[1] = 850.0;
            salarios[2] = 1500.0;
            salarios[3] = 2500.0;
            salarios[4] = 364.0;
            salarios[5] = 1000.0;
            salarios[6] = 900.0;
   
            //ORDENAR EL VECTOR POR ORDEN ALFABETICO
            Array.Sort(nombres, salarios);
            //CICLO QUE RECORRE LOS VECTORES
            for (int i = 0; i < 7; i++)
            {
                //INGRESAR EL VECTOR AL DATAGRID
                dataGridEmpleados.Rows.Add(nombres[i], salarios[i]);
                
                //CONDICONAL QUE GUARDA LA CANTIDAD DE PERSONAS CON SALARIO MENOR A $850
                if (salarios[i] < 850.0)
                {
                    salarioInferior = ++salarioInferior;
                    labelMenos.Text = salarioInferior.ToString();
                }
                //CONDICONAL QUE GUARDA LA CANTIDAD DE PERSONAS CON SALARIO ENTRE $850 Y $1500
                if (salarios[i] >= 850 && salarios[i] <= 1500.00)
                {
                    salarioEntre = ++salarioEntre;

                    labelEntre.Text = salarioEntre.ToString();
                }
                //CONDICONAL QUE GUARDA LA CANTIDAD DE PERSONAS CON SALARIO MAYOR A $1500
                if (salarios[i] > 1500.00)
                {
                    salarioSuperior += ++salarioSuperior;
                    labelMas.Text = salarioSuperior.ToString();

                }
            }

            //PORCENTAJE DE EMPLEADOS QUE TIENEN SALARIO MENOR A $850
            porcSalarioInferior = (salarioInferior*100)/7;
            //PORCENTAJE DE EMPLEADOS QUE TIENEN SALARIO ENTRE $850 Y $1500
            porcSalarioEntre = (salarioEntre*100)/ 7;
            //PORCENTAJE DE EMPLEADOS QUE TIENEN SALARIO MAYOR A $1500
            porcSalarioSuperior = (salarioSuperior*100) / 7;

            labelPocentajeInferior.Text = porcSalarioInferior.ToString();
            labelPorcentajeEntre.Text = porcSalarioEntre.ToString();
            labelPocentajeSuperior.Text = porcSalarioSuperior.ToString();





        }
    }
}
