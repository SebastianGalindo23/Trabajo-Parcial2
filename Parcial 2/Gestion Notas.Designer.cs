namespace Parcial_2
{
    partial class Gestion_Notas
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TablaNotas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionarCursos = new System.Windows.Forms.DomainUpDown();
            this.SeleccionarAlumnos = new System.Windows.Forms.DomainUpDown();
            this.ReporteBoton = new System.Windows.Forms.Button();
            this.Notatxt = new System.Windows.Forms.TextBox();
            this.Tablapromedio = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablapromedio)).BeginInit();
            this.SuspendLayout();
            // 
            // Bienvenidalabel
            // 
            this.Bienvenidalabel.AutoSize = true;
            this.Bienvenidalabel.BackColor = System.Drawing.Color.White;
            this.Bienvenidalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenidalabel.Location = new System.Drawing.Point(12, 20);
            this.Bienvenidalabel.Name = "Bienvenidalabel";
            this.Bienvenidalabel.Size = new System.Drawing.Size(384, 54);
            this.Bienvenidalabel.TabIndex = 5;
            this.Bienvenidalabel.Text = "Gestion de Notas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(812, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Volver al inicio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(21, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(740, 44);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // TablaNotas
            // 
            this.TablaNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.TablaNotas.Location = new System.Drawing.Point(21, 187);
            this.TablaNotas.Name = "TablaNotas";
            this.TablaNotas.RowHeadersWidth = 51;
            this.TablaNotas.RowTemplate.Height = 24;
            this.TablaNotas.Size = new System.Drawing.Size(508, 251);
            this.TablaNotas.TabIndex = 8;
            this.TablaNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaNotas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Curso";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estudiante";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Valor";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // SeleccionarCursos
            // 
            this.SeleccionarCursos.BackColor = System.Drawing.SystemColors.Info;
            this.SeleccionarCursos.Location = new System.Drawing.Point(43, 126);
            this.SeleccionarCursos.Name = "SeleccionarCursos";
            this.SeleccionarCursos.Size = new System.Drawing.Size(145, 22);
            this.SeleccionarCursos.TabIndex = 38;
            this.SeleccionarCursos.Text = "Cursos";
            this.SeleccionarCursos.SelectedItemChanged += new System.EventHandler(this.SeleccionarCursos_SelectedItemChanged);
            // 
            // SeleccionarAlumnos
            // 
            this.SeleccionarAlumnos.BackColor = System.Drawing.SystemColors.Info;
            this.SeleccionarAlumnos.Location = new System.Drawing.Point(231, 126);
            this.SeleccionarAlumnos.Name = "SeleccionarAlumnos";
            this.SeleccionarAlumnos.Size = new System.Drawing.Size(145, 22);
            this.SeleccionarAlumnos.TabIndex = 39;
            this.SeleccionarAlumnos.Text = "Alumnos";
            // 
            // ReporteBoton
            // 
            this.ReporteBoton.BackColor = System.Drawing.Color.Yellow;
            this.ReporteBoton.Location = new System.Drawing.Point(533, 120);
            this.ReporteBoton.Name = "ReporteBoton";
            this.ReporteBoton.Size = new System.Drawing.Size(178, 33);
            this.ReporteBoton.TabIndex = 40;
            this.ReporteBoton.Text = "Agregar Reporte";
            this.ReporteBoton.UseVisualStyleBackColor = false;
            this.ReporteBoton.Click += new System.EventHandler(this.ReporteBoton_Click);
            // 
            // Notatxt
            // 
            this.Notatxt.Location = new System.Drawing.Point(403, 126);
            this.Notatxt.Name = "Notatxt";
            this.Notatxt.Size = new System.Drawing.Size(99, 22);
            this.Notatxt.TabIndex = 41;
            this.Notatxt.TextChanged += new System.EventHandler(this.Notatxt_TextChanged);
            // 
            // Tablapromedio
            // 
            this.Tablapromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablapromedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.Tablapromedio.Location = new System.Drawing.Point(554, 191);
            this.Tablapromedio.Name = "Tablapromedio";
            this.Tablapromedio.RowHeadersWidth = 51;
            this.Tablapromedio.RowTemplate.Height = 24;
            this.Tablapromedio.Size = new System.Drawing.Size(322, 247);
            this.Tablapromedio.TabIndex = 42;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cursos";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Promedios";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Gestion_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.Tablapromedio);
            this.Controls.Add(this.Notatxt);
            this.Controls.Add(this.ReporteBoton);
            this.Controls.Add(this.SeleccionarAlumnos);
            this.Controls.Add(this.SeleccionarCursos);
            this.Controls.Add(this.TablaNotas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bienvenidalabel);
            this.Name = "Gestion_Notas";
            this.Text = "Gestion_Notas";
            this.Load += new System.EventHandler(this.Gestion_Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablapromedio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenidalabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView TablaNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DomainUpDown SeleccionarCursos;
        private System.Windows.Forms.DomainUpDown SeleccionarAlumnos;
        private System.Windows.Forms.Button ReporteBoton;
        private System.Windows.Forms.TextBox Notatxt;
        private System.Windows.Forms.DataGridView Tablapromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}