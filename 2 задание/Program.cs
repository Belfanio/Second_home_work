int GetNumberFromConsole(string message)
{
int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result > 99)
            {
                break;
            }
            else
            {
                Console.WriteLine("В веденном числе нет третьей цифры");
            }
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
return result;    
}



int number = GetNumberFromConsole("введите трёхзначное число");
while (number > 999)
{
    number = number / 10;
}
number = number % 10;
Console.WriteLine($"Третья цифра числа = {number}");