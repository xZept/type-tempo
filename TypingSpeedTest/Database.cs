using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TypingSpeedTest
{
    internal class Database
    {
        public static void getWords()
        {
            // Read word.txt on the same directory and read it line by line
            string filePath = "words.txt"; // Relative filepath
            string[] lines = File.ReadAllLines(filePath);

            List<string> words = new List<string>();
            foreach (string line in lines)
            {
                // Split the strings into words using whitespaces as delimiter
                string[] lineWords = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                // Add them to the list
                words.AddRange(lineWords);
            }

            // Display each word to the text box in the MainWindow class
            foreach (string word in words)
            {
                // TODO
            }
        }
    }
}
