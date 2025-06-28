namespace Sistema_Mascotas
{
    partial class DuenosForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            btn_agregar = new Button();
            dataGridViewDueños = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            btn_Mascotas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDueños).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 83);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 15;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 54);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 14;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(132, 80);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(188, 23);
            txtTelefono.TabIndex = 12;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(132, 51);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(188, 23);
            txtDireccion.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 10;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(56, 121);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(138, 32);
            btn_agregar.TabIndex = 9;
            btn_agregar.Text = "Agregar Dueño";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // dataGridViewDueños
            // 
            dataGridViewDueños.AllowUserToAddRows = false;
            dataGridViewDueños.AllowUserToDeleteRows = false;
            dataGridViewDueños.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDueños.Columns.AddRange(new DataGridViewColumn[] { nombre, direccion, telefono });
            dataGridViewDueños.Location = new Point(56, 171);
            dataGridViewDueños.Name = "dataGridViewDueños";
            dataGridViewDueños.ReadOnly = true;
            dataGridViewDueños.RowTemplate.Height = 25;
            dataGridViewDueños.Size = new Size(689, 257);
            dataGridViewDueños.TabIndex = 8;
            // 
            // nombre
            // 
            nombre.HeaderText = "NOMBRE";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.HeaderText = "DIRECCION";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.HeaderText = "TELEFONO";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // btn_Mascotas
            // 
            btn_Mascotas.Location = new Point(612, 12);
            btn_Mascotas.Name = "btn_Mascotas";
            btn_Mascotas.Size = new Size(133, 46);
            btn_Mascotas.TabIndex = 16;
            btn_Mascotas.Text = "Modulo de Mascotas";
            btn_Mascotas.UseVisualStyleBackColor = true;
            btn_Mascotas.Click += btn_Mascotas_Click;
            // 
            // DuenosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Mascotas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(btn_agregar);
            Controls.Add(dataGridViewDueños);
            Name = "DuenosForm";
            Text = "DuenosForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDueños).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Button btn_agregar;
        private DataGridView dataGridViewDueños;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private Button btn_Mascotas;
    }
}