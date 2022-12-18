Console.WriteLine("Введите k1 и b1 через проблел для функции y = k1 * x + b1:");
int[] f1x = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine("Введите k2 и b2 через проблел для функции y = k2 * x + b2:");
int[] f2x = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (f1x[0] == f2x[0] && f1x[0] != f2x[0]) Console.WriteLine("Линии не пересекаются");
else if (f1x[0] == f2x[0] && f1x[0] == f2x[0]) Console.WriteLine("Линии совпадают");
else Console.WriteLine("Коодинаты пересечения функций f1x и f2x: (" + $"{(f1x[1] - f2x[1]) / (f2x[0] - f1x[0])}, "
+ $"{f1x[0] * (f1x[1] - f2x[1]) / (f2x[0] - f1x[0]) + f1x[1]})");
