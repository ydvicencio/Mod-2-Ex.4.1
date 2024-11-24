using System;

class Program {
  static bool isPerfect(int n)
  {
    // declare variable sum of type int and initiate to 0
    int sum = 0;

    // find divisors of n and add
    for (int i = 1; i <= n / 2; i++)
    {
      if (n % i == 0)
      {
        sum += i;
      }
    }

    return sum == n;
  }

  static void Main ()
  {
    // ask to enter number
    Console.Write("Enter a number between 1 and 10000: ");
    int inputNumber;

    while (true)
    {
      // check if input is valid
      if (int.TryParse(Console.ReadLine(), out inputNumber))
      {
        if (inputNumber >= 1 && inputNumber <= 10000)
        {
          break; // valid input, exit the loop
        }
        else
        {
          Console.WriteLine("Invalid input. Please enter a number between 1 and 10000.");
        }
      }
      else
      {
        Console.WriteLine("Invalid input. Please enter a valid number.");
      }
    }

    // check if the number entered is perfect
    if (isPerfect(inputNumber))
    {
      Console.WriteLine($"\n{inputNumber} is a perfect number.");
    }
    else
    {
      Console.WriteLine($"\n{inputNumber} is not a perfect number.");
    }
  }
}
