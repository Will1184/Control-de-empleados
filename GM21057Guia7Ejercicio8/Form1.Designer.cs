namespace GM21057Guia7Ejercicio8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSalir = new System.Windows.Forms.Button();
            this.dataGridEmpleados = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMas = new System.Windows.Forms.Label();
            this.labelEntre = new System.Windows.Forms.Label();
            this.labelMenos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPocentajeSuperior = new System.Windows.Forms.Label();
            this.labelPorcentajeEntre = new System.Windows.Forms.Label();
            this.labelPocentajeInferior = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(285, 104);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // dataGridEmpleados
            // 
            this.dataGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.salario});
            this.dataGridEmpleados.Location = new System.Drawing.Point(12, 12);
            this.dataGridEmpleados.Name = "dataGridEmpleados";
            this.dataGridEmpleados.RowTemplate.Height = 25;
            this.dataGridEmpleados.Size = new System.Drawing.Size(255, 224);
            this.dataGridEmpleados.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // salario
            // 
            this.salario.HeaderText = "Salario";
            this.salario.Name = "salario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMas);
            this.groupBox1.Controls.Add(this.labelEntre);
            this.groupBox1.Controls.Add(this.labelMenos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados que ganan";
            // 
            // labelMas
            // 
            this.labelMas.AutoSize = true;
            this.labelMas.Location = new System.Drawing.Point(161, 112);
            this.labelMas.Name = "labelMas";
            this.labelMas.Size = new System.Drawing.Size(0, 15);
            this.labelMas.TabIndex = 6;
            // 
            // labelEntre
            // 
            this.labelEntre.AutoSize = true;
            this.labelEntre.Location = new System.Drawing.Point(161, 66);
            this.labelEntre.Name = "labelEntre";
            this.labelEntre.Size = new System.Drawing.Size(0, 15);
            this.labelEntre.TabIndex = 5;
            // 
            // labelMenos
            // 
            this.labelMenos.AutoSize = true;
            this.labelMenos.Location = new System.Drawing.Point(161, 25);
            this.labelMenos.Name = "labelMenos";
            this.labelMenos.Size = new System.Drawing.Size(0, 15);
            this.labelMenos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mas de $1500";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entre $850 y $1500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menos de $850";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelPocentajeSuperior);
            this.groupBox2.Controls.Add(this.labelPorcentajeEntre);
            this.groupBox2.Controls.Add(this.labelPocentajeInferior);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(13, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 157);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Porcentaje de empleados con salario";
            // 
            // labelPocentajeSuperior
            // 
            this.labelPocentajeSuperior.AutoSize = true;
            this.labelPocentajeSuperior.Location = new System.Drawing.Point(171, 123);
            this.labelPocentajeSuperior.Name = "labelPocentajeSuperior";
            this.labelPocentajeSuperior.Size = new System.Drawing.Size(0, 15);
            this.labelPocentajeSuperior.TabIndex = 12;
            // 
            // labelPorcentajeEntre
            // 
            this.labelPorcentajeEntre.AutoSize = true;
            this.labelPorcentajeEntre.Location = new System.Drawing.Point(171, 77);
            this.labelPorcentajeEntre.Name = "labelPorcentajeEntre";
            this.labelPorcentajeEntre.Size = new System.Drawing.Size(0, 15);
            this.labelPorcentajeEntre.TabIndex = 11;
            // 
            // labelPocentajeInferior
            // 
            this.labelPocentajeInferior.AutoSize = true;
            this.labelPocentajeInferior.Location = new System.Drawing.Point(171, 36);
            this.labelPocentajeInferior.Name = "labelPocentajeInferior";
            this.labelPocentajeInferior.Size = new System.Drawing.Size(0, 15);
            this.labelPocentajeInferior.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mayor a $1500";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Entre $850 y $1500";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Menor a $850";
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(285, 58);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar.TabIndex = 13;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "% ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 584);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dataGridEmpleados);
            this.Name = "Form1";
            this.Text = "Control Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonSalir;
        private DataGridView dataGridEmpleados;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn salario;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label labelMas;
        private Label labelEntre;
        private Label labelMenos;
        private Label label3;
        private GroupBox groupBox2;
        private Label labelPocentajeSuperior;
        private Label labelPorcentajeEntre;
        private Label labelPocentajeInferior;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button buttonMostrar;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}