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
            this.btn_Creditos = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Alumnas
            // 
            this.btn_Alumnas.Location = new System.Drawing.Point(173, 61);
            this.btn_Alumnas.Name = "btn_Alumnas";
            this.btn_Alumnas.Size = new System.Drawing.Size(75, 23);
            this.btn_Alumnas.TabIndex = 0;
            this.btn_Alumnas.Text = "Alumnas";
            this.btn_Alumnas.UseVisualStyleBackColor = true;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Location = new System.Drawing.Point(412, 61);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(75, 23);
            this.btn_Usuarios.TabIndex = 1;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            // 
            // btn_Creditos
            // 
            this.btn_Creditos.Location = new System.Drawing.Point(173, 271);
            this.btn_Creditos.Name = "btn_Creditos";
            this.btn_Creditos.Size = new System.Drawing.Size(75, 23);
            this.btn_Creditos.TabIndex = 2;
            this.btn_Creditos.Text = "Créditos";
            this.btn_Creditos.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(401, 271);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Creditos);
            this.Controls.Add(this.btn_Usuarios);
            this.Controls.Add(this.btn_Alumnas);
            this.Name = "MenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuView";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_Alumnas;
        public System.Windows.Forms.Button btn_Usuarios;
        public System.Windows.Forms.Button btn_Creditos;
        public System.Windows.Forms.Button btn_Salir;
    }
}