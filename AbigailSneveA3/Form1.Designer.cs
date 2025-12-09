using System.ComponentModel;

namespace AbigailSneveA4
{
    sealed partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            PromptLbl = new Label();
            FirstWordTextBox = new TextBox();
            OutputLbl = new Label();
            SecondWordTextBox = new TextBox();
            WordMetricsButton = new Button();
            WordSquareButton = new Button();
            WordPyramidButton = new Button();
            WordPalindromeButton = new Button();
            LetterCheckerButton = new Button();
            WordMultiplyButton = new Button();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            wordFunToolStripMenuItem = new ToolStripMenuItem();
            metricsToolStripMenuItem = new ToolStripMenuItem();
            letterToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            pyramidToolStripMenuItem = new ToolStripMenuItem();
            palindromeToolStripMenuItem = new ToolStripMenuItem();
            multiplyToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PromptLbl
            // 
            PromptLbl.AutoSize = true;
            PromptLbl.Location = new Point(321, 36);
            PromptLbl.MaximumSize = new Size(200, 0);
            PromptLbl.Name = "PromptLbl";
            PromptLbl.Size = new Size(199, 25);
            PromptLbl.TabIndex = 0;
            PromptLbl.Text = "Please enter two words.";
            // 
            // FirstWordTextBox
            // 
            FirstWordTextBox.Location = new Point(209, 64);
            FirstWordTextBox.Name = "FirstWordTextBox";
            FirstWordTextBox.Size = new Size(150, 31);
            FirstWordTextBox.TabIndex = 1;
            // 
            // OutputLbl
            // 
            OutputLbl.AutoSize = true;
            OutputLbl.Location = new Point(209, 119);
            OutputLbl.MaximumSize = new Size(400, 0);
            OutputLbl.MinimumSize = new Size(400, 0);
            OutputLbl.Name = "OutputLbl";
            OutputLbl.Size = new Size(400, 25);
            OutputLbl.TabIndex = 3;
            OutputLbl.Text = "No words entered yet";
            OutputLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SecondWordTextBox
            // 
            SecondWordTextBox.Location = new Point(471, 64);
            SecondWordTextBox.Name = "SecondWordTextBox";
            SecondWordTextBox.Size = new Size(150, 31);
            SecondWordTextBox.TabIndex = 2;
            // 
            // WordMetricsButton
            // 
            WordMetricsButton.BackColor = Color.FromArgb(255, 192, 192);
            WordMetricsButton.ForeColor = SystemColors.ActiveCaptionText;
            WordMetricsButton.Location = new Point(6, 30);
            WordMetricsButton.Name = "WordMetricsButton";
            WordMetricsButton.Size = new Size(112, 34);
            WordMetricsButton.TabIndex = 5;
            WordMetricsButton.Text = "Metrics";
            WordMetricsButton.UseVisualStyleBackColor = false;
            WordMetricsButton.UseWaitCursor = true;
            WordMetricsButton.Click += WordMetricsButton_Click;
            // 
            // WordSquareButton
            // 
            WordSquareButton.BackColor = Color.FromArgb(255, 192, 192);
            WordSquareButton.ForeColor = SystemColors.ActiveCaptionText;
            WordSquareButton.Location = new Point(6, 70);
            WordSquareButton.Name = "WordSquareButton";
            WordSquareButton.Size = new Size(112, 34);
            WordSquareButton.TabIndex = 7;
            WordSquareButton.Text = "Square";
            WordSquareButton.UseVisualStyleBackColor = false;
            WordSquareButton.UseWaitCursor = true;
            WordSquareButton.Click += WordSquareButton_Click;
            // 
            // WordPyramidButton
            // 
            WordPyramidButton.BackColor = Color.FromArgb(255, 192, 192);
            WordPyramidButton.ForeColor = SystemColors.ActiveCaptionText;
            WordPyramidButton.Location = new Point(6, 110);
            WordPyramidButton.Name = "WordPyramidButton";
            WordPyramidButton.Size = new Size(112, 34);
            WordPyramidButton.TabIndex = 8;
            WordPyramidButton.Text = "Pyramid";
            WordPyramidButton.UseVisualStyleBackColor = false;
            WordPyramidButton.UseWaitCursor = true;
            WordPyramidButton.Click += WordPyramidButton_Click;
            // 
            // WordPalindromeButton
            // 
            WordPalindromeButton.BackColor = Color.FromArgb(255, 192, 192);
            WordPalindromeButton.ForeColor = SystemColors.ActiveCaptionText;
            WordPalindromeButton.Location = new Point(124, 30);
            WordPalindromeButton.Name = "WordPalindromeButton";
            WordPalindromeButton.Size = new Size(112, 34);
            WordPalindromeButton.TabIndex = 9;
            WordPalindromeButton.Text = "Palindrome";
            WordPalindromeButton.UseVisualStyleBackColor = false;
            WordPalindromeButton.UseWaitCursor = true;
            WordPalindromeButton.Click += WordPalindromeButton_Click;
            // 
            // LetterCheckerButton
            // 
            LetterCheckerButton.BackColor = Color.FromArgb(255, 192, 192);
            LetterCheckerButton.ForeColor = SystemColors.ActiveCaptionText;
            LetterCheckerButton.Location = new Point(124, 70);
            LetterCheckerButton.Name = "LetterCheckerButton";
            LetterCheckerButton.Size = new Size(112, 34);
            LetterCheckerButton.TabIndex = 6;
            LetterCheckerButton.Text = "Letter Checker";
            LetterCheckerButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            LetterCheckerButton.UseVisualStyleBackColor = false;
            LetterCheckerButton.UseWaitCursor = true;
            LetterCheckerButton.Click += LetterCheckerButton_Click;
            // 
            // WordMultiplyButton
            // 
            WordMultiplyButton.BackColor = Color.FromArgb(255, 192, 192);
            WordMultiplyButton.Location = new Point(642, 253);
            WordMultiplyButton.Name = "WordMultiplyButton";
            WordMultiplyButton.Size = new Size(112, 34);
            WordMultiplyButton.TabIndex = 4;
            WordMultiplyButton.Text = "Multiply";
            WordMultiplyButton.UseVisualStyleBackColor = false;
            WordMultiplyButton.Click += WordMultiplyButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(48, 155);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 11;
            label1.Text = "Word Fun Functions";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Location = new Point(593, 155);
            label2.Name = "label2";
            label2.Size = new Size(209, 60);
            label2.TabIndex = 12;
            label2.Text = "Use two numbers one to ten to get product";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { wordFunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(878, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // wordFunToolStripMenuItem
            // 
            wordFunToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 192);
            wordFunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { metricsToolStripMenuItem, letterToolStripMenuItem, squareToolStripMenuItem, pyramidToolStripMenuItem, palindromeToolStripMenuItem, multiplyToolStripMenuItem });
            wordFunToolStripMenuItem.Name = "wordFunToolStripMenuItem";
            wordFunToolStripMenuItem.ShortcutKeyDisplayString = "";
            wordFunToolStripMenuItem.Size = new Size(106, 29);
            wordFunToolStripMenuItem.Text = "&Word Fun";
            // 
            // metricsToolStripMenuItem
            // 
            metricsToolStripMenuItem.Name = "metricsToolStripMenuItem";
            metricsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.M;
            metricsToolStripMenuItem.Size = new Size(286, 34);
            metricsToolStripMenuItem.Text = "&Metrics";
            metricsToolStripMenuItem.Click += metricsToolStripMenuItem_Click;
            // 
            // letterToolStripMenuItem
            // 
            letterToolStripMenuItem.Name = "letterToolStripMenuItem";
            letterToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.L;
            letterToolStripMenuItem.Size = new Size(286, 34);
            letterToolStripMenuItem.Text = "&Letter";
            letterToolStripMenuItem.Click += letterToolStripMenuItem_Click;
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(286, 34);
            squareToolStripMenuItem.Text = "&Square";
            squareToolStripMenuItem.Click += squareToolStripMenuItem_Click;
            // 
            // pyramidToolStripMenuItem
            // 
            pyramidToolStripMenuItem.Name = "pyramidToolStripMenuItem";
            pyramidToolStripMenuItem.Size = new Size(286, 34);
            pyramidToolStripMenuItem.Text = "&Pyramid";
            pyramidToolStripMenuItem.Click += pyramidToolStripMenuItem_Click;
            // 
            // palindromeToolStripMenuItem
            // 
            palindromeToolStripMenuItem.Name = "palindromeToolStripMenuItem";
            palindromeToolStripMenuItem.Size = new Size(286, 34);
            palindromeToolStripMenuItem.Text = "Palin&drome";
            palindromeToolStripMenuItem.Click += palindromeToolStripMenuItem_Click;
            // 
            // multiplyToolStripMenuItem
            // 
            multiplyToolStripMenuItem.Name = "multiplyToolStripMenuItem";
            multiplyToolStripMenuItem.Size = new Size(286, 34);
            multiplyToolStripMenuItem.Text = "M&ultiply";
            multiplyToolStripMenuItem.Click += multiplyToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WordMetricsButton);
            groupBox1.Controls.Add(LetterCheckerButton);
            groupBox1.Controls.Add(WordSquareButton);
            groupBox1.Controls.Add(WordPyramidButton);
            groupBox1.Controls.Add(WordPalindromeButton);
            groupBox1.Location = new Point(12, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 203);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(878, 544);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(WordMultiplyButton);
            Controls.Add(SecondWordTextBox);
            Controls.Add(OutputLbl);
            Controls.Add(FirstWordTextBox);
            Controls.Add(PromptLbl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Abigail Sneve Assignment 4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PromptLbl;
        private TextBox FirstWordTextBox;
        private Label OutputLbl;
        private TextBox SecondWordTextBox;
        private Button WordMetricsButton;
        private Button WordSquareButton;
        private Button WordPyramidButton;
        private Button WordPalindromeButton;
        private Button LetterCheckerButton;
        private Button WordMultiplyButton;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem wordFunToolStripMenuItem;
        private ToolStripMenuItem metricsToolStripMenuItem;
        private ToolStripMenuItem letterToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem pyramidToolStripMenuItem;
        private ToolStripMenuItem palindromeToolStripMenuItem;
        private ToolStripMenuItem multiplyToolStripMenuItem;
        private GroupBox groupBox1;
    }
}
