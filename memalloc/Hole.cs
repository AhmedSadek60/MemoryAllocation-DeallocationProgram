using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memalloc
{
    class Hole
    {
        public int start;
        public int size;
        public bool filled;
        public Process assigned_process;

        public Hole(int size,int start)
        {
            this.size = size;
            this.start = start;
            assigned_process = null;
            filled = false;
        }
       
    }
}
