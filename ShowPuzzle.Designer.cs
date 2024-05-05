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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.printbothButton = new System.Windows.Forms.Button();
            this.puzzleContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1184, 1344);
            this.closeButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(336, 74);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(114, 1136);
            this.copyButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(336, 74);
            this.copyButton.TabIndex = 1;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            this.copyButton.MouseHover += new System.EventHandler(this.copyButton_MouseHover);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(485, 1316);
            this.printButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(336, 102);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print what you see in the window above";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            this.printButton.MouseHover += new System.EventHandler(this.printButton_MouseHover);
            // 
            // PuzzleDisplay
            // 
            this.PuzzleDisplay.ContextMenuStrip = this.puzzleContextMenu;
            this.PuzzleDisplay.Location = new System.Drawing.Point(97, 108);
            this.PuzzleDisplay.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PuzzleDisplay.Name = "PuzzleDisplay";
            this.PuzzleDisplay.ReadOnly = true;
            this.PuzzleDisplay.Size = new System.Drawing.Size(1442, 1020);
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
            this.puzzleContextMenu.Size = new System.Drawing.Size(177, 116);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(176, 56);
            this.copyToolStripMenuItem.Text = "copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(176, 56);
            this.printToolStripMenuItem.Text = "print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(1184, 1136);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(336, 74);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Export...";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ToggleButton
            // 
            this.ToggleButton.Location = new System.Drawing.Point(127, 1316);
            this.ToggleButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(323, 102);
            this.ToggleButton.TabIndex = 5;
            this.ToggleButton.Text = "Show Answers";
            this.ToggleButton.UseVisualStyleBackColor = true;
            this.ToggleButton.Click += new System.EventHandler(this.ToggleButton_Click);
            this.ToggleButton.MouseHover += new System.EventHandler(this.ToggleButton_MouseHover);
            // 
            // exportDialog
            // 
            this.exportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportDialog_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 1238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 44);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 1245);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Serial Number";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // printbothButton
            // 
            this.printbothButton.Location = new System.Drawing.Point(841, 1318);
            this.printbothButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.printbothButton.Name = "printbothButton";
            this.printbothButton.Size = new System.Drawing.Size(336, 100);
            this.printbothButton.TabIndex = 18;
            this.printbothButton.Text = "Print puzzle and answer";
            this.printbothButton.UseVisualStyleBackColor = true;
            this.printbothButton.Click += new System.EventHandler(this.printbothButton_Click);
            this.printbothButton.MouseHover += new System.EventHandler(this.printbothButton_MouseHover);
            // 
            // ShowPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1650, 1486);
            this.Controls.Add(this.printbothButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ToggleButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.PuzzleDisplay);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.closeButton);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button printbothButton;
    }
}