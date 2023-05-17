using System;
namespace prac1
{
	class demo6
		{
			public  void Check(int n)
		{
			bool flag = false;
			for(int i =2;i<=0;i++)
			{
				if (n%i==0)
				{
					flag = true;
				}

			}
			if (flag = true)
			{
				Console.WriteLine("the number is prime num");
			}
			else
			{
				Console.WriteLine("the num is not prime number");

			}
			
		}

		}
	static void Main(string[] args)
	{
		int n = 5;
		demo6 obj = new demo6();
		obj.Check(n);
	}

	}


}
