namespace DEVSIS_ENERGISUR
{
    partial class GenerarNotaCredito
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
            this.labelGenerarFactura = new System.Windows.Forms.Label();
            this.labelFactura = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datosFacturas = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.textFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notaDeCredito = new System.Windows.Forms.TextBox();
            this.buttongenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datosFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGenerarFactura
            // 
            this.labelGenerarFactura.AutoSize = true;
            this.labelGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenerarFactura.Location = new System.Drawing.Point(277, 9);
            this.labelGenerarFactura.Name = "labelGenerarFactura";
            this.labelGenerarFactura.Size = new System.Drawing.Size(302, 36);
            this.labelGenerarFactura.TabIndex = 2;
            this.labelGenerarFactura.Text = "NOTA DE CRÉDITO";
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactura.Location = new System.Drawing.Point(21, 119);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(153, 20);
            this.labelFactura.TabIndex = 5;
            this.labelFactura.Text = "Número de factura:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(597, 119);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(275, 22);
            this.textBoxNombre.TabIndex = 75;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNombre_KeyDown);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(450, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 83;
            this.label2.Text = "Fecha de emisión:";
            // 
            // fechaEmision
            // 
            this.fechaEmision.Location = new System.Drawing.Point(597, 68);
            this.fechaEmision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaEmision.Name = "fechaEmision";
            this.fechaEmision.Size = new System.Drawing.Size(274, 22);
            this.fechaEmision.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(450, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 85;
            this.label3.Text = "Responsable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Número Nota de crédito:";
            // 
            // datosFacturas
            // 
            this.datosFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosFacturas.Location = new System.Drawing.Point(44, 287);
            this.datosFacturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datosFacturas.Name = "datosFacturas";
            this.datosFacturas.RowHeadersWidth = 51;
            this.datosFacturas.RowTemplate.Height = 24;
            this.datosFacturas.Size = new System.Drawing.Size(828, 210);
            this.datosFacturas.TabIndex = 91;
            this.datosFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosFacturas_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(652, 523);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 38);
            this.button2.TabIndex = 93;
            this.button2.Text = "CANCELAR ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(370, 527);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 34);
            this.button3.TabIndex = 94;
            this.button3.Text = "LIMPIAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(146, 161);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(725, 107);
            this.descripcion.TabIndex = 95;
            this.descripcion.Text = "";
            this.descripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descripcion_KeyDown);
            // 
            // textFactura
            // 
            this.textFactura.Location = new System.Drawing.Point(237, 119);
            this.textFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFactura.Name = "textFactura";
            this.textFactura.Size = new System.Drawing.Size(172, 22);
            this.textFactura.TabIndex = 96;
            this.textFactura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textFactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFactura_KeyDown);
            this.textFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFactura_KeyPress);
            this.textFactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textFactura_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Descripción:";
            // 
            // notaDeCredito
            // 
            this.notaDeCredito.Location = new System.Drawing.Point(237, 72);
            this.notaDeCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notaDeCredito.Name = "notaDeCredito";
            this.notaDeCredito.Size = new System.Drawing.Size(172, 22);
            this.notaDeCredito.TabIndex = 98;
            // 
            // buttongenerar
            // 
            this.buttongenerar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttongenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttongenerar.Location = new System.Drawing.Point(100, 527);
            this.buttongenerar.Margin = new System.Windows.Forms.Padding(2);
            this.buttongenerar.Name = "buttongenerar";
            this.buttongenerar.Size = new System.Drawing.Size(179, 34);
            this.buttongenerar.TabIndex = 99;
            this.buttongenerar.Text = "GENERAR";
            this.buttongenerar.UseVisualStyleBackColor = false;
            this.buttongenerar.Click += new System.EventHandler(this.buttongenerar_Click);
            // 
            // GenerarNotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 592);
            this.Controls.Add(this.buttongenerar);
            this.Controls.Add(this.notaDeCredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFactura);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datosFacturas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaEmision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelFactura);
            this.Controls.Add(this.labelGenerarFactura);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GenerarNotaCredito";
            this.Text = "Generar Notas de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.datosFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenerarFactura;
        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaEmision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datosFacturas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox descripcion;
        private System.Windows.Forms.TextBox textFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notaDeCredito;
        private System.Windows.Forms.Button buttongenerar;
    }
}