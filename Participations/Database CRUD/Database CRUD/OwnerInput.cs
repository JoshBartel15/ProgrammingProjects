using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_CRUD
{
    public class OwnerInput
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

}
