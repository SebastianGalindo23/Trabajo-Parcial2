namespace Parcial_2
{
    partial class FormRegistrarCurso
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
            this.btnRegistrarCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCapacidadMax = new System.Windows.Forms.TextBox();
            this.Bienvenidalabel = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarCurso
            // 
            this.btnRegistrarCurso.BackColor = System.Drawing.Color.Yellow;
            this.btnRegistrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCurso.Location = new System.Drawing.Point(569, 344);
            this.btnRegistrarCurso.Name = "btnRegistrarCurso";
            this.btnRegistrarCurso.Size = new System.Drawing.Size(194, 71);
            this.btnRegistrarCurso.TabIndex = 0;
            this.btnRegistrarCurso.Text = "Registrar Curso ";
            this.btnRegistrarCurso.UseVisualStyleBackColor = false;
            this.btnRegistrarCurso.Click += new System.EventHandler(this.btnRegistrarCurso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Curso ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreCurso.Location = new System.Drawing.Point(41, 146);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(236, 22);
            this.txtNombreCurso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo del Curso ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción del Curso ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de Inicio ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Fin ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Capacidad Maxima ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtCodigo.Location = new System.Drawing.Point(41, 218);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(236, 22);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescripcion.Location = new System.Drawing.Point(41, 287);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(236, 22);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtCapacidadMax
            // 
            this.txtCapacidadMax.BackColor = System.Drawing.SystemColors.Info;
            this.txtCapacidadMax.Location = new System.Drawing.Point(41, 354);
            this.txtCapacidadMax.Name = "txtCapacidadMax";
            this.txtCapacidadMax.Size = new System.Drawing.Size(236, 22);
            this.txtCapacidadMax.TabIndex = 12;
            this.txtCapacidadMax.TextChanged += new System.EventHandler(this.txtCapacidadMax_TextChanged);
            // 
            // Bienvenidalabel
            // 
            this.Bienvenidalabel.AutoSize = true;
            this.Bienvenidalabel.BackColor = System.Drawing.Color.White;
            this.Bienvenidalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenidalabel.Location = new System.Drawing.Point(12, 9);
            this.Bienvenidalabel.Name = "Bienvenidalabel";
            this.Bienvenidalabel.Size = new System.Drawing.Size(373, 54);
            this.Bienvenidalabel.TabIndex = 13;
            this.Bienvenidalabel.Text = "Creacion Cursos";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.txtFechaInicio.Location = new System.Drawing.Point(408, 146);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(236, 22);
            this.txtFechaInicio.TabIndex = 14;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.txtFechaFin.Location = new System.Drawing.Point(412, 218);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(236, 22);
            this.txtFechaFin.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(643, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 23;
            this.button1.Text = "Volver ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegistrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.Bienvenidalabel);
            this.Controls.Add(this.txtCapacidadMax);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarCurso);
            this.Name = "FormRegistrarCurso";
            this.Text = "FormRegistrarCurso";
            this.Load += new System.EventHandler(this.FormRegistrarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCapacidadMax;
        private System.Windows.Forms.Label Bienvenidalabel;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private System.Windows.Forms.DateTimePicker txtFechaFin;
        private System.Windows.Forms.Button button1;
    }
}