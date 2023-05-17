using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

class Data
{
	public void nikhil ()
	{
		Console.WriteLine("hi i am nikhil");

	}
	internal void nikam() 
	{
		Console.WriteLine("hi i am nikam");

	}
	private void nileshwari()

	{
		Console.WriteLine("hi i am nileshwari");
	}
}
class Program 
{
	static void main(string[] args)
	{
       
        Data obj = new Data();
		obj.nikhil();
		obj.nikam();
	}
}
