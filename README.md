<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>README - C# Loops and Power Calculation</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            background-color: #f9f9f9;
            color: #333;
        }
        h1, h2, h3 {
            color: #2e6da4;
        }
        h1 {
            margin-bottom: 10px;
        }
        img {
            max-width: 100%;
            height: auto;
            border-radius: 8px;
            margin-bottom: 20px;
        }
        code {
            background-color: #eaeaea;
            padding: 2px 4px;
            border-radius: 4px;
            font-family: monospace;
        }
        pre {
            background-color: #f3f3f3;
            padding: 10px;
            border-radius: 4px;
            overflow: auto;
            margin: 20px 0;
        }
        .badge {
            display: inline-block;
            margin-right: 5px;
            padding: 5px 10px;
            border-radius: 4px;
            background-color: #2e6da4;
            color: white;
            text-decoration: none;
            font-size: 0.9em;
        }
        .section {
            margin-bottom: 20px;
            padding: 15px;
            border: 1px solid #ddd;
            border-radius: 8px;
            background-color: #fff;
        }
    </style>
</head>
<body>

    <img src="your-image-url.jpg" alt="Code Example Image">

    <h1>C# Loops and Power Calculation</h1>

    <div class="section">
        <h2>Badges</h2>
        <a class="badge" href="#">C#</a>
        <a class="badge" href="#">Loops</a>
        <a class="badge" href="#">Math</a>
    </div>

    <div class="section">
        <h2>Overview</h2>
        <p>
            This C# program demonstrates various looping constructs (while, do-while, and for loops) 
            and includes examples for basic arithmetic operations, such as calculating powers and summing user inputs. 
            The primary purpose is to illustrate how to use loops effectively in C# and gather user input for calculations.
        </p>
    </div>

    <div class="section">
        <h2>Code Structure</h2>
        <p>The code consists of several methods, each demonstrating a different concept related to loops and user input:</p>

        <h3>1. <code>labExample1()</code></h3>
        <p><strong>Purpose:</strong> Demonstrates a <code>while</code> loop.</p>
        <p><strong>Functionality:</strong> Increments a number from 0 to 5 and prints the current number in each iteration.</p>

        <h3>2. <code>labExample2()</code></h3>
        <p><strong>Purpose:</strong> Demonstrates a <code>do-while</code> loop.</p>
        <p><strong>Functionality:</strong> Increments a number and calculates the cumulative sum, printing the current number and sum until the number exceeds 5.</p>

        <h3>3. <code>labExample3()</code></h3>
        <p><strong>Purpose:</strong> Demonstrates a <code>for</code> loop.</p>
        <p><strong>Functionality:</strong> Iterates from 0 to 9, but increments <code>i</code> twice in each iteration, resulting in output every second number.</p>

        <h3>4. <code>labExcercise1Que()</code></h3>
        <p><strong>Purpose:</strong> Collects five numbers from the user and performs cumulative addition.</p>
        <p><strong>Functionality:</strong> Prompts the user for five numbers and shows how each number contributes to the cumulative sum.</p>

        <h3>5. <code>labExcercise1()</code></h3>
        <p><strong>Purpose:</strong> Similar to <code>labExcercise1Que()</code>, but directly collects five inputs and calculates the sum.</p>
        <p><strong>Functionality:</strong> Prompts the user for five numbers and prints the cumulative sum after each input.</p>

        <h3>6. <code>labExcercise2()</code></h3>
        <p><strong>Purpose:</strong> Demonstrates a dynamic loop based on user input.</p>
        <p><strong>Functionality:</strong> Asks the user how many numbers they want to input and calculates the cumulative sum accordingly.</p>

        <h3>7. <code>labExercise3()</code></h3>
        <p><strong>Purpose:</strong> Similar to <code>labExcercise1()</code>, but specifically designed for five iterations.</p>
        <p><strong>Functionality:</strong> Collects five numbers from the user and calculates their cumulative sum.</p>

        <h3>8. <code>labSessionAssI()</code></h3>
        <p><strong>Purpose:</strong> Combines power calculation and checking for even/odd numbers.</p>
        <p><strong>Functionality:</strong> Prompts the user for a base number and a power number, validating input. 
        Calculates and displays the result of raising the base to the power. Collects ten numbers from the user and determines 
        whether each is even or odd.</p>
    </div>

    <div class="section">
        <h2>Key Concepts</h2>
        <ul>
            <li><strong>Loops:</strong> Demonstrated through <code>while</code>, <code>do-while</code>, and <code>for</code> constructs to manage repeated actions based on conditions.</li>
            <li><strong>User Input:</strong> Uses <code>Console.ReadLine()</code> and <code>Convert.ToInt32()</code> to gather and convert user input into integers.</li>
            <li><strong>Power Calculation:</strong> Utilizes <code>Math.Pow()</code> to compute the result of raising one number to the power of another.</li>
            <li><strong>Even/Odd Check:</strong> Implements a simple conditional check to classify numbers.</li>
        </ul>
    </div>

    <div class="section">
        <h2>Usage</h2>
        <ol>
            <li><strong>Setup:</strong> Open a C# development environment (e.g., Visual Studio, Visual Studio Code).</li>
            <li><strong>Create a New Project:</strong> Set up a new C# console application.</li>
            <li><strong>Copy the Code:</strong> Paste the provided code into the main program file (e.g., <code>Program.cs</code>).</li>
            <li><strong>Run the Application:</strong> Execute the program and follow the prompts to test various functionalities.</li>
        </ol>
    </div>

    <div class="section">
        <h2>Conclusion</h2>
        <p>
            This program serves as an educational tool to understand basic C# loop constructs, user input handling, and simple mathematical operations. 
            It provides a hands-on approach to learning fundamental programming concepts. 
        </p>
        <p>
            Feel free to modify the code to explore additional functionalities or improve the user interface!
        </p>
    </div>

</body>
</html>
