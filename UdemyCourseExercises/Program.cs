//These exercises are part of a course I'm taking on Udemy (Mosh Hamedani's Basic and Intermediate).
//Obviously these are not real world applications, so I did not always validate input or handle exceptions unless specified.
//You can uncomment the code to run any exercise(ctrl+K+C).



//--------------------------------------------------------------------------------------------------
//#1 Control Flow
//      Write a program and ask the user to enter a number. The number should be between 1 to 10.
//      If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
//      (This logic is used a lot in applications where values entered into input boxes need to be
//      validated.)

//Console.WriteLine("Enter a number between 1 and 10: ");
//var input = Int32.Parse(Console.ReadLine());

//if (input <= 10 && input >= 1)
//{
//    Console.WriteLine("Valid");
//}
//else { Console.WriteLine("Invalid"); }
//--------------------------------------------------------------------------------------------------
//#2 Control Flow



//      Write a program which takes two numbers from the console and displays the maximum of the two.

//Console.WriteLine("Enter a number: ");
//var input1 = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter another number: ");
//var input2 = Int32.Parse(Console.ReadLine());
//Console.WriteLine($"{Math.Max(input1,input2)}");
//--------------------------------------------------------------------------------------------------
//#3 Control Flow




//      Write a program and ask the user to enter the width and height of an image. Then tell if the
//      image is landscape or portrait.

//Console.WriteLine("Enter the width of the image: ");
//var imageWidth = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter the height of the image: ");
//var imageHeight = Int32.Parse(Console.ReadLine());

//if (imageWidth > imageHeight)
//{
//    Console.WriteLine("Landscape");
//}
//else if (imageHeight > imageWidth)
//{
//    Console.WriteLine("Portrait");
//}
//--------------------------------------------------------------------------------------------------
//#4 Control Flow




//      Your job is to write a program for a speed camera. For simplicity, ignore the details such as
//      camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter
//      the speed limit. Once set, the program asks for the speed of a car. If the user enters a value
//      less than the speed limit, program should display Ok on the console. If the value is above the
//      speed limit, the program should calculate the number of demerit points. For every 5km/hr above
//      the speed limit, 1 demerit points should be incurred and displayed on the console. If the number
//      of demerit points is above 12, the program should display License Suspended.

//Console.WriteLine("Enter the speed limit: ");
//var speedLimit = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter the speed of a car: ");
//var carSpeed = int.Parse(Console.ReadLine());
// int demeritPoints;

//if (carSpeed <= speedLimit)
//{
//    Console.WriteLine("Ok");
//}
//else
//{
//    const int mphPerDemerit = 5;
//    demeritPoints = (carSpeed - speedLimit) / mphPerDemerit;
//    if (demeritPoints > 12)
//    {
//        Console.WriteLine("License Suspended.");
//    }
//    else { Console.WriteLine($"Demerit points: {demeritPoints}"); }
//}
//--------------------------------------------------------------------------------------------------
//#5 Control Flow




//      Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
//      Display the count on the console.
//var count = 0;
//for (var i = 1; i <= 100; i++)
//{
//    if(i % 3 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"There are {count} numbers between 1 and 100 that are divisible by 3.");
//--------------------------------------------------------------------------------------------------
//#6 Control Flow




//      Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the
//      sum of all the previously entered numbers and display it on the console.
//int sum = 0;
//while (true)
//{
//    Console.WriteLine("Enter a number or 'ok' to exit: ");
//    var input = Console.ReadLine().ToLower();
//    if(input == "ok")
//    {
//        break;
//    }
//    sum += Int32.Parse(input);
//}
//Console.WriteLine($"The sum of the entered numbers is {sum}");
//--------------------------------------------------------------------------------------------------
//#7 Control Flow




//      Write a program and ask the user to enter a number. Compute the factorial of the number and print
//      it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1
//      and display it as 5! = 120.
//Console.WriteLine("Enter a number to compute the factorial: ");
//var input = Int32.Parse(Console.ReadLine());

//var factorial = 1;
//for (var i = 1; i <= input; i++)
//    factorial *= i;

//Console.WriteLine($"{input}! = {factorial}");
//--------------------------------------------------------------------------------------------------
//#8 Control Flow




//      Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess
//      the number. If the user guesses the number, display “You won"; otherwise, display “You lost".
//      (To make sure the program is behaving correctly, you can display the secret number on the console first.)
//var randomNum = new Random().Next(1, 10);
//for(var i = 1; i <= 4; i++)
//{
//    Console.WriteLine("Guess a number between 1 and 10: ");
//    var guess = Int32.Parse(Console.ReadLine());
//    if(guess == randomNum)
//    {
//        Console.WriteLine("You won!");
//        return;
//    }
//    else { Console.WriteLine("Wrong!"); }
//}
//Console.WriteLine("You lose!");
//--------------------------------------------------------------------------------------------------
//#9 Control Flow






