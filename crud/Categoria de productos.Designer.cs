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
            guaradarcategoria = new Button();
            editatcategoria = new Button();
            borrarcategoria = new Button();
            Ncategoria = new TextBox();
            Dcategoria = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_categoria).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_categoria
            // 
            dataGridView_categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_categoria.Location = new Point(12, 12);
            dataGridView_categoria.Name = "dataGridView_categoria";
            dataGridView_categoria.Size = new Size(625, 310);
            dataGridView_categoria.TabIndex = 0;
            // 
            // guaradarcategoria
            // 
            guaradarcategoria.Location = new Point(702, 125);
            guaradarcategoria.Name = "guaradarcategoria";
            guaradarcategoria.Size = new Size(86, 28);
            guaradarcategoria.TabIndex = 1;
            guaradarcategoria.Text = "Guardar";
            guaradarcategoria.UseVisualStyleBackColor = true;
            guaradarcategoria.Click += guaradarcategoria_Click;
            // 
            // editatcategoria
            // 
            editatcategoria.Location = new Point(659, 164);
            editatcategoria.Name = "editatcategoria";
            editatcategoria.Size = new Size(86, 28);
            editatcategoria.TabIndex = 2;
            editatcategoria.Text = "Editar";
            editatcategoria.UseVisualStyleBackColor = true;
            editatcategoria.Click += editatcategoria_Click;
            // 
            // borrarcategoria
            // 
            borrarcategoria.Location = new Point(751, 164);
            borrarcategoria.Name = "borrarcategoria";
            borrarcategoria.Size = new Size(86, 28);
            borrarcategoria.TabIndex = 3;
            borrarcategoria.Text = "Borrar";
            borrarcategoria.UseVisualStyleBackColor = true;
            borrarcategoria.Click += borrarcategoria_Click;
            // 
            // Ncategoria
            // 
            Ncategoria.Location = new Point(659, 35);
            Ncategoria.Name = "Ncategoria";
            Ncategoria.Size = new Size(183, 23);
            Ncategoria.TabIndex = 5;
            // 
            // Dcategoria
            // 
            Dcategoria.Location = new Point(659, 96);
            Dcategoria.Name = "Dcategoria";
            Dcategoria.Size = new Size(183, 23);
            Dcategoria.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(659, 11);
            label2.Name = "label2";
            label2.Size = new Size(172, 21);
            label2.TabIndex = 8;
            label2.Text = "Nombre de categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(659, 72);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 9;
            label3.Text = "Descripción";
            // 
            // Categoria_de_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 347);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Dcategoria);
            Controls.Add(Ncategoria);
            Controls.Add(borrarcategoria);
            Controls.Add(editatcategoria);
            Controls.Add(guaradarcategoria);
            Controls.Add(dataGridView_categoria);
            Name = "Categoria_de_productos";
            Text = "Categoria_de_productos";
            Load += Categoria_de_productos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_categoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_categoria;
        private Button guaradarcategoria;
        private Button editatcategoria;
        private Button borrarcategoria;
        private TextBox Ncategoria;
        private TextBox Dcategoria;
        private Label label2;
        private Label label3;
    }
}