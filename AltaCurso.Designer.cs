namespace proyecto_base
{
    partial class AltaCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroCurso = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionCurso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroCarrera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarCarrera = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.grillaAlumnos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdPersona = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de nuevo curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(700, 29);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nro de curso:";
            // 
            // txtNumeroCurso
            // 
            this.txtNumeroCurso.Enabled = false;
            this.txtNumeroCurso.Location = new System.Drawing.Point(90, 84);
            this.txtNumeroCurso.Name = "txtNumeroCurso";
            this.txtNumeroCurso.Size = new System.Drawing.Size(65, 20);
            this.txtNumeroCurso.TabIndex = 4;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(600, 84);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(65, 20);
            this.txtNombreCurso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre:";
            // 
            // txtDescripcionCurso
            // 
            this.txtDescripcionCurso.Location = new System.Drawing.Point(282, 84);
            this.txtDescripcionCurso.Name = "txtDescripcionCurso";
            this.txtDescripcionCurso.Size = new System.Drawing.Size(169, 20);
            this.txtDescripcionCurso.TabIndex = 8;
            this.txtDescripcionCurso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descripcion:";
            // 
            // txtNumeroCarrera
            // 
            this.txtNumeroCarrera.Location = new System.Drawing.Point(247, 127);
            this.txtNumeroCarrera.Name = "txtNumeroCarrera";
            this.txtNumeroCarrera.Size = new System.Drawing.Size(35, 20);
            this.txtNumeroCarrera.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nro de carrera:";
            // 
            // btnBuscarCarrera
            // 
            this.btnBuscarCarrera.Location = new System.Drawing.Point(309, 125);
            this.btnBuscarCarrera.Name = "btnBuscarCarrera";
            this.btnBuscarCarrera.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCarrera.TabIndex = 11;
            this.btnBuscarCarrera.Text = "Buscar";
            this.btnBuscarCarrera.UseVisualStyleBackColor = true;
            this.btnBuscarCarrera.Click += new System.EventHandler(this.btnBuscarCarrera_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(401, 128);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(183, 20);
            this.txtCarrera.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdPersona);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.grillaAlumnos);
            this.groupBox1.Controls.Add(this.btnAgregarAlumno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtApellidoAlumno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNombreAlumno);
            this.groupBox1.Controls.Add(this.btnBuscarAlumno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 373);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos del curso";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(388, 23);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(111, 20);
            this.txtNombreAlumno.TabIndex = 17;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(243, 21);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumno.TabIndex = 16;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(91, 21);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(133, 20);
            this.txtDni.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dni de alumno: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Apellido:";
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(587, 26);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(111, 20);
            this.txtApellidoAlumno.TabIndex = 19;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(587, 70);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(111, 43);
            this.btnAgregarAlumno.TabIndex = 21;
            this.btnAgregarAlumno.Text = "Agregar alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // grillaAlumnos
            // 
            this.grillaAlumnos.AllowUserToAddRows = false;
            this.grillaAlumnos.AllowUserToDeleteRows = false;
            this.grillaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Documento,
            this.Nombre,
            this.Apellido});
            this.grillaAlumnos.Location = new System.Drawing.Point(20, 95);
            this.grillaAlumnos.Name = "grillaAlumnos";
            this.grillaAlumnos.ReadOnly = true;
            this.grillaAlumnos.Size = new System.Drawing.Size(515, 160);
            this.grillaAlumnos.TabIndex = 22;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(449, 282);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 42);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar Curso";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Id persona: ";
            // 
            // txtIdPersona
            // 
            this.txtIdPersona.Enabled = false;
            this.txtIdPersona.Location = new System.Drawing.Point(445, 59);
            this.txtIdPersona.Name = "txtIdPersona";
            this.txtIdPersona.Size = new System.Drawing.Size(54, 20);
            this.txtIdPersona.TabIndex = 25;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 200;
            // 
            // AltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.btnBuscarCarrera);
            this.Controls.Add(this.txtNumeroCarrera);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcionCurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de nuevo curso";
            this.Load += new System.EventHandler(this.AltaCurso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumeroCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionCurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView grillaAlumnos;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtIdPersona;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
    }
}