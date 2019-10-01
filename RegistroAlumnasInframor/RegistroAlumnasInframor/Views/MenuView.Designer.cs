namespace RegistroAlumnasInframor.Views
{
    partial class MenuView
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
            this.btn_Alumnas = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pxventanas = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pxclose = new System.Windows.Forms.PictureBox();
            this.pxminimizar = new System.Windows.Forms.PictureBox();
            this.btn_Creditos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxventanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Alumnas
            // 
            this.btn_Alumnas.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.alumna;
            this.btn_Alumnas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Alumnas.Location = new System.Drawing.Point(132, 238);
            this.btn_Alumnas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Alumnas.Name = "btn_Alumnas";
            this.btn_Alumnas.Size = new System.Drawing.Size(103, 91);
            this.btn_Alumnas.TabIndex = 0;
            this.btn_Alumnas.Text = "Alumnas";
            this.btn_Alumnas.UseVisualStyleBackColor = true;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.ADMINUSUARIO;
            this.btn_Usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Usuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Usuarios.Location = new System.Drawing.Point(132, 400);
            this.btn_Usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(103, 91);
            this.btn_Usuarios.TabIndex = 1;
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.CLOSEE;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Location = new System.Drawing.Point(347, 400);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(103, 91);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pxventanas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pxclose);
            this.panel1.Controls.Add(this.pxminimizar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 31);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pxventanas
            // 
            this.pxventanas.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.VENTANAS;
            this.pxventanas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxventanas.Location = new System.Drawing.Point(497, -2);
            this.pxventanas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxventanas.Name = "pxventanas";
            this.pxventanas.Size = new System.Drawing.Size(37, 27);
            this.pxventanas.TabIndex = 4;
            this.pxventanas.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "MENÚ...";
            // 
            // pxclose
            // 
            this.pxclose.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.CLOSEVERDAD;
            this.pxclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxclose.Location = new System.Drawing.Point(543, 0);
            this.pxclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxclose.Name = "pxclose";
            this.pxclose.Size = new System.Drawing.Size(29, 25);
            this.pxclose.TabIndex = 2;
            this.pxclose.TabStop = false;
            // 
            // pxminimizar
            // 
            this.pxminimizar.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.MINIVERDAD;
            this.pxminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxminimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxminimizar.Location = new System.Drawing.Point(460, 0);
            this.pxminimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxminimizar.Name = "pxminimizar";
            this.pxminimizar.Size = new System.Drawing.Size(29, 24);
            this.pxminimizar.TabIndex = 0;
            this.pxminimizar.TabStop = false;
            // 
            // btn_Creditos
            // 
            this.btn_Creditos.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.CREDITOS;
            this.btn_Creditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Creditos.Location = new System.Drawing.Point(347, 234);
            this.btn_Creditos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Creditos.Name = "btn_Creditos";
            this.btn_Creditos.Size = new System.Drawing.Size(103, 91);
            this.btn_Creditos.TabIndex = 2;
            this.btn_Creditos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.infra2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(209, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 165);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "CREAR ALUMNA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = " CRÉDITOS";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 494);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "VER USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 494);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SALIR";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(0, 586);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 17);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Location = new System.Drawing.Point(1, 566);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 20);
            this.panel3.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.fondo_layout;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(71, 213);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(445, 317);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.fondo_layout;
            this.ClientSize = new System.Drawing.Size(576, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Creditos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Usuarios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Alumnas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxventanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Alumnas;
        public System.Windows.Forms.Button btn_Usuarios;
        public System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_Creditos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.PictureBox pxclose;
        public System.Windows.Forms.PictureBox pxminimizar;
        public System.Windows.Forms.PictureBox pxventanas;
    }
}