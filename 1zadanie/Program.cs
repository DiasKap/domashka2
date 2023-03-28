Console.Write("Число 3-х значное: ");
int num = int.Parse(Console.ReadLine());
int a = (num % 100) / 10;
Console.WriteLine($"{num} -> {a}");