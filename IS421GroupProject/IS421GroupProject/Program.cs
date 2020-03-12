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
        public static int RandIntRange(int range1, int range2)
        {
            Random rand = new Random(25);
            return rand.Next(range1, range2);
        }
        public static decimal RandDRange(int num1, int num2) {
            Random rand = new Random(25);
            var number = new decimal(rand.Next(num1, num2) * rand.NextDouble());
            return number;
        }    
        public static int[] RandListInt(int x)
        {
            Random rand = new Random(25);
            int[] result = new int[x];
            for (int ctr = 0; ctr <= x; ctr++)
            {
                result[ctr] = rand.Next();
            }
            return result;
        }
	public static decimal[] RandListD(int x) {
            Random rand = new Random(25);
            decimal[] result = new decimal[x];
            
	    for (int i = 0; i <= x; i++) {
                result[i] = (decimal)(rand.NextDouble() * rand.Next());
            }
            return result;
        }
	public static int listgrab(int[] list) {
	    Random rand = new Random();
	    return rand.Next(0,list.Length-1);
	}  
	public static int listGrabSeed(int[] list, int num, int seed) {
            Random rand = new Random(seed);
            int[] rlist = new int[num];
            for (int i = 0; i == num; i++){
                rlist[i]=rand.Next(0,list.Length-1);
            }
            return rlist;
        }
	 public static int listgrab(int[] list, int numitem) {
	    Random rand = new Random();
	    for (int i = 0;i == numitem;i++){
		rand.Next(0,list.Length-1);
	    }
	public static int setlistgrab(int[] list, int seed){
            Random rand = new Random(seed);
            return rand.Next(0,list.Length-1);
        }
	    
    }
}
