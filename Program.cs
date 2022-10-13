// Богомолв Даниил 13 вариант базовый
try
{
    Console.WriteLine("Введите число A: ");
    int FirstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int SecondNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число C: ");
    int ThirdNumber = int.Parse(Console.ReadLine());

    if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
        Console.WriteLine("Самое большое число " + FirstNumber);
    else if ((FirstNumber < SecondNumber && SecondNumber > ThirdNumber))
        Console.WriteLine("Самое большое число " + SecondNumber);
    else if (ThirdNumber > SecondNumber && FirstNumber < ThirdNumber)
        Console.WriteLine("Самое большое число " + ThirdNumber);
}

catch
{

}
