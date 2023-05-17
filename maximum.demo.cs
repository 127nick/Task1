namespace prac1
{

    public class maximum
	{
        class demo
		{
			public void Check(int a, int b, int c)
			{
				int m = a;
				if (m < b)
				{
					m = b;
				}
				if (m < c)
				{
					m = c;
				}

				Console.WriteLine("maximum cvalu is ", +m);
			}
			static void Main(string[] args)
			{
				int a, b, c;
				Console.WriteLine("enter three numbers");
				a = Convert.ToInt32(Console.ReadLine());
				b = Convert.ToInt32(Console.ReadLine());
				c = Convert.ToInt32(Console.ReadLine());
				demo obj = new demo();
				obj.Check(a, b, c);

			}
		}
	