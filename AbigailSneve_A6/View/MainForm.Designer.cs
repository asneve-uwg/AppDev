using System.ComponentModel;

namespace AbigailSneve_A6.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ChooseFileBtn = new Button();
            exportCsvBtn = new Button();
            exportJsonBtn = new Button();
            bookCountLbl = new Label();
            SuspendLayout();
            // 
            // ChooseFileBtn
            // 
            ChooseFileBtn.Location = new Point(320, 96);
            ChooseFileBtn.Name = "ChooseFileBtn";
            ChooseFileBtn.Size = new Size(159, 34);
            ChooseFileBtn.TabIndex = 0;
            ChooseFileBtn.Text = "Choose File";
            ChooseFileBtn.UseVisualStyleBackColor = true;
            ChooseFileBtn.Click += ChooseFileBtn_Click;
            // 
            // exportCsvBtn
            // 
            exportCsvBtn.Location = new Point(320, 136);
            exportCsvBtn.Name = "exportCsvBtn";
            exportCsvBtn.Size = new Size(159, 34);
            exportCsvBtn.TabIndex = 1;
            exportCsvBtn.Text = "Export CSV";
            exportCsvBtn.UseVisualStyleBackColor = true;
            exportCsvBtn.Click += exportCsvBtn_Click;
            // 
            // exportJsonBtn
            // 
            exportJsonBtn.Location = new Point(320, 176);
            exportJsonBtn.Name = "exportJsonBtn";
            exportJsonBtn.Size = new Size(159, 34);
            exportJsonBtn.TabIndex = 2;
            exportJsonBtn.Text = "Export JSON";
            exportJsonBtn.UseVisualStyleBackColor = true;
            exportJsonBtn.Click += exportJsonBtn_Click;
            // 
            // bookCountLbl
            // 
            bookCountLbl.AutoSize = true;
            bookCountLbl.Location = new Point(369, 229);
            bookCountLbl.Name = "bookCountLbl";
            bookCountLbl.Size = new Size(59, 25);
            bookCountLbl.TabIndex = 3;
            bookCountLbl.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bookCountLbl);
            Controls.Add(exportJsonBtn);
            Controls.Add(exportCsvBtn);
            Controls.Add(ChooseFileBtn);
            Name = "MainForm";
            Text = "Abigail Sneve Assignment 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChooseFileBtn;
        private Button exportCsvBtn;
        private Button exportJsonBtn;
        private Label bookCountLbl;
    }
}