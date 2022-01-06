
namespace Lab1
{
    partial class Calculator
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
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_sub = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.tb_ans = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.lb_num1 = new System.Windows.Forms.Label();
            this.lb_num2 = new System.Windows.Forms.Label();
            this.lb_ans = new System.Windows.Forms.Label();
            this.lb_sign = new System.Windows.Forms.Label();
            this.lb_equal = new System.Windows.Forms.Label();
            this.bt_mult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(75, 154);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(130, 30);
            this.bt_add.TabIndex = 0;
            this.bt_add.Text = "+ | addition";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_sub
            // 
            this.bt_sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sub.Font = new System.Drawing.Font("Tw Cen MT", 12.75F);
            this.bt_sub.Location = new System.Drawing.Point(211, 154);
            this.bt_sub.Name = "bt_sub";
            this.bt_sub.Size = new System.Drawing.Size(130, 30);
            this.bt_sub.TabIndex = 1;
            this.bt_sub.Text = "- | subtraction";
            this.bt_sub.UseVisualStyleBackColor = true;
            this.bt_sub.Click += new System.EventHandler(this.bt_sub_Click);
            // 
            // bt_div
            // 
            this.bt_div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_div.Font = new System.Drawing.Font("Tw Cen MT", 12.75F);
            this.bt_div.Location = new System.Drawing.Point(211, 190);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(130, 30);
            this.bt_div.TabIndex = 4;
            this.bt_div.Text = "/ | division";
            this.bt_div.UseVisualStyleBackColor = true;
            this.bt_div.Click += new System.EventHandler(this.bt_div_Click);
            // 
            // tb_num1
            // 
            this.tb_num1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tb_num1.Location = new System.Drawing.Point(75, 78);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(100, 23);
            this.tb_num1.TabIndex = 5;
            // 
            // tb_num2
            // 
            this.tb_num2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.tb_num2.Location = new System.Drawing.Point(228, 78);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(100, 23);
            this.tb_num2.TabIndex = 6;
            // 
            // tb_ans
            // 
            this.tb_ans.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ans.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_ans.Location = new System.Drawing.Point(381, 78);
            this.tb_ans.Name = "tb_ans";
            this.tb_ans.Size = new System.Drawing.Size(100, 23);
            this.tb_ans.TabIndex = 7;
            // 
            // bt_clear
            // 
            this.bt_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_clear.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.ForeColor = System.Drawing.Color.Red;
            this.bt_clear.Location = new System.Drawing.Point(381, 154);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(100, 66);
            this.bt_clear.TabIndex = 8;
            this.bt_clear.Text = "clear all";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // lb_num1
            // 
            this.lb_num1.AutoSize = true;
            this.lb_num1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_num1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_num1.Location = new System.Drawing.Point(93, 62);
            this.lb_num1.Name = "lb_num1";
            this.lb_num1.Size = new System.Drawing.Size(62, 13);
            this.lb_num1.TabIndex = 9;
            this.lb_num1.Text = "number 1";
            // 
            // lb_num2
            // 
            this.lb_num2.AutoSize = true;
            this.lb_num2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_num2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_num2.Location = new System.Drawing.Point(245, 62);
            this.lb_num2.Name = "lb_num2";
            this.lb_num2.Size = new System.Drawing.Size(62, 13);
            this.lb_num2.TabIndex = 10;
            this.lb_num2.Text = "number 2";
            // 
            // lb_ans
            // 
            this.lb_ans.AutoSize = true;
            this.lb_ans.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_ans.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lb_ans.Location = new System.Drawing.Point(407, 62);
            this.lb_ans.Name = "lb_ans";
            this.lb_ans.Size = new System.Drawing.Size(48, 13);
            this.lb_ans.TabIndex = 11;
            this.lb_ans.Text = "answer";
            // 
            // lb_sign
            // 
            this.lb_sign.AutoSize = true;
            this.lb_sign.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lb_sign.Location = new System.Drawing.Point(193, 81);
            this.lb_sign.Name = "lb_sign";
            this.lb_sign.Size = new System.Drawing.Size(0, 16);
            this.lb_sign.TabIndex = 12;
            this.lb_sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_equal
            // 
            this.lb_equal.AutoSize = true;
            this.lb_equal.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.lb_equal.Location = new System.Drawing.Point(346, 81);
            this.lb_equal.Name = "lb_equal";
            this.lb_equal.Size = new System.Drawing.Size(0, 16);
            this.lb_equal.TabIndex = 13;
            // 
            // bt_mult
            // 
            this.bt_mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_mult.Font = new System.Drawing.Font("Tw Cen MT", 12.75F);
            this.bt_mult.Location = new System.Drawing.Point(75, 190);
            this.bt_mult.Name = "bt_mult";
            this.bt_mult.Size = new System.Drawing.Size(130, 30);
            this.bt_mult.TabIndex = 14;
            this.bt_mult.Text = "* | multiplication";
            this.bt_mult.UseVisualStyleBackColor = true;
            this.bt_mult.Click += new System.EventHandler(this.bt_mult_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 310);
            this.Controls.Add(this.bt_mult);
            this.Controls.Add(this.lb_equal);
            this.Controls.Add(this.lb_sign);
            this.Controls.Add(this.lb_ans);
            this.Controls.Add(this.lb_num2);
            this.Controls.Add(this.lb_num1);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.tb_ans);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.bt_div);
            this.Controls.Add(this.bt_sub);
            this.Controls.Add(this.bt_add);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_sub;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.TextBox tb_ans;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Label lb_num1;
        private System.Windows.Forms.Label lb_num2;
        private System.Windows.Forms.Label lb_ans;
        private System.Windows.Forms.Label lb_sign;
        private System.Windows.Forms.Label lb_equal;
        private System.Windows.Forms.Button bt_mult;
    }
}

