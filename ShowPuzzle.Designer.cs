namespace Wordfind_Generator
{
    partial class ShowPuzzle
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
            this.components = new System.ComponentModel.Container();
            this.closeButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.PuzzleDisplay = new System.Windows.Forms.RichTextBox();
            this.puzzleContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTip = new System.Windows.Forms.ToolTip(this.components);
            this.printTip = new System.Windows.Forms.ToolTip(this.components);
            this.closeTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExportButton = new System.Windows.Forms.Button();
            this.ToggleButton = new System.Windows.Forms.Button();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.SerialNumberBox = new System.Windows.Forms.TextBox();
            this.serialNoLabel = new System.Windows.Forms.Label();
            this.puzzleContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(279, 445);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(106, 26);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(36, 399);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(106, 26);
            this.copyButton.TabIndex = 1;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            this.copyButton.MouseHover += new System.EventHandler(this.copyButton_MouseHover);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(204, 399);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(106, 26);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print...";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            this.printButton.MouseHover += new System.EventHandler(this.printButton_MouseHover);
            // 
            // PuzzleDisplay
            // 
            this.PuzzleDisplay.ContextMenuStrip = this.puzzleContextMenu;
            this.PuzzleDisplay.Location = new System.Drawing.Point(31, 38);
            this.PuzzleDisplay.Name = "PuzzleDisplay";
            this.PuzzleDisplay.ReadOnly = true;
            this.PuzzleDisplay.Size = new System.Drawing.Size(458, 344);
            this.PuzzleDisplay.TabIndex = 3;
            this.PuzzleDisplay.Text = "";
            this.PuzzleDisplay.WordWrap = false;
            // 
            // puzzleContextMenu
            // 
            this.puzzleContextMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.puzzleContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.printToolStripMenuItem});
            this.puzzleContextMenu.Name = "puzzleContextMenu";
            this.puzzleContextMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.copyToolStripMenuItem.Text = "copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.printToolStripMenuItem.Text = "print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(374, 399);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(106, 26);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Export...";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ToggleButton
            // 
            this.ToggleButton.Location = new System.Drawing.Point(122, 445);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(102, 26);
            this.ToggleButton.TabIndex = 5;
            this.ToggleButton.Text = "Toggle Answers";
            this.ToggleButton.UseVisualStyleBackColor = true;
            this.ToggleButton.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // exportDialog
            // 
            this.exportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportDialog_FileOk);
            // 
            // SerialNumberBox
            // 
            this.SerialNumberBox.Location = new System.Drawing.Point(105, 9);
            this.SerialNumberBox.Margin = new System.Windows.Forms.Padding(1);
            this.SerialNumberBox.Name = "SerialNumberBox";
            this.SerialNumberBox.ReadOnly = true;
            this.SerialNumberBox.Size = new System.Drawing.Size(62, 20);
            this.SerialNumberBox.TabIndex = 6;
            // 
            // serialNoLabel
            // 
            this.serialNoLabel.AutoSize = true;
            this.serialNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNoLabel.Location = new System.Drawing.Point(28, 12);
            this.serialNoLabel.Name = "serialNoLabel";
            this.serialNoLabel.Size = new System.Drawing.Size(73, 13);
            this.serialNoLabel.TabIndex = 17;
            this.serialNoLabel.Text = "Serial Number";
            // 
            // ShowPuzzle
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(516, 488);
            this.Controls.Add(this.serialNoLabel);
            this.Controls.Add(this.SerialNumberBox);
            this.Controls.Add(this.ToggleButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.PuzzleDisplay);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.closeButton);
            this.Name = "ShowPuzzle";
            this.Text = "Puzzle View";
            this.puzzleContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.RichTextBox PuzzleDisplay;
        private System.Windows.Forms.ToolTip copyTip;
        private System.Windows.Forms.ToolTip printTip;
        private System.Windows.Forms.ToolTip closeTip;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ToggleButton;
        private System.Windows.Forms.ContextMenuStrip puzzleContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.TextBox SerialNumberBox;
        private System.Windows.Forms.Label serialNoLabel;
    }
}