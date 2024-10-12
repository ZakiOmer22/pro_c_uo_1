using System;

void labExample1()
{
    Console.WriteLine("WEEK THREE | LOOPS | EXAMPLE 1");
    int number = 0;

    while (number <= 5)
    {
        number++;
        Console.WriteLine($"The While loop are {number}");
    }
}
labExample1();

void labExample2()
{
    Console.WriteLine("");
    Console.WriteLine("WEEK THREE | LOOPS | EXAMPLE 2");
    int number = 0;
    int sum = 0;

    do
    {
        number++;
        sum += number;
        Console.WriteLine($"The Do While Loop are {number} with a sum of {sum}");
    }

    while (number <= 5);
    {
        number++;
    }
}
labExample2();


void labExample3()
{
    Console.WriteLine("");
    Console.WriteLine("WEEK THREE | LOOPS | EXAMPLE 3");

    for (int i = 0; i < 10; i++)
    {
        i++;
        Console.WriteLine($"The For Loop are {i}");
    }
}

labExample3();

void labExcercise1Que()
{
    Console.WriteLine("");
    Console.WriteLine("WEEK THREE | LOOPS | EXAMPLE 3");

    int sum = 0;

    Console.WriteLine("Enter The Number One");
    int Num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter The Number Two");
    int Num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter The Number Three");
    int Num3 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter The Number Four");
    int Num4 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter The Number Five");
    int Num5 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < 5; i++)
    {
        Num1 += Num2;
        Console.WriteLine($"The Number {Num1} with The Sum is {sum}");

        Num2 += Num3;
        Console.WriteLine($"The Number {Num2} with The Sum  is {sum}");

        Num3 += Num4;
        Console.WriteLine($"The Number {Num3} with The Sum of is {sum}");

        Num4 += Num5;
        Console.WriteLine($"The Number {Num3} with The Sum of is {sum}");

        i++;
    }
}

void labExcercise1()
{
    Console.WriteLine("");
    Console.WriteLine("WEEK THREE | LOOPS | EXAMPLE 3");

    int Num;
    int sum = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Enter The Number {i}:");
        Num = Convert.ToInt32(Console.ReadLine());
        sum += Num;

        Console.WriteLine($"The Sum of The Number: {Num} is {sum}");
        i++;
    }
}

//labExcercise1();

//DYNAMIC LOOP STATMENT
void labExcercise2()
{
    Console.WriteLine("");
    Console.WriteLine("WEEK THREE | LOOPS | EXAMPLE 4");

    int Num;
    int sum = 0;

    Console.WriteLine("");
    Console.WriteLine("ENTER HOW LONG YOU WANT TO LOAD THE LOOP");
    int LoopNum = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= LoopNum; i++)
    {
        Console.WriteLine($"Enter The Number {i}:");
        Num = Convert.ToInt32(Console.ReadLine());
        sum += Num;

        Console.WriteLine($"The Sum of The Number: {Num} is {sum}");
        i++;
    }
}

//labExcercise2();


void lapExercise3()
{
    Console.WriteLine("");
    Console.WriteLine("WEEK THREE | LOOPS | EXERCISE 4");

    int Num;
    int sum = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Enter The Number {i}:");
        Num = Convert.ToInt32(Console.ReadLine());
        sum += Num;

        Console.WriteLine($"The Sum of The Number: {Num} is {sum}");
        i++;
    }
}

//lapExercise3();


void labSessionAssI()
{
    // Variables baseNumber, Iyo PowerNum
    int baseNumber, powerNumber;

    // Weydii qofka BaseNum 
    Console.Write("Enter the base number (x): ");
    while (!int.TryParse(Console.ReadLine(), out baseNumber))
    {
        //out waxay inoo qabanaysaa in uu method soo celiyo multiple values iyadoo as parameters ama argument ahaan ku pass garaynaysa
        Console.WriteLine("Invalid input. Please enter a valid integer for the base number.");
    }

    // Weydii qofka PowerNum
    Console.Write("Enter the power number (y): ");
    while (!int.TryParse(Console.ReadLine(), out powerNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for the power number.");
    }

    // Waxa aad Xiisabisaa Powerka Tirooyinka
    double result = Math.Pow(baseNumber, powerNumber);
    Console.WriteLine($"\n{baseNumber} raised to the power of {powerNumber} is: {result}");


    // Soo Ururi 10 Number si loo eego Odd iyo Even
    const int numberOfEntries = 10; // Inta uu Qofku Soo input sameyn karo
    int number; // Variableka inoo haya inta iyo waxa uu qofku soo galiyay

    Console.WriteLine("\nPlease enter 10 numbers:");

    for (int i = 0; i < numberOfEntries; i++)
    {
        Console.Write($"Enter number {i + 1}: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            Console.Write($"Enter number {i + 1}: ");
        }

        // Tijaabi in ay tiradu tahay Even ama Odd
        if (number % 2 == 0)
        {
            Console.WriteLine($"Even Number: {number}");
        }
        else
        {
            Console.WriteLine($"Odd Number: {number}");
        }
    }
}

labSessionAssI();