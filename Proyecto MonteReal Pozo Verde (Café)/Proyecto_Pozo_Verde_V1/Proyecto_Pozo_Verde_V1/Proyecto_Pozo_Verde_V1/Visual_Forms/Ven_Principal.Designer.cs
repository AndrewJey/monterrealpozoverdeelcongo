namespace Proyecto_Pozo_Verde_V1.Visual_Forms
{
    partial class Ven_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ven_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // facturaciónToolStripMenuItem
            // 
            resources.ApplyResources(this.facturaciónToolStripMenuItem, "facturaciónToolStripMenuItem");
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem1,
            this.inventarioToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.facturaciónToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            // 
            // facturaciónToolStripMenuItem1
            // 
            resources.ApplyResources(this.facturaciónToolStripMenuItem1, "facturaciónToolStripMenuItem1");
            this.facturaciónToolStripMenuItem1.ForeColor = System.Drawing.Color.Maroon;
            this.facturaciónToolStripMenuItem1.Name = "facturaciónToolStripMenuItem1";
            this.facturaciónToolStripMenuItem1.Click += new System.EventHandler(this.facturaciónToolStripMenuItem1_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            resources.ApplyResources(this.inventarioToolStripMenuItem, "inventarioToolStripMenuItem");
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            // 
            // usuariosToolStripMenuItem
            // 
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            // 
            // ayudaToolStripMenuItem
            // 
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            // 
            // Ven_Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ven_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}