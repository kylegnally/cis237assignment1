using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        private WineItem[] _wineCellar;
        
        public WineItemCollection()
        {

        }

        public void Add(string id, string desc, string pack)
        {
            WineItem wineCase = new WineItem(id, desc, pack);            
        }
    }
}
