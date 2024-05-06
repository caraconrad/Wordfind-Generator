namespace Wordfind_Generator
{
    partial class CreateWordFind
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
            this.WordList = new System.Windows.Forms.ListBox();
            this.wordlistContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.left_right_check = new System.Windows.Forms.CheckBox();
            this.right_left_check = new System.Windows.Forms.CheckBox();
            this.top_bottom_check = new System.Windows.Forms.CheckBox();
            this.bottom_top_check = new System.Windows.Forms.CheckBox();
            this.topleft_bottomright_check = new System.Windows.Forms.CheckBox();
            this.bottomleft_topright_check = new System.Windows.Forms.CheckBox();
            this.topright_bottomleft_check = new System.Windows.Forms.CheckBox();
            this.bottomright_topleft_check = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightPanel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WidthPanel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.addTip = new System.Windows.Forms.ToolTip(this.components);
            this.removeTip = new System.Windows.Forms.ToolTip(this.components);
            this.modifyTip = new System.Windows.Forms.ToolTip(this.components);
            this.loadTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveTip = new System.Windows.Forms.ToolTip(this.components);
            this.generateTip = new System.Windows.Forms.ToolTip(this.components);
            this.cancelTip = new System.Windows.Forms.ToolTip(this.components);
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listboxTip = new System.Windows.Forms.ToolTip(this.components);
            this.wordlistContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // WordList
            // 
            this.WordList.ContextMenuStrip = this.wordlistContextMenu;
            this.WordList.FormattingEnabled = true;
            this.WordList.ItemHeight = 37;
            this.WordList.Location = new System.Drawing.Point(79, 111);
            this.WordList.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(371, 448);
            this.WordList.TabIndex = 0;
            this.WordList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WordList_MouseMove);
            // 
            // wordlistContextMenu
            // 
            this.wordlistContextMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.wordlistContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.wordlistContextMenu.Name = "wordlistContextMenu";
            this.wordlistContextMenu.Size = new System.Drawing.Size(182, 60);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(181, 56);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(478, 586);
            this.addButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(238, 65);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            this.addButton.MouseHover += new System.EventHandler(this.addButton_MouseHover);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(478, 330);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(238, 65);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            this.modifyButton.MouseHover += new System.EventHandler(this.modifyButton_MouseHover);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(478, 202);
            this.removeButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(238, 65);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.removeButton.MouseHover += new System.EventHandler(this.removeButton_MouseHover);
            // 
            // left_right_check
            // 
            this.left_right_check.AutoSize = true;
            this.left_right_check.Checked = true;
            this.left_right_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.left_right_check.Location = new System.Drawing.Point(852, 566);
            this.left_right_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.left_right_check.Name = "left_right_check";
            this.left_right_check.Size = new System.Drawing.Size(235, 41);
            this.left_right_check.TabIndex = 8;
            this.left_right_check.Text = "Left to Right";
            this.left_right_check.UseVisualStyleBackColor = true;
            // 
            // right_left_check
            // 
            this.right_left_check.AutoSize = true;
            this.right_left_check.Checked = true;
            this.right_left_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.right_left_check.Location = new System.Drawing.Point(852, 632);
            this.right_left_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.right_left_check.Name = "right_left_check";
            this.right_left_check.Size = new System.Drawing.Size(235, 41);
            this.right_left_check.TabIndex = 10;
            this.right_left_check.Text = "Right to Left";
            this.right_left_check.UseVisualStyleBackColor = true;
            // 
            // top_bottom_check
            // 
            this.top_bottom_check.AutoSize = true;
            this.top_bottom_check.Checked = true;
            this.top_bottom_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.top_bottom_check.Location = new System.Drawing.Point(852, 697);
            this.top_bottom_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.top_bottom_check.Name = "top_bottom_check";
            this.top_bottom_check.Size = new System.Drawing.Size(266, 41);
            this.top_bottom_check.TabIndex = 12;
            this.top_bottom_check.Text = "Top to Bottom";
            this.top_bottom_check.UseVisualStyleBackColor = true;
            // 
            // bottom_top_check
            // 
            this.bottom_top_check.AutoSize = true;
            this.bottom_top_check.Checked = true;
            this.bottom_top_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bottom_top_check.Location = new System.Drawing.Point(852, 763);
            this.bottom_top_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bottom_top_check.Name = "bottom_top_check";
            this.bottom_top_check.Size = new System.Drawing.Size(266, 41);
            this.bottom_top_check.TabIndex = 14;
            this.bottom_top_check.Text = "Bottom to Top";
            this.bottom_top_check.UseVisualStyleBackColor = true;
            // 
            // topleft_bottomright_check
            // 
            this.topleft_bottomright_check.AutoSize = true;
            this.topleft_bottomright_check.Checked = true;
            this.topleft_bottomright_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topleft_bottomright_check.Location = new System.Drawing.Point(1200, 566);
            this.topleft_bottomright_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.topleft_bottomright_check.Name = "topleft_bottomright_check";
            this.topleft_bottomright_check.Size = new System.Drawing.Size(411, 41);
            this.topleft_bottomright_check.TabIndex = 9;
            this.topleft_bottomright_check.Text = "Top Left to Bottom Right";
            this.topleft_bottomright_check.UseVisualStyleBackColor = true;
            // 
            // bottomleft_topright_check
            // 
            this.bottomleft_topright_check.AutoSize = true;
            this.bottomleft_topright_check.Checked = true;
            this.bottomleft_topright_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bottomleft_topright_check.Location = new System.Drawing.Point(1200, 632);
            this.bottomleft_topright_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bottomleft_topright_check.Name = "bottomleft_topright_check";
            this.bottomleft_topright_check.Size = new System.Drawing.Size(411, 41);
            this.bottomleft_topright_check.TabIndex = 11;
            this.bottomleft_topright_check.Text = "Bottom Left to Top Right";
            this.bottomleft_topright_check.UseVisualStyleBackColor = true;
            // 
            // topright_bottomleft_check
            // 
            this.topright_bottomleft_check.AutoSize = true;
            this.topright_bottomleft_check.Checked = true;
            this.topright_bottomleft_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topright_bottomleft_check.Location = new System.Drawing.Point(1200, 697);
            this.topright_bottomleft_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.topright_bottomleft_check.Name = "topright_bottomleft_check";
            this.topright_bottomleft_check.Size = new System.Drawing.Size(411, 41);
            this.topright_bottomleft_check.TabIndex = 13;
            this.topright_bottomleft_check.Text = "Top Right to Bottom Left";
            this.topright_bottomleft_check.UseVisualStyleBackColor = true;
            // 
            // bottomright_topleft_check
            // 
            this.bottomright_topleft_check.AutoSize = true;
            this.bottomright_topleft_check.Checked = true;
            this.bottomright_topleft_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bottomright_topleft_check.Location = new System.Drawing.Point(1200, 763);
            this.bottomright_topleft_check.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bottomright_topleft_check.Name = "bottomright_topleft_check";
            this.bottomright_topleft_check.Size = new System.Drawing.Size(411, 41);
            this.bottomright_topleft_check.TabIndex = 15;
            this.bottomright_topleft_check.Text = "Bottom Right to Top Left";
            this.bottomright_topleft_check.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1061, 512);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Position Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 44);
            this.label2.TabIndex = 14;
            this.label2.Text = "Word List";
            // 
            // HeightPanel
            // 
            this.HeightPanel.Location = new System.Drawing.Point(1115, 253);
            this.HeightPanel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.HeightPanel.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.HeightPanel.Name = "HeightPanel";
            this.HeightPanel.Size = new System.Drawing.Size(380, 44);
            this.HeightPanel.TabIndex = 6;
            this.HeightPanel.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(906, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(650, 44);
            this.label3.TabIndex = 16;
            this.label3.Text = "Grid Dimensions (Character Length)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(966, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "Height:";
            // 
            // WidthPanel
            // 
            this.WidthPanel.Location = new System.Drawing.Point(1115, 353);
            this.WidthPanel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.WidthPanel.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.WidthPanel.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.WidthPanel.Name = "WidthPanel";
            this.WidthPanel.Size = new System.Drawing.Size(380, 44);
            this.WidthPanel.TabIndex = 7;
            this.WidthPanel.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(966, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "Width:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(915, 868);
            this.saveButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(238, 65);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(1257, 868);
            this.loadButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(238, 65);
            this.loadButton.TabIndex = 17;
            this.loadButton.Text = "Load...";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            this.loadButton.MouseHover += new System.EventHandler(this.loadButton_MouseHover);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(66, 788);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(421, 125);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Generate Puzzle";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.Generate_Click);
            this.GenerateButton.MouseHover += new System.EventHandler(this.generateButton_MouseHover);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(79, 586);
            this.wordTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(371, 44);
            this.wordTextBox.TabIndex = 3;
            this.wordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WordTextBox_KeyDown);
            this.wordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WordTextBox_KeyPress);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // CreateWordFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1830, 1099);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WidthPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeightPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bottomright_topleft_check);
            this.Controls.Add(this.topright_bottomleft_check);
            this.Controls.Add(this.bottomleft_topright_check);
            this.Controls.Add(this.topleft_bottomright_check);
            this.Controls.Add(this.bottom_top_check);
            this.Controls.Add(this.top_bottom_check);
            this.Controls.Add(this.right_left_check);
            this.Controls.Add(this.left_right_check);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.WordList);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "CreateWordFind";
            this.Text = "Create WordFind V1.3";
            this.wordlistContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeightPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WordList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.CheckBox left_right_check;
        private System.Windows.Forms.CheckBox right_left_check;
        private System.Windows.Forms.CheckBox top_bottom_check;
        private System.Windows.Forms.CheckBox bottom_top_check;
        private System.Windows.Forms.CheckBox topleft_bottomright_check;
        private System.Windows.Forms.CheckBox bottomleft_topright_check;
        private System.Windows.Forms.CheckBox topright_bottomleft_check;
        private System.Windows.Forms.CheckBox bottomright_topleft_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown HeightPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown WidthPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.ToolTip addTip;
        private System.Windows.Forms.ToolTip removeTip;
        private System.Windows.Forms.ToolTip modifyTip;
        private System.Windows.Forms.ToolTip loadTip;
        private System.Windows.Forms.ToolTip saveTip;
        private System.Windows.Forms.ToolTip generateTip;
        private System.Windows.Forms.ToolTip cancelTip;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip listboxTip;
        private System.Windows.Forms.ContextMenuStrip wordlistContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}