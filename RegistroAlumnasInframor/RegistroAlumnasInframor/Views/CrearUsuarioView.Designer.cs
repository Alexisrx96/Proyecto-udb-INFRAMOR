namespace RegistroAlumnasInframor.Views
{
    partial class CrearUsuarioView
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nomUsuario = new System.Windows.Forms.Label();
            this.lbl_Contrasenia = new System.Windows.Forms.Label();
            this.lbl_confirmar = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nomUsuario = new System.Windows.Forms.TextBox();
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pxclose = new System.Windows.Forms.PictureBox();
            this.pxventanas = new System.Windows.Forms.PictureBox();
            this.pxminimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxventanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxminimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.CLOSE1;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Location = new System.Drawing.Point(443, 465);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(145, 52);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_crear
            // 
            this.btn_crear.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.LOG_OUT;
            this.btn_crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_crear.Location = new System.Drawing.Point(97, 465);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(145, 52);
            this.btn_crear.TabIndex = 6;
            this.btn_crear.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 123);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.splitContainer1.Panel1.Controls.Add(this.lbl_nombre);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_apellido);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_nomUsuario);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Contrasenia);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_confirmar);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Panel2.Controls.Add(this.txt_nombre);
            this.splitContainer1.Panel2.Controls.Add(this.txt_apellido);
            this.splitContainer1.Panel2.Controls.Add(this.txt_nomUsuario);
            this.splitContainer1.Panel2.Controls.Add(this.txt_confirmar);
            this.splitContainer1.Panel2.Controls.Add(this.txt_contrasenia);
            this.splitContainer1.Panel2.Controls.Add(this.shapeContainer1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(685, 315);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 10;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(68, 32);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(101, 29);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            this.lbl_nombre.Click += new System.EventHandler(this.Lbl_nombre_Click);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(68, 90);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(102, 29);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nomUsuario
            // 
            this.lbl_nomUsuario.AutoSize = true;
            this.lbl_nomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomUsuario.Location = new System.Drawing.Point(68, 140);
            this.lbl_nomUsuario.Name = "lbl_nomUsuario";
            this.lbl_nomUsuario.Size = new System.Drawing.Size(224, 29);
            this.lbl_nomUsuario.TabIndex = 3;
            this.lbl_nomUsuario.Text = "Nombre de Usuario";
            this.lbl_nomUsuario.Click += new System.EventHandler(this.Lbl_nomUsuario_Click);
            // 
            // lbl_Contrasenia
            // 
            this.lbl_Contrasenia.AutoSize = true;
            this.lbl_Contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contrasenia.Location = new System.Drawing.Point(68, 193);
            this.lbl_Contrasenia.Name = "lbl_Contrasenia";
            this.lbl_Contrasenia.Size = new System.Drawing.Size(136, 29);
            this.lbl_Contrasenia.TabIndex = 4;
            this.lbl_Contrasenia.Text = "Contraseña";
            // 
            // lbl_confirmar
            // 
            this.lbl_confirmar.AutoSize = true;
            this.lbl_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmar.Location = new System.Drawing.Point(68, 250);
            this.lbl_confirmar.Name = "lbl_confirmar";
            this.lbl_confirmar.Size = new System.Drawing.Size(242, 29);
            this.lbl_confirmar.TabIndex = 5;
            this.lbl_confirmar.Text = "Confirmar contraseña";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Location = new System.Drawing.Point(53, 32);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(260, 15);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellido.Location = new System.Drawing.Point(53, 90);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(259, 15);
            this.txt_apellido.TabIndex = 7;
            // 
            // txt_nomUsuario
            // 
            this.txt_nomUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_nomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomUsuario.Location = new System.Drawing.Point(55, 146);
            this.txt_nomUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nomUsuario.MaxLength = 20;
            this.txt_nomUsuario.Name = "txt_nomUsuario";
            this.txt_nomUsuario.Size = new System.Drawing.Size(259, 15);
            this.txt_nomUsuario.TabIndex = 8;
            this.txt_nomUsuario.TextChanged += new System.EventHandler(this.Txt_nomUsuario_TextChanged);
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_confirmar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmar.Location = new System.Drawing.Point(53, 250);
            this.txt_confirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.PasswordChar = '*';
            this.txt_confirmar.Size = new System.Drawing.Size(259, 15);
            this.txt_confirmar.TabIndex = 10;
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contrasenia.Location = new System.Drawing.Point(57, 193);
            this.txt_contrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.PasswordChar = '*';
            this.txt_contrasenia.Size = new System.Drawing.Size(259, 15);
            this.txt_contrasenia.TabIndex = 9;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(363, 311);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderWidth = 2;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 39;
            this.lineShape5.X2 = 232;
            this.lineShape5.Y1 = 224;
            this.lineShape5.Y2 = 224;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 39;
            this.lineShape4.X2 = 232;
            this.lineShape4.Y1 = 180;
            this.lineShape4.Y2 = 180;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 39;
            this.lineShape3.X2 = 232;
            this.lineShape3.Y1 = 136;
            this.lineShape3.Y2 = 136;
            this.lineShape3.Click += new System.EventHandler(this.LineShape3_Click);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 39;
            this.lineShape2.X2 = 232;
            this.lineShape2.Y1 = 92;
            this.lineShape2.Y2 = 92;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 39;
            this.lineShape1.X2 = 232;
            this.lineShape1.Y1 = 48;
            this.lineShape1.Y2 = 48;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "CREAR USUARIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(0, 535);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 21);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Location = new System.Drawing.Point(3, 523);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 18);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pxclose);
            this.panel3.Controls.Add(this.pxventanas);
            this.panel3.Controls.Add(this.pxminimizar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(693, 31);
            this.panel3.TabIndex = 14;
            // 
            // pxclose
            // 
            this.pxclose.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.CLOSEVERDAD;
            this.pxclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxclose.Location = new System.Drawing.Point(609, 0);
            this.pxclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxclose.Name = "pxclose";
            this.pxclose.Size = new System.Drawing.Size(40, 28);
            this.pxclose.TabIndex = 8;
            this.pxclose.TabStop = false;
            // 
            // pxventanas
            // 
            this.pxventanas.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.VENTANAS;
            this.pxventanas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxventanas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxventanas.Location = new System.Drawing.Point(557, 0);
            this.pxventanas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxventanas.Name = "pxventanas";
            this.pxventanas.Size = new System.Drawing.Size(43, 32);
            this.pxventanas.TabIndex = 7;
            this.pxventanas.TabStop = false;
            // 
            // pxminimizar
            // 
            this.pxminimizar.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.MINIVERDAD;
            this.pxminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxminimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxminimizar.Location = new System.Drawing.Point(513, -2);
            this.pxminimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxminimizar.Name = "pxminimizar";
            this.pxminimizar.Size = new System.Drawing.Size(35, 28);
            this.pxminimizar.TabIndex = 6;
            this.pxminimizar.TabStop = false;
            // 
            // CrearUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.fondo_layout;
            this.ClientSize = new System.Drawing.Size(657, 556);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CrearUsuarioView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearUsuarioView";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxventanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxminimizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_crear;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.Label lbl_apellido;
        public System.Windows.Forms.Label lbl_nomUsuario;
        public System.Windows.Forms.Label lbl_Contrasenia;
        public System.Windows.Forms.Label lbl_confirmar;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_apellido;
        public System.Windows.Forms.TextBox txt_nomUsuario;
        public System.Windows.Forms.TextBox txt_confirmar;
        public System.Windows.Forms.TextBox txt_contrasenia;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pxminimizar;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox pxclose;
        public System.Windows.Forms.PictureBox pxventanas;
    }
}