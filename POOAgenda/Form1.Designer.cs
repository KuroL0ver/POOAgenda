namespace POOAgenda
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            TxtNombre = new TextBox();
            TxtTelefono = new TextBox();
            Agregar = new Button();
            DgvContactos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            TxtEmail = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvContactos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 192, 192);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(95, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 192, 192);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(92, 107);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            label2.TextChanged += Telefono;
            label2.Click += label2_Click;
            // 
            // TxtNombre
            // 
            TxtNombre.AccessibleRole = AccessibleRole.Client;
            TxtNombre.BackColor = Color.HotPink;
            TxtNombre.ForeColor = Color.Lime;
            TxtNombre.Location = new Point(227, 34);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(408, 27);
            TxtNombre.TabIndex = 2;
            // 
            // TxtTelefono
            // 
            TxtTelefono.BackColor = Color.HotPink;
            TxtTelefono.ForeColor = Color.DarkBlue;
            TxtTelefono.Location = new Point(227, 107);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(408, 27);
            TxtTelefono.TabIndex = 3;
            // 
            // Agregar
            // 
            Agregar.BackColor = Color.Gold;
            Agregar.ForeColor = Color.DarkOrchid;
            Agregar.Location = new Point(666, 175);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(94, 29);
            Agregar.TabIndex = 4;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            Agregar.Click += button1_Click_1;
            // 
            // DgvContactos
            // 
            DgvContactos.BackgroundColor = Color.SlateBlue;
            DgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvContactos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Email, Teléfono });
            DgvContactos.Location = new Point(210, 217);
            DgvContactos.Name = "DgvContactos";
            DgvContactos.RowHeadersWidth = 51;
            DgvContactos.Size = new Size(425, 235);
            DgvContactos.TabIndex = 5;
            DgvContactos.CellContentClick += DgvContactos_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Teléfono
            // 
            Teléfono.DataPropertyName = "Telefono";
            Teléfono.HeaderText = "Teléfono";
            Teléfono.MinimumWidth = 6;
            Teléfono.Name = "Teléfono";
            Teléfono.Width = 125;
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = Color.HotPink;
            TxtEmail.ForeColor = Color.DarkBlue;
            TxtEmail.Location = new Point(227, 175);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(408, 27);
            TxtEmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 192, 192);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(95, 184);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(label3);
            Controls.Add(TxtEmail);
            Controls.Add(DgvContactos);
            Controls.Add(Agregar);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Click += label2_Click;
            ((System.ComponentModel.ISupportInitialize)DgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNombre;
        private TextBox TxtTelefono;
        private Button Agregar;
        private Label label2;
        private DataGridView DgvContactos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Teléfono;
        private TextBox TxtEmail;
        private Label label3;
    }
}
