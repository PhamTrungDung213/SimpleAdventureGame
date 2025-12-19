using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string NameP { get; set; }
        [Obsolete("Use NameP instead")]
        public string NamePlural { get => NameP; set => NameP = value; }

        public Item(int id,string name,string namep)
        {
            ID=id;
            Name=name;
            NameP=namep;
        }
    }
}
