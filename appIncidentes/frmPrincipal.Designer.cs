namespace appIncidentes
{
    partial class frmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textTiquetes = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.comboPrioridad = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioAlto = new System.Windows.Forms.RadioButton();
            this.radioMedio = new System.Windows.Forms.RadioButton();
            this.radioBajo = new System.Windows.Forms.RadioButton();
            this.butRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiquetes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prioridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duracion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gravedad";
            // 
            // textTiquetes
            // 
            this.textTiquetes.Location = new System.Drawing.Point(172, 100);
            this.textTiquetes.Name = "textTiquetes";
            this.textTiquetes.Size = new System.Drawing.Size(100, 20);
            this.textTiquetes.TabIndex = 6;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(172, 145);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textDescripcion.TabIndex = 7;
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(172, 47);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 8;
            // 
            // comboPrioridad
            // 
            this.comboPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrioridad.FormattingEnabled = true;
            this.comboPrioridad.Location = new System.Drawing.Point(172, 193);
            this.comboPrioridad.Name = "comboPrioridad";
            this.comboPrioridad.Size = new System.Drawing.Size(121, 21);
            this.comboPrioridad.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(172, 239);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // radioAlto
            // 
            this.radioAlto.AutoSize = true;
            this.radioAlto.Location = new System.Drawing.Point(172, 298);
            this.radioAlto.Name = "radioAlto";
            this.radioAlto.Size = new System.Drawing.Size(43, 17);
            this.radioAlto.TabIndex = 11;
            this.radioAlto.TabStop = true;
            this.radioAlto.Text = "Alto";
            this.radioAlto.UseVisualStyleBackColor = true;
            // 
            // radioMedio
            // 
            this.radioMedio.AutoSize = true;
            this.radioMedio.Location = new System.Drawing.Point(263, 298);
            this.radioMedio.Name = "radioMedio";
            this.radioMedio.Size = new System.Drawing.Size(54, 17);
            this.radioMedio.TabIndex = 12;
            this.radioMedio.TabStop = true;
            this.radioMedio.Text = "Medio";
            this.radioMedio.UseVisualStyleBackColor = true;
            // 
            // radioBajo
            // 
            this.radioBajo.AutoSize = true;
            this.radioBajo.Location = new System.Drawing.Point(362, 298);
            this.radioBajo.Name = "radioBajo";
            this.radioBajo.Size = new System.Drawing.Size(46, 17);
            this.radioBajo.TabIndex = 13;
            this.radioBajo.TabStop = true;
            this.radioBajo.Text = "Bajo";
            this.radioBajo.UseVisualStyleBackColor = true;
            // 
            // butRegistrar
            // 
            this.butRegistrar.Location = new System.Drawing.Point(161, 360);
            this.butRegistrar.Name = "butRegistrar";
            this.butRegistrar.Size = new System.Drawing.Size(156, 36);
            this.butRegistrar.TabIndex = 14;
            this.butRegistrar.Text = "Registrar";
            this.butRegistrar.UseVisualStyleBackColor = true;
            this.butRegistrar.Click += new System.EventHandler(this.butRegistrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 443);
            this.Controls.Add(this.butRegistrar);
            this.Controls.Add(this.radioBajo);
            this.Controls.Add(this.radioMedio);
            this.Controls.Add(this.radioAlto);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboPrioridad);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textTiquetes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Registro de Incidentes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTiquetes;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.ComboBox comboPrioridad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioAlto;
        private System.Windows.Forms.RadioButton radioMedio;
        private System.Windows.Forms.RadioButton radioBajo;
        private System.Windows.Forms.Button butRegistrar;
    }
}

