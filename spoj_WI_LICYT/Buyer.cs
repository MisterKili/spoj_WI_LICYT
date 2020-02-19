using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj_WI_LICYT
{
    class Buyer
    {
        string pesel;
        List<Bid> bids = new List<Bid>();
        int totalCost = 0;

        public Buyer(string pesel)
        {
            this.pesel = pesel;
        }

        public string GetPesel()
        {
            return pesel;
        }

        public void AddFinalBid(Bid bid)
        {
            bids.Add(bid);
            totalCost += bid.price;
        }

        public void SortBids()
        {
            bids.OrderBy(o => o.plotNumber).ToList();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(pesel);
            sb.Append(" ");
            foreach (Bid bid in bids)
            {
                sb.Append(bid.plotNumber);
                sb.Append(" ");
            }
            sb.Append(totalCost);

            return sb.ToString();
        }
    }
}
