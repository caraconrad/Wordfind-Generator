using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
namespace Wordfind_Generator
{
    public partial class ShowPuzzle : Form
    {


        private string _answers, _puzzle;
        private int toggle;
        private BindingList<string> _items;

        public static int serialNumber; //public static int made the variable accessible from other methods in this class.

        public ShowPuzzle(string answers, string puzzle, BindingList<string> items)
        {
            InitializeComponent();

            _answers = answers;
            _puzzle = puzzle;
            _items = items;

            toggle = 0;

            PuzzleDisplay.Font = new Font("Courier New", 14);
            PuzzleDisplay.AppendText(_puzzle);

            textBox1.Text = serialNumber.ToString(); //used to convert random number and display in the TEXTBOX

        }


        //Opens print dialog
        private void printButton_Click(object sender, EventArgs e)
        {
            print();
        }


        public static int makeSerialNumber()   //this is called from within the Generate_Click method !!!!!
        {

            Random rnd = new Random();
            serialNumber = rnd.Next(100, 999);
            return ShowPuzzle.serialNumber;
        }


        //Builds a string containing puzzle and wordlist
        private string buildPrintString()
        {

            int columnCount = 0;

            // this modification allows you to print the puzzle and answer sheet separately.
            //string printerString = _puzzle + "\r\n";    //cara's original  2/5/2024  de AA3M
            string printerString = _puzzle;

            if (toggle == 0)
            {
                printerString = _puzzle + "\r\n" + "Serial Number " + serialNumber;
            }
            else if (toggle == 1)
            {
                printerString = _answers + "\r\n" + "Serial Number " + serialNumber;
            }

            foreach (string item in _items)
            {
                if (columnCount % 3 == 0)
                {
                    printerString += "\r\n\r\n";
                }

                printerString += item + "\t";
                columnCount++;
            }

            return printerString;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Tooltips
        private void copyButton_MouseHover(object sender, EventArgs e)
        {
            copyTip.SetToolTip(copyButton, "Copy the puzzle to the clipboard");
        }

        private void printButton_MouseHover(object sender, EventArgs e)
        {
            printTip.SetToolTip(printButton, "Print the puzzle view shown in window above \n use the Toggle Answers button to switch views.");
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeTip.SetToolTip(closeButton, "Return to the puzzle options");
        }


        //Toggles between showing the puzzle and showing the answers
        private void ToggleButton_Click(object sender, EventArgs e)
        {
            if (toggle == 0)
            {
                PuzzleDisplay.Clear();
                PuzzleDisplay.AppendText(_answers);
                toggle = 1;
            }
            else if (toggle == 1)
            {
                PuzzleDisplay.Clear();
                PuzzleDisplay.AppendText(_puzzle);
                toggle = 0;
            }
        }


        //Copy button copies what is displayed in the box
        private void copyButton_Click(object sender, EventArgs e)
        {
            copy();
        }


        //Context menu copy option
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy();
        }


        //Copies what is displayed in the rich textbox
        private void copy()
        {
            if (toggle == 0)
            {
                Clipboard.SetText(_puzzle);
            }
            else if (toggle == 1)
            {
                Clipboard.SetText(_answers);
            }
        }


        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print();
        }


        private void print()
        {
            PrintDialog printDialog1 = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            string s = buildPrintString();

            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(s, new Font("Courier New", 14), new SolidBrush(Color.Black),
                    new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width,
                        p.DefaultPageSettings.PrintableArea.Height));
            };
            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Error printing document", ex);
            }
        }


        //Saves the puzzle to text file
        private void ExportButton_Click(object sender, EventArgs e)
        {
            exportDialog.ShowDialog();
        }


        private void exportDialog_FileOk(object sender, CancelEventArgs e)
        {
            string name = exportDialog.FileName + ".txt";
            File.WriteAllText(name, _puzzle, System.Text.Encoding.Unicode);
            File.AppendAllText(name, "\n\n\n\n", System.Text.Encoding.Unicode);
            File.AppendAllText(name, _answers, System.Text.Encoding.Unicode);
        }
    }
}
