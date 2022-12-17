using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Wordfind_Generator
{
    class WordFindGeneration
    {
        private List<bool> _checklist;
        private BindingList<string> _originalWordList;
        private List<string> _newWordList;

        private int _height, _width;
        private char[,] _answersArray;
        private char[,] _puzzleArray;

        private bool _generationFailed { get; set; } = false;

        private Random random;

        //Constructor
        public WordFindGeneration(List<bool> checklist, BindingList<string> words, int height, int width)
        {
            _checklist = checklist;
            _originalWordList = words;
            _newWordList = new List<string>();

            _height = height;
            _width = width;

            _answersArray = new char[_height, _width];
            _puzzleArray = new char[_height, _width];

            _generationFailed = false;

            //Initialize _answersArray and _puzzleArray
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    _answersArray[i, j] = '*';
                    _puzzleArray[i, j] = '*';
                }            

            random = new Random();
        }

        public bool GenerationFailed()
        {
            return _generationFailed;
        }
        
        //New list needs to be sorted
        public void GenerateNewList()
        {
            SortNewList();
            CapitalizeNewList();
        }


        //Populates the grid with the wordlist
        public void PopulateGrid()
        {            
            foreach (string word in _newWordList)
            {
                if (!GenerationFailed()) //If it's discovered we can't generate the puzzle we halt puzzle generation
                {
                    int directionSelection = random.Next(0, 8);

                    //Randomly selects a checkbox selection marked as true
                    while (_checklist[directionSelection] != true)
                    {
                        directionSelection = random.Next(0, 8);
                    }

                    EnterWordIntoGrid(word, directionSelection);
                }
                else
                {
                    break;
                }
            }
            
        }


        //Reverses a string
        public string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }


        //Returns the answer grid as a single string
        public string GetAnswersGrid()
        {
            string answerGrid = "";

            for (int i = 0; i < _height; i++)
                for (int j = 0; j < _width; j++)
                    if (j != _width - 1)
                        answerGrid = answerGrid + _answersArray[i, j] + " ";
                    else
                        answerGrid = answerGrid + _answersArray[i, j] + "\r\n";

                    return answerGrid;
        }


        //Returns the puzzle grid as a single string
        public string GetPuzzleGrid()
        {
            string puzzleGrid = "";

            for (int i = 0; i < _height; i++)
                for (int j = 0; j < _width; j++)
                    if (j != _width - 1)
                        puzzleGrid = puzzleGrid + _puzzleArray[i, j] + " ";
                    else
                        puzzleGrid = puzzleGrid + _puzzleArray[i, j] + "\r\n";

            return puzzleGrid;
        }


        //Copies the answer grid into the puzzle grid
        public void InitializePuzzleGrid()
        {
            for (int i = 0; i < _height; i++)
                for (int j = 0; j < _width; j++)
                    _puzzleArray[i, j] = _answersArray[i, j];
        }


        //Replaces the '*' placeholder with a random letter
        public void BuildPuzzle()
        {
            for (int i = 0; i < _height; i++)
                for (int j = 0; j < _width; j++)
                    if (_puzzleArray[i, j] == '*')
                        _puzzleArray[i, j] = GenerateRandomUpperChar();
        }


        //Generates a random uppercase letter (ASCII) to be placed in the grid
        private char GenerateRandomUpperChar()
        {
            return (char)random.Next(65, 91); //65 = A in ASCII, 90 = Z. 91 is not included in random.Next()
        }


        //New list needs to be sorted by descending length
        private void SortNewList()
        {
            var sortedByDescendingLength = from element in _originalWordList
                          orderby element.Length descending
                          select element;

            foreach (string value in sortedByDescendingLength)
                _newWordList.Add(value);
        }


        //New list needs to be capitalized
        private void CapitalizeNewList()
        {
            _newWordList = _newWordList.ConvertAll(d => d.ToUpper());
        }


        //Makes new random row index between 0 and height of the grid
        private int GenerateRowIndexNoBounds()
        {
            return random.Next(0, _height);
        }

        //Makes a random row index so word can't run off the bottom
        private int GenerateRowIndexLowerBounds(string word)
        {
            return random.Next(0, _height - word.Length - 1);
        }

        //Makes new random column index between 0 and width of the grid
        private int GenerateColumnIndexNoBounds()
        {
            return random.Next(0, _width);
        }


        //Makes a new random column index so word can't run off the right
        private int GenerateColumnIndexRightBounds(string word)
        {
            return random.Next(0, _width - word.Length - 1);
        }


        //Write a word in the array horizontally
        private void DrawHorizontal(string word, int tries)
        {
            //Pick a random row to start
            int i = GenerateRowIndexNoBounds();

            //Pick random column index so word can't run off the right
            int j = GenerateColumnIndexRightBounds(word);

            if (CheckHorizontal(word, i, j) == true)
            {          
                foreach (char c in word)
                {
                    _answersArray[i, j] = c;
                    j++;
                }
            }
            else if (tries < 500)
            {
                tries++;
                DrawHorizontal(word, tries);
            }
            else
            {
                _generationFailed = true; //The puzzle cannot be successfully created due to the list being too long for the size of the puzzle grid
            }
        }


        //Checks if we can write horizontally, starting at row i column j
        private bool CheckHorizontal(string word, int i, int j)
        {
            foreach (char c in word)
            {
                //Allows words to cross
                if ((_answersArray[i, j] != '*') && (_answersArray[i,j] != c))
                    return false;
                else
                    j++;
            }          
            return true;
        }


        //Write a word in the array vertically
        private void DrawVertical(string word, int tries)
        {
            //Pick a random row index so word can't run off the bottom
            int i = GenerateRowIndexLowerBounds(word);

            //Pick random column to start
            int j = GenerateColumnIndexNoBounds();

            if (CheckVertical(word, i, j) == true)
            {         
                foreach (char c in word)
                {
                    _answersArray[i, j] = c;
                    i++;
                }
            }
            else if (tries < 500)
            {
                tries++;
                DrawVertical(word, tries);
            }
            else
            {
                _generationFailed = true; //The puzzle cannot be successfully created due to the list being too long for the size of the puzzle grid
            }
        }


        //Checks if we can write vertically, starting at row i column j
        private bool CheckVertical(string word, int i, int j)
        {
            foreach (char c in word)
            {
                //Allows words to cross
                if ((_answersArray[i, j] != '*') && (_answersArray[i, j] != c))
                    return false;
                else
                    i++;
            }          
            return true;
        }


        //Write a word in the array diagonally downards to the right
        private void DrawDiagonalDownRight(string word, int tries)
        {
            //Pick a random row index so word doesnt run off the bottom
            int i = GenerateRowIndexLowerBounds(word);

            //Pick a random column index so word doesnt run off the right
            int j = GenerateColumnIndexRightBounds(word);

            if (CheckDiagonalDownRight(word, i, j) == true)
            {                      
                foreach (char c in word)
                {
                    _answersArray[i, j] = c;
                    i++;
                    j++;
                }
            }
            else if (tries < 500)
            {
                tries++;
                DrawDiagonalDownRight(word, tries);
            }
            else
            {
                _generationFailed = true; //The puzzle cannot be successfully created due to the list being too long for the size of the puzzle grid
            }
        }


        //Checks if we can write diagonally downwards to the right, starting at row i column j
        private bool CheckDiagonalDownRight(string word, int i, int j)
        {
            foreach (char c in word)
            {
                if ((_answersArray[i, j] != '*') && (_answersArray[i, j] != c))
                    return false;
                else
                {
                    i++;
                    j++;
                }
            }         
            return true;
        }


        //Write a word in the array diagonally upwards to the right
        private void DrawDiagonalUpRight(string word, int tries)
        {
            //Pick a random row index so word doesn't run off the top
            int i = random.Next(word.Length - 1, _height);

            //Pick a random column index so word doesn't run off the right
            int j = random.Next(0, _width - word.Length - 1);

            if (CheckDiagonalUpRight(word, i, j) == true)
            {        
                foreach (char c in word)
                {
                    _answersArray[i, j] = c;
                    i--;
                    j++;
                }
            }
            else if (tries < 500)
            {
                tries++;
                DrawDiagonalUpRight(word, tries);
            }
            else
            {
                _generationFailed = true; //The puzzle cannot be successfully created due to the list being too long for the size of the puzzle grid
            }
        }


        //Checks if we can diagonally downwards to the right, starting at row i column j
        private bool CheckDiagonalUpRight(string word, int i, int j)
        {
            foreach (char c in word)
            {
                if ((_answersArray[i, j] != '*') && (_answersArray[i, j] != c))
                    return false;
                else
                {
                    i--;
                    j++;
                }
            }        
            return true;
        }


        //Enters a word into the grid based on the direction input
        private void EnterWordIntoGrid(string item, int directionSelection)
        {
            if (directionSelection == 0)
            {
                DrawHorizontal(item, 0);
            }
            else if (directionSelection == 1)
            {
                DrawHorizontal(Reverse(item), 0);
            }
            else if (directionSelection == 2)
            {
                DrawVertical(item, 0);
            }
            else if (directionSelection == 3)
            {
                DrawVertical(Reverse(item), 0);
            }
            else if (directionSelection == 4)
            {
                DrawDiagonalDownRight(item, 0);
            }
            else if (directionSelection == 5)
            {
                DrawDiagonalUpRight(item, 0);
            }
            else if (directionSelection == 6)
            {
                DrawDiagonalUpRight(Reverse(item), 0);
            }
            else if (directionSelection == 7)
            {
                DrawDiagonalDownRight(Reverse(item), 0);
            }
        }
    }
}
