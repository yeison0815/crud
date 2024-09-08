namespace Presentacion
{
    partial class Medios_de_pago
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            Nmediopago = new TextBox();
            Dmediopago = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(850, 242);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 267);
            label1.Name = "label1";
            label1.Size = new Size(215, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Medio de pago";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 320);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 2;
            label2.Text = "Descripción";
            // 
            // Nmediopago
            // 
            Nmediopago.Location = new Point(12, 291);
            Nmediopago.Name = "Nmediopago";
            Nmediopago.Size = new Size(215, 23);
            Nmediopago.TabIndex = 3;
            // 
            // Dmediopago
            // 
            Dmediopago.Location = new Point(12, 344);
            Dmediopago.Name = "Dmediopago";
            Dmediopago.Size = new Size(215, 23);
            Dmediopago.TabIndex = 4;
            // 
            // Medios_de_pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 407);
            Controls.Add(Dmediopago);
            Controls.Add(Nmediopago);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Medios_de_pago";
            Text = "Medios_de_pago";
            Load += Medios_de_pago_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox Nmediopago;
        private TextBox Dmediopago;
    }
}