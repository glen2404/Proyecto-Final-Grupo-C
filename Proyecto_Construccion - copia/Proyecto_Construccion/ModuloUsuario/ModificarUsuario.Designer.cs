namespace CapaVisual
{
    partial class ModificarUsuario
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
            dataGridView1 = new DataGridView();
            txtCedula = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            textBox8 = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1129, 242);
            dataGridView1.TabIndex = 0;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(319, 42);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(173, 27);
            txtCedula.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(519, 42);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(619, 42);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 3;
            button2.Text = "Mostrar Todos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(744, 42);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Seleccionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 403);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1158, 209);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar Usuario";
            // 
            // button4
            // 
            button4.Location = new Point(1064, 180);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 16;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(319, 155);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(210, 27);
            textBox8.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(214, 154);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 14;
            label9.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(655, 154);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 13;
            label7.Text = "Rol:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(649, 122);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 12;
            label6.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(650, 88);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 11;
            label5.Text = "Nombre de Usuario:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Usuario", "Administrador" });
            comboBox1.Location = new Point(804, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 28);
            comboBox1.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(804, 122);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(210, 27);
            textBox7.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(804, 85);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(210, 27);
            textBox6.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 55);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 121);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 55);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 4;
            label1.Text = "Cedula:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(804, 52);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(210, 27);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(319, 122);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 27);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(319, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 27);
            textBox2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(88, 41);
            label8.Name = "label8";
            label8.Size = new Size(205, 20);
            label8.TabIndex = 6;
            label8.Text = "Ingrese la Cedula del Usuario:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(txtCedula);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1158, 373);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Seleccionar Usuario";
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ModificarUsuario";
            Text = "Modificar Usuario";
            Load += ModificarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtCedula;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox7;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private GroupBox groupBox2;
        private TextBox textBox8;
        private Label label9;
        private Button button4;
    }
}