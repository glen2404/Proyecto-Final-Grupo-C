namespace CapaVisual
{
    partial class RegistrarUsuario
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
            button1 = new Button();
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtNombreUsuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtContrasenia = new TextBox();
            label7 = new Label();
            button2 = new Button();
            cb1 = new ComboBox();
            txtApellido = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtTelefono = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(249, 375);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 0;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(427, 96);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(151, 27);
            txtCedula.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(427, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 96);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 3;
            label1.Text = "Cedula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 130);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombres:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(427, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(427, 270);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(151, 27);
            txtNombreUsuario.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 235);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 305);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 8;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 340);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 9;
            label5.Text = "Rol:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 63);
            label6.Name = "label6";
            label6.Size = new Size(205, 20);
            label6.TabIndex = 10;
            label6.Text = "Ingrese los Datos del Usuario:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(427, 305);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(151, 27);
            txtContrasenia.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 270);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 12;
            label7.Text = "Nombre de Usuario:";
            // 
            // button2
            // 
            button2.Location = new Point(427, 375);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Usuario", "Administrador" });
            cb1.Location = new Point(427, 340);
            cb1.Name = "cb1";
            cb1.Size = new Size(151, 28);
            cb1.TabIndex = 14;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(427, 165);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(151, 27);
            txtApellido.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(249, 165);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 16;
            label8.Text = "Apellidos:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(249, 200);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 17;
            label9.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(427, 200);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(154, 27);
            txtTelefono.TabIndex = 18;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelefono);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtApellido);
            Controls.Add(cb1);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(txtContrasenia);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(txtCedula);
            Controls.Add(button1);
            Name = "RegistrarUsuario";
            Text = "Registrar Usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtCedula;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtNombreUsuario;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtContrasenia;
        private Label label7;
        private Button button2;
        private ComboBox cb1;
        private TextBox txtApellido;
        private Label label8;
        private Label label9;
        private TextBox txtTelefono;
    }
}