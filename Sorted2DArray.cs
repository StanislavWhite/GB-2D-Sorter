using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        
            int[] arrayTemp = new int [a.GetLength(0) * a.GetLength(1)];

            // Разбиваем массив
            int index = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    arrayTemp[index] = a[i, j];
                    index++;
                }
            }

            // Сортируем 
            int temporary;
            for (int i = 0; i < arrayTemp.Length; i++)
            {
                for (int x = i + 1; x < arrayTemp.Length; x++)
                {
                    if (arrayTemp[i] > arrayTemp[x])
                    {
                        temporary = arrayTemp[x];
                        arrayTemp[x] = arrayTemp[i];
                        arrayTemp[i] = temporary;
                    }
                }
            }

            // Заполняем
            index = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = arrayTemp[index];
                    index++;
                }
            }

            // Печатаем
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}   ");
                }
                Console.WriteLine();
            }
        }
    }