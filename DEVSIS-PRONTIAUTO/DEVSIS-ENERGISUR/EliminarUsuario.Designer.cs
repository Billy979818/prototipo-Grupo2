namespace DEVSIS_ENERGISUR
{
    partial class EliminarUsuario
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.labelContrasenaConfirmacion = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContrasena = new System.Windows.Forms.TextBox();
            this.textContrasenaConfirmacion = new System.Windows.Forms.TextBox();
            this.labelEliminarUsuario = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 177);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(9, 32);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(9, 65);
            this.labelContrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(61, 13);
            this.labelContrasena.TabIndex = 2;
            this.labelContrasena.Text = "Contraseña";
            // 
            // labelContrasenaConfirmacion
            // 
            this.labelContrasenaConfirmacion.AutoSize = true;
            this.labelContrasenaConfirmacion.Location = new System.Drawing.Point(9, 98);
            this.labelContrasenaConfirmacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrasenaConfirmacion.Name = "labelContrasenaConfirmacion";
            this.labelContrasenaConfirmacion.Size = new System.Drawing.Size(139, 13);
            this.labelContrasenaConfirmacion.TabIndex = 3;
            this.labelContrasenaConfirmacion.Text = "Confirmación de contraseña";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(181, 32);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(248, 20);
            this.textUsuario.TabIndex = 4;
            // 
            // textContrasena
            // 
            this.textContrasena.Location = new System.Drawing.Point(181, 65);
            this.textContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textContrasena.Name = "textContrasena";
            this.textContrasena.Size = new System.Drawing.Size(248, 20);
            this.textContrasena.TabIndex = 5;
            // 
            // textContrasenaConfirmacion
            // 
            this.textContrasenaConfirmacion.Location = new System.Drawing.Point(181, 98);
            this.textContrasenaConfirmacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textContrasenaConfirmacion.Name = "textContrasenaConfirmacion";
            this.textContrasenaConfirmacion.Size = new System.Drawing.Size(248, 20);
            this.textContrasenaConfirmacion.TabIndex = 6;
            // 
            // labelEliminarUsuario
            // 
            this.labelEliminarUsuario.AutoSize = true;
            this.labelEliminarUsuario.Location = new System.Drawing.Point(150, 8);
            this.labelEliminarUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEliminarUsuario.Name = "labelEliminarUsuario";
            this.labelEliminarUsuario.Size = new System.Drawing.Size(117, 13);
            this.labelEliminarUsuario.TabIndex = 7;
            this.labelEliminarUsuario.Text = "Eliminación de usuarios";
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(9, 177);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(186, 22);
            this.botonRegresar.TabIndex = 33;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 206);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.labelEliminarUsuario);
            this.Controls.Add(this.textContrasenaConfirmacion);
            this.Controls.Add(this.textContrasena);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.labelContrasenaConfirmacion);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EliminarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminaciónUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Label labelContrasenaConfirmacion;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textContrasena;
        private System.Windows.Forms.TextBox textContrasenaConfirmacion;
        private System.Windows.Forms.Label labelEliminarUsuario;
        private System.Windows.Forms.Button botonRegresar;
    }
}