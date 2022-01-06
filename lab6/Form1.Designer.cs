namespace lab6
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.path_tb = new System.Windows.Forms.TextBox();
            this.browse_bt = new System.Windows.Forms.Button();
            this.fileContent_rtb = new System.Windows.Forms.RichTextBox();
            this.listType_cb = new System.Windows.Forms.ComboBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.lb4 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.writeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(348, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.writeToolStripMenuItem.Text = "Write";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
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
            this.path_tb.Location = new System.Drawing.Point(12, 27);
            this.path_tb.Name = "path_tb";
            this.path_tb.Size = new System.Drawing.Size(243, 20);
            this.path_tb.TabIndex = 1;
            // 
            // browse_bt
            // 
            this.browse_bt.Location = new System.Drawing.Point(261, 25);
            this.browse_bt.Name = "browse_bt";
            this.browse_bt.Size = new System.Drawing.Size(75, 23);
            this.browse_bt.TabIndex = 2;
            this.browse_bt.Text = "Browse";
            this.browse_bt.UseVisualStyleBackColor = true;
            this.browse_bt.Click += new System.EventHandler(this.browse_bt_Click);
            // 
            // fileContent_rtb
            // 
            this.fileContent_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileContent_rtb.Location = new System.Drawing.Point(12, 82);
            this.fileContent_rtb.Name = "fileContent_rtb";
            this.fileContent_rtb.Size = new System.Drawing.Size(324, 270);
            this.fileContent_rtb.TabIndex = 3;
            this.fileContent_rtb.Text = "";
            // 
            // listType_cb
            // 
            this.listType_cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listType_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listType_cb.FormattingEnabled = true;
            this.listType_cb.Items.AddRange(new object[] {
            "List of integers",
            "List of decimal",
            "Integer + decimal + string",
            "Data of one person",
            "List of integers + list of decimal",
            "List of people"});
            this.listType_cb.Location = new System.Drawing.Point(12, 53);
            this.listType_cb.Name = "listType_cb";
            this.listType_cb.Size = new System.Drawing.Size(324, 23);
            this.listType_cb.TabIndex = 4;
            this.listType_cb.Text = "Choose type";
            this.listType_cb.SelectedIndexChanged += new System.EventHandler(this.listType_cb_SelectedIndexChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(24, 82);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(27, 18);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "lb1";
            this.lb1.Visible = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(24, 135);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(27, 18);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "lb2";
            this.lb2.Visible = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.Location = new System.Drawing.Point(24, 191);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(27, 18);
            this.lb3.TabIndex = 7;
            this.lb3.Text = "lb3";
            this.lb3.Visible = false;
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb1.Location = new System.Drawing.Point(12, 103);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 24);
            this.tb1.TabIndex = 8;
            this.tb1.Visible = false;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb2.Location = new System.Drawing.Point(12, 156);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 24);
            this.tb2.TabIndex = 9;
            this.tb2.Visible = false;
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb3.Location = new System.Drawing.Point(12, 212);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 24);
            this.tb3.TabIndex = 10;
            this.tb3.Visible = false;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb4.Location = new System.Drawing.Point(209, 109);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(27, 18);
            this.lb4.TabIndex = 11;
            this.lb4.Text = "lb4";
            this.lb4.Visible = false;
            // 
            // tb4
            // 
            this.tb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb4.Location = new System.Drawing.Point(197, 130);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 24);
            this.tb4.TabIndex = 12;
            this.tb4.Visible = false;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb5.Location = new System.Drawing.Point(209, 165);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(27, 18);
            this.lb5.TabIndex = 13;
            this.lb5.Text = "lb4";
            this.lb5.Visible = false;
            // 
            // tb5
            // 
            this.tb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb5.Location = new System.Drawing.Point(197, 186);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 24);
            this.tb5.TabIndex = 14;
            this.tb5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 364);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.listType_cb);
            this.Controls.Add(this.fileContent_rtb);
            this.Controls.Add(this.browse_bt);
            this.Controls.Add(this.path_tb);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Binary files";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox path_tb;
        private System.Windows.Forms.Button browse_bt;
        private System.Windows.Forms.RichTextBox fileContent_rtb;
        private System.Windows.Forms.ComboBox listType_cb;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox tb5;
    }
}

