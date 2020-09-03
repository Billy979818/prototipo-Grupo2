namespace DEVSIS_ENERGISUR
{
    partial class ConsultarNombreCliente
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
            this.labelConsultarProducto = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.botonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConsultarProducto
            // 
            this.labelConsultarProducto.AutoSize = true;
            this.labelConsultarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultarProducto.Location = new System.Drawing.Point(368, 9);
            this.labelConsultarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsultarProducto.Name = "labelConsultarProducto";
            this.labelConsultarProducto.Size = new System.Drawing.Size(135, 18);
            this.labelConsultarProducto.TabIndex = 45;
            this.labelConsultarProducto.Text = "Consultar cliente";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(359, 45);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(316, 20);
            this.textCodigo.TabIndex = 47;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(120, 44);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(144, 18);
            this.labelCodigo.TabIndex = 48;
            this.labelCodigo.Text = "Nombres completos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(62, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 325);
            this.dataGridView1.TabIndex = 49;
            // 
            // botonConsultar
            // 
            this.botonConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultar.Location = new System.Drawing.Point(137, 428);
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(232, 39);
            this.botonConsultar.TabIndex = 50;
            this.botonConsultar.Text = "CONSULTAR";
            this.botonConsultar.UseVisualStyleBackColor = false;
            // 
            // botonRegresar
            // 
            this.botonRegresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegresar.Location = new System.Drawing.Point(487, 428);
            this.botonRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(232, 39);
            this.botonRegresar.TabIndex = 51;
            this.botonRegresar.Text = "CANCELAR";
            this.botonRegresar.UseVisualStyleBackColor = false;
            // 
            // ConsultarNombreCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 489);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.labelConsultarProducto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultarNombreCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar cliente mediante sus nombres completos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConsultarProducto;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Button botonRegresar;
    }
}