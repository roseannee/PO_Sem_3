namespace lab8
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
            this.currentLine_tb = new System.Windows.Forms.TextBox();
            this.nextLines_rtb = new System.Windows.Forms.RichTextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.openSong = new System.Windows.Forms.OpenFileDialog();
            this.openLyrics = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // currentLine_tb
            // 
            this.currentLine_tb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLine_tb.Location = new System.Drawing.Point(12, 12);
            this.currentLine_tb.Name = "currentLine_tb";
            this.currentLine_tb.ReadOnly = true;
            this.currentLine_tb.Size = new System.Drawing.Size(321, 23);
            this.currentLine_tb.TabIndex = 0;
            // 
            // nextLines_rtb
            // 
            this.nextLines_rtb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextLines_rtb.Location = new System.Drawing.Point(12, 45);
            this.nextLines_rtb.Name = "nextLines_rtb";
            this.nextLines_rtb.ReadOnly = true;
            this.nextLines_rtb.Size = new System.Drawing.Size(321, 303);
            this.nextLines_rtb.TabIndex = 1;
            this.nextLines_rtb.Text = "";
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(339, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 30);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(339, 48);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 30);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(339, 84);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 30);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // openSong
            // 
            this.openSong.DefaultExt = "wav";
            this.openSong.Filter = "Wave files (.wav)|*.wav";
            this.openSong.InitialDirectory = "D:\\Downloads\\My\\Uni\\Subjects\\Sem. 3\\PO\\All\\lab8\\Songs";
            this.openSong.Title = "Choose song";
            // 
            // openLyrics
            // 
            this.openLyrics.DefaultExt = "txt";
            this.openLyrics.Filter = "Text files (.txt)|*.txt";
            this.openLyrics.Title = "Choose lyrics";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 360);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.nextLines_rtb);
            this.Controls.Add(this.currentLine_tb);
            this.Name = "Form1";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentLine_tb;
        private System.Windows.Forms.RichTextBox nextLines_rtb;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.OpenFileDialog openSong;
        private System.Windows.Forms.OpenFileDialog openLyrics;
    }
}

