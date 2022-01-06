namespace lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.browse_bt = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.decoratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.path_tb = new System.Windows.Forms.TextBox();
            this.fileContent_rtb = new System.Windows.Forms.RichTextBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse_bt
            // 
            this.browse_bt.Location = new System.Drawing.Point(277, 27);
            this.browse_bt.Name = "browse_bt";
            this.browse_bt.Size = new System.Drawing.Size(75, 23);
            this.browse_bt.TabIndex = 0;
            this.browse_bt.Text = "Browse";
            this.browse_bt.UseVisualStyleBackColor = true;
            this.browse_bt.Click += new System.EventHandler(this.browse_bt_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.decoratorsToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(364, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // decoratorsToolStripMenuItem
            // 
            this.decoratorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptionToolStripMenuItem,
            this.compressionToolStripMenuItem});
            this.decoratorsToolStripMenuItem.Name = "decoratorsToolStripMenuItem";
            this.decoratorsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.decoratorsToolStripMenuItem.Text = "Decorators";
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.CheckOnClick = true;
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encryptionToolStripMenuItem.Text = "Encryption";
            // 
            // compressionToolStripMenuItem
            // 
            this.compressionToolStripMenuItem.CheckOnClick = true;
            this.compressionToolStripMenuItem.Name = "compressionToolStripMenuItem";
            this.compressionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compressionToolStripMenuItem.Text = "Compression";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // path_tb
            // 
            this.path_tb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.path_tb.Location = new System.Drawing.Point(12, 29);
            this.path_tb.Name = "path_tb";
            this.path_tb.Size = new System.Drawing.Size(259, 20);
            this.path_tb.TabIndex = 2;
            // 
            // fileContent_rtb
            // 
            this.fileContent_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileContent_rtb.Location = new System.Drawing.Point(12, 55);
            this.fileContent_rtb.Name = "fileContent_rtb";
            this.fileContent_rtb.Size = new System.Drawing.Size(340, 280);
            this.fileContent_rtb.TabIndex = 3;
            this.fileContent_rtb.Text = "";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.writeToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.writeToolStripMenuItem.Text = "Write";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 347);
            this.Controls.Add(this.fileContent_rtb);
            this.Controls.Add(this.path_tb);
            this.Controls.Add(this.browse_bt);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse_bt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem decoratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox path_tb;
        private System.Windows.Forms.RichTextBox fileContent_rtb;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

