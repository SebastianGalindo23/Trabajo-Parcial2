namespace Parcial_2
{
    partial class Gestion_Alumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TablaEstudiantes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditarBoton = new System.Windows.Forms.Button();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Bienvenidalabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaEstudiantes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.TablaEstudiantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TablaEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TablaEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.TablaEstudiantes.Location = new System.Drawing.Point(283, 174);
            this.TablaEstudiantes.Name = "TablaEstudiantes";
            this.TablaEstudiantes.ReadOnly = true;
            this.TablaEstudiantes.RowHeadersWidth = 51;
            this.TablaEstudiantes.RowTemplate.Height = 24;
            this.TablaEstudiantes.Size = new System.Drawing.Size(1000, 409);
            this.TablaEstudiantes.TabIndex = 0;
            this.TablaEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaEstudiantes_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FechaNacimiento";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dirección";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Correo Electronico";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Numero Telefono";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Matricula";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // EditarBoton
            // 
            this.EditarBoton.Location = new System.Drawing.Point(39, 407);
            this.EditarBoton.Name = "EditarBoton";
            this.EditarBoton.Size = new System.Drawing.Size(200, 59);
            this.EditarBoton.TabIndex = 1;
            this.EditarBoton.Text = "Editar";
            this.EditarBoton.UseVisualStyleBackColor = true;
            this.EditarBoton.Click += new System.EventHandler(this.EditarBoton_Click);
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(39, 281);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(200, 59);
            this.AgregarBoton.TabIndex = 2;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1126, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Volver al inicio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bienvenidalabel
            // 
            this.Bienvenidalabel.AutoSize = true;
            this.Bienvenidalabel.BackColor = System.Drawing.Color.White;
            this.Bienvenidalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenidalabel.Location = new System.Drawing.Point(30, 40);
            this.Bienvenidalabel.Name = "Bienvenidalabel";
            this.Bienvenidalabel.Size = new System.Drawing.Size(700, 54);
            this.Bienvenidalabel.TabIndex = 4;
            this.Bienvenidalabel.Text = "Gestion de los Alumnos inscritos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(12, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 289);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Gestion_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1295, 630);
            this.Controls.Add(this.Bienvenidalabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.EditarBoton);
            this.Controls.Add(this.TablaEstudiantes);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Gestion_Alumnos";
            this.Text = "Gestion_Alumnos";
            this.Load += new System.EventHandler(this.Gestion_Alumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaEstudiantes;
        private System.Windows.Forms.Button EditarBoton;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Bienvenidalabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}