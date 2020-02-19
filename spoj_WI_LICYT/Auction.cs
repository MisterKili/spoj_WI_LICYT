using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj_WI_LICYT
{
    class Auction
    {
        public Bid[,] highestBids;
        public static int numberOfPlotsInRow;

        public Auction(int numberOfPlots)
        {
            highestBids = new Bid[numberOfPlots, numberOfPlots];
            numberOfPlotsInRow = numberOfPlots;
        }

        public void SetBid(Bid bid)
        {
            int columnNumber = PlotsCounter.GetColumnNumber(bid.plotNumber);
            int rowNumber = PlotsCounter.GetRowNumber(bid.plotNumber);
            highestBids[columnNumber, rowNumber] = bid;
        }

        public void Bid(Offer offer)
        {
            List<Bid> bids = offer.GetListOfBids();

            foreach (Bid bid in bids)
            {
                if (CheckIfHighestBid(bid))
                {
                    highestBids[PlotsCounter.GetColumnNumber(bid.plotNumber), PlotsCounter.GetRowNumber(bid.plotNumber)] = bid;
                }
            }
        }

        private bool CheckIfHighestBid(Bid bid)
        {
            int columnNumber = PlotsCounter.GetColumnNumber(bid.plotNumber);
            int rowNumber = PlotsCounter.GetRowNumber(bid.plotNumber);
            if (highestBids[PlotsCounter.GetColumnNumber(bid.plotNumber), PlotsCounter.GetRowNumber(bid.plotNumber)] == null 
                || bid.price > highestBids[PlotsCounter.GetColumnNumber(bid.plotNumber), PlotsCounter.GetRowNumber(bid.plotNumber)].price)
            {
                return true;
            }
            return false;
        }

        public List<Buyer> GetBuyers()
        {
            List<Buyer> winners = new List<Buyer>();
            PrintHighestBids();
            foreach (Bid bid in highestBids)
            {
                if (bid != null)
                {
                    if (winners.Count == 0)
                    {
                        Buyer newBuyer = new Buyer(bid.GetPesel());
                        newBuyer.AddFinalBid(bid);
                        winners.Add(newBuyer);
                    }
                    else
                    {

                        string peselFromBid = bid.GetPesel();

                        int i = 0;
                        bool added = false;
                        while (i < winners.Count && !added)
                        {
                            Buyer buyer = winners[i];
                            if (bid.GetPesel().Equals(buyer.GetPesel()))
                            {
                                buyer.AddFinalBid(bid);
                                added = true;
                            }
                            i++;
                        }
                        if (!added)
                        {
                            Buyer newBuyer = new Buyer(bid.GetPesel());
                            newBuyer.AddFinalBid(bid);
                            winners.Add(newBuyer);
                        }
                    }
                }
            }
            SortBuyers(ref winners);
            return winners;
        }

        private void SortBuyersBids(List<Buyer> winners)
        {
            foreach (Buyer buyer in winners)
            {
                buyer.SortBids();
            }
        }

        public void SortBuyers(ref List<Buyer> winners)
        {
            winners = winners.OrderBy(o => o.GetPesel()).ToList();
            //SortBuyersBids(winners);
        }

        public void PrintHighestBids()
        {
            for (int i = 0; i < numberOfPlotsInRow; i++)
            {
                for (int j = 0; j < numberOfPlotsInRow; j++)
                {
                    if (highestBids[j, i] != null)
                    {
                        Bid bid = highestBids[j, i];
                        Console.Write(bid.price +"     ");
                    }
                    else
                    {
                        Console.Write("0     ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
