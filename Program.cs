namespace g10
{
      internal class Program
      {
            static void Main(string[] texts)
            {
                  //1

                  Console.WriteLine("number : ");
                  var number = Convert.ToInt32(Console.ReadLine());
                  
                  var ones = number % 10;
                  var tens = number / 10 % 10;
                  var hundreds = number / 100 % 10;
                  var thousands = number / 1000 % 10;
                  
                  var result = thousands * 1000 + hundreds * 100 + ones * 10 + tens;
                  
                  Console.WriteLine(result);

                  //2

                  // Console.Write("threeroom number :");
                  //
                  // var number = Convert.ToInt32(Console.ReadLine());
                  //
                  // var ones = number % 10;
                  // var tens = number / 10 % 10;
                  // var hundreds = number / 100 % 10;
                  //
                  // var result = hundreds * 10 + tens * 100 + ones;
                  //
                  // Console.WriteLine(result);
                  
                  // 3
                  
                  // Console.Write("number : ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  //
                  // var ones = number % 10;
                  // var tens = number / 10 % 10;
                  // var hundreds = number / 100 % 10;
                  // var thousands = number / 1000 % 10;
                  //
                  // var result = thousands * 10 + hundreds * 100 + tens * 1000 + ones;
                  // ;
                  //
                  // Console.WriteLine(result);
                  
                  // 4
                  
                  // Console.Write(" Gb : ");
                  //
                  // var gb = Convert.ToInt32(Console.ReadLine());
                  //
                  // var result = gb * 1024;
                  //
                  // Console.WriteLine(result + " mb");
                  
                  // 5
                  
                  // Console.Write(" Gb : ");
                  //
                  // var gb = Convert.ToInt32(Console.ReadLine());
                  //
                  // var result = gb * 1024l * 1024 * 1024 * 8;
                  //
                  // Console.WriteLine(result + " bit");
                  
                  // 6
                  
                  // Console.Write(" Gb : ");
                  //
                  // var gb = Convert.ToInt32(Console.ReadLine());
                  //
                  // var result = gb / 1024d;
                  //
                  // Console.WriteLine(result + " TB");
                  
                  // 7
                  
                  // Console.Write(" Gb : ");
                  //
                  // var gb = Convert.ToInt32(Console.ReadLine());
                  //
                  // var result = gb / 2;
                  //
                  // Console.WriteLine(result);
                  
                  
                  // ---------- //
                  //       2
                  
                  // Console.Write("number : ");
                  //
                  // var number = Convert.ToInt32(Console.ReadLine());
                  //
                  // var first = number * number;
                  // var two = first * first;
                  // var three = two * first;
                  //
                  // Console.WriteLine(three);
                  
                  // 3
                  
                  // Console.Write("number : ");
                  //
                  // var number = Convert.ToInt32(Console.ReadLine());
                  //
                  // var second = number * number;
                  // var fourth = second * second;
                  // var eighth = fourth * fourth;
                  //
                  // Console.WriteLine(eighth);
                  
                  
                  // ------------- //
                  
                  //       1
                  
                  // Console.Write("Enter number: ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  // if (number % 2 == 0)
                  // {
                  //       Console.WriteLine("couple");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("odd");
                  // }
                  
                  
                  // 2
                  
                  // Console.Write("Enter number: ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  // if (number % 2 != 0)
                  // {
                  //       Console.WriteLine("odd");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("couple");
                  // }
                  
                  // 3
                  
                  // Console.Write("Enter number: ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  // if (number > 9 && number < 100)
                  // {
                  //       Console.WriteLine("two rooms");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("another room");
                  // }
                  
                  // 4
                  
                  // Console.Write("Enter number: ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  // if (number > 999 && number < 10000)
                  // {
                  //       Console.WriteLine("four rooms");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("another room");
                  // }
                  
                  // 5
                  
                  // Console.Write("number : ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  // if (number % 2 == 0 && number > 9 && number < 100)
                  // {
                  //       Console.WriteLine("two rooms and couple");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("another rooms and odd or couple");
                  // }
                  
                  // 6
                  
                  // Console.Write("number : ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  // if (number % 2 != 0 && number > 99 && number < 1000)
                  // {
                  //       Console.WriteLine("three rooms and odd");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("another rooms and odd or couple");
                  // }
                  
                  // 7
                  
                  // Console.Write("number : ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  // if (number % 2 == 0 && number > 999 && number < 10000)
                  // {
                  //       Console.WriteLine("four rooms and couple");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("another rooms and odd or couple");
                  // }
                  
                  // 8
                  
                  // Console.Write("first number : ");
                  // var firstNumber = Convert.ToInt32(Console.ReadLine());
                  // Console.Write("second number : ");
                  // var seecondNumber = Convert.ToInt32(Console.ReadLine());
                  // if (firstNumber % 2 != 0 && seecondNumber % 2 != 0)
                  // {
                  //       Console.WriteLine("both of odd numbers ");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("another numbers ");
                  // }
                  
                  // 9
                  
                  // Console.Write("first number : ");
                  // var firstNumber = Convert.ToInt32(Console.ReadLine());
                  // Console.Write("second number : ");
                  // var seecondNumber = Convert.ToInt32(Console.ReadLine());
                  // if (firstNumber % 2 == 0 && seecondNumber % 2 == 0)
                  // {
                  //       Console.WriteLine("both of couple numbers ");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("another numbers ");
                  // }
                  
                  // 10
                  
                  // Console.Write("first number : ");
                  // var firstNumber = Convert.ToInt32(Console.ReadLine());
                  // Console.Write("second number : ");
                  // var seecondNumber = Convert.ToInt32(Console.ReadLine());
                  // if (firstNumber % 2 != 0 && seecondNumber % 2 != 0 && firstNumber < 100 && firstNumber > 9 &&
                  //     seecondNumber < 100 && seecondNumber > 9)
                  // {
                  //       Console.WriteLine("both of odd numbers and two rooms");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("another numbers ");
                  // }
                  
                  // 11
                  
                  // Console.Write("one rom number : ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  //
                  // var ones = number % 10;
                  // var tens = number / 10 % 10;
                  //
                  // if (ones == tens)
                  // {
                  //       Console.WriteLine("true");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("false");
                  // }

                  //12

                  // Console.Write("one rom number : ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  //
                  // var ones = number % 10;
                  // var tens = number / 10 % 10;
                  //
                  // if (ones + tens > 10)
                  // {
                  //       Console.WriteLine("true");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("false");
                  // }

                  //16

                  // Console.Write("number : ");
                  // var number = Convert.ToInt32(Console.ReadLine());
                  // if (number % 3 == 0)
                  // {
                  //       Console.WriteLine("true ");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("false ");
                  // }

                  //22

                  // Console.Write("number : ");
                  //
                  // var number = Convert.ToInt32(Console.ReadLine());
                  // if (number % 4 == 0 && number % 3 != 0)
                  // {
                  //       Console.WriteLine("true");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("false");
                  // }
                  //
                  //23

                  // Console.Write("firstNumber : ");
                  // var firstNumber = Convert.ToInt32(Console.ReadLine());
                  // Console.Write("secondNumber : ");
                  // var secondNumber = Convert.ToInt32(Console.ReadLine());
                  //
                  // if (firstNumber > secondNumber)
                  // {
                  //       Console.WriteLine("True");
                  // }
                  // else
                  // {
                  //       Console.WriteLine("False");
                  // }
                  
                  //25
                  
                  // Console.Write("firstNumber : ");
                  // var firstNumber = Convert.ToInt32(Console.ReadLine());
                  // Console.Write("secondNumber : ");
                  // var secondNumber = Convert.ToInt32(Console.ReadLine());
                  // Console.Write("thirdNumber : ");
                  // var thirdNumber = Convert.ToInt32(Console.ReadLine());
                  //
                  // if (firstNumber > secondNumber && firstNumber > thirdNumber)
                  // {
                  //       Console.WriteLine("The first number big");
                  // }
                  
                  
                  
                  
                  
                  
                  Main(texts);
            }
      }
}