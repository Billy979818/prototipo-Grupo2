namespace DEVSIS_ENERGISUR
{
    partial class IngresarProductoVehiculo
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
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelVoltaje = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textVoltaje = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textNombreProducto = new System.Windows.Forms.TextBox();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIngresarProducto
            // 
            this.labelIngresarProducto.AutoSize = true;
            this.labelIngresarProducto.Location = new System.Drawing.Point(150, 8);
            this.labelIngresarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIngresarProducto.Name = "labelIngresarProducto";
            this.labelIngresarProducto.Size = new System.Drawing.Size(90, 13);
            this.labelIngresarProducto.TabIndex = 0;
            this.labelIngresarProducto.Text = "Ingresar vehículo";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(9, 32);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(83, 13);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Marca Vehículo";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(181, 32);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(248, 20);
            this.textCodigo.TabIndex = 2;
            this.textCodigo.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            this.textCodigo.Leave += new System.EventHandler(this.textCodigo_Leave);
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(11, 416);
            this.botonIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(222, 22);
            this.botonIngresar.TabIndex = 3;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Placa Vehículo";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(9, 98);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(88, 13);
            this.labelMarca.TabIndex = 5;
            this.labelMarca.Text = "Modelo Vehículo";
            // 
            // labelVoltaje
            // 
            this.labelVoltaje.AutoSize = true;
            this.labelVoltaje.Location = new System.Drawing.Point(8, 134);
            this.labelVoltaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoltaje.Name = "labelVoltaje";
            this.labelVoltaje.Size = new System.Drawing.Size(58, 13);
            this.labelVoltaje.TabIndex = 7;
            this.labelVoltaje.Text = "Kilometraje";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(8, 169);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 10;
            this.labelPrecio.Text = "Precio";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(181, 169);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(248, 20);
            this.textPrecio.TabIndex = 11;
            this.textPrecio.Leave += new System.EventHandler(this.textPrecio_Leave);
            // 
            // textVoltaje
            // 
            this.textVoltaje.Location = new System.Drawing.Point(181, 134);
            this.textVoltaje.Margin = new System.Windows.Forms.Padding(2);
            this.textVoltaje.Name = "textVoltaje";
            this.textVoltaje.Size = new System.Drawing.Size(248, 20);
            this.textVoltaje.TabIndex = 14;
            this.textVoltaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textVoltaje_KeyPress);
            this.textVoltaje.Leave += new System.EventHandler(this.textVoltaje_Leave);
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(181, 98);
            this.textMarca.Margin = new System.Windows.Forms.Padding(2);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(248, 20);
            this.textMarca.TabIndex = 16;
            this.textMarca.Leave += new System.EventHandler(this.textMarca_Leave);
            // 
            // textNombreProducto
            // 
            this.textNombreProducto.Location = new System.Drawing.Point(181, 65);
            this.textNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreProducto.Name = "textNombreProducto";
            this.textNombreProducto.Size = new System.Drawing.Size(248, 20);
            this.textNombreProducto.TabIndex = 17;
            this.textNombreProducto.TextChanged += new System.EventHandler(this.textNombreProducto_TextChanged);
            this.textNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombreProducto_KeyPress);
            this.textNombreProducto.Leave += new System.EventHandler(this.textNombreProducto_Leave);
            // 
            // botonRegresar
            // 
            this.botonRegresar.Location = new System.Drawing.Point(235, 415);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(190, 23);
            this.botonRegresar.TabIndex = 40;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = true;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // IngresarProductoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 449);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.textNombreProducto);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textVoltaje);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelVoltaje);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelIngresarProducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IngresarProductoVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Vehículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIngresarProducto;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelVoltaje;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textVoltaje;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textNombreProducto;
        private System.Windows.Forms.Button botonRegresar;
    }
}