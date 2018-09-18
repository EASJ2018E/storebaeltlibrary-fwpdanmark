using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace StorebæltLibrary
{
   public class MC : Køretøj
    {
        public override decimal Pris(bool brobizz)
        {
            if (brobizz)
            {
                return (125m / 100m) * 95m;
            }

            return 125m;
        }

        public override string Køretøjet()
        {
            return "MC";
        }
    }
}
