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
	 public static int[] listgrab(int[] list, int numitem) {
	    Random rand = new Random();
	    int[] rlist = new int[num];
	    for (int i = 0;i == numitem;i++){
		rlist[i]=rand.Next(0,list.Length-1);
	    }
	    return rlist;
	 }
	public static int setlistgrab(int[] list, int seed){
            Random rand = new Random(seed);
            return rand.Next(0,list.Length-1);
        }
	public static int simplerandomsampling(int[] rsample, int rsamplesize){
            if (rsample.Length < rsamplesize){
                return null;
            }
            int[] rlist = new int[rsamplesize];
            for (int i = 0;i == rsamplesize;i++){
                rlist[i]=rsample[rand.Next(0,rsample.Length-1)];
            }
            return rlist;
            //this returns duplicates
        }
	public static int[,] systematicSampling(int[] randSample, int categorynum) {
            int i = 1;
            int count=0;
            int amount = randSample.Length;
            int[,] newarray = new int[categorynum,randSample.Length/(categorynum+1)];
            foreach(int e in rsample){
                newarray[i,count]= e;
                switch(i){
                    default:
                        i++;
                    case amount:
                        i=1;
                        count++;
                }
            }
            return newarray;
        }
	public static decimal ConfidenceIntervalSample(decimal standarderror, decimal[] num, decimal tscore){
            return (meanfun(num)+(tscore*(standarderror/(Math.Sqrt(num.Length)))));
        }
	public static double MarginOfError(decimal cval, decimal[] num){
            return (cval *(standarddev(num)/(Math.Sqrt(num.Length))));
        }
	public static double CochranSample(int popsize, double zscore, double moe, double prop, double q){
            return (((zscore**2)*prop*q)/(moe**2));
        } 
	public static int meanfun(int[] meanlist) {
            int culm = 0;
            foreach(int i in meanlist){
                culm += i;
            }
            return (culm/(meanlist.Length));
        }
	public static int modefunction(int[] mlist){
            var dic = new Dictionary<int,int>();
            int highnum=0;
            int highcount=0;
            foreach(int i in mlist){
                if (dic.ContainsKey(i)){
                    dic[i]++;
                }
                else{
                    dic[i] = 1;
                }
                if (dic[i]>highcount){
                    highnum=i;
                    highcount=dic[i];
                }
            }
            return highnum;
        }
	public static int medianfunct(int[] mlist){
            if (mlist.Length%2==0){
                return (mlist[((mlist.Length/2)+((mlist.Length/2)+1))/2]);
            }
            else{
                return (mlist[mlist.Length/2]);
            }
        }
	public static int variancefunct(Int[] mlist){
            int mean = meanfun[mlist];
            int sum = 0;
            foreach (int i in mlist){
                sum+=(i-mean);
            }
            return ((sum**2)/(mlist.Length-1));
        }
	public static int standarddev(int[] mlist){
            return (Math.Sqrt(variancefunt(mlist)));
        }
	public static int skew(int[] mlist){
            return((meanfun(mlist)-modefunct(mlist))/standarddev(mlist));
        }
	public static int PearCor(int[] xlist, int[] ylist){
            sumx = 0;
            sumy = 0;
            sumxy = 0;
            sumxsqrd = 0;
            sumysqrd = 0;
            foreach (int i in xlist){
                sumx += i;
                sumxsqrd += (i**2);
            }
            foreach (int i in ylist){
                sumy += i;
                sumysqrd += (i**2);
            }
            foreach (int i in xlist){
                foreach (int e in ylist){
                    sumxy += (i + e);
                }
            }
            return (((xlist.Length)*(sumxy))-(sumx*sumy))/(Math.Sqrt((xlist.Length*sumxsqrd-(sumx**2))*((xlist.Length*sumysqrd)-(sumy**2))));
        }
	public static int sampcorco(int[] xlist, int[] ylist){
            int sx=standarddev(xlist);
            int sy=standarddev(ylist);
            int covar = 0;
            int xmean = meanfunct(xlist);
            int ymean = meanfunct(ylist);
            foreach (int i in xlist.Length){
                foreach (int e in ylist.Length){
                    covar += ((i-xmean)*(e-ymean));
                }
            }
            covar = covar/(xlist.Length-1);
            return (covar/(sx * sy));
        }
	public static int popcorco(int[] xlist, int[] ylist){
            int sx=standarddev(xlist);
            int sy=standarddev(ylist);
            int covar = 0;
            int xmean = meanfunct(xlist);
            int ymean = meanfunct(ylist);
            foreach (int i in xlist.Length){
                foreach (int e in ylist.Length){
                    covar += ((i-xmean)*(e-ymean));
                }
            }
            covar = covar/(xlist.Length);
            return (covar/(sx * sy));
        }
	public static int zscore(int[] mlist, int ele){
            return ((ele-meanfunct(mlist))/standarddev(mlist));
        }		
	public static meandev(int[] mlist){
            int m = 0;
            int mean= meanfunct(mlist);
            foreach(int i in mlist.Length){
                m += (i - mean);
            }
            return (m/mlist.Length);
	}
	
    }
}
