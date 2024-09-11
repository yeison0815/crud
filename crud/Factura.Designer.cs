namespace Presentacion
{
    partial class Factura
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
            label1 = new Label();
            CLI_factura = new TextBox();
            MEP_factura = new TextBox();
            label2 = new Label();
            PRO_factura = new TextBox();
            label3 = new Label();
            CAN_factura = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            FEC_factura = new DateTimePicker();
            Adicionar = new Button();
            Guardar = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Factura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CAN_factura).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Factura
            // 
            dataGridView_Factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Factura.Location = new Point(12, 164);
            dataGridView_Factura.Name = "dataGridView_Factura";
            dataGridView_Factura.Size = new Size(719, 200);
            dataGridView_Factura.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // CLI_factura
            // 
            CLI_factura.Location = new Point(12, 33);
            CLI_factura.Name = "CLI_factura";
            CLI_factura.Size = new Size(145, 23);
            CLI_factura.TabIndex = 2;
            // 
            // MEP_factura
            // 
            MEP_factura.Location = new Point(12, 85);
            MEP_factura.Name = "MEP_factura";
            MEP_factura.Size = new Size(145, 23);
            MEP_factura.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 61);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 3;
            label2.Text = "Medio de pago";
            // 
            // PRO_factura
            // 
            PRO_factura.Location = new Point(12, 135);
            PRO_factura.Name = "PRO_factura";
            PRO_factura.Size = new Size(145, 23);
            PRO_factura.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 111);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 5;
            label3.Text = "Producto";
            // 
            // CAN_factura
            // 
            CAN_factura.Location = new Point(198, 135);
            CAN_factura.Name = "CAN_factura";
            CAN_factura.Size = new Size(79, 23);
            CAN_factura.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(198, 111);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 8;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(294, 111);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 9;
            label5.Text = "Costo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 138);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 10;
            label6.Text = "valor costo";
            // 
            // FEC_factura
            // 
            FEC_factura.Location = new Point(180, 33);
            FEC_factura.Name = "FEC_factura";
            FEC_factura.Size = new Size(200, 23);
            FEC_factura.TabIndex = 11;
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(401, 122);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(131, 31);
            Adicionar.TabIndex = 12;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(600, 407);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(131, 31);
            Guardar.TabIndex = 13;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(600, 378);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 15;
            textBox1.Text = "TO_factura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(530, 380);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 14;
            label7.Text = "Total:";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(Guardar);
            Controls.Add(Adicionar);
            Controls.Add(FEC_factura);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CAN_factura);
            Controls.Add(PRO_factura);
            Controls.Add(label3);
            Controls.Add(MEP_factura);
            Controls.Add(label2);
            Controls.Add(CLI_factura);
            Controls.Add(label1);
            Controls.Add(dataGridView_Factura);
            Name = "Factura";
            Text = "Facturacs";
            Load += Factura_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Factura).EndInit();
            ((System.ComponentModel.ISupportInitialize)CAN_factura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Factura;
        private Label label1;
        private TextBox CLI_factura;
        private TextBox MEP_factura;
        private Label label2;
        private TextBox PRO_factura;
        private Label label3;
        private NumericUpDown CAN_factura;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker FEC_factura;
        private Button Adicionar;
        private Button Guardar;
        private TextBox textBox1;
        private Label label7;
    }
}