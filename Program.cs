// See https://aka.ms/new-console-template for more information

int number = 0;
while (number <= 100) {
    number++;

    if (number % 11 == 0)
    {
        Console.WriteLine("Bong");
    }
    else if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (number % 7 == 0 && (number % 3 == 0 || number % 5 == 0))
    {
        Console.WriteLine("FizzBang");
    }
    else if (number % 13 == 0) {
        Console.WriteLine("Fezz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (number % 7 == 0)
    {
        Console.WriteLine("Bang");
    }
    else
    {
        Console.WriteLine(number);
    }
}