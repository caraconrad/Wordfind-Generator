using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;


namespace Wordfind_Generator
{
    public partial class CreateWordFind : Form
    {
        BindingList<string> _words;
        List<bool> _checklist;
        public string serialNumberString;

        public CreateWordFind()
        {
            _words = new BindingList<string>();
            _checklist = new List<bool>();

            InitializeComponent();
            WordList.DataSource = _words;


        }


        //Open the save dialog
        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }


        //Save settings to the file
        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            _checklist.Clear();   // this clears out any previous checklist so "appending" to
                                  // the list does not build the length beyond
                                  // 8 checkboxes in the saved file.  "_checklist.Clear();"
                                  //Load Checkboxes

            string fileName = saveFileDialog1.FileName;
            File.WriteAllText(fileName, "Cheklist:\n");

            //Save the checkbox list into the file

            MakeCheckboxList();     //checks the puzzle direction settings boxes

            foreach (bool value in _checklist)
            {
                File.AppendAllText(fileName, value.ToString() + "\n");
            }

            //Save the word list into the file
            File.AppendAllText(fileName, "\nWordlist:\n");

            foreach (string str in _words)
            {
                File.AppendAllText(fileName, str + "\n");
            }

            //Save dimension settings
            File.AppendAllText(fileName, "\nHeight:\n");
            File.AppendAllText(fileName, HeightPanel.Value.ToString());

            File.AppendAllText(fileName, "\n\nWidth:\n");
            File.AppendAllText(fileName, WidthPanel.Value.ToString());
        }


        //Open the open dialog, load configuration settings/word list 
        private void LoadButton_Click(object sender, EventArgs e)

        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            DialogResult result = openFileDialog1.ShowDialog();

            //Load settings when OK is clicked
            if (result == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                try
                {
                    StreamReader reader = File.OpenText(name);
                    string line;
                    int count = 1;

                    while ((line = reader.ReadLine()) != null)
                    {
                        _checklist.Clear();   // this clears out any previous checklist so "appending" to
                                              // the list does not build the length beyond
                                              // 8 boxes in the saved file.  "_checklist.Clear();"
                                              //Load Checkboxes
                        if (line == "Cheklist:")
                        {
                            while ((line = reader.ReadLine()) != "")
                            {
                                LoadCheckboxes(line, count);
                                count++;
                            }
                        }

                        //Load Wordlist
                        if (line == "Wordlist:")
                        {
                            _words.Clear();
                            while ((line = reader.ReadLine()) != "")
                            {
                                _words.Add(line);
                            }
                            WordList.DataSource = null;
                            WordList.DataSource = _words;
                        }

                        //Load Height
                        if (line == "Height:")
                        {
                            line = reader.ReadLine();
                            HeightPanel.Value = Convert.ToInt32(line);
                        }

                        //Load Width
                        if (line == "Width:")
                        {
                            line = reader.ReadLine();
                            WidthPanel.Value = Convert.ToInt32(line);
                        }

                    }
                    // close the stream in order to "save" to the filename which was
                    // opened using the "LOAD" button. AA3M  3/11/2024  "reader.close();"
                    reader.Close();

                }
                catch (IOException)
                {
                    MessageBox.Show("An IOException has occurred.");
                }

            }

        }


        //Add a word from the textbox to the list when clicking 'Add'
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.wordTextBox.Text != "")
            {
                _words.Add(this.wordTextBox.Text);
                this.wordTextBox.Focus();
                this.wordTextBox.Clear();
            }
        }


        //The 'Add' button is pressed when 'enter' is pressed in the textbox
        private void WordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton_Click(this, new EventArgs());
            }
        }


        //Restrict word text box so only letters and backspace can be entered
        private void WordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        //Modify selected word in word list
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = WordList.SelectedIndex;


            //Replace word if a word is selected
            if (selectedIndex != -1)
            {
                ModifyWord mod = new ModifyWord(WordList.GetItemText(WordList.SelectedItem));

                DialogResult dialogresult = mod.ShowDialog();
                _words.Insert(selectedIndex, mod.getWord());
                _words.RemoveAt(selectedIndex + 1);

                mod.Dispose();
            }
            else
                MessageBox.Show("Select a word for modification.");

        }


        //Removes word on button click, displays error if no word is selected
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = WordList.SelectedIndex;

            try
            {
                _words.RemoveAt(selectedIndex);
            }
            catch
            {
                MessageBox.Show("Select a word for removal.");
            }

        }


        //Clicking the generate puzzle button 
        public void Generate_Click(object sender, EventArgs e)
        {
            MakeCheckboxList();


            int localSerialNumber = ShowPuzzle.makeSerialNumber();   //need this to call the makeSerialNumber() method from within this method
                                                                     // that creates the random serial number printed on the pages
                                                                     //after hitting the Generate Puzzle button.
            serialNumberString = localSerialNumber.ToString();       //provides a text string input for serial number text box


            int height = Convert.ToInt32(HeightPanel.Value);
            int width = Convert.ToInt32(WidthPanel.Value);

            //Check for the largest word in case it is too big for the grid size
            int length = 0;
            foreach (string word in _words)
            {
                if (word.Length > length)
                    length = word.Length;
            }

            height = CheckHeight(length, height);
            width = CheckWidth(length, width);




            //We can proceed to generate the puzzle if at least one directional checkbox is selected
            if (DirectionalsNotUnchecked())
            {
                WordFindGeneration wordFind = new WordFindGeneration(_checklist, _words, height, width);

                wordFind.GenerateNewList();
                wordFind.PopulateGrid();
                wordFind.InitializePuzzleGrid();
                wordFind.BuildPuzzle();

                string answersGrid = wordFind.GetAnswersGrid();
                string puzzleGrid = wordFind.GetPuzzleGrid();

                if (!wordFind.GenerationFailed()) //If the puzzle didn't fail to generate we can display it.
                {
                    ShowPuzzle show = new ShowPuzzle(answersGrid, puzzleGrid, _words);
                    show.ShowDialog();

                    //The box is closed
                    show.Dispose();
                }
                else
                {
                    MessageBox.Show("The puzzle was unable to be generated due to too many words being into too small a puzzle grid. \n" +
                        "Please try again with either a shorter list or larger grid size.");
                }
            }
            else
                MessageBox.Show("Please select at least one directional option.");
        }


        //This builds the list of booleans associated with the checkboxes
        private void MakeCheckboxList()
        {
            if (left_right_check.Checked)
                _checklist.Add(true);
            else
                _checklist.Add(false);

            if (right_left_check.Checked)
                _checklist.Add(true);
            else
                _checklist.Add(false);

            if (top_bottom_check.Checked)
                _checklist.Add(true);
            else
                _checklist.Add(false);

            if (bottom_top_check.Checked)
                _checklist.Add(true);
            else
                _checklist.Add(false);

            if (topleft_bottomright_check.Checked)
                _checklist.Add(true);
            else
                _checklist.Add(false);

            if (bottomleft_topright_check.Checked)
                _checklist.Add(true);
            else
                _checklist.Add(false);

            if (topright_bottomleft_check.Checked)
                _checklist.Add(true);
            else
                _checklist.Add(false);

            if (bottomright_topleft_check.Checked)
                _checklist.Add(true);
            else
                _checklist.Add(false);
        }


        //Used for loading the checkboxes upon file load
        private void LoadCheckboxes(string line, int count)
        {
            //Set Left_Right_Check
            if ((line == "True") && (count == 1))
            {
                left_right_check.Checked = true;
            }
            else if ((line == "False") && (count == 1))
            {
                left_right_check.Checked = false;
            }

            //Set Right_Left_Check
            if ((line == "True") && (count == 2))
            {
                right_left_check.Checked = true;
            }
            else if ((line == "False") && (count == 2))
            {
                right_left_check.Checked = false;
            }

            //Set Top_Bottom_Check
            if ((line == "True") && (count == 3))
            {
                top_bottom_check.Checked = true;
            }
            else if ((line == "False") && (count == 3))
            {
                top_bottom_check.Checked = false;
            }

            //Set Bottom_Top_Check
            if ((line == "True") && (count == 4))
            {
                bottom_top_check.Checked = true;
            }
            else if ((line == "False") && (count == 4))
            {
                bottom_top_check.Checked = false;
            }

            //Set Topleft_Bottomright_Check
            if ((line == "True") && (count == 5))
            {
                topleft_bottomright_check.Checked = true;
            }
            else if ((line == "False") && (count == 5))
            {
                topleft_bottomright_check.Checked = false;
            }

            //Set Bottomleft_Topright_Check
            if ((line == "True") && (count == 6))
            {
                bottomleft_topright_check.Checked = true;
            }
            else if ((line == "False") && (count == 6))
            {
                bottomleft_topright_check.Checked = false;
            }

            //Set Topright_Bottomleft_Check
            if ((line == "True") && (count == 7))
            {
                topright_bottomleft_check.Checked = true;
            }
            else if ((line == "False") && (count == 7))
            {
                topright_bottomleft_check.Checked = false;
            }

            //Set Bottomright_Topleft_Check
            if ((line == "True") && (count == 8))
            {
                bottomright_topleft_check.Checked = true;
            }
            else if ((line == "False") && (count == 8))
            {
                bottomright_topleft_check.Checked = false;
            }
        }


        //Checks if all checks are unchecked
        private bool DirectionalsNotUnchecked()
        {
            foreach (bool value in _checklist)
            {
                if (value == true)
                    return true; //As long as one value is true, there is no error
            }
            return false; //No values were true, we cannot proceed
        }


        //Tooltips
        private void addButton_MouseHover(object sender, EventArgs e)
        {
            addTip.SetToolTip(addButton, "Add a new word to the list");
        }

        private void removeButton_MouseHover(object sender, EventArgs e)
        {
            removeTip.SetToolTip(removeButton, "Removes selected word from the list");
        }

        private void modifyButton_MouseHover(object sender, EventArgs e)
        {
            modifyTip.SetToolTip(modifyButton, "Modify the selected word in the list");
        }

        private void loadButton_MouseHover(object sender, EventArgs e)
        {
            loadTip.SetToolTip(loadButton, "Load a previously saved puzzle");
        }

        private void saveButton_MouseHover(object sender, EventArgs e)
        {
            saveTip.SetToolTip(saveButton, "Save the current puzzle.");
        }

        private void generateButton_MouseHover(object sender, EventArgs e)
        {
            generateTip.SetToolTip(GenerateButton, "Generate a new puzzle using the given options");
        }


        //Hovering over a word in the listbox shows the word in a tooltip
        private void WordList_MouseMove(object sender, MouseEventArgs e)
        {
            //Get the index for the item being hovered.
            int index = WordList.IndexFromPoint(e.Location);

            //Check if the index is valid.
            if (index != -1 && index < WordList.Items.Count)
            {
                //Check if the ToolTip's text isn't already the one we are now processing.
                if (listboxTip.GetToolTip(WordList) != WordList.Items[index].ToString())
                {
                    //If it isn't, then a new item needs to be displayed on the toolTip. Update it.
                    listboxTip.SetToolTip(WordList, WordList.Items[index].ToString());
                }
            }
            else
            {
                listboxTip.SetToolTip(this.WordList, string.Empty); //Dont show tip over empty area
            }
        }


        //Check the grid size is appropriate, otherwise we must resize
        private int CheckHeight(int length, int height)
        {
            if (length > height)
            {
                height = length + 1;
                HeightPanel.Value = height;
                MessageBox.Show("A word is too big, readjusted height to " +
                    height.ToString());
            }
            return height;
        }


        private int CheckWidth(int length, int width)
        {
            if (length > width)
            {
                width = length + 1;
                WidthPanel.Value = length + 1;
                MessageBox.Show("A word is too big, readjusted width to " +
                    width.ToString());
            }
            return width;
        }


        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wordlist = "";

            foreach (string item in _words)
            {
                wordlist += item + "\r\n";
            }
            Clipboard.SetText(wordlist);
        }
    }
}
