Console.Write("Впиши день: ");
int a = int.Parse(Console.ReadLine());
if ((a == 6) || (a == 7)) {
    Console.WriteLine("Выходной");
}
else {
    if ((a > 0) && (a < 6)) {
        Console.WriteLine("Нет");
    }
else{
    Console.WriteLine("Всего 7 дней");
    }
}