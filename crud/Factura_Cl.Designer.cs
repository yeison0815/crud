namespace Presentacion
{
    partial class Factura_Cl
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
            dataGridView_Factura = new DataGridView();
            actualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Factura).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Factura
            // 
            dataGridView_Factura.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView_Factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Factura.Location = new Point(12, 12);
            dataGridView_Factura.Name = "dataGridView_Factura";
            dataGridView_Factura.Size = new Size(686, 333);
            dataGridView_Factura.TabIndex = 0;
            // 
            // actualizar
            // 
            actualizar.Location = new Point(12, 360);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(104, 26);
            actualizar.TabIndex = 1;
            actualizar.Text = "Actualizar";
            actualizar.UseVisualStyleBackColor = true;
            actualizar.Click += actualizar_Click;
            // 
            // Factura_Cl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(actualizar);
            Controls.Add(dataGridView_Factura);
            Name = "Factura_Cl";
            Text = "Factura";
            Load += Factura_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Factura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_Factura;
        private Button actualizar;
    }
}