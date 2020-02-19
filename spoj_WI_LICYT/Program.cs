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
            //Auction auction = new Auction(5);
            //Bid b1 = new Bid(1, "123", 12);
            //Bid b2 = new Bid(1, "123", 10);

            ReaderWriter rw = new ReaderWriter();
            Auction auction = rw.Read();
            rw.WriteResult(auction);

            //Auction auction = new Auction(4);

            //Buyer b6 = new Buyer("6");
            //Buyer b2 = new Buyer("2");
            //Buyer b3 = new Buyer("3");
            //Buyer b1 = new Buyer("1");
            //List<Buyer> buyers = new List<Buyer>();

            //buyers.Add(b6);
            //buyers.Add(b2);
            //buyers.Add(b3);
            //buyers.Add(b1);

            //auction.SortBuyers(ref buyers);

            //foreach (Buyer b in buyers)
            //{
            //    Console.WriteLine(b.GetPesel());
            //}

            //Offer o = new Offer("12341", 1, 21, 10);
            //auction.Bid(o);

            //Offer o2 = new Offer("12341", 7, 13, 9);
            //auction.Bid(o2);
            //Offer o3 = new Offer("12341", 11, 12, 11);
            //auction.Bid(o3);
            //auction.SetBid(b1);
            //auction.PrintHighestBids();
        }
    }
}
