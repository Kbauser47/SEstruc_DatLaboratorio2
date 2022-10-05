namespace PLaboratorio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btninser = new System.Windows.Forms.Button();
            this.btnelimina = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btninser
            // 
            this.btninser.Location = new System.Drawing.Point(297, 90);
            this.btninser.Name = "btninser";
            this.btninser.Size = new System.Drawing.Size(75, 23);
            this.btninser.TabIndex = 0;
            this.btninser.Text = "Insertar";
            this.btninser.UseVisualStyleBackColor = true;
            this.btninser.Click += new System.EventHandler(this.btninser_Click);
            // 
            // btnelimina
            // 
            this.btnelimina.Location = new System.Drawing.Point(378, 90);
            this.btnelimina.Name = "btnelimina";
            this.btnelimina.Size = new System.Drawing.Size(75, 23);
            this.btnelimina.TabIndex = 1;
            this.btnelimina.Text = "Eliminar";
            this.btnelimina.UseVisualStyleBackColor = true;
            this.btnelimina.Click += new System.EventHandler(this.btnelimina_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(297, 48);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(156, 20);
            this.txtnum.TabIndex = 2;
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(297, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 108);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnelimina);
            this.Controls.Add(this.btninser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninser;
        private System.Windows.Forms.Button btnelimina;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.ListBox listBox1;
    }
}

