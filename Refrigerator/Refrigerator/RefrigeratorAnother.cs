using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class RefrigeratorAnother
    {
        public double MaxWeight { get; set; }
        public int NumberOfItems { get; set; }
        public double WeightPerItem { get; set; }


        public double GetCurrentWeight()
        {
            try
            {
                double currentWeight = this.NumberOfItems * this.WeightPerItem;

                return currentWeight;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }
        public double GetRemainingtWeight()
        {
            try
            {
                double remainingWeight = this.MaxWeight - GetCurrentWeight();

                return remainingWeight;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }
    }
}
