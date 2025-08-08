using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
  static void Main(String[] args)
  {
    //WriteLine Methods
    /* Console.WriteLine("Hello World!");
     Console.WriteLine("I am learning C#");
     Console.WriteLine("It is  awesome");
     Console.WriteLine(3 + 3);*/

    //Write Methods
    /* Console.Write("Hello World !");
     Console.Write("I will print on the same line");*/

    //Variables-{String}
    /*  string name = "John";
      Console.WriteLine(name);*/
    //Example
    /*  string greeting = "hello world \n";
      string name = "john";
      string message;
       message = greeting + name;
      Console.WriteLine(message);*/

    /* int myNum = 15;
     Console.WriteLine(myNum);*/

    //OR
    /* int myNum;
     myNum = 15;
     Console.WriteLine(myNum);*/
    //Example
    /* int number = 42;
     Console.WriteLine(number);
     int sum = number + 10;
     Console.WriteLine(sum);
     int updatenumber = 100;
     Console.WriteLine(updatenumber);*/



    //{double}
    /* double myDoubleNum = 19.99;
       Console.WriteLine(myDoubleNum);*/
    //Example
    /* double price = 19.99 ;
     double tempreture = -3.5;
     double scientificValue = 6.023456;
     double radius = 5.5;
     double area = Math.PI * radius * radius;
     Console.WriteLine(price);
     Console.WriteLine(tempreture);
     Console.WriteLine(scientificValue);
     Console.WriteLine(area);*/

    /*double a = 0.1;
    double b = 0.2;
    double sum = a + b;
    Console.WriteLine(sum);*/

    //{char}
    /* char myLetter = 'D';
     Console.WriteLine(myLetter);*/
    //Example
    /*char myChar = 'A';
    Console.WriteLine(myChar);
    char ch1 = 'a';
    Console.WriteLine(ch1);
    char ch3 = '\x0061';  // 'a'
    Console.WriteLine(ch3);
    char ch4 = (char)97;  // 'a'
    Console.WriteLine(ch4);
    char letter = 'B';
    Console.WriteLine(letter);
    char digit = '7';
    Console.WriteLine(digit);
    char lower = 'c';
    Console.WriteLine(lower);
    char newLine = '\n';
    char tab = '\t';
    char backslash = '\\';
    char singleQuote = '\'';
    Console.WriteLine(newLine);
    Console.WriteLine(tab);
    Console.WriteLine(backslash);
    Console.WriteLine(singleQuote);*/


    //{Bool}
    /*bool myBool = true;
    Console.WriteLine(myBool);*/
    //Example
    /* int x = 10;
     int y = 20;
     bool isXGreaterThanY = x > y; 
        Console.WriteLine($"Is x greater than y? {isXGreaterThanY}");*/

    //Display variables {1}
    /* string name = "John";
     Console.WriteLine("Hello"+ name  );*/
    //{2}
    /*string firstName = "John";
    string lastName = "Doe";
    string fullName = firstName + lastName;
    Console.WriteLine(fullName);*/
    //{3}
    /*int x = 5;
    int y = 6;
    Console.WriteLine(x + y);*/

    //Multiple variables {1}
    /* int x = 5, y = 6, z = 50;
     Console.WriteLine(x + y + z);*/
    //{2}
    /* int x, y, z;
     x = y = z = 50;
     Console.WriteLine(x + y + z);*/

    //Integer types -Int 
    /*  int myNum = 100000;
      Console.WriteLine(myNum);*/
    //long
    /*long myNum = 15000000L;
    Console.WriteLine(myNum);*/

    //Floting types - Float
    /* float myNum = 5.75F;
     Console.WriteLine(myNum);*/
    //double
    /*double myNum = 19.99D;
    Console.WriteLine(myNum);*/

    //Scientific Numbers
    /* float f1 = 35e3F;
     double d1 = 12D;
     Console.WriteLine(f1);
     Console.WriteLine(d1);*/

    //Type Casting
    //Implicity-{Example}
    /* int myInt = 9;
     double myDouble = myInt;
     Console.WriteLine(myInt);
     Console.WriteLine(myDouble);*/
    //Explicit-}{Example}
    /* double myDouble = 9.78;
     int myInt = (int)myDouble;
     Console.WriteLine(myDouble);
     Console.WriteLine(myInt);*/

    //Type Conversion Method-{Example}
    /*int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;
    Console.WriteLine(Convert.ToString(myInt));
    Console.WriteLine(Convert.ToDouble(myInt));
    Console.WriteLine(Convert.ToInt32(myDouble));
    Console.WriteLine(Convert.ToInt64(myInt));
    Console.WriteLine(Convert.ToString(myBool));*/

    //User Input - {Example 1}
    /*Console.WriteLine("Enter username");
    string userName = Console.ReadLine();
    Console.WriteLine("Username is" + userName);*/
    //{Example 2}-Error
    /*Console.WriteLine("Enter your age");
    int age = Console.ReadLine();
    Console.WriteLine("your age is" + age);*/
    //not error
    /* Console.WriteLine("Enter your age");
     int age = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Your age is" + age);*/

    //OPERATORS-{Example 1}
    /*int x = 100 + 50;
    Console.WriteLine(x);*/

    //{Example 2}

    /*int sum1 = 100 + 50;
    int sum2 = sum1 + 250;
    int sum3 = sum2 + sum2;
    Console.WriteLine(sum1);
    Console.WriteLine(sum2);
    Console.WriteLine(sum3);*/

    //Arithmetic Operators
    /* int x = 45;
     x++;
    x--;
     int y = 15;
     Console.WriteLine(x + y); //Addition
     Console.WriteLine(x - y); //Subtraction
     Console.WriteLine(x * y); //Multiplication
     Console.WriteLine(x / y); //Division
     Console.WriteLine(x % y); //Modulus
    Console.WriteLine(x); //Increment
     Console.WriteLine(x); //Decrement*/

    //Assignment Operator {Example}
    /* int x = 10;
     // x += 5; //Addition
     //x -= 3;  //subtraction
     //x *= 3; //multiplication
     //  x /= 3; //division
     // x %= 3; //modulus
     // x &= 3; //bitwise and
     //x |= 3; //bitwise or
     //  x ^= 3; //bitwise xor
     // x >>= 3; //right shift
    // x <<= 3; //left shift
     Console.WriteLine(x);*/

    //Comparision Operator-{Example}
    /* int x = 5;
     int y = 3;
     Console.WriteLine(x == y); //equal to
     Console.WriteLine(x != y); //not equal
     Console.WriteLine(x > y); //greater than
     Console.WriteLine(x < y); //less than
     Console.WriteLine(x >= y); //greater than and equal to
     Console.WriteLine(x <= y);*/ //less than and equal to


    //Logical Operators -{Example}
    /* int x = 5;
     Console.WriteLine(x > 3 && x < 10);     // logical and
     Console.WriteLine(x > 5 || x < 4);       //logical or
      Console.WriteLine(!(x > 3 && x < 10));*/  //logical not

    //Math tools {Example}
    //Math.Max
    /* Console.WriteLine(Math.Max(5, 10));
     //Math.Min
     Console.WriteLine(Math.Min(5, 10));
     //Math.Sqrt
     Console.WriteLine(Math.Sqrt(64));
     //Math.Abs
     Console.WriteLine(Math.Abs(-4));
     //Math.Round
     Console.WriteLine(Math.Round(9.99));*/

    //STRING -{EXAMPLE}
    /* string greeting = "Hello";
     Console.WriteLine(greeting);
     string greeting2 = "Nice to meet you";
     Console.WriteLine(greeting2);
     //STRING LENGTH
     string txt = "ABCDEFGHI";
     Console.WriteLine("The length of the txt string " + txt.Length);*/
    //OTHER METHODS-{TOUPPERCASE}
    /* string txt = "Hello World!";
     Console.WriteLine(txt.ToUpper());
     Console.WriteLine(txt.ToLower());*/
    //STRING CONCATENATION {Example 1}
    /* string firstName = "John";
     string lastName = "Doe";
     //string name = firstName + lastName;
     string name = string.Concat(firstName, lastName);
     Console.WriteLine(name);
     //{Example 2}
     string x = "10";
     string y = "20";
     // string z = x + y;
     string z = string.Concat(x, y);
     Console.WriteLine(z);*/
    //STRING INTERPOLATION -{EXAMPLE}
    /*  string firstName = "John";
      string lastName = "Doe";
      string name = $"My full name is  {firstName}  {lastName}";
      Console.WriteLine(name);
      //ACESS STRING {EXAMPLE 1}
      string myString = "Hello";
      Console.WriteLine(myString[0]);
      Console.WriteLine(myString[1]);
      //{EXAMPLE 2} SPECIFIC METHOD
      Console.WriteLine(myString.IndexOf("e"));*/
    //LOCATION 
    /* string name = "John Doe";
     int charPos = name.IndexOf("D");
     string lastName = name.Substring(charPos);
     Console.WriteLine(lastName);*/

    //SPECIAL CHARACTER
    //{\"- double quotes}
    // string txt = "we are the so-called\" vikings \" from the north";
    //{\'- single quotes}
    // string txt = "It\'s alright";
    //{\\- backslash}
    // string txt = "The character \\ is called backslash";
    //{\n- new line}
    //string txt = "Hello\nWorld";
    //{\t- new tab}
    // string txt = "Hello\t World";
    //{\b- backspace}
    // string txt = "hel\b lo World";
    //Console.WriteLine(txt);


    //BOOLEANS EXAMPLE
    /*  bool isCSharpFun = true;
      bool isFishTasty = false;
      Console.WriteLine(isCSharpFun);
      Console.WriteLine(isFishTasty);
      //COMPARISION OPERATOR{>}
      int x = 10;
      int y = 15;
      Console.WriteLine(x > y);
      //Or
      // Console.WriteLine(10 > 15);*/
    //EQUAL TO {==}
    int x = 10;
    Console.WriteLine(x == 10);
    //or
    //Console.WriteLine(10 == 15);
    //EQUAL TO GREATER THAN{>=}
    int myAge = 25;
    int votinAge = 18;
    Console.WriteLine(myAge >= votinAge);
     }
}
