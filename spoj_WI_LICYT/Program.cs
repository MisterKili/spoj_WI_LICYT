using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj_WI_LICYT
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReaderWriter reader = new ReaderWriter();
            //reader.Read();
            Auction auction = new Auction(5);
            Bid b1 = new Bid(1, "123", 12);
            Bid b2 = new Bid(1, "123", 10);

            

            Offer o = new Offer("12341", 1, 21, 10);
            auction.Bid(o);

            Offer o2 = new Offer("12341", 7, 13, 9);
            auction.Bid(o2);
            Offer o3 = new Offer("12341", 11, 12, 11);
            auction.Bid(o3);
            auction.SetBid(b1);
            auction.PrintHighestBids();
        }
    }
}
