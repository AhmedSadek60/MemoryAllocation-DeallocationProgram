using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memalloc
{
    class Process
    {
        public int size;
        public string name;
        public Hole my_hole;

        public Process(int size,string name)
        {
            this.size = size;
            this.name = name;
            my_hole = null;
        }
    }
}
