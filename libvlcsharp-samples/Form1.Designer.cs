namespace libvlcsharp_samples
{
    partial class LibVLCSharp_Sample
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtVideo1 = new TextBox();
            vlcPanel = new Panel();
            audioOption = new ComboBox();
            btnPlay1 = new Button();
            txtVideo2 = new TextBox();
            txtVideo3 = new TextBox();
            txtVideo4 = new TextBox();
            txtVideo5 = new TextBox();
            btnPlay2 = new Button();
            btnPlay3 = new Button();
            btnPlay4 = new Button();
            btnPlay5 = new Button();
            btnPause = new Button();
            btnStop = new Button();
            timeSleep = new ComboBox();
            SuspendLayout();
            // 
            // txtVideo1
            // 
            txtVideo1.Location = new Point(12, 299);
            txtVideo1.Name = "txtVideo1";
            txtVideo1.Size = new Size(463, 23);
            txtVideo1.TabIndex = 0;
            // 
            // vlcPanel
            // 
            vlcPanel.Location = new Point(12, 12);
            vlcPanel.Name = "vlcPanel";
            vlcPanel.Size = new Size(463, 281);
            vlcPanel.TabIndex = 5;
            // 
            // audioOption
            // 
            audioOption.FormattingEnabled = true;
            audioOption.Items.AddRange(new object[] { "Automatic", "WaveOut" });
            audioOption.Location = new Point(481, 12);
            audioOption.Name = "audioOption";
            audioOption.Size = new Size(93, 23);
            audioOption.TabIndex = 10;
            audioOption.SelectedIndex = 1;
            audioOption.SelectedIndexChanged += audioOption_SelectedIndexChanged;
            // 
            // btnPlay1
            // 
            btnPlay1.Location = new Point(481, 299);
            btnPlay1.Name = "btnPlay1";
            btnPlay1.Size = new Size(93, 25);
            btnPlay1.TabIndex = 11;
            btnPlay1.Text = "LOAD";
            btnPlay1.UseVisualStyleBackColor = true;
            btnPlay1.Click += btnPlay1_Click;
            // 
            // txtVideo2
            // 
            txtVideo2.Location = new Point(12, 328);
            txtVideo2.Name = "txtVideo2";
            txtVideo2.Size = new Size(463, 23);
            txtVideo2.TabIndex = 12;
            // 
            // txtVideo3
            // 
            txtVideo3.Location = new Point(12, 357);
            txtVideo3.Name = "txtVideo3";
            txtVideo3.Size = new Size(463, 23);
            txtVideo3.TabIndex = 13;
            // 
            // txtVideo4
            // 
            txtVideo4.Location = new Point(12, 386);
            txtVideo4.Name = "txtVideo4";
            txtVideo4.Size = new Size(463, 23);
            txtVideo4.TabIndex = 14;
            // 
            // txtVideo5
            // 
            txtVideo5.Location = new Point(12, 415);
            txtVideo5.Name = "txtVideo5";
            txtVideo5.Size = new Size(463, 23);
            txtVideo5.TabIndex = 15;
            // 
            // btnPlay2
            // 
            btnPlay2.Location = new Point(481, 328);
            btnPlay2.Name = "btnPlay2";
            btnPlay2.Size = new Size(93, 25);
            btnPlay2.TabIndex = 16;
            btnPlay2.Text = "LOAD";
            btnPlay2.UseVisualStyleBackColor = true;
            btnPlay2.Click += btnPlay2_Click;
            // 
            // btnPlay3
            // 
            btnPlay3.Location = new Point(481, 357);
            btnPlay3.Name = "btnPlay3";
            btnPlay3.Size = new Size(93, 25);
            btnPlay3.TabIndex = 17;
            btnPlay3.Text = "LOAD";
            btnPlay3.UseVisualStyleBackColor = true;
            btnPlay3.Click += btnPlay3_Click;
            // 
            // btnPlay4
            // 
            btnPlay4.Location = new Point(481, 386);
            btnPlay4.Name = "btnPlay4";
            btnPlay4.Size = new Size(93, 25);
            btnPlay4.TabIndex = 18;
            btnPlay4.Text = "LOAD";
            btnPlay4.UseVisualStyleBackColor = true;
            btnPlay4.Click += btnPlay4_Click;
            // 
            // btnPlay5
            // 
            btnPlay5.Location = new Point(481, 415);
            btnPlay5.Name = "btnPlay5";
            btnPlay5.Size = new Size(93, 25);
            btnPlay5.TabIndex = 19;
            btnPlay5.Text = "LOAD";
            btnPlay5.UseVisualStyleBackColor = true;
            btnPlay5.Click += btnPlay5_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(481, 72);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(93, 25);
            btnPause.TabIndex = 20;
            btnPause.Text = "RESUME";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(481, 41);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(93, 25);
            btnStop.TabIndex = 21;
            btnStop.Text = "STOP";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // timeSleep
            // 
            timeSleep.FormattingEnabled = true;
            timeSleep.Items.AddRange(new object[] { "100", "300", "500", "1000", "1500", "2000", "10000" });
            timeSleep.Location = new Point(549, 52);
            timeSleep.Margin = new Padding(3, 4, 3, 4);
            timeSleep.Name = "timeSleep";
            timeSleep.Size = new Size(106, 23);
            timeSleep.TabIndex = 22;
            // 
            // LibVLCSharp_Sample
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Controls.Add(btnPlay5);
            Controls.Add(btnPlay4);
            Controls.Add(btnPlay3);
            Controls.Add(btnPlay2);
            Controls.Add(txtVideo5);
            Controls.Add(txtVideo4);
            Controls.Add(txtVideo3);
            Controls.Add(txtVideo2);
            Controls.Add(btnPlay1);
            Controls.Add(audioOption);
            Controls.Add(vlcPanel);
            Controls.Add(txtVideo1);
            Name = "LibVLCSharp_Sample";
            Text = "LibVLCSharp Sample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVideo1;
        private Panel vlcPanel;
        private ComboBox audioOption;
        private Button btnPlay1;
        private TextBox txtVideo2;
        private TextBox txtVideo3;
        private TextBox txtVideo4;
        private TextBox txtVideo5;
        private Button btnPlay2;
        private Button btnPlay3;
        private Button btnPlay4;
        private Button btnPlay5;
        private Button btnPause;
        private Button btnStop;
        private ComboBox timeSleep;
    }
}
