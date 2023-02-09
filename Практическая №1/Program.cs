float z, o, v;
string num1, num2;
string menu;
int menuUI;
do
{
    Console.WriteLine("1. Сложить два числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти один процент из числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");

    menu = Console.ReadLine();
    menuUI = Convert.ToInt32(menu);

    if (menuUI == 1)
    {
        Console.WriteLine("введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        z = Convert.ToInt32(num1);
        o = Convert.ToInt32(num2);

        Console.WriteLine(z + o);
    }
    if (menuUI == 2)
    {
        Console.WriteLine("введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        z = Convert.ToInt32(num1);
        o = Convert.ToInt32(num2);

        Console.WriteLine(z - o);
    }
    if (menuUI == 3)
    {
        Console.WriteLine("введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        z = Convert.ToInt32(num1);
        o = Convert.ToInt32(num2);

        Console.WriteLine(z * o);
    }
    if (menuUI == 4)
    {
        Console.WriteLine("введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        z = Convert.ToInt32(num1);
        o = Convert.ToInt32(num2);

        Console.WriteLine(z / o);
    }
    if (menuUI == 5)
    {
        Console.WriteLine("введите 2 числа");

        num1 = Console.ReadLine();
        num2 = Console.ReadLine();
        z = Convert.ToInt32(num1);
        o = Convert.ToInt32(num2);

        Console.WriteLine(Math.Pow(z, o));
    }
    if (menuUI == 6)
    {
        Console.WriteLine("введите число");

        num1 = Console.ReadLine();
        z = Convert.ToInt32(num1);

        Console.WriteLine("квадратный корень от числа - " + Math.Sqrt (z));

    }
    if (menuUI == 7)
    {
        Console.WriteLine("введите число");

        num1 = Console.ReadLine();
        z = Convert.ToInt32(num1);

        Console.WriteLine("1% от числа - " + (z / 100));

    }
    if (menuUI == 8)
    {
        Console.WriteLine("введите число");
        num1 = Console.ReadLine();
        z = Convert.ToInt32(num1);
        z = 1;

        for (int i = 1; i < z + 1; i++)
        {
            v = z * o;
        }
        Console.WriteLine(v);
    }
} while (menuUI != 9);




