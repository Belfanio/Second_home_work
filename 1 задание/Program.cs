//получает число с консоли. "Защита от дурака"
int GetNumberFromConsole(string message)
{
int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result > 99 && result < 1000)
            {
                break;
            }
            else
            {
                Console.WriteLine("Число не трёхзначное");
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
number = number / 10;
number = number % 10;
Console.WriteLine($"Вторая цифра числа = {number}");
