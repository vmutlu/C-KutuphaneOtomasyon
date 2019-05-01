namespace Kutuphanem
{
    partial class Form5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sekreterGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaGirişiToolStripMenuItem,
            this.doktorGirişiToolStripMenuItem,
            this.sekreterGirişToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaGirişiToolStripMenuItem
            // 
            this.hastaGirişiToolStripMenuItem.Name = "hastaGirişiToolStripMenuItem";
            this.hastaGirişiToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.hastaGirişiToolStripMenuItem.Text = "Hasta Girişi";
            this.hastaGirişiToolStripMenuItem.Click += new System.EventHandler(this.hastaGirişiToolStripMenuItem_Click);
            // 
            // doktorGirişiToolStripMenuItem
            // 
            this.doktorGirişiToolStripMenuItem.Name = "doktorGirişiToolStripMenuItem";
            this.doktorGirişiToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.doktorGirişiToolStripMenuItem.Text = "Doktor Girişi";
            // 
            // sekreterGirişToolStripMenuItem
            // 
            this.sekreterGirişToolStripMenuItem.Name = "sekreterGirişToolStripMenuItem";
            this.sekreterGirişToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.sekreterGirişToolStripMenuItem.Text = "Sekreter Giriş";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 430);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sekreterGirişToolStripMenuItem;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}