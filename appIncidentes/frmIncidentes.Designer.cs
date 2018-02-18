namespace appIncidentes
{
    partial class frmIncidentes
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
            this.lsbIncid = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbIncid
            // 
            this.lsbIncid.FormattingEnabled = true;
            this.lsbIncid.Location = new System.Drawing.Point(47, 48);
            this.lsbIncid.Name = "lsbIncid";
            this.lsbIncid.Size = new System.Drawing.Size(429, 186);
            this.lsbIncid.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exportar a XML";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmIncidentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsbIncid);
            this.Name = "frmIncidentes";
            this.Text = "Incidentes";
            this.Load += new System.EventHandler(this.frmIncidentes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbIncid;
        private System.Windows.Forms.Button button1;
    }
}