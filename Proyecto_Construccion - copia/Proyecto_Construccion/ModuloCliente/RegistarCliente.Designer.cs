namespace CapaVisual
{
    partial class RegistrarCliente
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
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(371, 97);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(285, 27);
            txtCedula.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(371, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(371, 172);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(285, 27);
            txtApellido.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(371, 212);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(285, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(371, 252);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(285, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(371, 292);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(285, 27);
            txtDireccion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 64);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 7;
            label1.Text = "Ingrese los Datos del Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 97);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 8;
            label2.Text = "Cedula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 132);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 9;
            label3.Text = "Nombres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 172);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Apellidos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 212);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 252);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 12;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 292);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 13;
            label7.Text = "Direccion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(215, 332);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 14;
            label8.Text = "Fecha:";
            // 
            // button1
            // 
            button1.Location = new Point(215, 384);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 15;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(371, 384);
            button2.Name = "button2";
            button2.Size = new Size(150, 30);
            button2.TabIndex = 16;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(371, 332);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(285, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Name = "RegistrarCliente";
            Text = "Registrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCedula;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
    }
}