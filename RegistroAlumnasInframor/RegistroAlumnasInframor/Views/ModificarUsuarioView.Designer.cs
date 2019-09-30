namespace RegistroAlumnasInframor.Views
{
    partial class ModificarUsuarioView
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_nomUsuario = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nomUsuario = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.check_activo = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(104, 242);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // txt_nomUsuario
            // 
            this.txt_nomUsuario.Location = new System.Drawing.Point(203, 166);
            this.txt_nomUsuario.MaxLength = 20;
            this.txt_nomUsuario.Name = "txt_nomUsuario";
            this.txt_nomUsuario.Size = new System.Drawing.Size(100, 22);
            this.txt_nomUsuario.TabIndex = 3;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(203, 138);
            this.txt_apellido.MaxLength = 25;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 22);
            this.txt_apellido.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(203, 111);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_nomUsuario
            // 
            this.lbl_nomUsuario.AutoSize = true;
            this.lbl_nomUsuario.Location = new System.Drawing.Point(101, 169);
            this.lbl_nomUsuario.Name = "lbl_nomUsuario";
            this.lbl_nomUsuario.Size = new System.Drawing.Size(86, 17);
            this.lbl_nomUsuario.TabIndex = 8;
            this.lbl_nomUsuario.Text = "NomUsuario";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(101, 141);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(58, 17);
            this.lbl_apellido.TabIndex = 10;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(101, 114);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(58, 17);
            this.lbl_nombre.TabIndex = 13;
            this.lbl_nombre.Text = "Nombre";
            // 
            // check_activo
            // 
            this.check_activo.AutoSize = true;
            this.check_activo.Location = new System.Drawing.Point(203, 194);
            this.check_activo.Name = "check_activo";
            this.check_activo.Size = new System.Drawing.Size(68, 21);
            this.check_activo.TabIndex = 4;
            this.check_activo.Text = "Activo";
            this.check_activo.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModificarUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check_activo);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.txt_nomUsuario);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nomUsuario);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "ModificarUsuarioView";
            this.Text = "ModificarUsuarioView";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_modificar;
        public System.Windows.Forms.TextBox txt_nomUsuario;
        public System.Windows.Forms.TextBox txt_apellido;
        public System.Windows.Forms.TextBox txt_nombre;
        public System.Windows.Forms.Label lbl_nomUsuario;
        public System.Windows.Forms.Label lbl_apellido;
        public System.Windows.Forms.Label lbl_nombre;
        public System.Windows.Forms.CheckBox check_activo;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}