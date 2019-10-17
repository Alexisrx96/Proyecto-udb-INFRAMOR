namespace RegistroAlumnasInframor.Views
{
    partial class IniciarSesionView
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
            this.components = new System.ComponentModel.Container();
            this.txt_NomUsuario = new System.Windows.Forms.TextBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NomUsuario
            // 
            this.txt_NomUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NomUsuario.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_NomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NomUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txt_NomUsuario.Location = new System.Drawing.Point(253, 84);
            this.txt_NomUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NomUsuario.Name = "txt_NomUsuario";
            this.txt_NomUsuario.Size = new System.Drawing.Size(301, 15);
            this.txt_NomUsuario.TabIndex = 2;
            this.txt_NomUsuario.Text = "USUARIO";
            this.txt_NomUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NomUsuario.Enter += new System.EventHandler(this.Txt_NomUsuario_Enter);
            this.txt_NomUsuario.Leave += new System.EventHandler(this.Txt_NomUsuario_Leave);
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Contrasenia.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_Contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contrasenia.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Contrasenia.Location = new System.Drawing.Point(249, 186);
            this.txt_Contrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(297, 15);
            this.txt_Contrasenia.TabIndex = 3;
            this.txt_Contrasenia.Text = "CONTRASEÑA";
            this.txt_Contrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Contrasenia.Enter += new System.EventHandler(this.Txt_Contrasenia_Enter);
            this.txt_Contrasenia.Leave += new System.EventHandler(this.Txt_Contrasenia_Leave);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.sign_in2;
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Aceptar.FlatAppearance.BorderSize = 3;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.Location = new System.Drawing.Point(69, 297);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(175, 48);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.CLOSE;
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cerrar.Location = new System.Drawing.Point(359, 297);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(175, 48);
            this.btn_Cerrar.TabIndex = 5;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 16);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(1, 351);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 37);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.perfil_azul;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(107, 46);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 66);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.candado3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(107, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(596, 391);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 187;
            this.lineShape2.X2 = 409;
            this.lineShape2.Y1 = 170;
            this.lineShape2.Y2 = 170;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 190;
            this.lineShape1.X2 = 412;
            this.lineShape1.Y1 = 90;
            this.lineShape1.Y2 = 90;
            // 
            // IniciarSesionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.fondodefini;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 391);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_NomUsuario);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IniciarSesionView";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarSesionView";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txt_NomUsuario;
        public System.Windows.Forms.TextBox txt_Contrasenia;
        public System.Windows.Forms.Button btn_Aceptar;
        public System.Windows.Forms.Button btn_Cerrar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}