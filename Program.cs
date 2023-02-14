using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4._8
{
	internal class Program
	{
		static void Main(string[] args)
		// Случайная матрица
		//Сначала пользователю предлагается ввести количество строк в будущей матрице.
		//Затем — ввести количество столбцов в будущей матрице.
		//Когда данные будут получены, нужно создать в памяти матрицу заданного размера.
		//Используя Random, заполнить матрицу случайными целыми числами.
		//Вывести полученную матрицу на экран.
		//Вывести сумму всех элементов этой матрицы на экран отдельной строкой.
		{
			Random rand = new Random();
			int sum = 0;
			WriteLine("Введите кол-во строк:");
			int x = int.Parse(ReadLine());
			WriteLine("Введите коль-во столбцов:");
			int y = int.Parse(ReadLine());

			int[,] str = new int[x , y];
			

			for (int i = 0; i < x; i++)
			{
				//sum++;
				for (int j = 0; j < y; j++)
				{
					str[i, j] = rand.Next(10);
					sum += str[i, j];
					Write($"{str[i, j]} ");
				}
				WriteLine();
				
			}
			WriteLine($"\n : {sum}");

		}
	}
}
