
namespace Lab2
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
            this.name_lable = new System.Windows.Forms.Label();
            this.surname_lable = new System.Windows.Forms.Label();
            this.weight_lable = new System.Windows.Forms.Label();
            this.birthYear_lable = new System.Windows.Forms.Label();
            this.age_lable = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.surname_tb = new System.Windows.Forms.TextBox();
            this.weight_tb = new System.Windows.Forms.TextBox();
            this.birthYear_tb = new System.Windows.Forms.TextBox();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.show_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_lable
            // 
            this.name_lable.AutoSize = true;
            this.name_lable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lable.Location = new System.Drawing.Point(59, 37);
            this.name_lable.Name = "name_lable";
            this.name_lable.Size = new System.Drawing.Size(43, 17);
            this.name_lable.TabIndex = 0;
            this.name_lable.Text = "Name";
            // 
            // surname_lable
            // 
            this.surname_lable.AutoSize = true;
            this.surname_lable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_lable.Location = new System.Drawing.Point(59, 67);
            this.surname_lable.Name = "surname_lable";
            this.surname_lable.Size = new System.Drawing.Size(59, 17);
            this.surname_lable.TabIndex = 1;
            this.surname_lable.Text = "Surname";
            // 
            // weight_lable
            // 
            this.weight_lable.AutoSize = true;
            this.weight_lable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight_lable.Location = new System.Drawing.Point(59, 97);
            this.weight_lable.Name = "weight_lable";
            this.weight_lable.Size = new System.Drawing.Size(49, 17);
            this.weight_lable.TabIndex = 2;
            this.weight_lable.Text = "Weight";
            // 
            // birthYear_lable
            // 
            this.birthYear_lable.AutoSize = true;
            this.birthYear_lable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthYear_lable.Location = new System.Drawing.Point(59, 127);
            this.birthYear_lable.Name = "birthYear_lable";
            this.birthYear_lable.Size = new System.Drawing.Size(63, 17);
            this.birthYear_lable.TabIndex = 3;
            this.birthYear_lable.Text = "Birth year";
            // 
            // age_lable
            // 
            this.age_lable.AutoSize = true;
            this.age_lable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_lable.Location = new System.Drawing.Point(59, 157);
            this.age_lable.Name = "age_lable";
            this.age_lable.Size = new System.Drawing.Size(31, 17);
            this.age_lable.TabIndex = 4;
            this.age_lable.Text = "Age";
            // 
            // name_tb
            // 
            this.name_tb.AccessibleDescription = "";
            this.name_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_tb.Location = new System.Drawing.Point(129, 34);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(100, 25);
            this.name_tb.TabIndex = 5;
            // 
            // surname_tb
            // 
            this.surname_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname_tb.Location = new System.Drawing.Point(129, 64);
            this.surname_tb.Name = "surname_tb";
            this.surname_tb.Size = new System.Drawing.Size(100, 25);
            this.surname_tb.TabIndex = 6;
            // 
            // weight_tb
            // 
            this.weight_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight_tb.Location = new System.Drawing.Point(129, 94);
            this.weight_tb.Name = "weight_tb";
            this.weight_tb.Size = new System.Drawing.Size(100, 25);
            this.weight_tb.TabIndex = 7;
            // 
            // birthYear_tb
            // 
            this.birthYear_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthYear_tb.Location = new System.Drawing.Point(129, 124);
            this.birthYear_tb.Name = "birthYear_tb";
            this.birthYear_tb.Size = new System.Drawing.Size(100, 25);
            this.birthYear_tb.TabIndex = 8;
            // 
            // age_tb
            // 
            this.age_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_tb.Location = new System.Drawing.Point(129, 154);
            this.age_tb.Name = "age_tb";
            this.age_tb.ReadOnly = true;
            this.age_tb.Size = new System.Drawing.Size(100, 25);
            this.age_tb.TabIndex = 9;
            // 
            // show_button
            // 
            this.show_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show_button.Location = new System.Drawing.Point(157, 204);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(105, 32);
            this.show_button.TabIndex = 10;
            this.show_button.Text = "Show";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(30, 204);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(105, 32);
            this.save_button.TabIndex = 12;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.clear_button.Location = new System.Drawing.Point(157, 242);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(105, 32);
            this.clear_button.TabIndex = 13;
            this.clear_button.Text = "Clear all fields";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.delete_button.Location = new System.Drawing.Point(30, 242);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(105, 32);
            this.delete_button.TabIndex = 15;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 304);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.show_button);
            this.Controls.Add(this.age_tb);
            this.Controls.Add(this.birthYear_tb);
            this.Controls.Add(this.weight_tb);
            this.Controls.Add(this.surname_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.age_lable);
            this.Controls.Add(this.birthYear_lable);
            this.Controls.Add(this.weight_lable);
            this.Controls.Add(this.surname_lable);
            this.Controls.Add(this.name_lable);
            this.Name = "Form1";
            this.Text = "Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lable;
        private System.Windows.Forms.Label surname_lable;
        private System.Windows.Forms.Label weight_lable;
        private System.Windows.Forms.Label birthYear_lable;
        private System.Windows.Forms.Label age_lable;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox surname_tb;
        private System.Windows.Forms.TextBox weight_tb;
        private System.Windows.Forms.TextBox birthYear_tb;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button delete_button;
    }
}

