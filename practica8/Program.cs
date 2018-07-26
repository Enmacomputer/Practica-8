using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
	class Program
	{
		static void Main(string[] args)
		{
			int edad;
			Console.WriteLine("Introducir Edad:");
			edad = int.Parse(Console.ReadLine());

			if (edad <= 10)
			{
				Console.WriteLine("Eres un niño");
			}
			else{
				if (edad <= 17)
				{
					Console.WriteLine("Eres un Adolecente");
				}
				else
				{
					if (edad <= 29)
					{
						Console.WriteLine("Eres un Joven");
					}
					else
					{

						if (edad <= 65)
						{
							Console.WriteLine("Eres un adulto");
						}
					}
				}
			}
			Console.ReadKey();
		}
	}
}
