using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj_WI_LICYT
{
    class Reader
    {
        public Auction Read()
        {
            int numberOfPlots;
            Int32.TryParse(Console.ReadLine(), out numberOfPlots);
            Auction auction = new Auction(numberOfPlots);

            string line;
            Offer offer;
            string[] splittedLine;
            int price, upperLeft, lowerRight;
            while ((line = Console.ReadLine()) != null && line != "")
            {
                splittedLine = line.Split(' ');
                Int32.TryParse(splittedLine[1], out upperLeft);
                Int32.TryParse(splittedLine[2], out lowerRight);
                Int32.TryParse(splittedLine[3], out price);
                offer = new Offer(splittedLine[0], upperLeft, lowerRight, price);
                auction.Bid(offer);
            }

            return auction;
        }
    }
}
