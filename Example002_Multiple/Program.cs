// Проверка числа на кратность 7 и 23

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n % 7 == 0 && n % 23 == 0)
{
    Console.WriteLine($"Число {n} кратно 7 и 23");
}
else{
    Console.WriteLine($"Число {n} не кратно 7 и 23");
}