using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        private static WineItem[] _wineCellar;
        private int _numRows;
        private int _counter;
        private int _id;
        private string _itemAsString; 
        
        public WineItemCollection()
        {

        }

        public WineItemCollection(string[] cellar)
        {
            _counter = 0;
            _numRows = cellar.Length;
            _wineCellar = new WineItem[_numRows];
            foreach (string item in cellar)
            {
                string[] anItem = item.Split(',');
                Add(anItem[0], anItem[1], anItem[2]);
            }
        }

        public void Add(string id, string desc, string pack)
        {
            WineItem wineCase = new WineItem(id, desc, pack);
            _wineCellar[_counter] = wineCase;
            _counter++;
        }

        public string Search(string wineId)
        {
            for (int i = 0; i < _wineCellar.Length; i++)
            {
                if (_wineCellar[i].Id == wineId)
                {
                    _itemAsString = "Item found: " +
                        _wineCellar[i].Id.ToString() + ", " +
                        _wineCellar[i].Desc.ToString() + ", " +
                        _wineCellar[i].Pack.ToString();
                }
                //else _itemAsString = "Item not found.";
            }
            if (_itemAsString == null) _itemAsString = "Item not found.";
            return _itemAsString;
        }

        public string OneWine
        {
            get { return _itemAsString; }
        }

        public void GetPrintString()
        {            
            for (int i = 0; i < _wineCellar.Length; i++)
            {
                Console.WriteLine(_wineCellar[i].Id.ToString() + ", " +
                        _wineCellar[i].Desc.ToString() + ", " +
                        _wineCellar[i].Pack.ToString());
            }
        }
    }
}
