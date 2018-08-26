using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private string _id;
        private string _description;
        private string _pack;

        public WineItem(string Id, string Desc, string Pack)
        {
            _id = Id;
            _description = Desc;
            _pack = Pack;
        }

        public string Id { get; set; }
        public string Desc { get; set; }
        public string Pack { get; set; }

    }
}
