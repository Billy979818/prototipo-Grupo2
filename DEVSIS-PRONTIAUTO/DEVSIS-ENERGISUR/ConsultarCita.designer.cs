namespace DEVSIS_ENERGISUR
{
    partial class ConsultarCita
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.labelConsultarProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fecha",
            "Placa"});
            this.comboBox1.Location = new System.Drawing.Point(45, 67);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(392, 32);
            this.comboBox1.TabIndex = 57;
            this.comboBox1.Text = "Seleccionar parámetro de búsqueda";
            // 
            // botonCancelar
            // 
            this.botonCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(560, 501);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(309, 48);
            this.botonCancelar.TabIndex = 56;
            this.botonCancelar.Text = "CANCELAR";
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonConsultar
            // 
            this.botonConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultar.Location = new System.Drawing.Point(166, 501);
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(309, 48);
            this.botonConsultar.TabIndex = 55;
            this.botonConsultar.Text = "CONSULTAR";
            this.botonConsultar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(45, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 351);
            this.dataGridView1.TabIndex = 54;
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(484, 73);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(468, 22);
            this.textCodigo.TabIndex = 53;
            // 
            // labelConsultarProducto
            // 
            this.labelConsultarProducto.AutoSize = true;
            this.labelConsultarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultarProducto.Location = new System.Drawing.Point(401, 20);
            this.labelConsultarProducto.Name = "labelConsultarProducto";
            this.labelConsultarProducto.Size = new System.Drawing.Size(186, 24);
            this.labelConsultarProducto.TabIndex = 52;
            this.labelConsultarProducto.Text = "CONSULTAR CITA";
            // 
            // ConsultarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 568);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.labelConsultarProducto);
            this.Name = "ConsultarCita";
            this.Text = "Consultar cita";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label labelConsultarProducto;
    }
}