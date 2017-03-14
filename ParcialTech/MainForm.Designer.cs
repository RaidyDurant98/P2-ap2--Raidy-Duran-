namespace ParcialTech
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retencionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retencionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoEmailToolStripMenuItem,
            this.retencionesToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // tipoEmailToolStripMenuItem
            // 
            this.tipoEmailToolStripMenuItem.Name = "tipoEmailToolStripMenuItem";
            this.tipoEmailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tipoEmailToolStripMenuItem.Text = "Tipos Emails";
            this.tipoEmailToolStripMenuItem.Click += new System.EventHandler(this.tipoEmailToolStripMenuItem_Click);
            // 
            // retencionesToolStripMenuItem
            // 
            this.retencionesToolStripMenuItem.Name = "retencionesToolStripMenuItem";
            this.retencionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.retencionesToolStripMenuItem.Text = "Retenciones";
            this.retencionesToolStripMenuItem.Click += new System.EventHandler(this.retencionesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoEmailsToolStripMenuItem,
            this.retencionesToolStripMenuItem1,
            this.empleadosToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tipoEmailsToolStripMenuItem
            // 
            this.tipoEmailsToolStripMenuItem.Name = "tipoEmailsToolStripMenuItem";
            this.tipoEmailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tipoEmailsToolStripMenuItem.Text = "Tipo Emails";
            this.tipoEmailsToolStripMenuItem.Click += new System.EventHandler(this.tipoEmailsToolStripMenuItem_Click);
            // 
            // retencionesToolStripMenuItem1
            // 
            this.retencionesToolStripMenuItem1.Name = "retencionesToolStripMenuItem1";
            this.retencionesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.retencionesToolStripMenuItem1.Text = "Retenciones";
            this.retencionesToolStripMenuItem1.Click += new System.EventHandler(this.retencionesToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retencionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retencionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

