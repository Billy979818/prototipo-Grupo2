namespace DEVSIS_ENERGISUR
{
    partial class RegistrarVehículo
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_limpiar = new System.Windows.Forms.Button();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textPlaca = new System.Windows.Forms.TextBox();
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
            this.botonRegresar.Location = new System.Drawing.Point(270, 381);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(232, 39);
            this.botonRegresar.TabIndex = 53;
            this.botonRegresar.Text = "CANCELAR";
            this.botonRegresar.UseVisualStyleBackColor = false;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(18, 265);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(148, 18);
            this.labelPrecio.TabIndex = 48;
            this.labelPrecio.Text = "Precio de compra ($)";
            // 
            // labelVoltaje
            // 
            this.labelVoltaje.AutoSize = true;
            this.labelVoltaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltaje.Location = new System.Drawing.Point(17, 222);
            this.labelVoltaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoltaje.Name = "labelVoltaje";
            this.labelVoltaje.Size = new System.Drawing.Size(117, 18);
            this.labelVoltaje.TabIndex = 47;
            this.labelVoltaje.Text = "Kilometraje (km)";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(18, 182);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(62, 18);
            this.labelMarca.TabIndex = 46;
            this.labelMarca.Text = "Modelo ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Placa ";
            // 
            // botonIngresar
            // 
            this.botonIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIngresar.Location = new System.Drawing.Point(11, 381);
            this.botonIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(232, 39);
            this.botonIngresar.TabIndex = 44;
            this.botonIngresar.Text = "REGISTRAR";
            this.botonIngresar.UseVisualStyleBackColor = false;
            this.botonIngresar.Click += new System.EventHandler(this.RegistrarVehiculo_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(18, 60);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(54, 18);
            this.labelCodigo.TabIndex = 42;
            this.labelCodigo.Text = "Marca ";
            // 
            // labelIngresarProducto
            // 
            this.labelIngresarProducto.AutoSize = true;
            this.labelIngresarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresarProducto.Location = new System.Drawing.Point(154, 9);
            this.labelIngresarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIngresarProducto.Name = "labelIngresarProducto";
            this.labelIngresarProducto.Size = new System.Drawing.Size(144, 18);
            this.labelIngresarProducto.TabIndex = 41;
            this.labelIngresarProducto.Text = "Registrar vehículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Precio de venta ($)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tipo ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "automovil",
            "camioneta"});
            this.comboBox1.Location = new System.Drawing.Point(197, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 26);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.Text = "seleccione";
            // 
            // bt_limpiar
            // 
            this.bt_limpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpiar.Location = new System.Drawing.Point(138, 444);
            this.bt_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_limpiar.Name = "bt_limpiar";
            this.bt_limpiar.Size = new System.Drawing.Size(232, 39);
            this.bt_limpiar.TabIndex = 73;
            this.bt_limpiar.Text = "LIMPIAR";
            this.bt_limpiar.UseVisualStyleBackColor = false;
            this.bt_limpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // textMarca
            // 
            this.textMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMarca.Location = new System.Drawing.Point(197, 60);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(182, 24);
            this.textMarca.TabIndex = 74;
            // 
            // textPlaca
            // 
            this.textPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlaca.Location = new System.Drawing.Point(197, 95);
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(182, 24);
            this.textPlaca.TabIndex = 75;
            // 
            // textModel
            // 
            this.textModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModel.Location = new System.Drawing.Point(197, 183);
            this.textModel.Name = "textModel";
            this.textModel.Size = new System.Drawing.Size(182, 24);
            this.textModel.TabIndex = 76;
            // 
            // textKm
            // 
            this.textKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKm.Location = new System.Drawing.Point(197, 219);
            this.textKm.Name = "textKm";
            this.textKm.Size = new System.Drawing.Size(182, 24);
            this.textKm.TabIndex = 77;
            // 
            // textPC
            // 
            this.textPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPC.Location = new System.Drawing.Point(197, 265);
            this.textPC.Name = "textPC";
            this.textPC.Size = new System.Drawing.Size(182, 24);
            this.textPC.TabIndex = 78;
            // 
            // textPV
            // 
            this.textPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPV.Location = new System.Drawing.Point(198, 312);
            this.textPV.Name = "textPV";
            this.textPV.Size = new System.Drawing.Size(181, 24);
            this.textPV.TabIndex = 79;
            // 
            // RegistrarVehículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 494);
            this.Controls.Add(this.textPV);
            this.Controls.Add(this.textPC);
            this.Controls.Add(this.textKm);
            this.Controls.Add(this.textModel);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.bt_limpiar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelVoltaje);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelIngresarProducto);
            this.Name = "RegistrarVehículo";
            this.Text = "Registrar  Vehículo";
            this.Load += new System.EventHandler(this.RegistrarVehículo_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_limpiar;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.TextBox textModel;
        private System.Windows.Forms.TextBox textKm;
        private System.Windows.Forms.TextBox textPC;
        private System.Windows.Forms.TextBox textPV;
    }
}