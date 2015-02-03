namespace DocService
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Preferenze = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.impostazioni = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Icona = new System.Windows.Forms.NotifyIcon(this.components);
            this.Preferenze.SuspendLayout();
            this.SuspendLayout();
            // 
            // Preferenze
            // 
            this.Preferenze.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impostazioni,
            this.About});
            this.Preferenze.Name = "Preferenze";
            this.Preferenze.Size = new System.Drawing.Size(143, 48);
            this.Preferenze.Text = "Menu";
            // 
            // impostazioni
            // 
            this.impostazioni.AccessibleName = "";
            this.impostazioni.Name = "impostazioni";
            this.impostazioni.Size = new System.Drawing.Size(152, 22);
            this.impostazioni.Text = "Impostazioni";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(152, 22);
            this.About.Text = "About";
            // 
            // Icona
            // 
            this.Icona.ContextMenuStrip = this.Preferenze;
            this.Icona.Icon = ((System.Drawing.Icon)(resources.GetObject("Icona.Icon")));
            this.Icona.Text = "DocService";
            this.Icona.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.Text = "Form1";
            this.Preferenze.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Preferenze;
        private System.Windows.Forms.ToolStripMenuItem impostazioni;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.NotifyIcon Icona;
    }
}