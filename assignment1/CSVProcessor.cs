using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        private static CSVProcessor _instance;
        private static string _filename = "WineList.csv";
        private string _path = Path.Combine(Environment.CurrentDirectory, @"datafiles\", _filename);

        public static CSVProcessor GetInstance()
        {
            if (_instance == null) _instance = new CSVProcessor();
            return _instance;
        }
    }
}
