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
            dataGridView_Mediopago = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            Vmediopago = new TextBox();
            GuardarMedios = new Button();
            EditarMedios = new Button();
            BorrarMedios = new Button();
            Nmediopago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Mediopago).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Mediopago
            // 
            dataGridView_Mediopago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Mediopago.Location = new Point(12, 12);
            dataGridView_Mediopago.Name = "dataGridView_Mediopago";
            dataGridView_Mediopago.Size = new Size(403, 242);
            dataGridView_Mediopago.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 267);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 1;
            label1.Text = "Medio de pago:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 320);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 2;
            label2.Text = "Valor:";
            // 
            // Vmediopago
            // 
            Vmediopago.Location = new Point(12, 344);
            Vmediopago.Name = "Vmediopago";
            Vmediopago.Size = new Size(142, 23);
            Vmediopago.TabIndex = 4;
            // 
            // GuardarMedios
            // 
            GuardarMedios.Location = new Point(251, 291);
            GuardarMedios.Name = "GuardarMedios";
            GuardarMedios.Size = new Size(79, 32);
            GuardarMedios.TabIndex = 5;
            GuardarMedios.Text = "Guardar";
            GuardarMedios.UseVisualStyleBackColor = true;
            GuardarMedios.Click += GuardarMedios_Click;
            // 
            // EditarMedios
            // 
            EditarMedios.Location = new Point(251, 338);
            EditarMedios.Name = "EditarMedios";
            EditarMedios.Size = new Size(79, 32);
            EditarMedios.TabIndex = 6;
            EditarMedios.Text = "Editar";
            EditarMedios.UseVisualStyleBackColor = true;
            EditarMedios.Click += EditarMedios_Click;
            // 
            // BorrarMedios
            // 
            BorrarMedios.Location = new Point(336, 316);
            BorrarMedios.Name = "BorrarMedios";
            BorrarMedios.Size = new Size(79, 32);
            BorrarMedios.TabIndex = 7;
            BorrarMedios.Text = "Borrar";
            BorrarMedios.UseVisualStyleBackColor = true;
            // 
            // Nmediopago
            // 
            Nmediopago.FormattingEnabled = true;
            Nmediopago.Items.AddRange(new object[] { "BancoColombia", "Nequi", "DaviPlata", "BBVA" });
            Nmediopago.Location = new Point(12, 291);
            Nmediopago.Name = "Nmediopago";
            Nmediopago.Size = new Size(142, 23);
            Nmediopago.TabIndex = 8;
            Nmediopago.SelectedIndexChanged += Nmediopago_SelectedIndexChanged;
            // 
            // Medios_de_pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 407);
            Controls.Add(Nmediopago);
            Controls.Add(BorrarMedios);
            Controls.Add(EditarMedios);
            Controls.Add(GuardarMedios);
            Controls.Add(Vmediopago);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView_Mediopago);
            Name = "Medios_de_pago";
            Text = "Medios_de_pago";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Mediopago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Mediopago;
        private Label label1;
        private Label label2;
        private TextBox Vmediopago;
        private Button GuardarMedios;
        private Button EditarMedios;
        private Button BorrarMedios;
        private ComboBox Nmediopago;
    }
}