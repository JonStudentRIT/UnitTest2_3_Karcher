using System;
using System.Collections.Generic;

namespace UnitTest2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a Tuple to store x, y, w
            Tuple<double, double, double> xyw;
            // create a SortedList to store xyw and z
            SortedList<Tuple<double, double, double>, double> calculation = new SortedList<Tuple<double, double, double>, double>();
            // create a variable for z
            double z = 0;
            // create a variable for the x index
            int xIndex = 0;
            // create a variable for the y index
            int yIndex = 0;
            // create a variable for the w index
            int wIndex = 0;
            // start at 0 and incrament by .1 to 4
            for (double x = 0; x <= 4; x += .1, xIndex++)
            {
                // reset the y index to 0
                yIndex = 0;
                // start at -1 and incrament by .1 to 1
                for (double y = -1; y <= 1; y += .1, yIndex++)
                {
                    // reset the w index to 0
                    wIndex = 0;
                    // start at -2 and incrament by .2 to 0
                    for (double w = -2; w <= 0; w += .2, wIndex++)
                    {
                        // calculate z
                        z = 4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * w + 7;
                        // create a Tuple for x, y, and w rounded to 1 place
                        xyw = new Tuple<double, double, double>(Math.Round(x, 1), Math.Round(y, 1), Math.Round(w, 1));
                        // add xyw and z to the sorted list
                        calculation.Add(xyw, Math.Round(z, 3));
                    }
                }
            }
        }
    }
}
