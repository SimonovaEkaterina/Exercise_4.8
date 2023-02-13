using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._8_2
{
	internal class Program_2
	{
		static void Main(string[] args)
		//Сложение матриц
		{
			Random r = new Random();

			WriteLine("Матрица A и В:");
			WriteLine("Введите кол-во строк:");
			int x1 = int.Parse(ReadLine());
			WriteLine("Введите коль-во столбцов:");
			int y1 = int.Parse(ReadLine());
			
			int[,] matrixA = new int[x1,y1];
			int[,] matrixB = new int[x1,y1];

			WriteLine("Матрица А:");

			for (int i = 0; i < x1; i++)
			{
				for (int j = 0; j < y1; j++)
				{
					matrixA[i, j] = r.Next(10);
					Write($"{matrixA[i, j]} ");

				}
				WriteLine();
			}
			WriteLine("Матрица В:");

			for (int k = 0; k < x1; k++)
			{
				for (int l = 0; l < y1; l++)
				{
					matrixB[k, l] = r.Next(10);
					Write($"{matrixB[k,l]} ");

				}
				WriteLine();
			}
			WriteLine("Сумма матриц А и В:");

			int[,] sumAB = new int[x1,y1];

			for (int q = 0; q < x1; q++)
			{
				for (int w = 0; w <  y1	; w++)
				{
					sumAB[q,w] = matrixA[q,w] + matrixB[q,w];
					Write($"{sumAB[q,w]} ");
				}
				WriteLine();
			}
		}
	}
}
