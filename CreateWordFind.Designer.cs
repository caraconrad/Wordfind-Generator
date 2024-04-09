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
            this.positionLabel = new System.Windows.Forms.Label();
            this.wordListLabel = new System.Windows.Forms.Label();
            this.HeightPanel = new System.Windows.Forms.NumericUpDown();
            this.dimensionsLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.WidthPanel = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
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
            this.SerialNoLabel = new System.Windows.Forms.Label();
            this.SerialNoBox = new System.Windows.Forms.TextBox();
            this.wordlistContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // WordList
            // 
            this.WordList.ContextMenuStrip = this.wordlistContextMenu;
            this.WordList.FormattingEnabled = true;
            this.WordList.Location = new System.Drawing.Point(25, 39);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(120, 160);
            this.WordList.TabIndex = 0;
            this.WordList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WordList_MouseMove);
            // 
            // wordlistContextMenu
            // 
            this.wordlistContextMenu.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.wordlistContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.wordlistContextMenu.Name = "wordlistContextMenu";
            this.wordlistContextMenu.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(151, 206);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            this.addButton.MouseHover += new System.EventHandler(this.addButton_MouseHover);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(151, 116);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            this.modifyButton.MouseHover += new System.EventHandler(this.modifyButton_MouseHover);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(151, 71);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
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
            this.left_right_check.Location = new System.Drawing.Point(269, 199);
            this.left_right_check.Name = "left_right_check";
            this.left_right_check.Size = new System.Drawing.Size(84, 17);
            this.left_right_check.TabIndex = 8;
            this.left_right_check.Text = "Left to Right";
            this.left_right_check.UseVisualStyleBackColor = true;
            // 
            // right_left_check
            // 
            this.right_left_check.AutoSize = true;
            this.right_left_check.Checked = true;
            this.right_left_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.right_left_check.Location = new System.Drawing.Point(269, 222);
            this.right_left_check.Name = "right_left_check";
            this.right_left_check.Size = new System.Drawing.Size(84, 17);
            this.right_left_check.TabIndex = 10;
            this.right_left_check.Text = "Right to Left";
            this.right_left_check.UseVisualStyleBackColor = true;
            // 
            // top_bottom_check
            // 
            this.top_bottom_check.AutoSize = true;
            this.top_bottom_check.Checked = true;
            this.top_bottom_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.top_bottom_check.Location = new System.Drawing.Point(269, 245);
            this.top_bottom_check.Name = "top_bottom_check";
            this.top_bottom_check.Size = new System.Drawing.Size(93, 17);
            this.top_bottom_check.TabIndex = 12;
            this.top_bottom_check.Text = "Top to Bottom";
            this.top_bottom_check.UseVisualStyleBackColor = true;
            // 
            // bottom_top_check
            // 
            this.bottom_top_check.AutoSize = true;
            this.bottom_top_check.Checked = true;
            this.bottom_top_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bottom_top_check.Location = new System.Drawing.Point(269, 268);
            this.bottom_top_check.Name = "bottom_top_check";
            this.bottom_top_check.Size = new System.Drawing.Size(93, 17);
            this.bottom_top_check.TabIndex = 14;
            this.bottom_top_check.Text = "Bottom to Top";
            this.bottom_top_check.UseVisualStyleBackColor = true;
            // 
            // topleft_bottomright_check
            // 
            this.topleft_bottomright_check.AutoSize = true;
            this.topleft_bottomright_check.Checked = true;
            this.topleft_bottomright_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topleft_bottomright_check.Location = new System.Drawing.Point(379, 199);
            this.topleft_bottomright_check.Name = "topleft_bottomright_check";
            this.topleft_bottomright_check.Size = new System.Drawing.Size(142, 17);
            this.topleft_bottomright_check.TabIndex = 9;
            this.topleft_bottomright_check.Text = "Top Left to Bottom Right";
            this.topleft_bottomright_check.UseVisualStyleBackColor = true;
            // 
            // bottomleft_topright_check
            // 
            this.bottomleft_topright_check.AutoSize = true;
            this.bottomleft_topright_check.Checked = true;
            this.bottomleft_topright_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bottomleft_topright_check.Location = new System.Drawing.Point(379, 222);
            this.bottomleft_topright_check.Name = "bottomleft_topright_check";
            this.bottomleft_topright_check.Size = new System.Drawing.Size(142, 17);
            this.bottomleft_topright_check.TabIndex = 11;
            this.bottomleft_topright_check.Text = "Bottom Left to Top Right";
            this.bottomleft_topright_check.UseVisualStyleBackColor = true;
            // 
            // topright_bottomleft_check
            // 
            this.topright_bottomleft_check.AutoSize = true;
            this.topright_bottomleft_check.Checked = true;
            this.topright_bottomleft_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topright_bottomleft_check.Location = new System.Drawing.Point(379, 245);
            this.topright_bottomleft_check.Name = "topright_bottomleft_check";
            this.topright_bottomleft_check.Size = new System.Drawing.Size(142, 17);
            this.topright_bottomleft_check.TabIndex = 13;
            this.topright_bottomleft_check.Text = "Top Right to Bottom Left";
            this.topright_bottomleft_check.UseVisualStyleBackColor = true;
            // 
            // bottomright_topleft_check
            // 
            this.bottomright_topleft_check.AutoSize = true;
            this.bottomright_topleft_check.Checked = true;
            this.bottomright_topleft_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bottomright_topleft_check.Location = new System.Drawing.Point(379, 268);
            this.bottomright_topleft_check.Name = "bottomright_topleft_check";
            this.bottomright_topleft_check.Size = new System.Drawing.Size(142, 17);
            this.bottomright_topleft_check.TabIndex = 15;
            this.bottomright_topleft_check.Text = "Bottom Right to Top Left";
            this.bottomright_topleft_check.UseVisualStyleBackColor = true;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(335, 180);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(106, 16);
            this.positionLabel.TabIndex = 13;
            this.positionLabel.Text = "Position Settings";
            // 
            // wordListLabel
            // 
            this.wordListLabel.AutoSize = true;
            this.wordListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordListLabel.Location = new System.Drawing.Point(44, 20);
            this.wordListLabel.Name = "wordListLabel";
            this.wordListLabel.Size = new System.Drawing.Size(63, 16);
            this.wordListLabel.TabIndex = 14;
            this.wordListLabel.Text = "Word List";
            // 
            // HeightPanel
            // 
            this.HeightPanel.Location = new System.Drawing.Point(352, 89);
            this.HeightPanel.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.HeightPanel.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.HeightPanel.Name = "HeightPanel";
            this.HeightPanel.Size = new System.Drawing.Size(120, 20);
            this.HeightPanel.TabIndex = 6;
            this.HeightPanel.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // dimensionsLabel
            // 
            this.dimensionsLabel.AutoSize = true;
            this.dimensionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionsLabel.Location = new System.Drawing.Point(286, 58);
            this.dimensionsLabel.Name = "dimensionsLabel";
            this.dimensionsLabel.Size = new System.Drawing.Size(218, 16);
            this.dimensionsLabel.TabIndex = 16;
            this.dimensionsLabel.Text = "Grid Dimensions (Character Length)";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(305, 91);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 17;
            this.heightLabel.Text = "Height:";
            // 
            // WidthPanel
            // 
            this.WidthPanel.Location = new System.Drawing.Point(352, 124);
            this.WidthPanel.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.WidthPanel.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.WidthPanel.Name = "WidthPanel";
            this.WidthPanel.Size = new System.Drawing.Size(120, 20);
            this.WidthPanel.TabIndex = 7;
            this.WidthPanel.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(305, 126);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 19;
            this.widthLabel.Text = "Width:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(289, 305);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.saveButton.MouseHover += new System.EventHandler(this.saveButton_MouseHover);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(397, 305);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 17;
            this.loadButton.Text = "Load...";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            this.loadButton.MouseHover += new System.EventHandler(this.loadButton_MouseHover);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(25, 253);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(133, 44);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Generate Puzzle";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.Generate_Click);
            this.GenerateButton.MouseHover += new System.EventHandler(this.generateButton_MouseHover);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(25, 206);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(120, 20);
            this.wordTextBox.TabIndex = 3;
            this.wordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WordTextBox_KeyDown);
            this.wordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WordTextBox_KeyPress);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // SerialNoLabel
            // 
            this.SerialNoLabel.AutoSize = true;
            this.SerialNoLabel.Location = new System.Drawing.Point(12, 308);
            this.SerialNoLabel.Name = "SerialNoLabel";
            this.SerialNoLabel.Size = new System.Drawing.Size(110, 13);
            this.SerialNoLabel.TabIndex = 20;
            this.SerialNoLabel.Text = "Serial No. (Optional)  -";
            // 
            // SerialNoBox
            // 
            this.SerialNoBox.Location = new System.Drawing.Point(127, 304);
            this.SerialNoBox.Name = "SerialNoBox";
            this.SerialNoBox.Size = new System.Drawing.Size(58, 20);
            this.SerialNoBox.TabIndex = 21;
            // 
            // CreateWordFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 373);
            this.Controls.Add(this.SerialNoBox);
            this.Controls.Add(this.SerialNoLabel);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.WidthPanel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.dimensionsLabel);
            this.Controls.Add(this.HeightPanel);
            this.Controls.Add(this.wordListLabel);
            this.Controls.Add(this.positionLabel);
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
            this.Name = "CreateWordFind";
            this.Text = "Create Word Find";
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
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label wordListLabel;
        private System.Windows.Forms.NumericUpDown HeightPanel;
        private System.Windows.Forms.Label dimensionsLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown WidthPanel;
        private System.Windows.Forms.Label widthLabel;
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
        private System.Windows.Forms.Label SerialNoLabel;
        private System.Windows.Forms.TextBox SerialNoBox;
    }
}