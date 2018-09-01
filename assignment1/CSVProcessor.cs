using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;

namespace assignment1
{
    class CSVProcessor
    {
        private static CSVProcessor _instance;
        private static string _filename = "WineList.csv";
        //private static string _path = Path.Combine(Environment.CurrentDirectory, @"datafiles\", _filename);
        //private static string _path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), _filename);
        private static string _path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, _filename);

        private string[,] loadedWinelist;
        
        public static CSVProcessor GetInstance()
        {
            if (_instance == null) _instance = new CSVProcessor(_path);
            return _instance;
        }

        private CSVProcessor(string path)
        {
            LoadCSV(_path);
        }

        private string[,] LoadCSV(string path)
        {
            string csvFile = System.IO.File.ReadAllText(path);
            string[] lines = csvFile.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int cols = lines[0].Split(',').Length;
            string[,] values = new string[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] lineRow = lines[r].Split(',');
                for (int c = 0; c < cols; c++)              // the counter also serves as a bad pun
                {
                    values[r, c] = lineRow[c];
                }
            }
            return loadedWinelist;
        }

        //private string[,] LoadCSV(string path)
        //{
        //    // Get the file's text.
        //    string whole_file = System.IO.File.ReadAllText(path);

        //    // Split into lines.
        //    whole_file = whole_file.Replace('\n', '\r');
        //    string[] lines = whole_file.Split(new char[] { '\r' },
        //        StringSplitOptions.RemoveEmptyEntries);

        //    // See how many rows and columns there are.
        //    int num_rows = lines.Length;
        //    int num_cols = lines[0].Split(',').Length;

        //    // Allocate the data array.
        //    string[,] values = new string[num_rows, num_cols];

        //    // Load the array.
        //    for (int r = 0; r < num_rows; r++)
        //    {
        //        string[] line_r = lines[r].Split(',');
        //        for (int c = 0; c < num_cols; c++)
        //        {
        //            values[r, c] = line_r[c];
        //        }
        //    }

        //    // Return the values.
        //    return values;
        //}
    }
}
