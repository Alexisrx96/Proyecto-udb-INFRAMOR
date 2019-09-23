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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nomUsuario = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_Contrasenia = new System.Windows.Forms.Label();
            this.txt_IdUsuarios = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nomUsuario = new System.Windows.Forms.TextBox();
            this.txt_contrasenia = new System.Windows.Forms.TextBox();
            this.txt_rol = new System.Windows.Forms.TextBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(68, 107);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(58, 17);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(68, 139);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(58, 17);
            this.lbl_apellido.TabIndex = 0;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nomUsuario
            // 
            this.lbl_nomUsuario.AutoSize = true;
            this.lbl_nomUsuario.Location = new System.Drawing.Point(68, 170);
            this.lbl_nomUsuario.Name = "lbl_nomUsuario";
            this.lbl_nomUsuario.Size = new System.Drawing.Size(86, 17);
            this.lbl_nomUsuario.TabIndex = 0;
            this.lbl_nomUsuario.Text = "NomUsuario";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(68, 75);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(19, 17);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Id";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Location = new System.Drawing.Point(68, 235);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(29, 17);
            this.lbl_rol.TabIndex = 0;
            this.lbl_rol.Text = "Rol";
            // 
            // lbl_Contrasenia
            // 
            this.lbl_Contrasenia.AutoSize = true;
            this.lbl_Contrasenia.Location = new System.Drawing.Point(68, 204);
            this.lbl_Contrasenia.Name = "lbl_Contrasenia";
            this.lbl_Contrasenia.Size = new System.Drawing.Size(84, 17);
            this.lbl_Contrasenia.TabIndex = 0;
            this.lbl_Contrasenia.Text = "Contrasenia";
            // 
            // txt_IdUsuarios
            // 
            this.txt_IdUsuarios.Location = new System.Drawing.Point(170, 72);
            this.txt_IdUsuarios.Name = "txt_IdUsuarios";
            this.txt_IdUsuarios.Size = new System.Drawing.Size(100, 22);
            this.txt_IdUsuarios.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(170, 107);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(170, 134);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 22);
            this.txt_apellido.TabIndex = 1;
            // 
            // txt_nomUsuario
            // 
            this.txt_nomUsuario.Location = new System.Drawing.Point(170, 170);
            this.txt_nomUsuario.Name = "txt_nomUsuario";
            this.txt_nomUsuario.Size = new System.Drawing.Size(100, 22);
            this.txt_nomUsuario.TabIndex = 1;
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.Location = new System.Drawing.Point(170, 204);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Size = new System.Drawing.Size(100, 22);
            this.txt_contrasenia.TabIndex = 1;
            // 
            // txt_rol
            // 
            this.txt_rol.Location = new System.Drawing.Point(170, 232);
            this.txt_rol.Name = "txt_rol";
            this.txt_rol.Size = new System.Drawing.Size(100, 22);
            this.txt_rol.TabIndex = 1;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(370, 268);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 2;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            // 
            // CrearUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.txt_rol);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.txt_nomUsuario);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_IdUsuarios);
            this.Controls.Add(this.lbl_nomUsuario);
            this.Controls.Add(this.lbl_Contrasenia);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_rol);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "CrearUsuarioView";
            this.Text = "CrearUsuarioView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_crear;
        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.Label lbl_apellido;
        public System.Windows.Forms.Label lbl_nomUsuario;
        public System.Windows.Forms.Label lbl_id;
        public System.Windows.Forms.Label lbl_rol;
        public System.Windows.Forms.Label lbl_Contrasenia;
        public System.Windows.Forms.TextBox txt_IdUsuarios;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.TextBox txt_apellido;
        public System.Windows.Forms.TextBox txt_nomUsuario;
        public System.Windows.Forms.TextBox txt_contrasenia;
        public System.Windows.Forms.TextBox txt_rol;
    }
}