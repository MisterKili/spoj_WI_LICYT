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

        public List<Bid> GetListOfBids()
        {
            List<Bid> listOfBids = new List<Bid>();
            int numberOfPlotsInRow = Auction.numberOfPlotsInRow;
            int upperLeftColumn = PlotsCounter.GetColumnNumber(upperLeft);
            int upperLeftRow = PlotsCounter.GetRowNumber(upperLeft);
            int lowerRightColumn = PlotsCounter.GetColumnNumber(lowerRight);
            int lowerRightRow = PlotsCounter.GetRowNumber(lowerRight);
            Bid temp;

            for (int i = upperLeftRow; i <= lowerRightRow; i++)
            {
                for (int j = upperLeftColumn; j <= lowerRightColumn; j++)
                {
                    temp = new Bid(PlotsCounter.GetPlotNumber(j, i), pesel, price);
                    listOfBids.Add(temp);
                }
            }
            return listOfBids;
        }

        override public string ToString()
        {
            return pesel + " " + upperLeft + " " + lowerRight + " " + price;
        }
    }
}
