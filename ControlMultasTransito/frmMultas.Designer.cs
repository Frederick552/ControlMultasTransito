namespace ControlMultasTransito
{
    partial class frmMultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.lvMultas = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Registro de Multas de Transito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora Actual";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(603, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Frecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(603, 117);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 15);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero de placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(215, 77);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 23);
            this.txtPlaca.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Infraccion de Velocidad(Km/H)";
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(215, 102);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(100, 23);
            this.txtVelocidad.TabIndex = 8;
            // 
            // lvMultas
            // 
            this.lvMultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMultas.Location = new System.Drawing.Point(62, 170);
            this.lvMultas.Name = "lvMultas";
            this.lvMultas.Size = new System.Drawing.Size(603, 199);
            this.lvMultas.TabIndex = 9;
            this.lvMultas.UseCompatibleStateImageBehavior = false;
            this.lvMultas.View = System.Windows.Forms.View.Details;
            this.lvMultas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMultas_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Placa";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Velocidad(Km/H)";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hora";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Multa";
            this.columnHeader5.Width = 120;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(348, 109);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(486, 395);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(594, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lvMultas);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMultas";
            this.Text = "Control de Registro de Multas de Transito";
            this.Load += new System.EventHandler(this.frmMultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFecha;
        private Label label4;
        private Label lblHora;
        private Label label6;
        private TextBox txtPlaca;
        private Label label7;
        private TextBox txtVelocidad;
        private ListView lvMultas;
        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnSalir;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}