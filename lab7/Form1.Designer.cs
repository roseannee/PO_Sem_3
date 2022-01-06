namespace lab7
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
            this.panel = new System.Windows.Forms.Panel();
            this.point_tb = new System.Windows.Forms.RichTextBox();
            this.nowPoint = new System.Windows.Forms.RichTextBox();
            this.presents_cb = new System.Windows.Forms.CheckBox();
            this.star_cb = new System.Windows.Forms.CheckBox();
            this.balls_cb = new System.Windows.Forms.CheckBox();
            this.lights_cb = new System.Windows.Forms.CheckBox();
            this.tinsel_cb = new System.Windows.Forms.CheckBox();
            this.carol_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Window;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(423, 418);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // point_tb
            // 
            this.point_tb.Location = new System.Drawing.Point(441, 249);
            this.point_tb.Name = "point_tb";
            this.point_tb.Size = new System.Drawing.Size(171, 181);
            this.point_tb.TabIndex = 1;
            this.point_tb.Text = "";
            // 
            // nowPoint
            // 
            this.nowPoint.Location = new System.Drawing.Point(441, 186);
            this.nowPoint.Name = "nowPoint";
            this.nowPoint.Size = new System.Drawing.Size(171, 57);
            this.nowPoint.TabIndex = 2;
            this.nowPoint.Text = "";
            // 
            // presents_cb
            // 
            this.presents_cb.AutoSize = true;
            this.presents_cb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.presents_cb.Location = new System.Drawing.Point(441, 12);
            this.presents_cb.Name = "presents_cb";
            this.presents_cb.Size = new System.Drawing.Size(84, 23);
            this.presents_cb.TabIndex = 3;
            this.presents_cb.Text = "presents";
            this.presents_cb.UseVisualStyleBackColor = true;
            this.presents_cb.CheckedChanged += new System.EventHandler(this.presents_cb_CheckedChanged);
            // 
            // star_cb
            // 
            this.star_cb.AutoSize = true;
            this.star_cb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.star_cb.Location = new System.Drawing.Point(441, 41);
            this.star_cb.Name = "star_cb";
            this.star_cb.Size = new System.Drawing.Size(53, 23);
            this.star_cb.TabIndex = 4;
            this.star_cb.Text = "star";
            this.star_cb.UseVisualStyleBackColor = true;
            this.star_cb.CheckedChanged += new System.EventHandler(this.star_cb_CheckedChanged);
            // 
            // balls_cb
            // 
            this.balls_cb.AutoSize = true;
            this.balls_cb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balls_cb.Location = new System.Drawing.Point(441, 70);
            this.balls_cb.Name = "balls_cb";
            this.balls_cb.Size = new System.Drawing.Size(59, 23);
            this.balls_cb.TabIndex = 5;
            this.balls_cb.Text = "balls";
            this.balls_cb.UseVisualStyleBackColor = true;
            this.balls_cb.CheckedChanged += new System.EventHandler(this.balls_cb_CheckedChanged);
            // 
            // lights_cb
            // 
            this.lights_cb.AutoSize = true;
            this.lights_cb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lights_cb.Location = new System.Drawing.Point(441, 99);
            this.lights_cb.Name = "lights_cb";
            this.lights_cb.Size = new System.Drawing.Size(64, 23);
            this.lights_cb.TabIndex = 6;
            this.lights_cb.Text = "lights";
            this.lights_cb.UseVisualStyleBackColor = true;
            this.lights_cb.CheckedChanged += new System.EventHandler(this.lights_cb_CheckedChanged);
            // 
            // tinsel_cb
            // 
            this.tinsel_cb.AutoSize = true;
            this.tinsel_cb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tinsel_cb.Location = new System.Drawing.Point(441, 128);
            this.tinsel_cb.Name = "tinsel_cb";
            this.tinsel_cb.Size = new System.Drawing.Size(64, 23);
            this.tinsel_cb.TabIndex = 7;
            this.tinsel_cb.Text = "tinsel";
            this.tinsel_cb.UseVisualStyleBackColor = true;
            this.tinsel_cb.CheckedChanged += new System.EventHandler(this.tinsel_cb_CheckedChanged);
            // 
            // carol_cb
            // 
            this.carol_cb.AutoSize = true;
            this.carol_cb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carol_cb.Location = new System.Drawing.Point(441, 157);
            this.carol_cb.Name = "carol_cb";
            this.carol_cb.Size = new System.Drawing.Size(60, 23);
            this.carol_cb.TabIndex = 8;
            this.carol_cb.Text = "carol";
            this.carol_cb.UseVisualStyleBackColor = true;
            this.carol_cb.CheckedChanged += new System.EventHandler(this.carol_cb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.carol_cb);
            this.Controls.Add(this.tinsel_cb);
            this.Controls.Add(this.lights_cb);
            this.Controls.Add(this.balls_cb);
            this.Controls.Add(this.star_cb);
            this.Controls.Add(this.presents_cb);
            this.Controls.Add(this.nowPoint);
            this.Controls.Add(this.point_tb);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Lab 9 - Christmas Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox point_tb;
        private System.Windows.Forms.RichTextBox nowPoint;
        private System.Windows.Forms.CheckBox presents_cb;
        private System.Windows.Forms.CheckBox star_cb;
        private System.Windows.Forms.CheckBox balls_cb;
        private System.Windows.Forms.CheckBox lights_cb;
        private System.Windows.Forms.CheckBox tinsel_cb;
        private System.Windows.Forms.CheckBox carol_cb;
    }
}

