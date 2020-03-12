using System;

namespace IS421GroupProject
{
    class Program
    {
        public static int RandInt(int range1, int range2)
        {
            Random rand = new Random();
            return rand.Next(range1, range2);
        }
        public static decimal RandD(int num1, int num2) {
		    Random rand = new Random();
		    var number = new decimal(rand.Next()*rand.NextDouble(num1, num2));
		    return number;
	    }
        
        
        
        
    }
}
