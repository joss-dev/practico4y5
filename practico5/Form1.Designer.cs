namespace practico5
{
    partial class form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form5));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            btnFoto = new Button();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            RMujer = new RadioButton();
            RHombre = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            DataGridPersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridPersonas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fondo;
            pictureBox1.Location = new Point(-5, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 560);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.fondopaneljpg;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnFoto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(RMujer);
            panel1.Controls.Add(RHombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(86, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 322);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(156, 261);
            button1.Name = "button1";
            button1.Size = new Size(81, 48);
            button1.TabIndex = 13;
            button1.Text = "Guardar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(66, 211);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(73, 23);
            btnFoto.TabIndex = 12;
            btnFoto.Text = "Foto";
            btnFoto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(66, 167);
            label5.Name = "label5";
            label5.Size = new Size(64, 22);
            label5.TabIndex = 11;
            label5.Text = "Saldo : ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(239, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(84, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // RMujer
            // 
            RMujer.AutoSize = true;
            RMujer.BackColor = Color.Transparent;
            RMujer.ForeColor = SystemColors.ButtonFace;
            RMujer.Location = new Point(214, 134);
            RMujer.Name = "RMujer";
            RMujer.Size = new Size(56, 19);
            RMujer.TabIndex = 9;
            RMujer.TabStop = true;
            RMujer.Text = "Mujer";
            RMujer.UseVisualStyleBackColor = false;
            // 
            // RHombre
            // 
            RHombre.AutoSize = true;
            RHombre.BackColor = Color.Transparent;
            RHombre.ForeColor = SystemColors.ButtonFace;
            RHombre.Location = new Point(136, 134);
            RHombre.Name = "RHombre";
            RHombre.Size = new Size(69, 19);
            RHombre.TabIndex = 8;
            RHombre.TabStop = true;
            RHombre.Text = "Hombre";
            RHombre.UseVisualStyleBackColor = false;
            RHombre.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(66, 131);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 7;
            label4.Text = "Sexo : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(66, 97);
            label3.Name = "label3";
            label3.Size = new Size(176, 22);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Nacimiento : ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(66, 51);
            label2.Name = "label2";
            label2.Size = new Size(86, 22);
            label2.TabIndex = 5;
            label2.Text = "Apellido : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(66, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 4;
            label1.Text = "Nombre : ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.silueta;
            pictureBox2.Location = new Point(506, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 322);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // DataGridPersonas
            // 
            DataGridPersonas.AllowUserToOrderColumns = true;
            DataGridPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridPersonas.Location = new Point(12, 399);
            DataGridPersonas.Name = "DataGridPersonas";
            DataGridPersonas.RowTemplate.Height = 25;
            DataGridPersonas.Size = new Size(776, 150);
            DataGridPersonas.TabIndex = 3;
            // 
            // form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(DataGridPersonas);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "form5";
            Text = "formulario dataGrid";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private RadioButton RHombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton RMujer;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button btnFoto;
        private Button button1;
        private PictureBox pictureBox2;
        private DataGridView DataGridPersonas;
    }
}