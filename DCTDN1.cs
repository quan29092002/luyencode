using System;
class HelloWorld {
  static void Main() {
   int n=Convert.ToInt32(Console.ReadLine());
    var s=Console.ReadLine();
    var s1=s.Split(' ');
    int[] a=new int[n+1];
    int[] length=new int[n+1];
    for(int i=1; i<n; i++)
        a[i]=Convert.ToInt32(s1[i].ToString());

    for(int k=1; k<=n; k++)
    {
        length[k]=1;
        for(int i=0;i<k;i++){
            if(a[i]<a[k]) length[k]=Math.Max(length[k], length[i]+1);
        }
    }
    int max=0;
    for(int k=1; k<n; k++)
        max=Math.Max(length[k], max);
        Console.WriteLine(max);
  }
}
