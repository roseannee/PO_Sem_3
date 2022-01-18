namespace lab10
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
            this.tb1_1 = new System.Windows.Forms.TextBox();
            this.tb1_2 = new System.Windows.Forms.TextBox();
            this.tb1_3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a_lb = new System.Windows.Forms.Label();
            this.b_lb = new System.Windows.Forms.Label();
            this.c_lb = new System.Windows.Forms.Label();
            this.resultContent = new System.Windows.Forms.RichTextBox();
            this.int_ToString_bt = new System.Windows.Forms.Button();
            this.int_Sort_bt = new System.Windows.Forms.Button();
            this.people_ToString_bt = new System.Windows.Forms.Button();
            this.people_Sort_bt = new System.Windows.Forms.Button();
            this.tb2_3 = new System.Windows.Forms.TextBox();
            this.tb2_2 = new System.Windows.Forms.TextBox();
            this.tb2_1 = new System.Windows.Forms.TextBox();
            this.tb3_3 = new System.Windows.Forms.TextBox();
            this.tb3_2 = new System.Windows.Forms.TextBox();
            this.tb3_1 = new System.Windows.Forms.TextBox();
            this.integers_gb = new System.Windows.Forms.GroupBox();
            this.people_gb = new System.Windows.Forms.GroupBox();
            this.integersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.integers_gb.SuspendLayout();
            this.people_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb1_1
            // 
            this.tb1_1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb1_1.Location = new System.Drawing.Point(12, 53);
            this.tb1_1.Name = "tb1_1";
            this.tb1_1.Size = new System.Drawing.Size(100, 26);
            this.tb1_1.TabIndex = 0;
            // 
            // tb1_2
            // 
            this.tb1_2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb1_2.Location = new System.Drawing.Point(143, 53);
            this.tb1_2.Name = "tb1_2";
            this.tb1_2.Size = new System.Drawing.Size(100, 26);
            this.tb1_2.TabIndex = 1;
            // 
            // tb1_3
            // 
            this.tb1_3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb1_3.Location = new System.Drawing.Point(273, 53);
            this.tb1_3.Name = "tb1_3";
            this.tb1_3.Size = new System.Drawing.Size(100, 26);
            this.tb1_3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integersToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // a_lb
            // 
            this.a_lb.AutoSize = true;
            this.a_lb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_lb.Location = new System.Drawing.Point(31, 35);
            this.a_lb.Name = "a_lb";
            this.a_lb.Size = new System.Drawing.Size(14, 15);
            this.a_lb.TabIndex = 4;
            this.a_lb.Text = "a";
            // 
            // b_lb
            // 
            this.b_lb.AutoSize = true;
            this.b_lb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_lb.Location = new System.Drawing.Point(162, 35);
            this.b_lb.Name = "b_lb";
            this.b_lb.Size = new System.Drawing.Size(14, 15);
            this.b_lb.TabIndex = 5;
            this.b_lb.Text = "b";
            // 
            // c_lb
            // 
            this.c_lb.AutoSize = true;
            this.c_lb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_lb.Location = new System.Drawing.Point(291, 35);
            this.c_lb.Name = "c_lb";
            this.c_lb.Size = new System.Drawing.Size(13, 15);
            this.c_lb.TabIndex = 6;
            this.c_lb.Text = "c";
            // 
            // resultContent
            // 
            this.resultContent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultContent.Location = new System.Drawing.Point(12, 230);
            this.resultContent.Name = "resultContent";
            this.resultContent.Size = new System.Drawing.Size(361, 96);
            this.resultContent.TabIndex = 7;
            this.resultContent.Text = "";
            // 
            // int_ToString_bt
            // 
            this.int_ToString_bt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.int_ToString_bt.Location = new System.Drawing.Point(6, 22);
            this.int_ToString_bt.Name = "int_ToString_bt";
            this.int_ToString_bt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.int_ToString_bt.Size = new System.Drawing.Size(75, 23);
            this.int_ToString_bt.TabIndex = 8;
            this.int_ToString_bt.Text = "ToString";
            this.int_ToString_bt.UseVisualStyleBackColor = true;
            this.int_ToString_bt.Click += new System.EventHandler(this.int_ToString_bt_Click);
            // 
            // int_Sort_bt
            // 
            this.int_Sort_bt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.int_Sort_bt.Location = new System.Drawing.Point(87, 22);
            this.int_Sort_bt.Name = "int_Sort_bt";
            this.int_Sort_bt.Size = new System.Drawing.Size(75, 23);
            this.int_Sort_bt.TabIndex = 9;
            this.int_Sort_bt.Text = "Sort";
            this.int_Sort_bt.UseVisualStyleBackColor = true;
            this.int_Sort_bt.Click += new System.EventHandler(this.int_Sort_bt_Click);
            // 
            // people_ToString_bt
            // 
            this.people_ToString_bt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.people_ToString_bt.Location = new System.Drawing.Point(6, 22);
            this.people_ToString_bt.Name = "people_ToString_bt";
            this.people_ToString_bt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.people_ToString_bt.Size = new System.Drawing.Size(75, 23);
            this.people_ToString_bt.TabIndex = 10;
            this.people_ToString_bt.Text = "ToString";
            this.people_ToString_bt.UseVisualStyleBackColor = true;
            this.people_ToString_bt.Click += new System.EventHandler(this.person_ToString_bt_Click);
            // 
            // people_Sort_bt
            // 
            this.people_Sort_bt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.people_Sort_bt.Location = new System.Drawing.Point(87, 22);
            this.people_Sort_bt.Name = "people_Sort_bt";
            this.people_Sort_bt.Size = new System.Drawing.Size(75, 23);
            this.people_Sort_bt.TabIndex = 11;
            this.people_Sort_bt.Text = "Sort";
            this.people_Sort_bt.UseVisualStyleBackColor = true;
            this.people_Sort_bt.Click += new System.EventHandler(this.person_Sort_bt_Click);
            // 
            // tb2_3
            // 
            this.tb2_3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb2_3.Location = new System.Drawing.Point(273, 85);
            this.tb2_3.Name = "tb2_3";
            this.tb2_3.Size = new System.Drawing.Size(100, 26);
            this.tb2_3.TabIndex = 14;
            // 
            // tb2_2
            // 
            this.tb2_2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb2_2.Location = new System.Drawing.Point(143, 85);
            this.tb2_2.Name = "tb2_2";
            this.tb2_2.Size = new System.Drawing.Size(100, 26);
            this.tb2_2.TabIndex = 13;
            // 
            // tb2_1
            // 
            this.tb2_1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb2_1.Location = new System.Drawing.Point(12, 85);
            this.tb2_1.Name = "tb2_1";
            this.tb2_1.Size = new System.Drawing.Size(100, 26);
            this.tb2_1.TabIndex = 12;
            // 
            // tb3_3
            // 
            this.tb3_3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb3_3.Location = new System.Drawing.Point(273, 117);
            this.tb3_3.Name = "tb3_3";
            this.tb3_3.Size = new System.Drawing.Size(100, 26);
            this.tb3_3.TabIndex = 17;
            // 
            // tb3_2
            // 
            this.tb3_2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb3_2.Location = new System.Drawing.Point(143, 117);
            this.tb3_2.Name = "tb3_2";
            this.tb3_2.Size = new System.Drawing.Size(100, 26);
            this.tb3_2.TabIndex = 16;
            // 
            // tb3_1
            // 
            this.tb3_1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb3_1.Location = new System.Drawing.Point(12, 117);
            this.tb3_1.Name = "tb3_1";
            this.tb3_1.Size = new System.Drawing.Size(100, 26);
            this.tb3_1.TabIndex = 15;
            // 
            // integers_gb
            // 
            this.integers_gb.Controls.Add(this.int_ToString_bt);
            this.integers_gb.Controls.Add(this.int_Sort_bt);
            this.integers_gb.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.integers_gb.Location = new System.Drawing.Point(12, 167);
            this.integers_gb.Name = "integers_gb";
            this.integers_gb.Size = new System.Drawing.Size(170, 53);
            this.integers_gb.TabIndex = 20;
            this.integers_gb.TabStop = false;
            this.integers_gb.Text = "integers";
            // 
            // people_gb
            // 
            this.people_gb.Controls.Add(this.people_ToString_bt);
            this.people_gb.Controls.Add(this.people_Sort_bt);
            this.people_gb.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.people_gb.Location = new System.Drawing.Point(203, 167);
            this.people_gb.Name = "people_gb";
            this.people_gb.Size = new System.Drawing.Size(170, 53);
            this.people_gb.TabIndex = 21;
            this.people_gb.TabStop = false;
            this.people_gb.Text = "people";
            // 
            // integersToolStripMenuItem
            // 
            this.integersToolStripMenuItem.Name = "integersToolStripMenuItem";
            this.integersToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.integersToolStripMenuItem.Text = "Integers";
            this.integersToolStripMenuItem.Click += new System.EventHandler(this.integersToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 343);
            this.Controls.Add(this.people_gb);
            this.Controls.Add(this.integers_gb);
            this.Controls.Add(this.tb3_3);
            this.Controls.Add(this.tb3_2);
            this.Controls.Add(this.tb3_1);
            this.Controls.Add(this.tb2_3);
            this.Controls.Add(this.tb2_2);
            this.Controls.Add(this.tb2_1);
            this.Controls.Add(this.c_lb);
            this.Controls.Add(this.b_lb);
            this.Controls.Add(this.a_lb);
            this.Controls.Add(this.tb1_3);
            this.Controls.Add(this.tb1_2);
            this.Controls.Add(this.tb1_1);
            this.Controls.Add(this.resultContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.integers_gb.ResumeLayout(false);
            this.people_gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1_1;
        private System.Windows.Forms.TextBox tb1_2;
        private System.Windows.Forms.TextBox tb1_3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label a_lb;
        private System.Windows.Forms.Label b_lb;
        private System.Windows.Forms.Label c_lb;
        private System.Windows.Forms.RichTextBox resultContent;
        private System.Windows.Forms.Button int_ToString_bt;
        private System.Windows.Forms.Button int_Sort_bt;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button people_ToString_bt;
        private System.Windows.Forms.Button people_Sort_bt;
        private System.Windows.Forms.TextBox tb2_3;
        private System.Windows.Forms.TextBox tb2_2;
        private System.Windows.Forms.TextBox tb2_1;
        private System.Windows.Forms.TextBox tb3_3;
        private System.Windows.Forms.TextBox tb3_2;
        private System.Windows.Forms.TextBox tb3_1;
        private System.Windows.Forms.GroupBox integers_gb;
        private System.Windows.Forms.GroupBox people_gb;
        private System.Windows.Forms.ToolStripMenuItem integersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
    }
}

