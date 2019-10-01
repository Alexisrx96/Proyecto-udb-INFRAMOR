namespace RegistroAlumnasInframor.Views
{
    partial class AlumnaView
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
            this.dgv_tablaAlumnas = new System.Windows.Forms.DataGridView();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_NuevaAlumna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaAlumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tablaAlumnas
            // 
            this.dgv_tablaAlumnas.AllowUserToAddRows = false;
            this.dgv_tablaAlumnas.AllowUserToDeleteRows = false;
            this.dgv_tablaAlumnas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_tablaAlumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablaAlumnas.Location = new System.Drawing.Point(12, 103);
            this.dgv_tablaAlumnas.Name = "dgv_tablaAlumnas";
            this.dgv_tablaAlumnas.ReadOnly = true;
            this.dgv_tablaAlumnas.RowHeadersWidth = 51;
            this.dgv_tablaAlumnas.RowTemplate.Height = 24;
            this.dgv_tablaAlumnas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tablaAlumnas.Size = new System.Drawing.Size(776, 335);
            this.dgv_tablaAlumnas.TabIndex = 0;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(52, 71);
            this.txt_buscar.MaxLength = 20;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(327, 22);
            this.txt_buscar.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_NuevaAlumna.Location = new System.Drawing.Point(438, 68);
            this.btn_NuevaAlumna.Name = "btn_buscar";
            this.btn_NuevaAlumna.Size = new System.Drawing.Size(158, 29);
            this.btn_NuevaAlumna.TabIndex = 2;
            this.btn_NuevaAlumna.Text = "Crear Nueva Alumna";
            this.btn_NuevaAlumna.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por Nombre de usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(602, 69);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(158, 27);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            // 
            // AlumnaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NuevaAlumna);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.dgv_tablaAlumnas);
            this.Name = "AlumnaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablaAlumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_tablaAlumnas;
        public System.Windows.Forms.TextBox txt_buscar;
        public System.Windows.Forms.Button btn_NuevaAlumna;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button btn_regresar;
    }
}