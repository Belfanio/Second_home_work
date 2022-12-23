int GetNumberFromConsole(string message)
{
int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result > 0 && result < 8)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введен не день недели");
            }
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
return result;    
}



int day = GetNumberFromConsole("Введите день недели цифрой");
if (day < 6)
{
    Console.WriteLine("Сегодня будний день");
}
else
{
    Console.WriteLine("Сегодня выходной день");
}
