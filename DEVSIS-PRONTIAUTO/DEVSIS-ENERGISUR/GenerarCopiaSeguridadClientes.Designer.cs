namespace DEVSIS_ENERGISUR
{
    partial class GenerarCopiaSeguridadClientes
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
            this.tiempo_respaldo = new System.Windows.Forms.DateTimePicker();
            this.labelFE = new System.Windows.Forms.Label();
            this.tabla1 = new System.Windows.Forms.DataGridView();
            this.buttonEmitir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // tiempo_respaldo
            // 
            this.tiempo_respaldo.Location = new System.Drawing.Point(203, 61);
            this.tiempo_respaldo.Name = "tiempo_respaldo";
            this.tiempo_respaldo.Size = new System.Drawing.Size(200, 20);
            this.tiempo_respaldo.TabIndex = 0;
            // 
            // labelFE
            // 
            this.labelFE.AutoSize = true;
            this.labelFE.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFE.Location = new System.Drawing.Point(12, 61);
            this.labelFE.Name = "labelFE";
            this.labelFE.Size = new System.Drawing.Size(143, 21);
            this.labelFE.TabIndex = 1;
            this.labelFE.Text = "Fecha de Emisión";
            // 
            // tabla1
            // 
            this.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla1.GridColor = System.Drawing.SystemColors.Control;
            this.tabla1.Location = new System.Drawing.Point(16, 148);
            this.tabla1.Margin = new System.Windows.Forms.Padding(2);
            this.tabla1.Name = "tabla1";
            this.tabla1.RowHeadersWidth = 51;
            this.tabla1.RowTemplate.Height = 24;
            this.tabla1.Size = new System.Drawing.Size(789, 315);
            this.tabla1.TabIndex = 49;
            // 
            // buttonEmitir
            // 
            this.buttonEmitir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEmitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmitir.Location = new System.Drawing.Point(203, 483);
            this.buttonEmitir.Name = "buttonEmitir";
            this.buttonEmitir.Size = new System.Drawing.Size(151, 37);
            this.buttonEmitir.TabIndex = 50;
            this.buttonEmitir.Text = "GUARDAR";
            this.buttonEmitir.UseVisualStyleBackColor = false;
            this.buttonEmitir.Click += new System.EventHandler(this.buttonEmitir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(413, 483);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(159, 37);
            this.buttonCancelar.TabIndex = 51;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Generar copias de seguridad de clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 37);
            this.button1.TabIndex = 53;
            this.button1.Text = "MOSTRAR CLIENTES REGISTRADOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ruta
            // 
            this.txt_ruta.Enabled = false;
            this.txt_ruta.Location = new System.Drawing.Point(395, 112);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(385, 20);
            this.txt_ruta.TabIndex = 54;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(535, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 37);
            this.button2.TabIndex = 55;
            this.button2.Text = "Seleccionar destino";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GenerarCopiaSeguridadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 530);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEmitir);
            this.Controls.Add(this.tabla1);
            this.Controls.Add(this.labelFE);
            this.Controls.Add(this.tiempo_respaldo);
            this.Name = "GenerarCopiaSeguridadClientes";
            this.Text = "GenerarCopiaSeguridadClientes";
            this.Load += new System.EventHandler(this.GenerarCopiaSeguridadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tiempo_respaldo;
        private System.Windows.Forms.Label labelFE;
        private System.Windows.Forms.DataGridView tabla1;
        private System.Windows.Forms.Button buttonEmitir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Button button2;
    }
}