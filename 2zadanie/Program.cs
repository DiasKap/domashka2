Console.Write("3-х значное число: ");
int a = int.Parse(Console.ReadLine());
 if (a < 100) {
    Console.Write("Нету последнего");
 }
 else
 { while (a >= 1000)
   {
   a /= 10;
   }
   Console.Write($"{a % 10}");
 }