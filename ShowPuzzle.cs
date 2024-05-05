using System;
using System.CodeDom.Compiler;
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

        //added for printing puzzle and answers with one click 5/5/24
        private void printbothButton_Click(object sender, EventArgs e)
        {
            printBoth();
            //print();
        }


        public static int makeSerialNumber()   //this is called from within the Generate_Click method !!!!!
        {

            Random rnd = new Random();
            serialNumber = rnd.Next(100, 999);
            return ShowPuzzle.serialNumber;
        }


        //Builds a string containing puzzle or wordlist
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
            printTip.SetToolTip(printButton, "Print the puzzle view shown in window above \n use the Show Answers / Show Puzzle button to switch views.");
        }
        private void printbothButton_MouseHover(object sender, EventArgs e)
        {
            printTip.SetToolTip(printbothButton, "Print the puzzle AND answer views. After printing, this window will close. \n Press the Generate button to make a new puzzle and serial number. ");
        }


            private void closeButton_MouseHover(object sender, EventArgs e)
            {
                closeTip.SetToolTip(closeButton, "Return to the puzzle options");
            }

            private void ToggleButton_MouseHover(object sender, EventArgs e)
            {
                closeTip.SetToolTip(ToggleButton, "Switch between the puzzle and answer views");
            }


            //Toggles between showing the puzzle and showing the answers
            private void ToggleButton_Click(object sender, EventArgs e)
            {
                if (toggle == 0)
                {
                    PuzzleDisplay.Clear();
                    PuzzleDisplay.AppendText(_answers);
                    this.ToggleButton.Text = "Show Puzzle";  //change prompt on button  4/22/2024 de AA3M
                    toggle = 1;
                }
                else if (toggle == 1)
                {
                    PuzzleDisplay.Clear();
                    PuzzleDisplay.AppendText(_puzzle);
                    this.ToggleButton.Text = "Show Answers";  //change prompt on button   4/22/2024 de AA3M
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

            private void printBoth()
            {

            if (toggle == 1)  //ignore toggle view setting for printing. set toggle to zero and print
            {
                toggle = 0;
            }


            if (toggle == 0)
            {
                PuzzleDisplay.Clear();      //call up the answers in the puzzle view window
                PuzzleDisplay.AppendText(_answers);
                
                toggle = 1;
            }


            PrintDialog printDialog2 = new PrintDialog();
                PrintDocument printDoc1 = new PrintDocument();

                string t = buildPrintString();

                PrintDocument q = new PrintDocument();
                q.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString(t, new Font("Courier New", 14), new SolidBrush(Color.Black),
                        new RectangleF(0, 0, q.DefaultPageSettings.PrintableArea.Width,
                            q.DefaultPageSettings.PrintableArea.Height));
                };
                try
                {
                   q.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error printing document", ex);
                }
            // put second page printing here

            if (toggle == 1)
            {
                PuzzleDisplay.Clear();      //call up the puzzle in the puzzle view window
                PuzzleDisplay.AppendText(_puzzle);
                
                toggle = 0;
            }


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

            this.Close();  //when using the "print puzzle and answers" button, it closes window forcing user to
                           //generate a new puzzle with unique serial number.

        }// end of  private void printBoth()


        //Saves the puzzle to text file
        private void ExportButton_Click(object sender, EventArgs e)
            {
                exportDialog.ShowDialog();
            }

            private void label3_Click(object sender, EventArgs e)
            {
                // keep this empty method
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void exportDialog_FileOk(object sender, CancelEventArgs e)
            {

                string name = exportDialog.FileName + ".txt";
                File.WriteAllText(name, _puzzle);
                File.AppendAllText(name, "\n\n\n\n");
                File.AppendAllText(name, _answers);

            }








        }
    }

