namespace Parcial_2
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.Bienvenidalabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GestionAlumnos = new System.Windows.Forms.Button();
            this.btnRegistrarProfesor = new System.Windows.Forms.Button();
            this.btnRegistrarCurso = new System.Windows.Forms.Button();
            this.GestionNotas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Bienvenidalabel
            // 
            this.Bienvenidalabel.AutoSize = true;
            this.Bienvenidalabel.BackColor = System.Drawing.Color.White;
            this.Bienvenidalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenidalabel.Location = new System.Drawing.Point(141, 19);
            this.Bienvenidalabel.Name = "Bienvenidalabel";
            this.Bienvenidalabel.Size = new System.Drawing.Size(237, 29);
            this.Bienvenidalabel.TabIndex = 0;
            this.Bienvenidalabel.Text = "Bienvenido de vuelta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(676, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 261);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(51, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 43);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = " Que desea Gestionar? ";
            // 
            // GestionAlumnos
            // 
            this.GestionAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionAlumnos.Location = new System.Drawing.Point(560, 144);
            this.GestionAlumnos.Name = "GestionAlumnos";
            this.GestionAlumnos.Size = new System.Drawing.Size(241, 44);
            this.GestionAlumnos.TabIndex = 7;
            this.GestionAlumnos.Text = "Gestionar Alumnos";
            this.GestionAlumnos.UseVisualStyleBackColor = true;
            this.GestionAlumnos.Click += new System.EventHandler(this.GestionAlumnos_Click);
            // 
            // btnRegistrarProfesor
            // 
            this.btnRegistrarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProfesor.Location = new System.Drawing.Point(560, 204);
            this.btnRegistrarProfesor.Name = "btnRegistrarProfesor";
            this.btnRegistrarProfesor.Size = new System.Drawing.Size(241, 44);
            this.btnRegistrarProfesor.TabIndex = 8;
            this.btnRegistrarProfesor.Text = "Gestionar Profesores";
            this.btnRegistrarProfesor.UseVisualStyleBackColor = true;
            this.btnRegistrarProfesor.Click += new System.EventHandler(this.GestionProfesores_Click);
            // 
            // btnRegistrarCurso
            // 
            this.btnRegistrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCurso.Location = new System.Drawing.Point(560, 265);
            this.btnRegistrarCurso.Name = "btnRegistrarCurso";
            this.btnRegistrarCurso.Size = new System.Drawing.Size(241, 44);
            this.btnRegistrarCurso.TabIndex = 9;
            this.btnRegistrarCurso.Text = "Gestionar Cursos";
            this.btnRegistrarCurso.UseVisualStyleBackColor = true;
            this.btnRegistrarCurso.Click += new System.EventHandler(this.btnRegistrarCurso_Click);
            // 
            // GestionNotas
            // 
            this.GestionNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionNotas.Location = new System.Drawing.Point(560, 327);
            this.GestionNotas.Name = "GestionNotas";
            this.GestionNotas.Size = new System.Drawing.Size(241, 44);
            this.GestionNotas.TabIndex = 10;
            this.GestionNotas.Text = "Gestionar Notas";
            this.GestionNotas.UseVisualStyleBackColor = true;
            this.GestionNotas.Click += new System.EventHandler(this.GestionNotas_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(839, 421);
            this.Controls.Add(this.GestionNotas);
            this.Controls.Add(this.btnRegistrarCurso);
            this.Controls.Add(this.btnRegistrarProfesor);
            this.Controls.Add(this.GestionAlumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bienvenidalabel);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenidalabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GestionAlumnos;
        private System.Windows.Forms.Button btnRegistrarProfesor;
        private System.Windows.Forms.Button btnRegistrarCurso;
        private System.Windows.Forms.Button GestionNotas;
    }
}