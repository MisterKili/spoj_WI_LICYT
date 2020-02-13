using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj_WI_LICYT
{
    class Bid
    {
        int plotNumber;
        string pesel;
        int price;

        public Bid(int plotNumber)
        {
            this.plotNumber = plotNumber;
        }

        public Bid(int plotNumber, string pesel, int price)
        {
            this.plotNumber = plotNumber;
            this.pesel = pesel;
            this.price = price;
        }
    }
}
