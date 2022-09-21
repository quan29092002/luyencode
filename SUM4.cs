using System;
class HelloWorld {
  static void Main() {
   int t=Convert.ToInt32(Console.ReadLine());
   int t1=t;
   int[] n=new int[t];
   while(t>0){
      n[t-1]=Convert.ToInt32(Console.ReadLine());
       t--;
   }
   while(t1>0){
       Console.WriteLine("{0}", s(n[t1-1]).ToString("0.00000000"));
       t1--;
   }
  }
  static double s(int n){
      double tong=0;
      int x=0;
      for(int i=1; i<=n; i++){
          x=x+i;
          tong=tong + 1.0/x;
      }
      return tong;
  }
}
