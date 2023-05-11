using System.Globalization;

//These exercises are part of a course I'm taking on Udemy (Mosh Hamedani's Basic and Intermediate).
//Obviously these are not real world applications, so I did not always validate input or handle exceptions unless specified.
//You can uncomment the code to run any exercise(ctrl+K+U).




//==================================================================================================
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
//==================================================================================================







//==================================================================================================
//#2 Control Flow
//      Write a program which takes two numbers from the console and displays the maximum of the two.

//Console.WriteLine("Enter a number: ");
//var input1 = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter another number: ");
//var input2 = Int32.Parse(Console.ReadLine());
//Console.WriteLine($"{Math.Max(input1,input2)}");
//==================================================================================================






//==================================================================================================
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
//==================================================================================================







//==================================================================================================
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
//==================================================================================================







//==================================================================================================
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
//==================================================================================================






//==================================================================================================
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
//==================================================================================================







//==================================================================================================
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
//==================================================================================================







//==================================================================================================
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
//==================================================================================================







//==================================================================================================
//#9 Control Flow
//      Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum
//      of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the
//      program should display 8.
//Console.WriteLine("Enter numbers separated by commas: ");
//var input = Console.ReadLine();

//var inputSplit = input.Split(",");
//var max = Int32.Parse(inputSplit[0]);
//for (var i = 0; i < inputSplit.Length; i++)
//{
//    if (Int32.Parse(inputSplit[i]) > max)
//    {
//        max = Int32.Parse(inputSplit[i]);
//    }
//}
//Console.WriteLine($"The max number is {max}");
//==================================================================================================







//==================================================================================================
//#10 Arrays and Lists
//      When you post a message on Facebook, depending on the number of people who like your post,
//      Facebook displays different information.
//       - If no one likes your post, it doesn't display anything.
//       - If only one person likes your post, it displays: [Friend's Name] likes your post.
//       - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
//       - If more than two people like your post, it displays: [Friend 1], [Friend 2] and
//          [Number of Other People] others like your post.
//      Write a program and continuously ask the user to enter different names, until the user presses
//      Enter (without supplying a name). Depending on the number of names provided, display a message based
//      on the above pattern.
//var likedUsers = new List<string>();
//while (true)
//{
//    Console.WriteLine("Enter a user's name");
//    var liked = Console.ReadLine();
//    if (String.IsNullOrWhiteSpace(liked))
//        break;
//    else { likedUsers.Add(liked); }
//}

//if (likedUsers.Count == 0)
//{
//    Console.WriteLine("Nobody likes this post.");
//}
//else if (likedUsers.Count == 1)
//{
//    Console.WriteLine(likedUsers[0]);
//}
//else if (likedUsers.Count == 2)
//{
//    Console.WriteLine($"{likedUsers[0]} and {likedUsers[1]} like your post.");
//}
//else if (likedUsers.Count >= 3)
//{
//    Console.WriteLine($"{likedUsers[0]}, {likedUsers[1]}, and {likedUsers.Count - 2} others like your post.");
//}
//==================================================================================================






//==================================================================================================
//#11 Arrays and Lists
//      Write a program and ask the user to enter their name. Use an array to reverse the name and
//      then store the result in a new string. Display the reversed name on the console.
//Console.WriteLine("Please enter your name: ");
//var name = Console.ReadLine();
//var nameArray = new char[name.Length];


//for (var i = name.Length; i > 0; i--)
//{
//    nameArray[name.Length - i] = name[i - 1];
//}

//var reversedString = new string(nameArray);
//Console.WriteLine($"Name reversed is: {reversedString}");
//==================================================================================================






//==================================================================================================
//#12 Arrays and Lists
//      Write a program and ask the user to enter 5 numbers. If a number has been previously entered,
//      display an error message and ask the user to re-try. Once the user successfully enters 5 unique
//      numbers, sort them and display the result on the console.
//var fiveNumbers = new List<int>();
//while(fiveNumbers.Count < 5)
//{
//    Console.WriteLine("Enter a number: ");
//    var input = Convert.ToInt32(Console.ReadLine());
//    if (fiveNumbers.Contains(input))
//    {
//        Console.WriteLine($"{input} has already been entered. Try Again.");
//    }
//    else { fiveNumbers.Add(input); }
//}
//fiveNumbers.Sort();
//Console.Clear();
//Console.WriteLine("The numbers you entered after sorting are: ");
//foreach (var number in fiveNumbers)
//{
//    Console.WriteLine(number);
//}
//==================================================================================================






//==================================================================================================
//#13 Arrays and Lists
//      Write a program and ask the user to continuously enter a number or type "Quit" to exit. The
//      list of numbers may include duplicates. Display the unique numbers that the user has entered.
//var numbers = new List<Int32>();
//while (true)
//{
//    Console.WriteLine("Enter a number or quit to exit: ");
//    var input = Console.ReadLine();
//    if (input.ToLower() == "quit")
//    {
//        break;
//    }
//    else if (!numbers.Contains(Convert.ToInt32(input)))
//    {
//        numbers.Add(Convert.ToInt32(input));
//    }
//}
//Console.Clear();
//Console.WriteLine("The unique numbers you entered are: ");
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}
//==================================================================================================






//==================================================================================================
//#14 Arrays and Lists
//      Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
//      If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to
//      re-try; otherwise, display the 3 smallest numbers in the list.
//string[] numberArray;
//while (true)
//{
//    Console.WriteLine("Enter a list of atleast 5 numbers separated by commas (e.g 5, 1, 9, 2, 10):  ");
//    var input = Console.ReadLine();
//    numberArray = input.Split(',');
//    if (numberArray.Length < 5)
//    {
//        Console.WriteLine("Invalid list, please retry.");
//    }
//    else { break; }
//}


//var numberList = new List<int>();
//for (var i = 0; i < numberArray.Length; i++ )
//{
//    numberList.Add(Convert.ToInt32(numberArray[i]));
//}


//numberList.Sort();
//Console.WriteLine("The three smallest numbers entered are: ");
//for (var i = 0; i < 3; i ++)
//{
//    Console.WriteLine(numberList[i]);
//}
//==================================================================================================






//==================================================================================================
//#15 Working with text
//     Write a program and ask the user to enter a few numbers separated by a hyphen. If the user
//     simply presses Enter, without supplying an input, exit immediately; otherwise, check to see
//     if there are duplicates. If so, display "Duplicate" on the console.
//Console.WriteLine("Enter a few numbers separated by hypen (eg.'5-6-7-8-9') or ('20-19-18-17-16')");
//var input = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(input))
//{
//    Environment.Exit(0);
//}
//var numbersArray = input.Split('-');
//var numbers = new List<int>();

//foreach (var number in numbersArray)
//{
//    numbers.Add(Convert.ToInt32(number));
//}

//var uniques = new List<int>(); 
//bool duplicates = false;

//foreach (var number in numbers)
//{
//    if (uniques.Contains(number) == false)
//    {
//        uniques.Add(number);
//    }
//    else
//    {
//        duplicates = true;
//        break;
//    }

//}
//if (duplicates == true)
//{
//    Console.WriteLine("Duplicates");
//}
//==================================================================================================
//





//==================================================================================================
//#16 Working with text
//      Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
//      A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise,
//      display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
//Console.WriteLine("Enter a time in 24-hour format (eg. 19:00)");
//var input = Console.ReadLine();
//if (DateTime.TryParseExact(input, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
//{
//    Console.WriteLine("Ok");
//}
//else
//{
//    Console.WriteLine("Invalid time.");
//}
//==================================================================================================






//==================================================================================================
//#17 Working with text
//      Write a program and ask the user to enter a few words separated by a space. Use the words to
//      create a variable name with PascalCase. For example, if the user types: "number of students",
//      display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if
//      the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
//Console.WriteLine("Enter a few words separated by space: ");
//var input = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(input))
//{
//    Console.WriteLine("Invalid input");
//    Environment.Exit(0);
//}

//var wordsArray = input.Split(' ');
//string pascalVariable = "";

//foreach (var word in wordsArray)
//{
//    var pascalWord = char.ToUpper(word[0]) + word.ToLower().Substring(1);
//    pascalVariable += pascalWord;
//}
//Console.WriteLine(pascalVariable);
//==================================================================================================






