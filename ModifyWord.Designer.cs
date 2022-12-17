namespace Wordfind_Generator
{
    partial class ModifyWord
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
            this.modifyTextbox = new System.Windows.Forms.TextBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifyTextbox
            // 
            this.modifyTextbox.Location = new System.Drawing.Point(98, 35);
            this.modifyTextbox.Name = "modifyTextbox";
            this.modifyTextbox.Size = new System.Drawing.Size(368, 20);
            this.modifyTextbox.TabIndex = 0;
            this.modifyTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modifyTextbox_KeyPress);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(137, 79);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 1;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(335, 79);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Modify_Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 124);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.modifyTextbox);
            this.Name = "Modify_Word";
            this.Text = "Modify Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modifyTextbox;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button cancelButton;
    }
}