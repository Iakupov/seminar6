Console.WriteLine("Введите числа через проблел:");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine("Количество положительных чисел:" + $"{array.Count(x => x > 0)}");
