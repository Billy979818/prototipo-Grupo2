namespace DEVSIS_ENERGISUR
{
    partial class ConsultarNotaCredito
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
            this.busquedaNota = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eleccionNota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGenerarFactura
            // 
            this.labelGenerarFactura.AutoSize = true;
            this.labelGenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenerarFactura.Location = new System.Drawing.Point(253, 9);
            this.labelGenerarFactura.Name = "labelGenerarFactura";
            this.labelGenerarFactura.Size = new System.Drawing.Size(505, 36);
            this.labelGenerarFactura.TabIndex = 3;
            this.labelGenerarFactura.Text = "CONSULTAR NOTA DE CRÉDITO";
            // 
            // busquedaNota
            // 
            this.busquedaNota.Location = new System.Drawing.Point(576, 70);
            this.busquedaNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.busquedaNota.Name = "busquedaNota";
            this.busquedaNota.Size = new System.Drawing.Size(309, 22);
            this.busquedaNota.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 269);
            this.dataGridView1.TabIndex = 84;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 42);
            this.button1.TabIndex = 85;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(543, 415);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 42);
            this.button2.TabIndex = 86;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Consultar por: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // eleccionNota
            // 
            this.eleccionNota.FormattingEnabled = true;
            this.eleccionNota.Items.AddRange(new object[] {
            "Nota de crédito",
            "Factura"});
            this.eleccionNota.Location = new System.Drawing.Point(190, 68);
            this.eleccionNota.Name = "eleccionNota";
            this.eleccionNota.Size = new System.Drawing.Size(255, 24);
            this.eleccionNota.TabIndex = 88;
            this.eleccionNota.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.eleccionNota.Click += new System.EventHandler(this.eleccionNota_Click);
            this.eleccionNota.MouseCaptureChanged += new System.EventHandler(this.eleccionNota_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 89;
            this.label1.Text = "Búsqueda: ";
            // 
            // ConsultarNotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eleccionNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.busquedaNota);
            this.Controls.Add(this.labelGenerarFactura);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsultarNotaCredito";
            this.Text = "Consultar Nota de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenerarFactura;
        private System.Windows.Forms.TextBox busquedaNota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox eleccionNota;
        private System.Windows.Forms.Label label1;
    }
}