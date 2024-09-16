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
            label4 = new Label();
            label5 = new Label();
            Adicionar = new Button();
            TO_factura = new TextBox();
            label7 = new Label();
            COS_factura = new TextBox();
            button1 = new Button();
            CAN_factura = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Factura).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Factura
            // 
            dataGridView_Factura.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView_Factura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Factura.Location = new Point(12, 98);
            dataGridView_Factura.Name = "dataGridView_Factura";
            dataGridView_Factura.Size = new Size(723, 200);
            dataGridView_Factura.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 8);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 8;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 8);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 9;
            label5.Text = "Costo";
            // 
            // Adicionar
            // 
            Adicionar.BackColor = Color.White;
            Adicionar.Location = new Point(132, 61);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(131, 31);
            Adicionar.TabIndex = 12;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = false;
            Adicionar.Click += Adicionar_Click_1;
            // 
            // TO_factura
            // 
            TO_factura.BackColor = Color.FromArgb(224, 224, 224);
            TO_factura.Location = new Point(604, 307);
            TO_factura.Name = "TO_factura";
            TO_factura.Size = new Size(131, 23);
            TO_factura.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(534, 309);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 14;
            label7.Text = "Total:";
            // 
            // COS_factura
            // 
            COS_factura.BackColor = Color.FromArgb(224, 224, 224);
            COS_factura.Location = new Point(108, 32);
            COS_factura.Name = "COS_factura";
            COS_factura.Size = new Size(93, 23);
            COS_factura.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(12, 61);
            button1.Name = "button1";
            button1.Size = new Size(114, 31);
            button1.TabIndex = 19;
            button1.Text = "editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CAN_factura
            // 
            CAN_factura.BackColor = Color.FromArgb(224, 224, 224);
            CAN_factura.Location = new Point(12, 32);
            CAN_factura.Name = "CAN_factura";
            CAN_factura.Size = new Size(90, 23);
            CAN_factura.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(635, 336);
            button2.Name = "button2";
            button2.Size = new Size(100, 31);
            button2.TabIndex = 21;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(747, 374);
            Controls.Add(button2);
            Controls.Add(CAN_factura);
            Controls.Add(button1);
            Controls.Add(COS_factura);
            Controls.Add(TO_factura);
            Controls.Add(label7);
            Controls.Add(Adicionar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView_Factura);
            ForeColor = SystemColors.ControlText;
            Name = "Factura";
            Text = "Facturacs";
            Load += Factura_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_Factura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Factura;
        private Label label4;
        private Label label5;
        private Button Adicionar;
        private TextBox TO_factura;
        private Label label7;
        private TextBox COS_factura;
        private Button button1;
        private TextBox CAN_factura;
        private Button button2;
    }
}