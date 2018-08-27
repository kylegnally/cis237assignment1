using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        public WineItem() { }

        public WineItem(string Id, string Desc, string Pack)
        {
            this.Id = Id;
            this.Desc = Desc;
            this.Pack = Pack;
        }

        public override string ToString()
        {
            ItemAsString = Id + ", " + Desc + ", " + Pack;
            return ItemAsString;
        }

        //public string Id { get; set; }
        //public string Desc { get; set; }

        public string Id { get; set; }
        public string Desc { get; set; }
        public string Pack { get; set; }
        public string ItemAsString { get; set; }

    }
}
