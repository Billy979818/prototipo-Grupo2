namespace DEVSIS_ENERGISUR
{
    partial class DardeBajaCliente
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
            this.darDeBaja = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.cedulaBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIngresarProducto
            // 
            this.labelIngresarProducto.AutoSize = true;
            this.labelIngresarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresarProducto.Location = new System.Drawing.Point(472, 11);
            this.labelIngresarProducto.Name = "labelIngresarProducto";
            this.labelIngresarProducto.Size = new System.Drawing.Size(186, 24);
            this.labelIngresarProducto.TabIndex = 55;
            this.labelIngresarProducto.Text = "Dar de Baja cliente";
            // 
            // darDeBaja
            // 
            this.darDeBaja.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.darDeBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darDeBaja.Location = new System.Drawing.Point(296, 501);
            this.darDeBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.darDeBaja.Name = "darDeBaja";
            this.darDeBaja.Size = new System.Drawing.Size(227, 48);
            this.darDeBaja.TabIndex = 76;
            this.darDeBaja.Text = "DAR DE BAJA";
            this.darDeBaja.UseVisualStyleBackColor = false;
            this.darDeBaja.Click += new System.EventHandler(this.botonIngresar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(636, 501);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(227, 48);
            this.botonCancelar.TabIndex = 77;
            this.botonCancelar.Text = "CANCELAR";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(83, 57);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(292, 24);
            this.labelCodigo.TabIndex = 78;
            this.labelCodigo.Text = "Número de cédula de ciudadanía";
            // 
            // cedulaBusqueda
            // 
            this.cedulaBusqueda.Location = new System.Drawing.Point(460, 54);
            this.cedulaBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cedulaBusqueda.MaxLength = 10;
            this.cedulaBusqueda.Name = "cedulaBusqueda";
            this.cedulaBusqueda.Size = new System.Drawing.Size(420, 22);
            this.cedulaBusqueda.TabIndex = 79;
            this.cedulaBusqueda.TextChanged += new System.EventHandler(this.cedulaDarBaja);
            this.cedulaBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCodigo_KeyDown);
            this.cedulaBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigo_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(73, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 400);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DardeBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cedulaBusqueda);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.darDeBaja);
            this.Controls.Add(this.labelIngresarProducto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DardeBajaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DardeBajaCliente";
            this.Load += new System.EventHandler(this.DardeBajaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelIngresarProducto;
        private System.Windows.Forms.Button darDeBaja;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox cedulaBusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}