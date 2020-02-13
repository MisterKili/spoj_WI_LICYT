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
            PlotsCounter pc = new PlotsCounter();
            int plotNumber = 9;

            Console.WriteLine("X: " + pc.GetColumnNumber(plotNumber));
            Console.WriteLine("Y: " + pc.GetRowNumber(plotNumber));
            Console.WriteLine("Plot numb: " + pc.GetPlotNumber(pc.GetColumnNumber(plotNumber), pc.GetRowNumber(plotNumber)));
        }
    }
}
