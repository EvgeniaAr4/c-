// 1. Напишите программу, которая на вход принимает число и выдаёт его квадрат

// Console.WriteLine("input integer number");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("result is " + result);

//2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго

// Console.WriteLine("input first number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input second number");
// // int num2 = Convert.ToInt32(Console.ReadLine());

// int square = num2 * num2;

// if (num == square)
//     Console.WriteLine("first number is a square of second number");

// else
//     Console.WriteLine("first number is not a square of second number");

//3. напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Console.WriteLine("input number of a day: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7)
//      Console.Write("incorrect day");

// else

//     if (day == 1)
//         Console.WriteLine("monday");

//4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутки от -N до N.

// Console.Write("input N");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;
// if (num < 0)
//    current = num;
//    num = num * (-1);

// else 
//    current = -1 * num;

// while(current < num-1)
//    current++;
//    Console.Write(current + " ");

//5. Напишите программу, которая на вход принимает трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Console.Write("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num % 10);



//homework
//1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("input A: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input B: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num > num2)
//     Console.WriteLine("max A");
//  else
//     Console.WriteLine("max B");

//2.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("input A: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input B: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input C: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = Convert.ToInt32(Console.ReadLine());
// max = num; 
// if (max < num2)
//    max = num2;
// if (max < num3)
//    max = num3;
// Console.Write("max = ");  // не могу понять как вывести значение max

//3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("input num: ");
// int num = Convert.ToInt32(Console.ReadLine());   
// Console.WriteLine(num % 2);

//4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("input N");
int num = Convert.ToInt32(Console.ReadLine());
int curr = Convert.ToInt32(Console.ReadLine());
int current;
if (num < 0)
    current = num;
    num = num * (-1);

while(current < num-1)
    Console.WriteLine(num % 2 == 0);
    current++;
    Console.Write(current + " ");  //логику решения поняла, а написать нормально не получается, не пойму в чем дело тут

