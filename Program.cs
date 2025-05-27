// See https://aka.ms/new-console-template for more information

int number = 1; 
while (number <= 100 ) {
    number++;

    if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    } else
    {
        Console.WriteLine(number);
    }
}