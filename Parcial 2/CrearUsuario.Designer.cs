namespace Parcial_2
{
    partial class CrearUsuario
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
            this.Nombretext = new System.Windows.Forms.TextBox();
            this.Apellidotext = new System.Windows.Forms.TextBox();
            this.Direcciontext = new System.Windows.Forms.TextBox();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.Fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.Numerotext = new System.Windows.Forms.TextBox();
            this.Correotext = new System.Windows.Forms.TextBox();
            this.crearboton = new System.Windows.Forms.Button();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.Apellidolabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Direccionlabel = new System.Windows.Forms.Label();
            this.Idlabel = new System.Windows.Forms.Label();
            this.Telefonolabel = new System.Windows.Forms.Label();
            this.Correolabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bienvenidalabel
            // 
            this.Bienvenidalabel.AutoSize = true;
            this.Bienvenidalabel.BackColor = System.Drawing.Color.White;
            this.Bienvenidalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenidalabel.Location = new System.Drawing.Point(32, 30);
            this.Bienvenidalabel.Name = "Bienvenidalabel";
            this.Bienvenidalabel.Size = new System.Drawing.Size(468, 54);
            this.Bienvenidalabel.TabIndex = 5;
            this.Bienvenidalabel.Text = "Creacion Estudiantes";
            // 
            // Nombretext
            // 
            this.Nombretext.BackColor = System.Drawing.SystemColors.Info;
            this.Nombretext.Location = new System.Drawing.Point(41, 157);
            this.Nombretext.Name = "Nombretext";
            this.Nombretext.Size = new System.Drawing.Size(235, 22);
            this.Nombretext.TabIndex = 6;
            // 
            // Apellidotext
            // 
            this.Apellidotext.BackColor = System.Drawing.SystemColors.Info;
            this.Apellidotext.Location = new System.Drawing.Point(41, 222);
            this.Apellidotext.Name = "Apellidotext";
            this.Apellidotext.Size = new System.Drawing.Size(235, 22);
            this.Apellidotext.TabIndex = 7;
            // 
            // Direcciontext
            // 
            this.Direcciontext.BackColor = System.Drawing.SystemColors.Info;
            this.Direcciontext.Location = new System.Drawing.Point(41, 362);
            this.Direcciontext.Name = "Direcciontext";
            this.Direcciontext.Size = new System.Drawing.Size(235, 22);
            this.Direcciontext.TabIndex = 8;
            // 
            // Idtext
            // 
            this.Idtext.BackColor = System.Drawing.SystemColors.Info;
            this.Idtext.Location = new System.Drawing.Point(41, 434);
            this.Idtext.Name = "Idtext";
            this.Idtext.Size = new System.Drawing.Size(235, 22);
            this.Idtext.TabIndex = 10;
            this.Idtext.TextChanged += new System.EventHandler(this.Idtext_TextChanged);
            // 
            // Fechanacimiento
            // 
            this.Fechanacimiento.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.Fechanacimiento.Location = new System.Drawing.Point(41, 290);
            this.Fechanacimiento.Name = "Fechanacimiento";
            this.Fechanacimiento.Size = new System.Drawing.Size(235, 22);
            this.Fechanacimiento.TabIndex = 11;
            this.Fechanacimiento.ValueChanged += new System.EventHandler(this.Fechanacimiento_ValueChanged);
            // 
            // Numerotext
            // 
            this.Numerotext.BackColor = System.Drawing.SystemColors.Info;
            this.Numerotext.Location = new System.Drawing.Point(332, 155);
            this.Numerotext.Name = "Numerotext";
            this.Numerotext.Size = new System.Drawing.Size(235, 22);
            this.Numerotext.TabIndex = 12;
            this.Numerotext.TextChanged += new System.EventHandler(this.Numerotext_TextChanged);
            // 
            // Correotext
            // 
            this.Correotext.BackColor = System.Drawing.SystemColors.Info;
            this.Correotext.Location = new System.Drawing.Point(332, 222);
            this.Correotext.Name = "Correotext";
            this.Correotext.Size = new System.Drawing.Size(235, 22);
            this.Correotext.TabIndex = 13;
            // 
            // crearboton
            // 
            this.crearboton.BackColor = System.Drawing.Color.Yellow;
            this.crearboton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearboton.Location = new System.Drawing.Point(358, 290);
            this.crearboton.Name = "crearboton";
            this.crearboton.Size = new System.Drawing.Size(177, 54);
            this.crearboton.TabIndex = 14;
            this.crearboton.Text = "Crear";
            this.crearboton.UseVisualStyleBackColor = false;
            this.crearboton.Click += new System.EventHandler(this.crearboton_Click);
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.BackColor = System.Drawing.Color.White;
            this.Nombrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelabel.Location = new System.Drawing.Point(41, 122);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(73, 22);
            this.Nombrelabel.TabIndex = 15;
            this.Nombrelabel.Text = "Nombre";
            // 
            // Apellidolabel
            // 
            this.Apellidolabel.AutoSize = true;
            this.Apellidolabel.BackColor = System.Drawing.Color.White;
            this.Apellidolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidolabel.Location = new System.Drawing.Point(41, 191);
            this.Apellidolabel.Name = "Apellidolabel";
            this.Apellidolabel.Size = new System.Drawing.Size(74, 22);
            this.Apellidolabel.TabIndex = 16;
            this.Apellidolabel.Text = "Apellido";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.BackColor = System.Drawing.Color.White;
            this.Fechalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalabel.Location = new System.Drawing.Point(42, 256);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(154, 22);
            this.Fechalabel.TabIndex = 17;
            this.Fechalabel.Text = "Fecha Nacimiento";
            // 
            // Direccionlabel
            // 
            this.Direccionlabel.AutoSize = true;
            this.Direccionlabel.BackColor = System.Drawing.Color.White;
            this.Direccionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccionlabel.Location = new System.Drawing.Point(42, 327);
            this.Direccionlabel.Name = "Direccionlabel";
            this.Direccionlabel.Size = new System.Drawing.Size(85, 22);
            this.Direccionlabel.TabIndex = 18;
            this.Direccionlabel.Text = "Direccion";
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.BackColor = System.Drawing.Color.White;
            this.Idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idlabel.Location = new System.Drawing.Point(42, 398);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(42, 22);
            this.Idlabel.TabIndex = 19;
            this.Idlabel.Text = "I. D.";
            // 
            // Telefonolabel
            // 
            this.Telefonolabel.AutoSize = true;
            this.Telefonolabel.BackColor = System.Drawing.Color.White;
            this.Telefonolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonolabel.Location = new System.Drawing.Point(331, 122);
            this.Telefonolabel.Name = "Telefonolabel";
            this.Telefonolabel.Size = new System.Drawing.Size(81, 22);
            this.Telefonolabel.TabIndex = 20;
            this.Telefonolabel.Text = "Telefono";
            // 
            // Correolabel
            // 
            this.Correolabel.AutoSize = true;
            this.Correolabel.BackColor = System.Drawing.Color.White;
            this.Correolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correolabel.Location = new System.Drawing.Point(331, 191);
            this.Correolabel.Name = "Correolabel";
            this.Correolabel.Size = new System.Drawing.Size(65, 22);
            this.Correolabel.TabIndex = 21;
            this.Correolabel.Text = "Correo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(782, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 22;
            this.button1.Text = "Volver ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(939, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Correolabel);
            this.Controls.Add(this.Telefonolabel);
            this.Controls.Add(this.Idlabel);
            this.Controls.Add(this.Direccionlabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Apellidolabel);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.crearboton);
            this.Controls.Add(this.Correotext);
            this.Controls.Add(this.Numerotext);
            this.Controls.Add(this.Fechanacimiento);
            this.Controls.Add(this.Idtext);
            this.Controls.Add(this.Direcciontext);
            this.Controls.Add(this.Apellidotext);
            this.Controls.Add(this.Nombretext);
            this.Controls.Add(this.Bienvenidalabel);
            this.Name = "CrearUsuario";
            this.Text = "CrearUsuario";
            this.Load += new System.EventHandler(this.CrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenidalabel;
        private System.Windows.Forms.TextBox Nombretext;
        private System.Windows.Forms.TextBox Apellidotext;
        private System.Windows.Forms.TextBox Direcciontext;
        private System.Windows.Forms.TextBox Idtext;
        private System.Windows.Forms.DateTimePicker Fechanacimiento;
        private System.Windows.Forms.TextBox Numerotext;
        private System.Windows.Forms.TextBox Correotext;
        private System.Windows.Forms.Button crearboton;
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label Apellidolabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label Direccionlabel;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Label Telefonolabel;
        private System.Windows.Forms.Label Correolabel;
        private System.Windows.Forms.Button button1;
    }
}