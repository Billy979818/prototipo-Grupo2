namespace DEVSIS_ENERGISUR
{
    partial class IngresarProductoMantenimiento
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
            this.textNombreProductoMant = new System.Windows.Forms.TextBox();
            this.textMarcaMant = new System.Windows.Forms.TextBox();
            this.textCodMan = new System.Windows.Forms.TextBox();
            this.textPrecioMant = new System.Windows.Forms.TextBox();
            this.labelVoltaje = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.textCodigoMant = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelIngresarProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescrpcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtprecioVen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonRegresar
            // 
            this.botonRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegresar.Location = new System.Drawing.Point(263, 422);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(232, 39);
            this.botonRegresar.TabIndex = 53;
            this.botonRegresar.Text = "CANCELAR";
            this.botonRegresar.UseVisualStyleBackColor = false;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // textNombreProductoMant
            // 
            this.textNombreProductoMant.Location = new System.Drawing.Point(216, 124);
            this.textNombreProductoMant.Margin = new System.Windows.Forms.Padding(2);
            this.textNombreProductoMant.Name = "textNombreProductoMant";
            this.textNombreProductoMant.Size = new System.Drawing.Size(248, 20);
            this.textNombreProductoMant.TabIndex = 52;
            this.textNombreProductoMant.TextChanged += new System.EventHandler(this.textNombreProducto_TextChanged);
            // 
            // textMarcaMant
            // 
            this.textMarcaMant.Location = new System.Drawing.Point(216, 157);
            this.textMarcaMant.Margin = new System.Windows.Forms.Padding(2);
            this.textMarcaMant.Name = "textMarcaMant";
            this.textMarcaMant.Size = new System.Drawing.Size(248, 20);
            this.textMarcaMant.TabIndex = 51;
            // 
            // textCodMan
            // 
            this.textCodMan.Location = new System.Drawing.Point(216, 191);
            this.textCodMan.Margin = new System.Windows.Forms.Padding(2);
            this.textCodMan.Name = "textCodMan";
            this.textCodMan.Size = new System.Drawing.Size(248, 20);
            this.textCodMan.TabIndex = 50;
            // 
            // textPrecioMant
            // 
            this.textPrecioMant.Location = new System.Drawing.Point(216, 226);
            this.textPrecioMant.Margin = new System.Windows.Forms.Padding(2);
            this.textPrecioMant.Name = "textPrecioMant";
            this.textPrecioMant.Size = new System.Drawing.Size(248, 20);
            this.textPrecioMant.TabIndex = 49;
            // 
            // labelVoltaje
            // 
            this.labelVoltaje.AutoSize = true;
            this.labelVoltaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltaje.Location = new System.Drawing.Point(35, 190);
            this.labelVoltaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoltaje.Name = "labelVoltaje";
            this.labelVoltaje.Size = new System.Drawing.Size(87, 18);
            this.labelVoltaje.TabIndex = 47;
            this.labelVoltaje.Text = "Stock inicial";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(35, 156);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(60, 18);
            this.labelMarca.TabIndex = 46;
            this.labelMarca.Text = "Código ";
            this.labelMarca.Click += new System.EventHandler(this.labelMarca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 45;
            this.label1.Text = "Modelo ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonIngresar
            // 
            this.botonIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIngresar.Location = new System.Drawing.Point(11, 422);
            this.botonIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(232, 39);
            this.botonIngresar.TabIndex = 44;
            this.botonIngresar.Text = "REGISTRAR";
            this.botonIngresar.UseVisualStyleBackColor = false;
            // 
            // textCodigoMant
            // 
            this.textCodigoMant.Location = new System.Drawing.Point(216, 91);
            this.textCodigoMant.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigoMant.Name = "textCodigoMant";
            this.textCodigoMant.Size = new System.Drawing.Size(248, 20);
            this.textCodigoMant.TabIndex = 43;
            this.textCodigoMant.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(38, 90);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(54, 18);
            this.labelCodigo.TabIndex = 42;
            this.labelCodigo.Text = "Marca ";
            this.labelCodigo.Click += new System.EventHandler(this.labelCodigo_Click);
            // 
            // labelIngresarProducto
            // 
            this.labelIngresarProducto.AutoSize = true;
            this.labelIngresarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIngresarProducto.Location = new System.Drawing.Point(162, 9);
            this.labelIngresarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIngresarProducto.Name = "labelIngresarProducto";
            this.labelIngresarProducto.Size = new System.Drawing.Size(149, 18);
            this.labelIngresarProducto.TabIndex = 41;
            this.labelIngresarProducto.Text = "Registrar producto";
            this.labelIngresarProducto.Click += new System.EventHandler(this.labelIngresarProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Descripción";
            // 
            // txtDescrpcion
            // 
            this.txtDescrpcion.Location = new System.Drawing.Point(216, 305);
            this.txtDescrpcion.Multiline = true;
            this.txtDescrpcion.Name = "txtDescrpcion";
            this.txtDescrpcion.Size = new System.Drawing.Size(244, 88);
            this.txtDescrpcion.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 59;
            this.label4.Text = "Nombre ";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(216, 59);
            this.txtNombreArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(248, 20);
            this.txtNombreArticulo.TabIndex = 60;
            // 
            // txtprecioVen
            // 
            this.txtprecioVen.Location = new System.Drawing.Point(216, 270);
            this.txtprecioVen.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecioVen.Name = "txtprecioVen";
            this.txtprecioVen.Size = new System.Drawing.Size(248, 20);
            this.txtprecioVen.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 82;
            this.label5.Text = "Precio ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 39);
            this.button1.TabIndex = 84;
            this.button1.Text = "LIMPIAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // IngresarProductoMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtprecioVen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescrpcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.textNombreProductoMant);
            this.Controls.Add(this.textMarcaMant);
            this.Controls.Add(this.textCodMan);
            this.Controls.Add(this.textPrecioMant);
            this.Controls.Add(this.labelVoltaje);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.textCodigoMant);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelIngresarProducto);
            this.Name = "IngresarProductoMantenimiento";
            this.Text = "Registrar Producto Mantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRegresar;
        private System.Windows.Forms.TextBox textNombreProductoMant;
        private System.Windows.Forms.TextBox textMarcaMant;
        private System.Windows.Forms.TextBox textCodMan;
        private System.Windows.Forms.TextBox textPrecioMant;
        private System.Windows.Forms.Label labelVoltaje;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.TextBox textCodigoMant;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelIngresarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescrpcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtprecioVen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}