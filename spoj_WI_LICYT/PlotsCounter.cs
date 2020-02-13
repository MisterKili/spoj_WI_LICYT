using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj_WI_LICYT
{
    class PlotsCounter
    {

        public static int GetColumnNumber(int plotNumber)
        {
            int columnNumber;
            int numberOfColumns = Auction.numberOfPlotsInRow;

        
            columnNumber = (plotNumber - 1) % numberOfColumns;

            return columnNumber;
        }

        public static int GetRowNumber(int plotNumber)
        {
            int rowNumber;
            int numberOfColumns = Auction.numberOfPlotsInRow;

            rowNumber = (plotNumber - 1) / numberOfColumns;

            return rowNumber;
        }

        public static int GetPlotNumber(int x, int y)
        {
            int rowNumber;
            int numberOfColumns = Auction.numberOfPlotsInRow;

            //third commit

            rowNumber = numberOfColumns * y + x + 1;

            return rowNumber;
        }
    }
}
