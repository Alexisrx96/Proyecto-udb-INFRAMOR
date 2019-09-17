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
            this.dgv_tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tablaUsuarios
            // 
            this.dgv_tablaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaUsuarios.Location = new System.Drawing.Point(12, 103);
            this.dgv_tablaUsuarios.Name = "dgv_tablaUsuarios";
            this.dgv_tablaUsuarios.RowHeadersWidth = 51;
            this.dgv_tablaUsuarios.RowTemplate.Height = 24;
            this.dgv_tablaUsuarios.Size = new System.Drawing.Size(776, 335);
            this.dgv_tablaUsuarios.TabIndex = 0;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(52, 71);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(327, 22);
            this.txt_buscar.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(385, 68);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(158, 29);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Crear Nuevo Usuario";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_tablaUsuarios);
            this.Name = "UsuarioView";
            this.Text = "UsuarioView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_tablaUsuarios;
        public System.Windows.Forms.TextBox txt_buscar;
        public System.Windows.Forms.Button btn_buscar;
    }
}