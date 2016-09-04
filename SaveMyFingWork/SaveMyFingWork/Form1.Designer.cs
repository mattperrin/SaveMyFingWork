namespace SaveMyFingWork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_DeleteAllBackups = new System.Windows.Forms.Button();
            this.btn_ToggleMonitor = new System.Windows.Forms.Button();
            this.btn_AddDirectoryToMonitor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DeleteAllBackups
            // 
            this.btn_DeleteAllBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteAllBackups.Location = new System.Drawing.Point(636, 27);
            this.btn_DeleteAllBackups.Name = "btn_DeleteAllBackups";
            this.btn_DeleteAllBackups.Size = new System.Drawing.Size(148, 23);
            this.btn_DeleteAllBackups.TabIndex = 0;
            this.btn_DeleteAllBackups.Text = "Delete All Backups";
            this.btn_DeleteAllBackups.UseVisualStyleBackColor = true;
            this.btn_DeleteAllBackups.Click += new System.EventHandler(this.btn_DeleteAllBackups_Click);
            // 
            // btn_ToggleMonitor
            // 
            this.btn_ToggleMonitor.Location = new System.Drawing.Point(166, 27);
            this.btn_ToggleMonitor.Name = "btn_ToggleMonitor";
            this.btn_ToggleMonitor.Size = new System.Drawing.Size(148, 23);
            this.btn_ToggleMonitor.TabIndex = 2;
            this.btn_ToggleMonitor.Text = "Start Monitoring";
            this.btn_ToggleMonitor.UseVisualStyleBackColor = true;
            this.btn_ToggleMonitor.Click += new System.EventHandler(this.btn_ToggleMonitor_Click);
            // 
            // btn_AddDirectoryToMonitor
            // 
            this.btn_AddDirectoryToMonitor.Location = new System.Drawing.Point(12, 27);
            this.btn_AddDirectoryToMonitor.Name = "btn_AddDirectoryToMonitor";
            this.btn_AddDirectoryToMonitor.Size = new System.Drawing.Size(148, 23);
            this.btn_AddDirectoryToMonitor.TabIndex = 4;
            this.btn_AddDirectoryToMonitor.Text = "Add Directory To Monitor";
            this.btn_AddDirectoryToMonitor.UseVisualStyleBackColor = true;
            this.btn_AddDirectoryToMonitor.Click += new System.EventHandler(this.btn_AddDirectoryToMonitor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.infoToolStripMenuItem.Text = "About";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 413);
            this.Controls.Add(this.btn_AddDirectoryToMonitor);
            this.Controls.Add(this.btn_ToggleMonitor);
            this.Controls.Add(this.btn_DeleteAllBackups);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Save My F***ing Work";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteAllBackups;
        private System.Windows.Forms.Button btn_ToggleMonitor;
        private System.Windows.Forms.Button btn_AddDirectoryToMonitor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

