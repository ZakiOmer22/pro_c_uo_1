Here’s a complete `README.md` for your C# code with explanations for all the functions:

```markdown
# Week Three - Loops in C#

This repository contains examples and exercises using loops in C#. These examples demonstrate the `while`, `do-while`, `for` loops, and cover basic arithmetic operations as well as user input handling. The exercises also include examples of working with numbers, summing inputs, and identifying even and odd numbers.

## Table of Contents
- [Code Overview](#code-overview)
  - [Example 1: `while` Loop](#example-1-while-loop)
  - [Example 2: `do-while` Loop](#example-2-do-while-loop)
  - [Example 3: `for` Loop](#example-3-for-loop)
  - [Lab Exercise 1](#lab-exercise-1)
  - [Lab Exercise 2](#lab-exercise-2)
  - [Lab Session Assignment I](#lab-session-assignment-i)
- [How to Run](#how-to-run)
- [Conclusion](#conclusion)

---

## Code Overview

### Example 1: `while` Loop

```csharp
void labExample1()
{
    Console.WriteLine("WEEK THREE | LOOPS | EXAMPLE 1");
    int number = 0;

    while (number <= 5)
    {
        number++;
        Console.WriteLine($"The While loop iteration: {number}");
    }
}
```

This example shows the usage of a `while` loop. The loop will run as long as the condition `number <= 5` is true, and in each iteration, it increments `number` by 1.

### Example 2: `do-while` Loop

```csharp
void labExample2()
{
    Console.WriteLine("WEEK THREE | LOOPS | EXAMPLE 2");
    int number = 0;
    int sum = 0;

    do
    {
        number++;
        sum += number;
        Console.WriteLine($"Iteration: {number}, Current Sum: {sum}");
    } while (number <= 5);
}
```

The `do-while` loop runs the block of code first, then checks the condition `number <= 5`. This guarantees that the code inside the loop is executed at least once.

### Example 3: `for` Loop

```csharp
void labExample3()
{
    Console.WriteLine("WEEK THREE | LOOPS | EXAMPLE 3");

    for (int i = 0; i < 10; i++)
    {
        i++;
        Console.WriteLine($"The For Loop iteration: {i}");
    }
}
```

The `for` loop is used here, where `i` starts at 0 and increments by 2 in each iteration, due to the `i++` inside the loop body and the one in the `for` loop statement itself.

### Lab Exercise 1

```csharp
void labExcercise1()
{
    Console.WriteLine("WEEK THREE | LOOPS | LAB EXERCISE 1");

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
```

In this lab exercise, the program asks the user to input 5 numbers, adds them together, and displays the sum after each input.

### Lab Exercise 2

```csharp
void labExcercise2()
{
    Console.WriteLine("WEEK THREE | LOOPS | LAB EXERCISE 2");

    int Num;
    int sum = 0;

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
```

This example allows the user to define how many iterations the loop should run. The program takes a number from the user for each iteration and sums it up.

### Lab Session Assignment I

```csharp
void labSessionAssI()
{
    // Variables baseNumber, Iyo PowerNum
    int baseNumber, powerNumber;

    // Ask user for base number 
    Console.Write("Enter the base number (x): ");
    while (!int.TryParse(Console.ReadLine(), out baseNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for the base number.");
    }

    // Ask user for power number
    Console.Write("Enter the power number (y): ");
    while (!int.TryParse(Console.ReadLine(), out powerNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer for the power number.");
    }

    // Calculate power of the numbers
    double result = Math.Pow(baseNumber, powerNumber);
    Console.WriteLine($"\n{baseNumber} raised to the power of {powerNumber} is: {result}");

    // Collect 10 numbers to check Odd or Even
    const int numberOfEntries = 10;
    int number;

    Console.WriteLine("\nPlease enter 10 numbers:");

    for (int i = 0; i < numberOfEntries; i++)
    {
        Console.Write($"Enter number {i + 1}: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

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
```

In this session assignment, the user first enters a base number and a power number, and the program calculates the power of the base number raised to the power number. The program then asks for 10 numbers and determines whether each one is odd or even.

---

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/loops-week-three.git
   ```
2. Open the project in your preferred C# IDE (e.g., Visual Studio).
3. Build the project to ensure all dependencies are resolved.
4. Run the program. Follow the prompts in the console to see how the loops function and interact with user inputs.

---

## Conclusion

This project demonstrates the basic use of loops in C#, including `while`, `do-while`, and `for` loops. These are fundamental constructs used in programming to handle repetitive tasks. The lab exercises provide an opportunity to practice taking user input and performing operations on those inputs. 
```

Feel free to modify the GitHub repository URL and adjust the text based on your project specifics!
