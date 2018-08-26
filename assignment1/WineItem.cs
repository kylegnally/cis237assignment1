using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private String _id;
        private String _description;
        private String _pack;

        public WineItem(String Id, String Desc, String Pack)
        {
            _id = Id;
            _description = Desc;
            _pack = Pack;
        }
    }
}
