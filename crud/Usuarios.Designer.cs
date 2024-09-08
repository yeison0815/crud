namespace Presentacion
{
    partial class Usuarios
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
            menuStrip1 = new MenuStrip();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            usuariosPrincipalesToolStripMenuItem = new ToolStripMenuItem();
            profuctosToolStripMenuItem = new ToolStripMenuItem();
            categoriasDeProductosToolStripMenuItem = new ToolStripMenuItem();
            mediosDePagoToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            facturaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, profuctosToolStripMenuItem, mediosDePagoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, usuariosPrincipalesToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(180, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // usuariosPrincipalesToolStripMenuItem
            // 
            usuariosPrincipalesToolStripMenuItem.Name = "usuariosPrincipalesToolStripMenuItem";
            usuariosPrincipalesToolStripMenuItem.Size = new Size(180, 22);
            usuariosPrincipalesToolStripMenuItem.Text = "Usuarios principales";
            usuariosPrincipalesToolStripMenuItem.Click += usuariosPrincipalesToolStripMenuItem_Click;
            // 
            // profuctosToolStripMenuItem
            // 
            profuctosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriasDeProductosToolStripMenuItem, productoToolStripMenuItem });
            profuctosToolStripMenuItem.Name = "profuctosToolStripMenuItem";
            profuctosToolStripMenuItem.Size = new Size(72, 20);
            profuctosToolStripMenuItem.Text = "Inventario";
            // 
            // categoriasDeProductosToolStripMenuItem
            // 
            categoriasDeProductosToolStripMenuItem.Name = "categoriasDeProductosToolStripMenuItem";
            categoriasDeProductosToolStripMenuItem.Size = new Size(203, 22);
            categoriasDeProductosToolStripMenuItem.Text = "Categorias de productos";
            categoriasDeProductosToolStripMenuItem.Click += categoriasDeProductosToolStripMenuItem_Click;
            // 
            // mediosDePagoToolStripMenuItem
            // 
            mediosDePagoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaToolStripMenuItem });
            mediosDePagoToolStripMenuItem.Name = "mediosDePagoToolStripMenuItem";
            mediosDePagoToolStripMenuItem.Size = new Size(104, 20);
            mediosDePagoToolStripMenuItem.Text = "Medios de pago";
            mediosDePagoToolStripMenuItem.Click += mediosDePagoToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(203, 22);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // facturaToolStripMenuItem
            // 
            facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            facturaToolStripMenuItem.Size = new Size(180, 22);
            facturaToolStripMenuItem.Text = "Factura";
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Usuarios";
            Text = "Usuarios";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem usuariosPrincipalesToolStripMenuItem;
        private ToolStripMenuItem profuctosToolStripMenuItem;
        private ToolStripMenuItem categoriasDeProductosToolStripMenuItem;
        private ToolStripMenuItem mediosDePagoToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem facturaToolStripMenuItem;
    }
}