using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj_WI_LICYT
{
    class Offer
    {
        string pesel;
        int upperLeft;
        int lowerRight;
        int price;

        public Offer(string pesel, int upperLeft, int lowerRight, int price)
        {
            this.pesel = pesel;
            this.price = price;
            this.upperLeft = upperLeft;
            this.lowerRight = lowerRight;
        }

        public List<Bid> getListOfBids()
        {
            List<Bid> listOfBids = new List<Bid>();
            int numberOfPlotsInRow = Auction.numberOfPlotsInRow;
            int upperLeftCornerX = PlotsCounter.

            for (int i = upperLeft; i < numberOfPlotsInRow; i++)
            {

            }

            return listOfBids;
        }

        override public string ToString()
        {
            return pesel + " " + upperLeft + " " + lowerRight + " " + price;
        }
    }
}
