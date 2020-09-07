namespace DEVSIS_ENERGISUR
{
    partial class ConsultarCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConsultarProducto
            // 
            this.labelConsultarProducto.AutoSize = true;
            this.labelConsultarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultarProducto.Location = new System.Drawing.Point(340, 9);
            this.labelConsultarProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsultarProducto.Name = "labelConsultarProducto";
            this.labelConsultarProducto.Size = new System.Drawing.Size(135, 18);
            this.labelConsultarProducto.TabIndex = 44;
            this.labelConsultarProducto.Text = "Consultar cliente";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(446, 52);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(316, 20);
            this.textCodigo.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(32, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 325);
            this.dataGridView1.TabIndex = 48;
            // 
            // botonConsultar
            // 
            this.botonConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultar.Location = new System.Drawing.Point(110, 422);
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(232, 39);
            this.botonConsultar.TabIndex = 49;
            this.botonConsultar.Text = "CONSULTAR";
            this.botonConsultar.UseVisualStyleBackColor = false;
            // 
            // botonRegresar
            // 
            this.botonCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(463, 422);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(232, 39);
            this.botonCancelar.TabIndex = 50;
            this.botonCancelar.Text = "CANCELAR";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cédula de ciudadanía",
            "Nombres completos"});
            this.comboBox1.Location = new System.Drawing.Point(32, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 28);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.Text = "Consultar ";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 472);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.labelConsultarProducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar cliente ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelConsultarProducto;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}