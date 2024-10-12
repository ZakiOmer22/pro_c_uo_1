```markdown
# Week Three: Loop Examples in C#

This repository contains example codes demonstrating various types of loops in C#. These examples are designed for educational purposes, illustrating how loops work to perform repetitive tasks in C#.

## Table of Contents

1. [Introduction](#introduction)
2. [Examples](#examples)
   - [Example 1: While Loop](#example-1-while-loop)
   - [Example 2: Do-While Loop](#example-2-do-while-loop)
   - [Example 3: For Loop](#example-3-for-loop)
3. [Exercises](#exercises)
   - [Exercise 1: Input and Summation](#exercise-1-input-and-summation)
   - [Exercise 2: Dynamic Loop Input](#exercise-2-dynamic-loop-input)
   - [Exercise 3: Power Calculation & Odd/Even Number Check](#exercise-3-power-calculation-oddeven-number-check)
4. [How to Run](#how-to-run)
5. [Conclusion](#conclusion)

---

## Introduction

This code demonstrates different loop structures (`while`, `do-while`, and `for`) to perform repetitive operations. These loops help automate tasks and manage sequences of operations effectively in C#. The exercises also incorporate user input and basic arithmetic operations.

---

## Examples

### Example 1: While Loop

This example showcases a basic `while` loop that increments a number and prints it until the number reaches 6.

```csharp
void labExample1()
{
    int number = 0;

    while (number <= 5)
    {
        number++;
        Console.WriteLine($"The While loop number is {number}");
    }
}
```

### Example 2: Do-While Loop

In this example, a `do-while` loop increments and sums numbers while checking the condition at the end of each iteration.

```csharp
void labExample2()
{
    int number = 0;
    int sum = 0;

    do
    {
        number++;
        sum += number;
        Console.WriteLine($"The Do-While loop number is {number} with a sum of {sum}");
    }
    while (number <= 5);
}
```

### Example 3: For Loop

This example demonstrates a `for` loop that increments a number and prints the value at every second step.

```csharp
void labExample3()
{
    for (int i = 0; i < 10; i++)
    {
        i++;
        Console.WriteLine($"The For loop number is {i}");
    }
}
```

---

## Exercises

### Exercise 1: Input and Summation

This exercise asks the user to input five numbers, and the program sums them while displaying the numbers and cumulative total.

```csharp
void labExercise1()
{
    int Num;
    int sum = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Enter number {i + 1}:");
        Num = Convert.ToInt32(Console.ReadLine());
        sum += Num;

        Console.WriteLine($"The sum so far is {sum}");
    }
}
```

### Exercise 2: Dynamic Loop Input

This exercise allows the user to specify the number of loop iterations and then sums user inputs during those iterations.

```csharp
void labExercise2()
{
    int Num;
    int sum = 0;

    Console.WriteLine("Enter the number of iterations for the loop:");
    int LoopNum = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= LoopNum; i++)
    {
        Console.WriteLine($"Enter number {i}:");
        Num = Convert.ToInt32(Console.ReadLine());
        sum += Num;

        Console.WriteLine($"The sum so far is {sum}");
    }
}
```

### Exercise 3: Power Calculation & Odd/Even Number Check

In this exercise, the user inputs a base and exponent, calculates the power, and then inputs 10 numbers to check whether each is odd or even.

```csharp
void labSessionAssI()
{
    // Input base number and exponent
    int baseNumber, powerNumber;

    Console.Write("Enter the base number (x): ");
    while (!int.TryParse(Console.ReadLine(), out baseNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }

    Console.Write("Enter the power number (y): ");
    while (!int.TryParse(Console.ReadLine(), out powerNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }

    double result = Math.Pow(baseNumber, powerNumber);
    Console.WriteLine($"\n{baseNumber} raised to the power of {powerNumber} is: {result}");

    // Check for odd or even numbers
    Console.WriteLine("\nPlease enter 10 numbers:");

    for (int i = 0; i < 10; i++)
    {
        int number;

        Console.Write($"Enter number {i + 1}: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        if (number % 2 == 0)
        {
            Console.WriteLine($"Even number: {number}");
        }
        else
        {
            Console.WriteLine($"Odd number: {number}");
        }
    }
}
```

---

## How to Run

1. Open the project in your favorite C# IDE (e.g., Visual Studio).
2. Copy and paste the code into a `.cs` file.
3. Compile and run the program.
4. Follow the on-screen instructions for each example and exercise.

---

## Conclusion

This project provides an introduction to looping structures in C#, demonstrating `while`, `do-while`, and `for` loops in different scenarios. The exercises help reinforce user input handling, summation, and basic arithmetic. You are encouraged to modify and experiment with these examples to deepen your understanding of loops.
```

You can modify the content to suit the specific instructions or details you want to highlight for your project.
