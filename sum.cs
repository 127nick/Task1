using System;
namespace CalDemo
{
   class calc
    {
        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("sum of two number is ", a, b, c);

        }
        static void Main(string[]args)
        {
            int a, b;
            Console.WriteLine("enter two number");
            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());
            calc obj = new calc();
            obj.Add(a, b);
        }

    }
}
