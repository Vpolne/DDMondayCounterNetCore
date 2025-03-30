
namespace DDMondaysWinnerCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OpenFileButton = new Button();
            LogTextBox = new TextBox();
            ClearLogButton = new Button();
            CopyLogButton = new Button();
            SubsessionIdTextBox = new TextBox();
            GetResultButton = new Button();
            SuspendLayout();
            // 
            // OpenFileButton
            // 
            OpenFileButton.BackColor = Color.White;
            OpenFileButton.Location = new Point(14, 14);
            OpenFileButton.Margin = new Padding(4, 3, 4, 3);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(88, 27);
            OpenFileButton.TabIndex = 0;
            OpenFileButton.Text = "Open File";
            OpenFileButton.UseVisualStyleBackColor = false;
            OpenFileButton.Click += button1_Click;
            // 
            // LogTextBox
            // 
            LogTextBox.BackColor = Color.FromArgb(239, 246, 238);
            LogTextBox.BorderStyle = BorderStyle.FixedSingle;
            LogTextBox.Location = new Point(14, 47);
            LogTextBox.Margin = new Padding(4, 3, 4, 3);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ScrollBars = ScrollBars.Vertical;
            LogTextBox.Size = new Size(568, 745);
            LogTextBox.TabIndex = 1;
            LogTextBox.TextChanged += LogTextBox_TextChanged;
            // 
            // ClearLogButton
            // 
            ClearLogButton.Location = new Point(138, 14);
            ClearLogButton.Margin = new Padding(4, 3, 4, 3);
            ClearLogButton.Name = "ClearLogButton";
            ClearLogButton.Size = new Size(88, 27);
            ClearLogButton.TabIndex = 2;
            ClearLogButton.Text = "Clear log";
            ClearLogButton.UseVisualStyleBackColor = true;
            ClearLogButton.Click += ClearLogButton_Click;
            // 
            // CopyLogButton
            // 
            CopyLogButton.Location = new Point(257, 14);
            CopyLogButton.Margin = new Padding(4, 3, 4, 3);
            CopyLogButton.Name = "CopyLogButton";
            CopyLogButton.Size = new Size(88, 27);
            CopyLogButton.TabIndex = 3;
            CopyLogButton.Text = "Copy log";
            CopyLogButton.UseVisualStyleBackColor = true;
            CopyLogButton.Click += CopyLogButton_Click;
            // 
            // SubsessionIdTextBox
            // 
            SubsessionIdTextBox.Location = new Point(363, 17);
            SubsessionIdTextBox.Name = "SubsessionIdTextBox";
            SubsessionIdTextBox.Size = new Size(125, 23);
            SubsessionIdTextBox.TabIndex = 4;
            SubsessionIdTextBox.Text = "SubSessionID";
            // 
            // GetResultButton
            // 
            GetResultButton.Location = new Point(496, 18);
            GetResultButton.Name = "GetResultButton";
            GetResultButton.Size = new Size(75, 23);
            GetResultButton.TabIndex = 5;
            GetResultButton.Text = "GetResult";
            GetResultButton.UseVisualStyleBackColor = true;
            GetResultButton.Click += GetResultButton_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(76, 88, 68);
            ClientSize = new Size(595, 800);
            Controls.Add(GetResultButton);
            Controls.Add(SubsessionIdTextBox);
            Controls.Add(CopyLogButton);
            Controls.Add(ClearLogButton);
            Controls.Add(LogTextBox);
            Controls.Add(OpenFileButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DDWinnerCount";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button ClearLogButton;
        private System.Windows.Forms.Button CopyLogButton;
        private TextBox SubsessionIdTextBox;
        private Button GetResultButton;
    }
}

