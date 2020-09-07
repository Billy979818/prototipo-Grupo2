namespace DEVSIS_ENERGISUR
{
    partial class EliminarCliente
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
            this.labelIngresarProducto = new System.Windows.Forms.Label();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIngresarProducto
            // 
            this.labelIngresarProducto.AutoSize = true;
            this.labelIngresarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresarProducto.Location = new System.Drawing.Point(354, 9);
            this.labelIngresarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIngresarProducto.Name = "labelIngresarProducto";
            this.labelIngresarProducto.Size = new System.Drawing.Size(123, 18);
            this.labelIngresarProducto.TabIndex = 55;
            this.labelIngresarProducto.Text = "Eliminar cliente";
            // 
            // botonIngresar
            // 
            this.botonIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIngresar.Location = new System.Drawing.Point(222, 407);
            this.botonIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(170, 39);
            this.botonIngresar.TabIndex = 76;
            this.botonIngresar.Text = "ELIMINAR";
            this.botonIngresar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.botonCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(477, 407);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(170, 39);
            this.botonCancelar.TabIndex = 77;
            this.botonCancelar.Text = "CANCELAR";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(143, 43);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(148, 18);
            this.labelCodigo.TabIndex = 78;
            this.labelCodigo.Text = "Cédula de ciudadanía";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(345, 44);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(316, 20);
            this.textCodigo.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(55, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 325);
            this.dataGridView1.TabIndex = 80;
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.labelIngresarProducto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EliminarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelIngresarProducto;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}