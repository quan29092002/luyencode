using System;
class HelloWorld {
  static void Main() {
            string s1 = Console.ReadLine();
            var s2 = s1.Split(' ');
            int a = Convert.ToInt32(s2[0]);
            int b = Convert.ToInt32(s2[1]);
           int c = UCLN(a, b);
            a = a / c;
            b = b / c;
			if(b<=0){
                Console.WriteLine("INVALID");
            }
      
            Console.WriteLine("{0} {1}", a, b);
  }
  static int UCLN(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
}
