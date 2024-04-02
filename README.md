Wordfind Generator
==============

// Original code collected from GitHub using "caraconrad Wordfind - Generator"  
// Cara did 100% all of the heavy lifting on this one. Thank You Cara    de AA3M

Just a simple tool to create wordfind puzzles.

- Specify custom grid dimensions
- Save and load word lists and settings
- Export, copy, or print generated puzzles with matching serial numbers

- changed print routine to print only puzzle or answer sheets ShowPuzzle.cs buildPrintString() 
- along with a serial number to match them using makeSerialNumber()
- Corrected an exception error when saving back to the original loaded filename by adding 
- reader.Close(); to the CreateWordFind.cs file (line 131)  3/15/2024  de AA3M
- Added _checklist.Clear(); to CreateWordFind.cs file (line 38 ) to fix checkbox settings list upon saving 