namespace Presentacion
{
    partial class Categoria_de_productos
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
            dataGridView_categoria = new DataGridView();
            actualizarcategoria = new Button();
            numericUpDown1 = new NumericUpDown();
            Resultado = new TextBox();
            Cortador = new Button();
            Buscardor = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_categoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_categoria
            // 
            dataGridView_categoria.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView_categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_categoria.Location = new Point(12, 12);
            dataGridView_categoria.Name = "dataGridView_categoria";
            dataGridView_categoria.Size = new Size(606, 310);
            dataGridView_categoria.TabIndex = 0;
            // 
            // actualizarcategoria
            // 
            actualizarcategoria.BackColor = Color.White;
            actualizarcategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            actualizarcategoria.Location = new Point(17, 354);
            actualizarcategoria.Name = "actualizarcategoria";
            actualizarcategoria.Size = new Size(86, 28);
            actualizarcategoria.TabIndex = 1;
            actualizarcategoria.Text = "Actualiuzar";
            actualizarcategoria.UseVisualStyleBackColor = false;
            actualizarcategoria.Click += actualizarcategoria_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(192, 192, 255);
            numericUpDown1.Location = new Point(17, 90);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // Resultado
            // 
            Resultado.BackColor = Color.FromArgb(192, 192, 255);
            Resultado.Location = new Point(17, 32);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(120, 23);
            Resultado.TabIndex = 3;
            // 
            // Cortador
            // 
            Cortador.BackColor = Color.White;
            Cortador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cortador.Location = new Point(98, 61);
            Cortador.Name = "Cortador";
            Cortador.Size = new Size(75, 23);
            Cortador.TabIndex = 4;
            Cortador.Text = "Cartar";
            Cortador.UseVisualStyleBackColor = false;
            Cortador.Click += Cortador_Click;
            // 
            // Buscardor
            // 
            Buscardor.BackColor = Color.White;
            Buscardor.BackgroundImageLayout = ImageLayout.None;
            Buscardor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buscardor.Location = new Point(17, 61);
            Buscardor.Name = "Buscardor";
            Buscardor.Size = new Size(75, 23);
            Buscardor.TabIndex = 5;
            Buscardor.Text = "Buacar";
            Buscardor.UseVisualStyleBackColor = false;
            Buscardor.Click += Buscardor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 1);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 6;
            label1.Text = "Resuldato";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(actualizarcategoria);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Buscardor);
            panel1.Controls.Add(Cortador);
            panel1.Controls.Add(Resultado);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(636, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 400);
            panel1.TabIndex = 7;
            // 
            // Categoria_de_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(857, 394);
            Controls.Add(dataGridView_categoria);
            Controls.Add(panel1);
            Name = "Categoria_de_productos";
            Text = "Categoria_de_productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView_categoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_categoria;
        private Button actualizarcategoria;
        private NumericUpDown numericUpDown1;
        private TextBox Resultado;
        private Button Cortador;
        private Button Buscardor;
        private Label label1;
        private Panel panel1;
    }
}