// Богомолв Даниил 13 вариант базовый
try
{
    Console.WriteLine("Введите число A: ");
    int FirstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int SecondNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число C: ");
    int ThirdNumber = int.Parse(Console.ReadLine());

    if ((FirstNumber < 45 && SecondNumber > 45 && ThirdNumber > 45) ||
        (FirstNumber > 45 && SecondNumber > 45 && ThirdNumber < 45) ||
        (FirstNumber > 45 && SecondNumber < 45 && ThirdNumber > 45))
    {
        Console.WriteLine(true);
    }
    else Console.WriteLine(false);
}

catch
{

}