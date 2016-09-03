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
            this.btn_DeleteAllBackups = new System.Windows.Forms.Button();
            this.btn_ToggleMonitor = new System.Windows.Forms.Button();
            this.btn_AddDirectoryToMonitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DeleteAllBackups
            // 
            this.btn_DeleteAllBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteAllBackups.Location = new System.Drawing.Point(636, 12);
            this.btn_DeleteAllBackups.Name = "btn_DeleteAllBackups";
            this.btn_DeleteAllBackups.Size = new System.Drawing.Size(148, 23);
            this.btn_DeleteAllBackups.TabIndex = 0;
            this.btn_DeleteAllBackups.Text = "Delete All Backups";
            this.btn_DeleteAllBackups.UseVisualStyleBackColor = true;
            this.btn_DeleteAllBackups.Click += new System.EventHandler(this.btn_DeleteAllBackups_Click);
            // 
            // btn_ToggleMonitor
            // 
            this.btn_ToggleMonitor.Location = new System.Drawing.Point(166, 12);
            this.btn_ToggleMonitor.Name = "btn_ToggleMonitor";
            this.btn_ToggleMonitor.Size = new System.Drawing.Size(148, 23);
            this.btn_ToggleMonitor.TabIndex = 2;
            this.btn_ToggleMonitor.Text = "Start Monitoring";
            this.btn_ToggleMonitor.UseVisualStyleBackColor = true;
            this.btn_ToggleMonitor.Click += new System.EventHandler(this.btn_ToggleMonitor_Click);
            // 
            // btn_AddDirectoryToMonitor
            // 
            this.btn_AddDirectoryToMonitor.Location = new System.Drawing.Point(12, 12);
            this.btn_AddDirectoryToMonitor.Name = "btn_AddDirectoryToMonitor";
            this.btn_AddDirectoryToMonitor.Size = new System.Drawing.Size(148, 23);
            this.btn_AddDirectoryToMonitor.TabIndex = 4;
            this.btn_AddDirectoryToMonitor.Text = "Add Directory To Monitor";
            this.btn_AddDirectoryToMonitor.UseVisualStyleBackColor = true;
            this.btn_AddDirectoryToMonitor.Click += new System.EventHandler(this.btn_AddDirectoryToMonitor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 413);
            this.Controls.Add(this.btn_AddDirectoryToMonitor);
            this.Controls.Add(this.btn_ToggleMonitor);
            this.Controls.Add(this.btn_DeleteAllBackups);
            this.Name = "Form1";
            this.Text = "Save My F***ing Work";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DeleteAllBackups;
        private System.Windows.Forms.Button btn_ToggleMonitor;
        private System.Windows.Forms.Button btn_AddDirectoryToMonitor;
    }
}

