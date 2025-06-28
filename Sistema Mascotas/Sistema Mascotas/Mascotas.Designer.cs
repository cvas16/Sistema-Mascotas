namespace Sistema_Mascotas
{
    partial class Mascotas
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
            txtRaza = new TextBox();
            txtNombre = new TextBox();
            btn_agregar = new Button();
            dataGridViewMascotas = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            raza = new DataGridViewTextBoxColumn();
            dueno = new DataGridViewTextBoxColumn();
            label4 = new Label();
            cmbDueño = new ComboBox();
            btn_duenos = new Button();
            txtEdad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMascotas).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 83);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 23;
            label3.Text = "Raza:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 54);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 22;
            label2.Text = "Edad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 21;
            label1.Text = "Nombre:";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(132, 80);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(188, 23);
            txtRaza.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 18;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(56, 143);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(138, 32);
            btn_agregar.TabIndex = 17;
            btn_agregar.Text = "Agregar Mascota";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // dataGridViewMascotas
            // 
            dataGridViewMascotas.AllowUserToAddRows = false;
            dataGridViewMascotas.AllowUserToDeleteRows = false;
            dataGridViewMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMascotas.Columns.AddRange(new DataGridViewColumn[] { nombre, edad, raza, dueno });
            dataGridViewMascotas.Location = new Point(56, 181);
            dataGridViewMascotas.Name = "dataGridViewMascotas";
            dataGridViewMascotas.ReadOnly = true;
            dataGridViewMascotas.RowTemplate.Height = 25;
            dataGridViewMascotas.Size = new Size(689, 257);
            dataGridViewMascotas.TabIndex = 16;
            // 
            // nombre
            // 
            nombre.HeaderText = "NOMBRE";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // edad
            // 
            edad.HeaderText = "EDAD";
            edad.Name = "edad";
            edad.ReadOnly = true;
            // 
            // raza
            // 
            raza.HeaderText = "RAZA";
            raza.Name = "raza";
            raza.ReadOnly = true;
            // 
            // dueno
            // 
            dueno.HeaderText = "DUEÑO";
            dueno.Name = "dueno";
            dueno.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 115);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 24;
            label4.Text = "Dueño:";
            // 
            // cmbDueño
            // 
            cmbDueño.FormattingEnabled = true;
            cmbDueño.Location = new Point(132, 112);
            cmbDueño.Name = "cmbDueño";
            cmbDueño.Size = new Size(188, 23);
            cmbDueño.TabIndex = 25;
            // 
            // btn_duenos
            // 
            btn_duenos.Location = new Point(612, 22);
            btn_duenos.Name = "btn_duenos";
            btn_duenos.Size = new Size(133, 46);
            btn_duenos.TabIndex = 27;
            btn_duenos.Text = "Modulo Dueños";
            btn_duenos.UseVisualStyleBackColor = true;
            btn_duenos.Click += btn_duenos_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(132, 52);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(188, 23);
            txtEdad.TabIndex = 28;
            // 
            // Mascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEdad);
            Controls.Add(btn_duenos);
            Controls.Add(cmbDueño);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(btn_agregar);
            Controls.Add(dataGridViewMascotas);
            Name = "Mascotas";
            Text = "Mascotas";
            Load += Marcotas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private Button btn_agregar;
        private DataGridView dataGridViewMascotas;
        private Label label4;
        private ComboBox cmbDueño;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn raza;
        private DataGridViewTextBoxColumn dueno;
        private Button btn_duenos;
        private TextBox txtEdad;
    }
}