using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302220144
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }
}
