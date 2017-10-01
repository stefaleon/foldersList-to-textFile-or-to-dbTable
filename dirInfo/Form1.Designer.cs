namespace dirInfo
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
            this.sortedSubfoldersListBox = new System.Windows.Forms.ListBox();
            this.selectDirectoryButton = new System.Windows.Forms.Button();
            this.displaySubFoldersButton = new System.Windows.Forms.Button();
            this.selectedDirTextBox = new System.Windows.Forms.TextBox();
            this.writeToTextFileButton = new System.Windows.Forms.Button();
            this.writeToMoviesTitlesButton = new System.Windows.Forms.Button();
            this.textFileTextBox = new System.Windows.Forms.TextBox();
            this.selectTextFileButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sortedSubfoldersListBox
            // 
            this.sortedSubfoldersListBox.FormattingEnabled = true;
            this.sortedSubfoldersListBox.ItemHeight = 18;
            this.sortedSubfoldersListBox.Location = new System.Drawing.Point(182, 65);
            this.sortedSubfoldersListBox.Name = "sortedSubfoldersListBox";
            this.sortedSubfoldersListBox.Size = new System.Drawing.Size(590, 472);
            this.sortedSubfoldersListBox.Sorted = true;
            this.sortedSubfoldersListBox.TabIndex = 0;
            // 
            // selectDirectoryButton
            // 
            this.selectDirectoryButton.Location = new System.Drawing.Point(12, 12);
            this.selectDirectoryButton.Name = "selectDirectoryButton";
            this.selectDirectoryButton.Size = new System.Drawing.Size(150, 50);
            this.selectDirectoryButton.TabIndex = 1;
            this.selectDirectoryButton.Text = "Select Root Folder";
            this.selectDirectoryButton.UseVisualStyleBackColor = true;
            // 
            // displaySubFoldersButton
            // 
            this.displaySubFoldersButton.Location = new System.Drawing.Point(12, 68);
            this.displaySubFoldersButton.Name = "displaySubFoldersButton";
            this.displaySubFoldersButton.Size = new System.Drawing.Size(150, 50);
            this.displaySubFoldersButton.TabIndex = 2;
            this.displaySubFoldersButton.Text = "Display Subfolders";
            this.displaySubFoldersButton.UseVisualStyleBackColor = true;
            // 
            // selectedDirTextBox
            // 
            this.selectedDirTextBox.Location = new System.Drawing.Point(182, 12);
            this.selectedDirTextBox.Name = "selectedDirTextBox";
            this.selectedDirTextBox.Size = new System.Drawing.Size(590, 24);
            this.selectedDirTextBox.TabIndex = 3;
            // 
            // writeToTextFileButton
            // 
            this.writeToTextFileButton.Location = new System.Drawing.Point(12, 230);
            this.writeToTextFileButton.Name = "writeToTextFileButton";
            this.writeToTextFileButton.Size = new System.Drawing.Size(150, 50);
            this.writeToTextFileButton.TabIndex = 4;
            this.writeToTextFileButton.Text = "Write to Text File";
            this.writeToTextFileButton.UseVisualStyleBackColor = true;
            // 
            // writeToMoviesTitlesButton
            // 
            this.writeToMoviesTitlesButton.Location = new System.Drawing.Point(12, 300);
            this.writeToMoviesTitlesButton.Name = "writeToMoviesTitlesButton";
            this.writeToMoviesTitlesButton.Size = new System.Drawing.Size(150, 100);
            this.writeToMoviesTitlesButton.TabIndex = 5;
            this.writeToMoviesTitlesButton.Text = "Write SubFolders Names to Movies Titles";
            this.writeToMoviesTitlesButton.UseVisualStyleBackColor = true;
            // 
            // textFileTextBox
            // 
            this.textFileTextBox.Location = new System.Drawing.Point(12, 200);
            this.textFileTextBox.Name = "textFileTextBox";
            this.textFileTextBox.Size = new System.Drawing.Size(150, 24);
            this.textFileTextBox.TabIndex = 6;
            // 
            // selectTextFileButton
            // 
            this.selectTextFileButton.Location = new System.Drawing.Point(12, 144);
            this.selectTextFileButton.Name = "selectTextFileButton";
            this.selectTextFileButton.Size = new System.Drawing.Size(150, 50);
            this.selectTextFileButton.TabIndex = 7;
            this.selectTextFileButton.Text = "Select Text File";
            this.selectTextFileButton.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(179, 44);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 18);
            this.infoLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.selectTextFileButton);
            this.Controls.Add(this.textFileTextBox);
            this.Controls.Add(this.writeToMoviesTitlesButton);
            this.Controls.Add(this.writeToTextFileButton);
            this.Controls.Add(this.selectedDirTextBox);
            this.Controls.Add(this.displaySubFoldersButton);
            this.Controls.Add(this.selectDirectoryButton);
            this.Controls.Add(this.sortedSubfoldersListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sortedSubfoldersListBox;
        private System.Windows.Forms.Button selectDirectoryButton;
        private System.Windows.Forms.Button displaySubFoldersButton;
        private System.Windows.Forms.TextBox selectedDirTextBox;
        private System.Windows.Forms.Button writeToTextFileButton;
        private System.Windows.Forms.Button writeToMoviesTitlesButton;
        private System.Windows.Forms.TextBox textFileTextBox;
        private System.Windows.Forms.Button selectTextFileButton;
        private System.Windows.Forms.Label infoLabel;
    }
}

