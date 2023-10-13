namespace Parcial_2
{
    partial class GestionCursos
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
            this.Bienvenidalabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.TablaCursos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.agrearalumnos = new System.Windows.Forms.Button();
            this.SeleccionarEstudiante = new System.Windows.Forms.DomainUpDown();
            this.SeleccionarCursos = new System.Windows.Forms.DomainUpDown();
            this.AgregarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // Bienvenidalabel
            // 
            this.Bienvenidalabel.AutoSize = true;
            this.Bienvenidalabel.BackColor = System.Drawing.Color.White;
            this.Bienvenidalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenidalabel.Location = new System.Drawing.Point(12, 9);
            this.Bienvenidalabel.Name = "Bienvenidalabel";
            this.Bienvenidalabel.Size = new System.Drawing.Size(483, 54);
            this.Bienvenidalabel.TabIndex = 5;
            this.Bienvenidalabel.Text = "Gestion de los Cursos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(21, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 289);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(48, 176);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(200, 59);
            this.AgregarBoton.TabIndex = 8;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // TablaCursos
            // 
            this.TablaCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.TablaCursos.Location = new System.Drawing.Point(311, 126);
            this.TablaCursos.Name = "TablaCursos";
            this.TablaCursos.RowHeadersWidth = 51;
            this.TablaCursos.RowTemplate.Height = 24;
            this.TablaCursos.Size = new System.Drawing.Size(764, 289);
            this.TablaCursos.TabIndex = 9;
            this.TablaCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaCursos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha Inicio";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Fecha Fin";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Capacidad";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ProfesorAsignado";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(941, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver al inicio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // agrearalumnos
            // 
            this.agrearalumnos.Location = new System.Drawing.Point(48, 288);
            this.agrearalumnos.Name = "agrearalumnos";
            this.agrearalumnos.Size = new System.Drawing.Size(200, 59);
            this.agrearalumnos.TabIndex = 11;
            this.agrearalumnos.Text = "Agregar Alumnos al curso";
            this.agrearalumnos.UseVisualStyleBackColor = true;
            this.agrearalumnos.Click += new System.EventHandler(this.agrearalumnos_Click);
            // 
            // SeleccionarEstudiante
            // 
            this.SeleccionarEstudiante.Location = new System.Drawing.Point(48, 453);
            this.SeleccionarEstudiante.Name = "SeleccionarEstudiante";
            this.SeleccionarEstudiante.Size = new System.Drawing.Size(145, 22);
            this.SeleccionarEstudiante.TabIndex = 38;
            this.SeleccionarEstudiante.Text = "Estudiante";
            this.SeleccionarEstudiante.Visible = false;
            this.SeleccionarEstudiante.SelectedItemChanged += new System.EventHandler(this.SeleccionarEstudiante_SelectedItemChanged);
            // 
            // SeleccionarCursos
            // 
            this.SeleccionarCursos.Location = new System.Drawing.Point(239, 453);
            this.SeleccionarCursos.Name = "SeleccionarCursos";
            this.SeleccionarCursos.Size = new System.Drawing.Size(145, 22);
            this.SeleccionarCursos.TabIndex = 39;
            this.SeleccionarCursos.Text = "Cursos";
            this.SeleccionarCursos.Visible = false;
            this.SeleccionarCursos.SelectedItemChanged += new System.EventHandler(this.SeleccionarCursos_SelectedItemChanged);
            // 
            // AgregarCurso
            // 
            this.AgregarCurso.BackColor = System.Drawing.Color.Yellow;
            this.AgregarCurso.Location = new System.Drawing.Point(421, 439);
            this.AgregarCurso.Name = "AgregarCurso";
            this.AgregarCurso.Size = new System.Drawing.Size(174, 49);
            this.AgregarCurso.TabIndex = 40;
            this.AgregarCurso.Text = "Agregar al Curso";
            this.AgregarCurso.UseVisualStyleBackColor = false;
            this.AgregarCurso.Visible = false;
            this.AgregarCurso.Click += new System.EventHandler(this.AgregarCurso_Click);
            // 
            // GestionCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1098, 550);
            this.Controls.Add(this.AgregarCurso);
            this.Controls.Add(this.SeleccionarCursos);
            this.Controls.Add(this.SeleccionarEstudiante);
            this.Controls.Add(this.agrearalumnos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablaCursos);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Bienvenidalabel);
            this.Name = "GestionCursos";
            this.Text = "GestionCursos";
            this.Load += new System.EventHandler(this.GestionCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenidalabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.DataGridView TablaCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button agrearalumnos;
        private System.Windows.Forms.DomainUpDown SeleccionarEstudiante;
        private System.Windows.Forms.DomainUpDown SeleccionarCursos;
        private System.Windows.Forms.Button AgregarCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}