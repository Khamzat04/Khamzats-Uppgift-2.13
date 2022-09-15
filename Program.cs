using System;
// Khamzat Uppgift 2.13
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Lön för Abdione");
		int Abdione = int.Parse(Console.ReadLine());

		Console.WriteLine("Lön för Abditwo");
		int Abditwo = int.Parse(Console.ReadLine());

		Console.WriteLine("Lön för Abditree");
		int Abditree = int.Parse(Console.ReadLine());

		Console.WriteLine(" Abdione " + Abdione + "kr" + " Abditwo " + Abditwo + "kr" + " Abditree " + Abditree + "kr");

		Console.WriteLine((Abdione + Abditwo + Abditree) / 3);
	}
}
