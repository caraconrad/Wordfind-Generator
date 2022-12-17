using System;
using System.Windows.Forms;

namespace Wordfind_Generator
{
    public partial class ModifyWord : Form
    {

        private string _replaceWord;

        public ModifyWord(string selectedWord)
        {
            _replaceWord = selectedWord;
            InitializeComponent();
            modifyTextbox.Text = _replaceWord;
        }


        public string getWord()
        {
            return _replaceWord;
        }


        //Close window
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Return the text to replace
        private void replaceButton_Click(object sender, EventArgs e)
        {
            if (modifyTextbox.Text.Trim().Length > 0)
            {
                _replaceWord = modifyTextbox.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter some text to replace the word with.");
            }
        }


        //Allow escape and enter
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {                
                cancelButton_Click(this, new EventArgs());
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                replaceButton_Click(this, new EventArgs());
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        //Restrict word text box so only letters and backspace can be entered
        private void modifyTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsLetter(e.KeyChar);
            }          
        }
    }
}
