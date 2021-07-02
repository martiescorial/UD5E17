using System;

namespace UD5E17
{
    class Program
    {
        static void Main(string[] args)
        {
			
				//Esto es opcional
				const int tam = 10;

				int[] num = new int[tam];

				
				rellenarArray(num);

				mostrarArray(num);
			}

			public static void rellenarArray(int[] lista)
			{
				for (int i = 0; i < lista.Length; i++)
				{
					string texto = "Introduce un número";
					lista[i] = int.Parse(texto);
				}
			}

			public static void mostrarArray(int[] lista)
			{
				for (int i = 0; i < lista.Length; i++)
				{
					Console.WriteLine("El indice " + i + " corresponde al valor " + lista[i]);
				}
			}
		}

	}
