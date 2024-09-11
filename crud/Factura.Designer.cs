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
            label2 = new Label();
            CAN_factura = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            Adicionar = new Button();
            Guardar = new Button();
            dataGridView_Factura = new DataGridView();
            label5 = new Label();
            textBox2 = new TextBox();
            PRO_factura = new TextBox();
            COS_factura = new Label();
            MEP_factura = new ComboBox();
            label1 = new Label();
            CLI_factura = new TextBox();
            label6 = new Label();
            FEC_factura = new DateTimePicker();
            DT_cliente = new DataGridViewTextBoxColumn();
            DT_mediopago = new DataGridViewTextBoxColumn();
            DT_producto = new DataGridViewTextBoxColumn();
            DT_cantidad = new DataGridViewTextBoxColumn();
            DT_fecha = new DataGridViewTextBoxColumn();
            DT_costo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)CAN_factura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Factura).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 105);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 2;
            label2.Text = "Producto";
            // 
            // CAN_factura
            // 
            CAN_factura.Location = new Point(178, 130);
            CAN_factura.Name = "CAN_factura";
            CAN_factura.Size = new Size(41, 23);
            CAN_factura.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(163, 106);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(279, 105);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 7;
            label4.Text = "Costo";
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(365, 121);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(136, 36);
            Adicionar.TabIndex = 8;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(521, 399);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(136, 36);
            Guardar.TabIndex = 9;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Factura
            // 
            dataGridView_Factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Factura.Columns.AddRange(new DataGridViewColumn[] { DT_cliente, DT_mediopago, DT_producto, DT_cantidad, DT_fecha, DT_costo });
            dataGridView_Factura.Location = new Point(12, 164);
            dataGridView_Factura.Name = "dataGridView_Factura";
            dataGridView_Factura.Size = new Size(645, 190);
            dataGridView_Factura.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(462, 362);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 12;
            label5.Text = "Total:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(521, 360);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 11;
            // 
            // PRO_factura
            // 
            PRO_factura.Location = new Point(15, 130);
            PRO_factura.Name = "PRO_factura";
            PRO_factura.Size = new Size(126, 23);
            PRO_factura.TabIndex = 3;
            // 
            // COS_factura
            // 
            COS_factura.AutoSize = true;
            COS_factura.Location = new Point(279, 132);
            COS_factura.Name = "COS_factura";
            COS_factura.Size = new Size(44, 15);
            COS_factura.TabIndex = 14;
            COS_factura.Text = "consos";
            // 
            // MEP_factura
            // 
            MEP_factura.FormattingEnabled = true;
            MEP_factura.Location = new Point(15, 79);
            MEP_factura.Name = "MEP_factura";
            MEP_factura.Size = new Size(121, 23);
            MEP_factura.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 55);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 16;
            label1.Text = "Medio de pago";
            // 
            // CLI_factura
            // 
            CLI_factura.Location = new Point(15, 34);
            CLI_factura.Name = "CLI_factura";
            CLI_factura.Size = new Size(126, 23);
            CLI_factura.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 9);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 17;
            label6.Text = "Cliente";
            // 
            // FEC_factura
            // 
            FEC_factura.Location = new Point(163, 34);
            FEC_factura.Name = "FEC_factura";
            FEC_factura.Size = new Size(200, 23);
            FEC_factura.TabIndex = 19;
            // 
            // DT_cliente
            // 
            DT_cliente.HeaderText = "Cliente";
            DT_cliente.Name = "DT_cliente";
            // 
            // DT_mediopago
            // 
            DT_mediopago.HeaderText = "Medio de Pago";
            DT_mediopago.Name = "DT_mediopago";
            // 
            // DT_producto
            // 
            DT_producto.HeaderText = "Producto";
            DT_producto.Name = "DT_producto";
            // 
            // DT_cantidad
            // 
            DT_cantidad.HeaderText = "Cantidad";
            DT_cantidad.Name = "DT_cantidad";
            // 
            // DT_fecha
            // 
            DT_fecha.HeaderText = "Fecha";
            DT_fecha.Name = "DT_fecha";
            // 
            // DT_costo
            // 
            DT_costo.HeaderText = "Costo";
            DT_costo.Name = "DT_costo";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 450);
            Controls.Add(FEC_factura);
            Controls.Add(CLI_factura);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(MEP_factura);
            Controls.Add(COS_factura);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(dataGridView_Factura);
            Controls.Add(Guardar);
            Controls.Add(Adicionar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CAN_factura);
            Controls.Add(PRO_factura);
            Controls.Add(label2);
            Name = "Factura";
            Text = "Factura";
            Load += Factura_Load;
            ((System.ComponentModel.ISupportInitialize)CAN_factura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Factura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private NumericUpDown CAN_factura;
        private Label label3;
        private Label label4;
        private Button Adicionar;
        private Button Guardar;
        private DataGridView dataGridView_Factura;
        private Label label5;
        private TextBox textBox2;
        private TextBox PRO_factura;
        private Label COS_factura;
        private ComboBox MEP_factura;
        private Label label1;
        private TextBox CLI_factura;
        private Label label6;
        private DataGridViewTextBoxColumn DT_cliente;
        private DataGridViewTextBoxColumn DT_mediopago;
        private DataGridViewTextBoxColumn DT_producto;
        private DataGridViewTextBoxColumn DT_cantidad;
        private DataGridViewTextBoxColumn DT_fecha;
        private DataGridViewTextBoxColumn DT_costo;
        private DateTimePicker FEC_factura;
    }
}