using System;
namespace prac1
{
	public class demo5
	{
		public void Factors(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0)
				{
					Console.WriteLine("factors " + i);

				}
			}
		}
		static void Main(string[] args)
		{
			int n;
			Console.WriteLine("enter the value of n ");
			n = Convert.ToInt32(Console.ReadLine());
			demo5 obj = new demo5();
			obj.Factors(n);

		}

	}

}	


