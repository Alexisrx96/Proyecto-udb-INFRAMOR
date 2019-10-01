namespace RegistroAlumnasInframor.Views
{
    partial class UsuarioView
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
            this.dgv_tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pxclose = new System.Windows.Forms.PictureBox();
            this.pxventana = new System.Windows.Forms.PictureBox();
            this.pxminimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxventana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tablaUsuarios
            // 
            this.dgv_tablaUsuarios.AllowUserToAddRows = false;
            this.dgv_tablaUsuarios.AllowUserToDeleteRows = false;
            this.dgv_tablaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaUsuarios.Location = new System.Drawing.Point(-4, 113);
            this.dgv_tablaUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_tablaUsuarios.Name = "dgv_tablaUsuarios";
            this.dgv_tablaUsuarios.ReadOnly = true;
            this.dgv_tablaUsuarios.RowHeadersWidth = 51;
            this.dgv_tablaUsuarios.RowTemplate.Height = 24;
            this.dgv_tablaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tablaUsuarios.Size = new System.Drawing.Size(804, 427);
            this.dgv_tablaUsuarios.TabIndex = 0;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(49, 82);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_buscar.MaxLength = 20;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(327, 22);
            this.txt_buscar.TabIndex = 1;
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearUsuario.Location = new System.Drawing.Point(425, 56);
            this.btn_CrearUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(274, 55);
            this.btn_CrearUsuario.TabIndex = 2;
            this.btn_CrearUsuario.Text = "Crear Nuevo Usuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUCAR USUARIO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pxclose);
            this.panel1.Controls.Add(this.pxventana);
            this.panel1.Controls.Add(this.pxminimizar);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 35);
            this.panel1.TabIndex = 4;
            // 
            // pxclose
            // 
            this.pxclose.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.CLOSEVERDAD;
            this.pxclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxclose.Location = new System.Drawing.Point(757, -1);
            this.pxclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxclose.Name = "pxclose";
            this.pxclose.Size = new System.Drawing.Size(39, 28);
            this.pxclose.TabIndex = 8;
            this.pxclose.TabStop = false;
            // 
            // pxventana
            // 
            this.pxventana.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.VENTANAS;
            this.pxventana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxventana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxventana.Location = new System.Drawing.Point(709, -1);
            this.pxventana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxventana.Name = "pxventana";
            this.pxventana.Size = new System.Drawing.Size(39, 32);
            this.pxventana.TabIndex = 7;
            this.pxventana.TabStop = false;
            // 
            // pxminimizar
            // 
            this.pxminimizar.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.MINIVERDAD;
            this.pxminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxminimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pxminimizar.Location = new System.Drawing.Point(668, -1);
            this.pxminimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pxminimizar.Name = "pxminimizar";
            this.pxminimizar.Size = new System.Drawing.Size(33, 32);
            this.pxminimizar.TabIndex = 6;
            this.pxminimizar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.LUPA;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(49, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 37);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.regreso;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_regresar.Location = new System.Drawing.Point(707, 56);
            this.btn_regresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(59, 55);
            this.btn_regresar.TabIndex = 14;
            this.btn_regresar.UseVisualStyleBackColor = true;
            // 
            // UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::RegistroAlumnasInframor.Properties.Resources.fondo_layout;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_tablaUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UsuarioView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxventana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_tablaUsuarios;
        public System.Windows.Forms.TextBox txt_buscar;
        public System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pxclose;
        private System.Windows.Forms.PictureBox pxventana;
        private System.Windows.Forms.PictureBox pxminimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_regresar;
    }
}