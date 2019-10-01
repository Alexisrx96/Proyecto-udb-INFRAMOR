namespace RegistroAlumnasInframor.Views
{
    partial class ModificarAlumnaView
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_calcelar = new System.Windows.Forms.Button();
            this.txt_nombreMadre = new System.Windows.Forms.TextBox();
            this.txt_nombrePadre = new System.Windows.Forms.TextBox();
            this.cmb_LugarNacimiento = new System.Windows.Forms.ComboBox();
            this.dtp_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_anioEgreso = new System.Windows.Forms.TextBox();
            this.txt_anioIngreso = new System.Windows.Forms.TextBox();
            this.txt_apelidos = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_nie = new System.Windows.Forms.TextBox();
            this.txt_idAlumna = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(455, 329);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(554, 329);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 6;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_calcelar
            // 
            this.btn_calcelar.Location = new System.Drawing.Point(660, 329);
            this.btn_calcelar.Name = "btn_calcelar";
            this.btn_calcelar.Size = new System.Drawing.Size(75, 23);
            this.btn_calcelar.TabIndex = 7;
            this.btn_calcelar.Text = "Cancelar";
            this.btn_calcelar.UseVisualStyleBackColor = true;
            // 
            // txt_nombreMadre
            // 
            this.txt_nombreMadre.Location = new System.Drawing.Point(266, 341);
            this.txt_nombreMadre.Name = "txt_nombreMadre";
            this.txt_nombreMadre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombreMadre.TabIndex = 30;
            // 
            // txt_nombrePadre
            // 
            this.txt_nombrePadre.Location = new System.Drawing.Point(266, 301);
            this.txt_nombrePadre.Name = "txt_nombrePadre";
            this.txt_nombrePadre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombrePadre.TabIndex = 29;
            // 
            // cmb_LugarNacimiento
            // 
            this.cmb_LugarNacimiento.FormattingEnabled = true;
            this.cmb_LugarNacimiento.Location = new System.Drawing.Point(266, 262);
            this.cmb_LugarNacimiento.Name = "cmb_LugarNacimiento";
            this.cmb_LugarNacimiento.Size = new System.Drawing.Size(121, 24);
            this.cmb_LugarNacimiento.TabIndex = 28;
            // 
            // dtp_nacimiento
            // 
            this.dtp_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nacimiento.Location = new System.Drawing.Point(266, 229);
            this.dtp_nacimiento.MaxDate = new System.DateTime(3000, 10, 1, 0, 0, 0, 0);
            this.dtp_nacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimiento.Name = "dtp_nacimiento";
            this.dtp_nacimiento.Size = new System.Drawing.Size(113, 22);
            this.dtp_nacimiento.TabIndex = 27;
            this.dtp_nacimiento.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            // 
            // txt_anioEgreso
            // 
            this.txt_anioEgreso.Location = new System.Drawing.Point(266, 193);
            this.txt_anioEgreso.MaxLength = 4;
            this.txt_anioEgreso.Name = "txt_anioEgreso";
            this.txt_anioEgreso.Size = new System.Drawing.Size(100, 22);
            this.txt_anioEgreso.TabIndex = 26;
            // 
            // txt_anioIngreso
            // 
            this.txt_anioIngreso.Location = new System.Drawing.Point(266, 153);
            this.txt_anioIngreso.MaxLength = 4;
            this.txt_anioIngreso.Name = "txt_anioIngreso";
            this.txt_anioIngreso.Size = new System.Drawing.Size(100, 22);
            this.txt_anioIngreso.TabIndex = 25;
            // 
            // txt_apelidos
            // 
            this.txt_apelidos.Location = new System.Drawing.Point(266, 124);
            this.txt_apelidos.MaxLength = 25;
            this.txt_apelidos.Name = "txt_apelidos";
            this.txt_apelidos.Size = new System.Drawing.Size(100, 22);
            this.txt_apelidos.TabIndex = 24;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(266, 94);
            this.txt_nombres.MaxLength = 25;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(100, 22);
            this.txt_nombres.TabIndex = 23;
            // 
            // txt_nie
            // 
            this.txt_nie.Location = new System.Drawing.Point(266, 56);
            this.txt_nie.MaxLength = 6;
            this.txt_nie.Name = "txt_nie";
            this.txt_nie.Size = new System.Drawing.Size(100, 22);
            this.txt_nie.TabIndex = 22;
            // 
            // txt_idAlumna
            // 
            this.txt_idAlumna.Location = new System.Drawing.Point(266, 16);
            this.txt_idAlumna.MaxLength = 8;
            this.txt_idAlumna.Name = "txt_idAlumna";
            this.txt_idAlumna.Size = new System.Drawing.Size(100, 22);
            this.txt_idAlumna.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "NIE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Nombre de la Madre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nombre del Padre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lugar de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Año de Egreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Año de Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id Alumna";
            // 
            // ModificarAlumnaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.txt_nombreMadre);
            this.Controls.Add(this.txt_nombrePadre);
            this.Controls.Add(this.cmb_LugarNacimiento);
            this.Controls.Add(this.dtp_nacimiento);
            this.Controls.Add(this.txt_anioEgreso);
            this.Controls.Add(this.txt_anioIngreso);
            this.Controls.Add(this.txt_apelidos);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.txt_nie);
            this.Controls.Add(this.txt_idAlumna);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcelar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_modificar);
            this.Name = "ModificarAlumnaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarUsuarioView";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_modificar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button btn_calcelar;
        public System.Windows.Forms.Button btn_borrar;
        public System.Windows.Forms.TextBox txt_nombreMadre;
        public System.Windows.Forms.TextBox txt_nombrePadre;
        public System.Windows.Forms.ComboBox cmb_LugarNacimiento;
        public System.Windows.Forms.DateTimePicker dtp_nacimiento;
        public System.Windows.Forms.TextBox txt_anioEgreso;
        public System.Windows.Forms.TextBox txt_anioIngreso;
        public System.Windows.Forms.TextBox txt_apelidos;
        public System.Windows.Forms.TextBox txt_nombres;
        public System.Windows.Forms.TextBox txt_nie;
        public System.Windows.Forms.TextBox txt_idAlumna;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}