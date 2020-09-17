namespace DEVSIS_ENERGISUR
{
    partial class ActualizarVehiculo
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
            this.botonRegresar = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelVoltaje = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelIngresarProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textModel = new System.Windows.Forms.TextBox();
            this.textKm = new System.Windows.Forms.TextBox();
            this.textPC = new System.Windows.Forms.TextBox();
            this.textPV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botonRegresar
            // 
            this.botonRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegresar.Location = new System.Drawing.Point(267, 300);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(232, 39);
            this.botonRegresar.TabIndex = 66;
            this.botonRegresar.Text = "CANCELAR";
            this.botonRegresar.UseVisualStyleBackColor = false;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click_1);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(20, 197);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(148, 18);
            this.labelPrecio.TabIndex = 61;
            this.labelPrecio.Text = "Precio de compra ($)";
            // 
            // labelVoltaje
            // 
            this.labelVoltaje.AutoSize = true;
            this.labelVoltaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltaje.Location = new System.Drawing.Point(20, 162);
            this.labelVoltaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoltaje.Name = "labelVoltaje";
            this.labelVoltaje.Size = new System.Drawing.Size(117, 18);
            this.labelVoltaje.TabIndex = 60;
            this.labelVoltaje.Text = "Kilometraje (km)";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(21, 126);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(62, 18);
            this.labelMarca.TabIndex = 59;
            this.labelMarca.Text = "Modelo ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "Placa ";
            // 
            // botonIngresar
            // 
            this.botonIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIngresar.Location = new System.Drawing.Point(14, 300);
            this.botonIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(232, 39);
            this.botonIngresar.TabIndex = 57;
            this.botonIngresar.Text = "ACTUALIZAR";
            this.botonIngresar.UseVisualStyleBackColor = false;
            this.botonIngresar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(20, 97);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(54, 18);
            this.labelCodigo.TabIndex = 55;
            this.labelCodigo.Text = "Marca ";
            // 
            // labelIngresarProducto
            // 
            this.labelIngresarProducto.AutoSize = true;
            this.labelIngresarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresarProducto.Location = new System.Drawing.Point(181, 9);
            this.labelIngresarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIngresarProducto.Name = "labelIngresarProducto";
            this.labelIngresarProducto.Size = new System.Drawing.Size(149, 18);
            this.labelIngresarProducto.TabIndex = 54;
            this.labelIngresarProducto.Text = "Actualizar vehículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Precio de venta ($)";
            // 
            // textPlaca
            // 
            this.textPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlaca.Location = new System.Drawing.Point(200, 58);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(200, 24);
            this.textPlaca.TabIndex = 68;
            this.textPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigo_KeyPress);
            // 
            // textMarca
            // 
            this.textMarca.Enabled = false;
            this.textMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMarca.Location = new System.Drawing.Point(200, 94);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(200, 24);
            this.textMarca.TabIndex = 69;
            this.textMarca.Text = "No permitido";
            // 
            // textModel
            // 
            this.textModel.Enabled = false;
            this.textModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModel.Location = new System.Drawing.Point(200, 127);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(200, 24);
            this.textModel.TabIndex = 70;
            this.textModel.Text = "No permitido";
            // 
            // textKm
            // 
            this.textKm.Enabled = false;
            this.textKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKm.Location = new System.Drawing.Point(200, 163);
            this.textKm.Name = "textKm";
            this.textKm.Size = new System.Drawing.Size(200, 24);
            this.textKm.TabIndex = 71;
            this.textKm.Text = "No permitido";
            // 
            // textPC
            // 
            this.textPC.Enabled = false;
            this.textPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPC.Location = new System.Drawing.Point(200, 198);
            this.textPC.Name = "textPC";
            this.textPC.Size = new System.Drawing.Size(200, 24);
            this.textPC.TabIndex = 72;
            this.textPC.Text = "No permitido";
            // 
            // textPV
            // 
            this.textPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPV.Location = new System.Drawing.Point(200, 237);
            this.textPV.Name = "textPV";
            this.textPV.Size = new System.Drawing.Size(200, 24);
            this.textPV.TabIndex = 73;
            // 
            // ActualizarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 363);
            this.Controls.Add(this.textPV);
            this.Controls.Add(this.textPC);
            this.Controls.Add(this.textKm);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelVoltaje);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelIngresarProducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActualizarVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Vehículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRegresar;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelVoltaje;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelIngresarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textKm;
        private System.Windows.Forms.TextBox textPC;
        private System.Windows.Forms.TextBox textPV;
    }
}