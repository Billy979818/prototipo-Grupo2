namespace DEVSIS_ENERGISUR
{
    partial class CrearUsuario
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.labelContrasenaConfirmacion = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContrasenaConfirmacion = new System.Windows.Forms.TextBox();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.botonCrearUsuario = new System.Windows.Forms.Button();
            this.labelCrearUsuario = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(9, 32);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(9, 65);
            this.labelContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(61, 13);
            this.labelContrasena.TabIndex = 1;
            this.labelContrasena.Text = "Contraseña";
            // 
            // labelContrasenaConfirmacion
            // 
            this.labelContrasenaConfirmacion.AutoSize = true;
            this.labelContrasenaConfirmacion.Location = new System.Drawing.Point(9, 98);
            this.labelContrasenaConfirmacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrasenaConfirmacion.Name = "labelContrasenaConfirmacion";
            this.labelContrasenaConfirmacion.Size = new System.Drawing.Size(124, 13);
            this.labelContrasenaConfirmacion.TabIndex = 2;
            this.labelContrasenaConfirmacion.Text = "Confirmación contraseña";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(181, 32);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(248, 20);
            this.textUsuario.TabIndex = 3;
            // 
            // textContrasenaConfirmacion
            // 
            this.textContrasenaConfirmacion.Location = new System.Drawing.Point(181, 98);
            this.textContrasenaConfirmacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textContrasenaConfirmacion.Name = "textContrasenaConfirmacion";
            this.textContrasenaConfirmacion.Size = new System.Drawing.Size(248, 20);
            this.textContrasenaConfirmacion.TabIndex = 4;
            // 
            // textContrasena
            // 
            this.textContrasena.Location = new System.Drawing.Point(181, 65);
            this.textContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.Size = new System.Drawing.Size(248, 20);
            this.textContrasena.TabIndex = 5;
            // 
            // botonCrearUsuario
            // 
            this.botonCrearUsuario.Location = new System.Drawing.Point(212, 177);
            this.botonCrearUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonCrearUsuario.Name = "botonCrearUsuario";
            this.botonCrearUsuario.Size = new System.Drawing.Size(216, 22);
            this.botonCrearUsuario.TabIndex = 6;
            this.botonCrearUsuario.Text = "Crear";
            this.botonCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // labelCrearUsuario
            // 
            this.labelCrearUsuario.AutoSize = true;
            this.labelCrearUsuario.Location = new System.Drawing.Point(150, 8);
            this.labelCrearUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCrearUsuario.Name = "labelCrearUsuario";
            this.labelCrearUsuario.Size = new System.Drawing.Size(106, 13);
            this.labelCrearUsuario.TabIndex = 7;
            this.labelCrearUsuario.Text = "Creación de usuarios";
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(11, 177);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(196, 22);
            this.botonRegresar.TabIndex = 33;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 206);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.labelCrearUsuario);
            this.Controls.Add(this.botonCrearUsuario);
            this.Controls.Add(this.textContrasena);
            this.Controls.Add(this.textContrasenaConfirmacion);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.labelContrasenaConfirmacion);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.labelUsuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreaciónUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Label labelContrasenaConfirmacion;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textContrasenaConfirmacion;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.Button botonCrearUsuario;
        private System.Windows.Forms.Label labelCrearUsuario;
        private System.Windows.Forms.Button botonRegresar;
    }
}