namespace Ev_final_4toBi
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
            this.TextUsuario = new System.Windows.Forms.TextBox();
            this.TextContrasena = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextUsuario
            // 
            this.TextUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TextUsuario.Location = new System.Drawing.Point(157, 112);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(100, 22);
            this.TextUsuario.TabIndex = 0;
            // 
            // TextContrasena
            // 
            this.TextContrasena.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TextContrasena.Location = new System.Drawing.Point(377, 112);
            this.TextContrasena.Name = "TextContrasena";
            this.TextContrasena.Size = new System.Drawing.Size(100, 22);
            this.TextContrasena.TabIndex = 1;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.Red;
            this.BtnIngresar.Location = new System.Drawing.Point(278, 43);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl1.Location = new System.Drawing.Point(275, 169);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(88, 16);
            this.Lbl1.TabIndex = 3;
            this.Lbl1.Text = "Examen Final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TextContrasena);
            this.Controls.Add(this.TextUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUsuario;
        private System.Windows.Forms.TextBox TextContrasena;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label Lbl1;
    }
}

