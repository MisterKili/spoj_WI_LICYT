using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj_WI_LICYT
{
    class Auction
    {
        Bid[,] highestBids;
        public static int numberOfPlotsInRow;

        public Auction(int numberOfPlots)
        {
            highestBids = new Bid[numberOfPlots, numberOfPlots];
            numberOfPlotsInRow = numberOfPlots;
        }

        public void Bid(Offer offer)
        {
            Console.WriteLine(offer.ToString());
        }
    }
}
