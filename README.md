Here’s the full `README.md` content for easy copy:

```markdown
# Week Three - Loops in C#

![Header Image](https://zamufey.com/wp-content/uploads/2024/10/lbAss3.png)

This repository contains examples and exercises using loops in C#. The examples demonstrate the usage of `while`, `do-while`, and `for` loops, as well as basic arithmetic operations and handling user input in a console application.

**GitHub Repository:** [ZakiOmer22/pro_c_uo_1](https://github.com/ZakiOmer22/pro_c_uo_1/tree/main)

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

This example demonstrates a `while` loop where the loop runs as long as the condition `number <= 5` is true.

---

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

The `do-while` loop runs the code block first and checks the condition afterwards, ensuring the block is executed at least once.

---

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

A simple `for` loop example that increments `i` and displays the iteration count.

---

### Lab Exercise 1: Summing User Input

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

In this exercise, the program asks the user to input numbers, adds them together, and displays the sum after each input.

---

### Lab Exercise 2: Dynamic Loop Length

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

This example allows the user to specify the number of iterations for the loop.

---

### Lab Session Assignment I: Powers and Odd/Even Check

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

This assignment covers raising a base number to a power, and then prompts the user for 10 numbers to check whether each number is odd or even.

---

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/ZakiOmer22/pro_c_uo_1.git
   ```
2. Open the project in your preferred C# IDE (e.g., Visual Studio).
3. Build the project to resolve dependencies.
4. Run the project, and follow the prompts in the console to interact with the different loop examples and exercises.

---

## Conclusion

This project demonstrates basic loop constructs in C#, including `while`, `do-while`, and `for` loops. These examples and exercises are designed to help beginners understand how loops work and how to handle user input for arithmetic operations in a console environment.
```
