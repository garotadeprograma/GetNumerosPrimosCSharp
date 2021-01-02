
using System;
using System.Collections.Generic;

namespace NumerosPrimosCSharp
{

	public class Program
	{
		public static void Main()
		{
			string valorInput = Console.ReadLine();
			int nrLinhas = Convert.ToInt16(valorInput);
			int col1 = 0;
			int col2 = 0;

			List<int> nrPrimo = GetNumerosPrimos(nrLinhas);

			for (int i = 0; i < nrLinhas; i++)
			{
				col1 += 1;
				col2 += nrPrimo[i];
				Console.WriteLine(col1 + " " + col2);

			}

			Console.ReadKey();
		}

		public static List<int> GetNumerosPrimos(int nrLinhas)
		{
			var listaPrimos = new List<int>() { 1, 3, 5, 7 };
			int vlr1 = 5;

			if(listaPrimos.Count > nrLinhas)
				listaPrimos.RemoveRange(nrLinhas + 1, listaPrimos.Count);

			while (true)
			{
				vlr1 += 6;

				if (AddListaPrimo(listaPrimos, vlr1))
					listaPrimos.Add(vlr1);

				if (listaPrimos.Count >= nrLinhas)
					break;
			}

			return listaPrimos;
		}

		public static bool AddListaPrimo(List<int> listaPrimos, int numero)
		{

			if (listaPrimos.Contains(numero))
				return false;

			if (numero % 2 == 0)
				return false;

			if (numero % 3 == 0)
				return false;

			if (numero % 5 == 0)
				return false;

			if (numero % 7 == 0)
				return false;

			return true;
		}
	}
}
