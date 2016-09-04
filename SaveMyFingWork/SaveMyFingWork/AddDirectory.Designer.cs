namespace SaveMyFIngWork
{
    partial class AddDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDirectory));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DirectoryToMonitor = new System.Windows.Forms.TextBox();
            this.txt_BackupToDirectory = new System.Windows.Forms.TextBox();
            this.btnOkAdd = new System.Windows.Forms.Button();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_DirectoryToMonitorSelectDialog = new System.Windows.Forms.Button();
            this.btn_BackupToSelectDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory to Monitor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Backup To Directory:";
            // 
            // txt_DirectoryToMonitor
            // 
            this.txt_DirectoryToMonitor.Location = new System.Drawing.Point(12, 40);
            this.txt_DirectoryToMonitor.Name = "txt_DirectoryToMonitor";
            this.txt_DirectoryToMonitor.Size = new System.Drawing.Size(385, 20);
            this.txt_DirectoryToMonitor.TabIndex = 2;
            // 
            // txt_BackupToDirectory
            // 
            this.txt_BackupToDirectory.Location = new System.Drawing.Point(12, 95);
            this.txt_BackupToDirectory.Name = "txt_BackupToDirectory";
            this.txt_BackupToDirectory.Size = new System.Drawing.Size(385, 20);
            this.txt_BackupToDirectory.TabIndex = 3;
            // 
            // btnOkAdd
            // 
            this.btnOkAdd.Location = new System.Drawing.Point(12, 131);
            this.btnOkAdd.Name = "btnOkAdd";
            this.btnOkAdd.Size = new System.Drawing.Size(75, 23);
            this.btnOkAdd.TabIndex = 4;
            this.btnOkAdd.Text = "OK";
            this.btnOkAdd.UseVisualStyleBackColor = true;
            this.btnOkAdd.Click += new System.EventHandler(this.btnOkAdd_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(93, 131);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAdd.TabIndex = 5;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btn_DirectoryToMonitorSelectDialog
            // 
            this.btn_DirectoryToMonitorSelectDialog.Location = new System.Drawing.Point(403, 38);
            this.btn_DirectoryToMonitorSelectDialog.Name = "btn_DirectoryToMonitorSelectDialog";
            this.btn_DirectoryToMonitorSelectDialog.Size = new System.Drawing.Size(24, 23);
            this.btn_DirectoryToMonitorSelectDialog.TabIndex = 6;
            this.btn_DirectoryToMonitorSelectDialog.Text = "...";
            this.btn_DirectoryToMonitorSelectDialog.UseVisualStyleBackColor = true;
            this.btn_DirectoryToMonitorSelectDialog.Click += new System.EventHandler(this.btn_DirectoryToMonitorSelectDialog_Click);
            // 
            // btn_BackupToSelectDialog
            // 
            this.btn_BackupToSelectDialog.Location = new System.Drawing.Point(403, 92);
            this.btn_BackupToSelectDialog.Name = "btn_BackupToSelectDialog";
            this.btn_BackupToSelectDialog.Size = new System.Drawing.Size(24, 23);
            this.btn_BackupToSelectDialog.TabIndex = 7;
            this.btn_BackupToSelectDialog.Text = "...";
            this.btn_BackupToSelectDialog.UseVisualStyleBackColor = true;
            this.btn_BackupToSelectDialog.Click += new System.EventHandler(this.btn_BackupToSelectDialog_Click);
            // 
            // AddDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 171);
            this.Controls.Add(this.btn_BackupToSelectDialog);
            this.Controls.Add(this.btn_DirectoryToMonitorSelectDialog);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnOkAdd);
            this.Controls.Add(this.txt_BackupToDirectory);
            this.Controls.Add(this.txt_DirectoryToMonitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDirectory";
            this.Text = "Add New Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DirectoryToMonitor;
        private System.Windows.Forms.TextBox txt_BackupToDirectory;
        private System.Windows.Forms.Button btnOkAdd;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_DirectoryToMonitorSelectDialog;
        private System.Windows.Forms.Button btn_BackupToSelectDialog;
    }
}