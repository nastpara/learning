using System.IO;
using static System.Net.Mime.MediaTypeNames;
/*
    # Пользователь вводит два числа, нужно найти их сумму
    # Пользователь вводит число, поделить это число на 5 без остатка
    # Пользователь вводит число, найти остаток от деления 100 на это число
    # Записать данные из задач 1-3 и красиво вывести их через f-строку в консоль
    # Пользователь вводит возраст. Вывести True, если чему больше 18, иначе False
 */


// Задача 1
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int num3 = num1 + num2;
//Console.WriteLine(num3);
////task 2
//int num4 = num1 / 5;
//Console.WriteLine(num4);
////Task 3
//int num5 = num2 %100;
//Console.WriteLine(num5);
////Task 4
//Console.WriteLine($"Сложение: {num3} , Деление на 5: {num4}, Остаток от деления на 100: {num5}");
//// Task 5
//int age = int.Parse(Console.ReadLine());
//bool age1 = age > 18;
//Console.WriteLine(age1);


/* Задачи
            Пользователь вводит возраст, если больше или равно 18, то пропускаем, иначе нет. (+тернарный)
            Пользователь вводит число, если оно чётное, то пропускаем, иначе нет. (+тернарный)
            Пользователь вводит число, если оно кратно 5, проверяем на кратность 3, если нет, то пропускаем. (+тернарный)
            Пользователь вводит число, если чётно, то пропускаем, иначе проверяем на кратность 3. (+тернарный)
    

            Дано число. Если оно от -10 до 10 не включительно, то увеличить его на 5, иначе уменьшить на 10. (+тернарный)
            
            Дано три числа. Найти количество положительных чисел среди них.
            Дана дата из трех чисел (день, месяц и год). Вывести yes, если такая дата существует (например, 12 02 1999 - yes, 22 13 2001 - no). Считать, что в феврале всегда 28 дней.


            Итоговое задание - написать свой калькулятор. Подумать, как можно добавить тернарный оператор
         */

/*
//task 1.1
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Task 1");
if (age >=18 )
{
    Console.WriteLine("Dandadan");
}
else
{
    Console.WriteLine("Nonono mister fish");
}
// task 1.2
Console.WriteLine(((age>=18) ? ("Dandadan") : ("Nonono mister fish")));

// task 2.1
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Task 2");
if (num % 2 == 0)
{
    Console.WriteLine("Dandadan");
}
else
{
    Console.WriteLine("Nonono mister fish");
}
// task 2.2
Console.WriteLine(((num%2==0) ? ("Dandadan") : ("Nonono mister fish")));

//Task 3.1
Console.WriteLine("Task 3");
if ((num%5==0) && (num%3==0))
{
    Console.WriteLine("Nonono mister fish");
}
else
{
    Console.WriteLine("Dandadan");
}
// task 3.2
Console.WriteLine(((num % 5 == 0 && num%3==0) ? ("Nonono mister fish") : ("Dandadan")));

//task 4.1
Console.WriteLine("Task 4");
if (num % 2 == 0)
{
    Console.WriteLine("Dandadan");
}
else if (num % 3 == 0)
{
    Console.WriteLine("Nonono mister fish");
}
else
{
    Console.WriteLine("XZ");
}
//task 4.2
Console.WriteLine(((num % 2 == 0) ? ("Dandadan") : (num%3==0) ? ("Nonono mister fish") : "XZ"));

//task 5.1
Console.WriteLine("Task 5");
int num1 = num;
if ( num1<1 && num1>10)
{
    Console.WriteLine(num1+5);
}
else
{
    Console.WriteLine(num1-10);
}
// task 5.2
int num2 = num;
Console.WriteLine(((num2<10 && num2>10) ? (num2+5) : (num2-10)));

// task 6
Console.WriteLine("Task 6");
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int a3 = int.Parse(Console.ReadLine());
int a = 0;
if (a1>0)
{
    a++;
}
if (a2 > 0)
{
    a++;
}
if (a3 > 0)
{
    a++;
}
Console.WriteLine(a);

// task 7
Console.WriteLine("Task 7");
Console.Write("Day: ");
int day = int.Parse(Console.ReadLine());
Console.Write("Month: ");
int month  = int.Parse(Console.ReadLine());
Console.Write("Year: ");
int year = int.Parse(Console.ReadLine());
if (month==2 && day>28)
{
    Console.WriteLine("Nonono mister fish");
}
else if (month<8 && month%2==0 && day<=30)
{
    Console.WriteLine("Dandadan");
}
else if (month < 8 && month % 2 == 1 && day <= 31)
{
    Console.WriteLine("Dandadan");
}
else if (month >= 8 && month % 2 == 0 && day <= 31 && month<13)
{
    Console.WriteLine("Dandadan");
}
else if (month >= 8 && month % 2 == 1 && day <= 3 && month < 13)
{
    Console.WriteLine("Dandadan");
}
else
{
    Console.WriteLine("Nonono mister fish");
}

// task 8
Console.WriteLine("Task 8");
Console.Write("Введите действие (+,-,*,/,%): ");
char sym = char.Parse(Console.ReadLine());
Console.Write("Первое число:");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Второе число:");
int number2 = int.Parse(Console.ReadLine());
if (sym=='+')
{
    Console.WriteLine(number1+number2);
}
else if (sym == '-')
{
    Console.WriteLine(number1 - number2);
}
else if (sym == '*')
{
    Console.WriteLine(number1 * number2);
}
else if (sym == '/')
{
    Console.WriteLine(number1 / number2);
}
else if (sym == '%')
{
    Console.WriteLine(number1 % number2);
}
*/

/*
Выведите на экран 10 раз фразу "You are welcome!"
    Выведите на экран n раз фразу "Silence is golden". Число n вводит пользователь.
    Выведите на экран прямоугольник из нулей. Количество строк вводит пользователь, количество столбцов равно 5.

    Вывести на экран фигуру из звездочек:
    *******
    *******
    *******
    *******
    (квадрат из n строк, в каждой строке n звездочек)

    Вывести на экран числа от 1000 до 9999 такие, что среди цифр есть цифра 3.

    Выведите на экран строки вида:
    *******
    ****
    *******
    ****
    *******
    ****
    (всего n строк, звездочек или 7, или 4 по очереди)


    Вывести на экран:
    AAABBBAAABBBAAABBB
    BBBAAABBBAAABBBAAA
    AAABBBAAABBBAAABBB
    (таких строк n, в каждой строке m троек AAA)

    Вывести на экран:
    AAAAAAAAAAAAAAAA
    ABBBBBBBBBBBBBBA
    ABBBBBBBBBBBBBBA
    ABBBBBBBBBBBBBBA
    AAAAAAAAAAAAAAAA
    (количество строк вводит пользователь, ширина прямоугольника в два раза больше высоты)

    Выведите на экран квадрат из нулей и единиц, причем нули находятся только на диагонали квадрата. Всего в квадрате сто цифр. Обе диагонали состоят из 0

    Вывести на экран числа от 1 до 100, которые делятся на 3 или на 5.

    Вывести на экран таблицу умножения для числа n (n вводит пользователь).

    Вывести на экран все четные числа от 1 до n (n вводит пользователь).
*/

// Выведите на экран 10 раз фразу "You are welcome!" task 1-2
//Console.Write("Введите количество строк: ");
//int n1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Task 1");
//for (int i = 0; i<n1; i++)
//{
//    Console.WriteLine("I love you");
//}

//// Выведите на экран прямоугольник из нулей. Количество строк вводит пользователь, количество столбцов равно n.

//Console.Write("Введите количество строк: ");
//int n2_1 = int.Parse(Console.ReadLine());
//int n2_2 = int.Parse(Console.ReadLine());
//for (int i = 0; i < n2_1; i++)
//{
//    for (int j = 1; j < n2_2; j++)
//    {
//        Console.Write('0');
//    }
//    Console.WriteLine('0');
//}

////// task 3   Вывести на экран числа от 1000 до 9999 такие, что среди цифр есть цифра 3.
////for (int i = 1000; i < 9999; i++)
////{
////    if (i / 1000 == 3 || i /10 % 10 == 3 || i /10 %10 == 3 || i %1000==3)
////    {
////        Console.WriteLine(i);
////    }
////}

//// task 4  Выведите на экран строки вида:
////*******
////****
////*******
////****
////*******
////****
////(всего n строк, звездочек или 7, или 4 по очереди)
//int n4 = int.Parse(Console.ReadLine());
//for (int i = 0; i<n4; i++)
//{
//    if (i % 2 == 1)
//        Console.WriteLine("****"); 
//    else
//        Console.WriteLine("*******");
//}

//// task 5 Вывести на экран: 
////AAABBBAAABBBAAABBB
////BBBAAABBBAAABBBAAA
////AAABBBAAABBBAAABBB
////    (таких строк n, в каждой строке m троек AAA)
//int n5 = int.Parse(Console.ReadLine());
//int m5 = int.Parse(Console.ReadLine());
//string s1 = "AAABBB";
//string s2 = "BBBAAA";
//string s = "";
//for (int i = 0;i<n5; i++)
//{
//    if (i % 2 == 0)
//    {
//        for (int j = 1; j < m5 + 1; j++)
//        {
//            s += s1;
//        }
//    }
//    if (i % 2 == 1)
//    {
//        for (int k = 1; k < m5 + 1; k++)
//        {
//            s += s2;
//        }
//    }
//    Console.WriteLine(s);
//    s = "";
//}

//// task 6  Вывести на экран все числа от 1 до n, которые являются степенью числа 23.
//int n6  = int.Parse(Console.ReadLine());
//int num = 1;
//Console.WriteLine(1);
//for (int i = 1; i<n6; i++)
//{
//    if (num*23 == i && i%23==0)
//    {
//        num = num*23;
//        Console.WriteLine(num);
//    }
//}


/* Задачи на while
  
    1. Напишите цикл while, который выведет числа от 1 до 10.

    2. Создайте цикл while, который будет находить сумму чисел от 1 до 100.

    3. Используя цикл while, выведите все нечетные числа от 1 до 20.

    4. Реализуйте бесконечный цикл while, который выводит числа от 1 до бесконечности, но прерывается при достижении числа 15.

    5. Напишите цикл while, который будет запрашивать у пользователя ввод чисел и завершится, когда пользователь введет число 0.

    1. Напишите цикл do while, который выведет "Hello, World!" 5 раз.

    2. Напишите программу, которая запрашивает ввод числа у пользователя и проверяет, положительное оно или отрицательное, до тех пор, пока пользователь не введет число 0.

    3. Напишите программу, которая запрашивает у пользователя пароль через цикл do while до тех пор, пока пароль не будет равен "12345".
*/
// task 1  Напишите цикл while, который выведет числа от 1 до 10.
//int lim = 1;
//while (lim<=10)
//{
//    Console.WriteLine(lim);
//    lim++;
//}

//// task 2  Создайте цикл while, который будет находить сумму чисел от 1 до 100.
//int sum = 0;
//int lim2 = 1;
//while (lim2<100)
//{
//    sum += lim2;
//    lim2++;
//}
//Console.WriteLine(sum);

////task 3  Используя цикл while, выведите все нечетные числа от 1 до 20.
//lim = 1;
//while (lim<=20)
//{
//    if (lim%2==1)
//    {
//        Console.WriteLine(lim);
//    }
//    lim++;
//}

////task 4   Реализуйте бесконечный цикл while, который выводит числа от 1 до бесконечности, но прерывается при достижении числа 15.
//lim = 1;
//while (lim>0)
//{
//    if ( lim ==15)
//    {
//        break;
//    }
//    lim++;
//}
////task 5 Напишите цикл while, который будет запрашивать у пользователя ввод чисел и завершится, когда пользователь введет число 0.
//int num = int.Parse(Console.ReadLine());
//while (num!=0)
//{
//    int num1 = int.Parse(Console.ReadLine());
//    num = num1;
//}

////task 6  Напишите цикл do while, который выведет "Hello, World!" 5 раз.
//int count = 0;
//do
//{
//    Console.WriteLine("Hello, World!");
//    count++;
//}
//while (count < 5);

//// task 7  Напишите программу, которая запрашивает ввод числа у пользователя и проверяет, положительное оно или отрицательное, до тех пор, пока пользователь не введет число 0.
//int num2 = int.Parse(Console.ReadLine());
//while (num2 != 0)
//{
//    if (num2>0)
//    {
//        Console.WriteLine("положительное");
//    }
//    else
//    {
//        Console.WriteLine("отрицательное");
//    }
//    int num1 = int.Parse(Console.ReadLine());
//    num2 = num1;
//}

////task 8  Напишите программу, которая запрашивает у пользователя пароль через цикл do while до тех пор, пока пароль не будет равен "12345".
//count = 0;
//do
//{
//    string pas = Console.ReadLine();
//    if (pas=="12345")
//    {
//        count++;
//    }
//    else
//    {
//        Console.WriteLine("Введите снова");
//    }
//}
//while (count !=1);

/* Задачи на кортежи

        1. Создайте кортеж, содержащий три элемента разных типов (например, int, string, double).

        2. Напишите программу, который принимает кортеж из двух элементов (строки) и возвращает их конкатенацию.

        3. Создайте кортеж, содержащий два вложенных кортежа. Доступ к элементам вложенных кортежей.
Задачи на DateTime

        1. Напишите программу, которая выводит текущую дату и время в формате "dd.MM.yyyy HH:mm:ss".

        2. Напишите программу, которая запрашивает у пользователя дату рождения и вычисляет его возраст.

        3. Напишите программу, которая вычисляет количество дней до нового года.
Задачи на Math

         1. Напишите программу, которая рандомно генерирует два числа и вычисляет их среднее арифметическое.

         2. Напишите программу, которая рандомно генерирует радиус круга и вычисляет его площадь.

         3. Напишите программу, которая рандомно генерирует три числа и находит максимальное из них.
*/

// task 1  Создайте кортеж, содержащий три элемента разных типов (например, int, string, double).
//var tuple = (6, "kao", 4, 15);

//// task 2  Напишите программу, который принимает кортеж из двух элементов (строки) и возвращает их конкатенацию.
//string str1 = Console.ReadLine();
//string str2 = Console.ReadLine();
//var str = (str1, str2) ;
//Console.WriteLine($"{str.Item1}, {str.Item2}");

//// task 3  Создайте кортеж, содержащий два вложенных кортежа. Доступ к элементам вложенных кортежей.

//var tuple3 = ((2, 3), (4, 5), (6, 7));

//// task 4  Напишите программу, которая выводит текущую дату и время в формате "dd.MM.yyyy HH:mm:ss".
//DateTime now = DateTime.Now;
//Console.WriteLine(now);

//// task 5  Напишите программу, которая запрашивает у пользователя дату рождения и вычисляет его возраст.
//var now5 = DateOnly.FromDateTime(DateTime.Now);
//int def = 0;
//Console.WriteLine(now5);
//Console.Write("Введите день: ");
//int day = int.Parse(Console.ReadLine());
//Console.Write("Введите месяц: ");
//int month = int.Parse(Console.ReadLine());
//Console.Write("Введите год: ");
//int year = int.Parse(Console.ReadLine());
//var birth = (day, month, year);
//if (now5.Month-birth.Item2<0)
//{
//    def = now5.Year-birth.Item3-1;
//}
//else if (now5.Month - birth.Item2 == 0)
//{
//    if (now5.Day - birth.Item1<0)
//        def = now5.Year - birth.Item3 - 1;
//}
//else
//{
//    def = now5.Year - birth.Item3;
//}
//Console.WriteLine(def);

//// task 6  Напишите программу, которая вычисляет количество дней до нового года.
//DateTime NY = new DateTime(2027, 1, 1);
//TimeSpan difference = NY - now;
//Console.WriteLine($"Всего дней: {difference.Days}");

//// task 7  Напишите программу, которая рандомно генерирует два числа и вычисляет их среднее арифметическое.
//Random random = new Random();
//int num1 = random.Next(0, 10);
//int num2 = random.Next(0, 10);
//Console.WriteLine($"{num1}, {num2}");
//Console.WriteLine((num1+num2)/2);

//// task 8  Напишите программу, которая рандомно генерирует радиус круга и вычисляет его площадь.
//int R = random.Next(0, 10);
//Console.WriteLine(R);
//double pi = Math.PI;
//Console.WriteLine(pi*R*R);


/* Задачи на одномерные массивы

        1. Создайте массив из 10 целых чисел и заполните его случайными числами от 1 до 100. Выведите массив на экран.

        2. Напишите программу, которая находит сумму всех элементов массива из задачи 1.

        3. Напишите программу, которая находит максимальный и минимальный элементы массива из задачи 1.

        4. Напишите программу, которая сортирует массив из задачи 1 по возрастанию и выводит его на экран.

        5. Напишите программу, которая находит среднее арифметическое всех элементов массива из задачи 1.
Задачи на двумерные массивы

        1. Создайте двумерный массив 3x3 и заполните его случайными числами от 1 до 10. Выведите массив на экран.

        2. Напишите программу, которая находит сумму всех элементов двумерного массива из задачи 1.

        3. Напишите программу, которая находит максимальный и минимальный элементы двумерного массива из задачи 1.

        4. Напишите программу, которая транспонирует двумерный массив из задачи 1 (меняет строки на столбцы) и выводит его на экран.

        5. Напишите программу, которая находит сумму элементов каждой строки двумерного массива из задачи 1.
Задачи на ступенчатые массивы

        1. Создайте ступенчатый массив из трех строк, где каждая строка содержит случайное количество элементов (от 1 до 5) и заполните их случайными числами от 1 до 10. Выведите массив на экран.
Задачи на трехмерные массивы

        1. Создайте трехмерный массив 2x2x2 и заполните его случайными числами от 1 до 10. Выведите массив на экран.
Финальная задача
          Написать программу, которая будет вставлять число введённое пользователем по индексу в массив 
          (число элементов в массиве должно стать больше)

          Сделать сортировку одномерного и двумерного массива (любая)
         */
// task 1  Создайте массив из 10 целых чисел и заполните его случайными числами от 1 до 100. Выведите массив на экран.


//Random random = new Random();
//int[] numbers = new int[10] ;
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(1, 101);
//    Console.WriteLine(numbers[i]);
//}

//// task 2  Напишите программу, которая находит сумму всех элементов массива из задачи 1.
//int sum = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}
//Console.WriteLine($"Сумма: {sum}");

//// task 3  Напишите программу, которая находит максимальный и минимальный элементы массива из задачи 1.
//int max = numbers.Max();
//Console.WriteLine($"максимальный: {max}");

//int min = numbers.Min();
//Console.WriteLine($"минимальный: {min}");

//// task 4  Напишите программу, которая сортирует массив из задачи 1 по возрастанию и выводит его на экран.
//Array.Sort(numbers);
//Console.WriteLine(string.Join(", ", numbers));

//// task 5  Напишите программу, которая находит среднее арифметическое всех элементов массива из задачи 1.
//int arith_mean = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    arith_mean += numbers[i];
//}
//Console.WriteLine($"Среднее арифметическое: {arith_mean/10}");

//// task 6  Создайте двумерный массив 3x3 и заполните его случайными числами от 1 до 10. Выведите массив на экран.
//int[,] array = new int[3, 3];
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        array[i, j] = random.Next(1, 11);
//        Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//// task 7  Напишите программу, которая находит сумму всех элементов двумерного массива из задачи 1.
//sum = 0;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        sum+= array[i, j];
//    }
//}
//Console.WriteLine($"Сумма: {sum}");

//// task 8  Напишите программу, которая находит максимальный и минимальный элементы двумерного массива из задачи 1.
//max = 0;
//min = 100;

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        if  (array[i, j]>max)
//        {
//            max = array[i, j];
//        }
//        if (array[i, j] < min) 
//        {
//            min = array[i, j];
//        }
//    }
//}
//Console.WriteLine($"максимальный: {max}, минимальный: {min}");

//// task 9  Напишите программу, которая транспонирует двумерный массив из задачи 1 (меняет строки на столбцы) и выводит его на экран.
//for(int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {

//        Console.Write(array[j, i] + " ");
//    }
//    Console.WriteLine();
//}

//// task 10  Напишите программу, которая находит сумму элементов каждой строки двумерного массива из задачи 1.
//int sum1 = 0;
//int sum2 = 0;   
//int sum3 = 0;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        if (i==0)
//        {
//            sum1 += array[i, j];
//        }
//        if (i == 1)
//        {
//            sum2 += array[i, j];
//        }
//        if (i == 2)
//        {
//            sum3 += array[i, j];
//        }

//    }

//}
//Console.WriteLine($"Сумма первой строки: {sum1}, сумма второй строки: {sum2}, сумма третей строки: {sum3}");

//// task 11  Создайте ступенчатый массив из трех строк, где каждая строка содержит случайное количество элементов (от 1 до 5) и заполните их случайными числами от 1 до 10. Выведите массив на экран.
//int[][] ARray = new int[3][];
//for (int i = 0; i < ARray.Length; i++)
//{
//    int s = random.Next(1, 6);
//    ARray[i] = new int[s];
//    for (int j = 0; j < ARray[i].Length; j++)
//    {
//        ARray[i][j] = random.Next(1, 11);
//        Console.Write(ARray[i][j] + " ");
//    }
//    Console.WriteLine();
//}

//// task 12  Создайте трехмерный массив 2x2x2 и заполните его случайными числами от 1 до 10. Выведите массив на экран.
//Console.WriteLine("task 12: ");
//int[,,] arr = new int[2, 2, 2];
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        for (int k = 0; k < 2; k++)
//        {
//            arr[i, j, k] = random.Next(1, 11);
//            Console.Write(arr[i, j, k] + " ");
//        }
//    }
//    Console.WriteLine();
//}

//// task 13  Написать программу, которая будет вставлять число введённое пользователем по индексу в массив (число элементов в массиве должно стать больше)
//Console.WriteLine("Task 13: ");
//int[] number = new int[10];
//for (int i = 0; i < number.Length; i++)
//{
//    number[i] = random.Next(1, 10);
//    Console.Write(number[i]+ " ");
//}

//Console.WriteLine();

//int[] num = new int[number.Length + 1];
//Console.WriteLine("Введите число: ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите индекс: ");
//int index = int.Parse(Console.ReadLine());
//for ( int i = 0; i < num.Length; i++)
//{
//    if (i < index)
//    {
//        num[i] = number[i];
//    }
//    else if (i == index)
//    {
//        num[i] = n;
//    }
//    else
//    {
//        num[i] = number[i-1];
//    }

//}
//for (int i = 0; i < num.Length; i++)
//{
//    Console.Write(num[i] + " ");
//}


/* Задачи
     
     1. Чтение и вывод содержимого файла:
        Напишите программу, которая открывает текстовый файл, читает его содержимое и выводит его на экран.

     2.Запись строки в файл:
       Напишите программу, которая запрашивает у пользователя строку и записывает ее в текстовый файл. Если файл уже существует, его содержимое должно быть удалено.

    3. Добавление текста в файл:
       Напишите программу, которая запрашивает у пользователя строку и добавляет эту строку в конец текстового файла, 
       не удаляя его предыдущего содержимого.
    
    4. Подсчет строк в файле:
       Напишите программу, которая открывает текстовый файл и подсчитывает количество строк в нем.

    5. Копирование содержимого одного файла в другой:
       Напишите программу, которая читает содержимое одного текстового файла и записывает его в другой файл.
     */

// task 1  Напишите программу, которая открывает текстовый файл, читает его содержимое и выводит его на экран.
//string filePath = "Lesson_7.txt";
//File.Create(filePath).Close();
//string text = "Hello Anton";
//File.WriteAllText(filePath, text);
//string readText = File.ReadAllText(filePath);
//Console.WriteLine(readText);

//// task 2  Напишите программу, которая запрашивает у пользователя строку и записывает ее в текстовый файл. Если файл уже существует, его содержимое должно быть удалено.
//File.Delete(filePath);
//string text2 = Console.ReadLine();
//File.WriteAllText(filePath, text2);
//readText = File.ReadAllText(filePath);
//Console.WriteLine(readText);

//// task 3  Напишите программу, которая запрашивает у пользователя строку и добавляет эту строку в конец текстового файла, не удаляя его предыдущего содержимого.
//string text3 = Console.ReadLine();
//File.AppendAllText(filePath, text3);
//readText = File.ReadAllText(filePath);
//Console.WriteLine(readText);

//// task 5   Напишите программу, которая читает содержимое одного текстового файла и записывает его в другой файл.
//readText = File.ReadAllText(filePath);
//string filePath1 = "Lesson_7_1.txt";
//File.Create(filePath1).Close();
//File.WriteAllText(filePath, readText);
//readText = File.ReadAllText(filePath);
//Console.WriteLine(readText);


/* Задачи (без возврата)

1. Вывод приветствия:
   Напишите функцию, которая принимает имя пользователя и выводит на экран приветствие в формате: "Привет, [имя]!".

2. Вывод таблицы умножения:
   Напишите функцию, которая выводит таблицу умножения для числа, переданного в качестве параметра.

3. Вывод массива:
   Напишите функцию, которая принимает массив целых чисел и выводит его элементы на экран.

4. Вывод чисел от 1 до N:
   Напишите функцию, которая принимает число N и выводит все числа от 1 до N.

5. Вывод чётных чисел:
   Напишите функцию, которая принимает число N и выводит все чётные числа от 1 до N.

1. Сумма двух чисел:
   Напишите функцию, которая принимает два числа и возвращает их сумму.

2. Факториал числа:
   Напишите функцию, которая принимает число и возвращает его факториал.

3. Максимальное число в массиве:
   Напишите функцию, которая принимает массив целых чисел и возвращает максимальное число в массиве.

4. Минимальное число в массиве:
   Напишите функцию, которая принимает массив целых чисел и возвращает минимальное число в массиве.

5. Среднее арифметическое массива:
   Напишите функцию, которая принимает массив целых чисел и возвращает среднее арифметическое его элементов.
4. Подсчёт гласных в строке:
   Напишите функцию, которая принимает строку и возвращает количество гласных букв в ней.

5. Сортировка массива:
   Напишите функцию, которая принимает массив целых чисел и возвращает отсортированный массив (по возрастанию).
*/

// task 1 Напишите функцию, которая принимает имя пользователя и выводит на экран приветствие в формате: "Привет, [имя]!".
//using System.Runtime.ExceptionServices;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//static void Task1()
//{
//    string name = Console.ReadLine();
//    Console.WriteLine($"Привет, {name}!");
//}
//Task1();

//// task 2  Напишите функцию, которая выводит таблицу умножения для числа, переданного в качестве параметра.
//static void Task2(int num)
//{
//    int n = 0;
//    while (n<11)
//    {
//        Console.WriteLine(n * num);
//        n++;
//    }
//}
//Task2(int.Parse(Console.ReadLine()));

//// task 3  Напишите функцию, которая принимает массив целых чисел и выводит его элементы на экран.
//static void Task3(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i]+ " ");
//    }
//}
//Task3([1,2,3,4,5]);

//// task 4  Напишите функцию, которая принимает число N и выводит все числа от 1 до N.
//Console.WriteLine();
//static void Task4(int N)
//{
//    for (int i = 1;i <= N;i++)
//    {
//        Console.WriteLine(i);
//    }
//}
//Task4(int.Parse(Console.ReadLine()));

//// task 5  Напишите функцию, которая принимает число N и выводит все чётные числа от 1 до N.
//static void Task5(int N)
//{
//    for (int i = 2; i <= N; i+=2)
//    {
//        Console.WriteLine(i);
//    }
//}
//Task5(int.Parse(Console.ReadLine()));


//// task 6  Напишите функцию, которая принимает два числа и возвращает их сумму.
//Console.WriteLine("Task 6");
//static int Sum(int num1, int num2)
//{
//    int sum = 0;
//    sum = num1 + num2;
//    return sum;
//}
//int res = Sum(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

//Console.WriteLine(res);
//// task 7  Напишите функцию, которая принимает число и возвращает его факториал.
//static int Fac(int num)
//{
//    int fac = 1;
//    for (int i = 1; i <= num; i++)
//    {
//        fac *= i;
//    }
//    return fac;
//}
//res = Fac(int.Parse(Console.ReadLine()));
//Console.WriteLine(res);

//// task 8  Напишите функцию, которая принимает массив целых чисел и возвращает максимальное число в массиве. Напишите функцию, которая принимает массив целых чисел и возвращает минимальное число в массиве.
//Console.WriteLine("Task 8: ");
//static int Array1(int[] array)
//{
//    int max = array.Max();
//    return max;

//}
//res = Array1([1,2,3,4,5]);
//Console.WriteLine(res);
//static int Array2(int[] array)
//{
//    int min = array.Min();
//    return min;

//}
//res = Array2([1, 2, 3, 4, 5]);
//Console.WriteLine(res);

//// task 9  Напишите функцию, которая принимает массив целых чисел и возвращает среднее арифметическое его элементов.
//Console.WriteLine("Task 9: ");
//static int Arr(int[] array)
//{
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        sum += array[i];
//    }
//    return sum / array.Length;
//}
//res = Arr([1, 2, 3, 4, 5, 6]);
//Console.WriteLine(res);

//// task 10  Напишите функцию, которая принимает строку и возвращает количество гласных букв в ней.
//Console.WriteLine("Task 10:");
//static int Str(string str)
//{
//    char[] chars = ['a','e','y','u','i','o',];
//    int count = 0;
//    for (int i = 0;i < str.Length;i++)
//    {
//        if (chars.Contains(str[i]))
//        {
//            count++;
//        }
//    }
//    return count;
//}

//res = Str("Hello");
//Console.WriteLine(res);

//// task 11  Напишите функцию, которая принимает массив целых чисел и возвращает отсортированный массив (по возрастанию).
//Console.WriteLine("Task 11: ");
//static int[] Arra(int[] array)
//{
//    int n = 0;
//    for (int i = 1; i < array.Length; i++)
//    {
//        for (int j = 1; j < array.Length; j++)
//        {
//            n = array[j-1];
//            if (array[j] < array[j-1])
//            {
//                array[j-1] = array[j];
//                array[j] = n;
//            }
//            else
//            {
//                array[j] = array[j];
//                array[j-1] = n;
//            }
//        }
//    }
//    return array;
//}
//int[] rest = Arra([1, 7, 9, 4, 5, 3]);
//for (int i = 0; i < rest.Length; i++)
//{
//    Console.Write(rest[i] + " ");
//}

/* Задачи на перегрузку методов

1. Вывод приветствия:
   Напишите перегруженные методы, которые выводят приветствие в зависимости от количества переданных параметров: 
   - Если передано одно имя, выводит "Привет, [имя]!".
   - Если передано два имени, выводит "Привет, [имя1] и [имя2]!".

2. Вывод суммы чисел:
   Напишите перегруженные методы, которые выводят сумму двух, трёх или четырёх чисел в зависимости от количества переданных параметров.

3. Вывод информации о фигурах:
   Напишите перегруженные методы, которые выводят информацию о площади фигур (круг, прямоугольник, треугольник) в зависимости от переданных параметров (радиус, стороны и т.д.).
Задачи на params

1. Вывод всех переданных чисел:
   Напишите метод с `params`, который принимает переменное количество целых чисел и выводит их на экран.

2. Вывод суммы всех чисел:
   Напишите метод с `params`, который принимает переменное количество чисел и выводит их сумму.

3. Вывод чётных чисел:
   Напишите метод с `params`, который принимает переменное количество чисел и выводит только чётные из них.
*/

// task 1 Напишите перегруженные методы, которые выводят приветствие в зависимости от количества переданных параметров: 
//-Если передано одно имя, выводит "Привет, [имя]!".
//   - Если передано два имени, выводит "Привет, [имя1] и [имя2]!".
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Task 1: ");

//        Hel("Re");
//        Hel("Re", "Ter");
//        Console.WriteLine("Task 2: ");
//        Console.WriteLine( Sum(1, 2));
//        Console.WriteLine( Sum(1, 2, 3));
//        Console.WriteLine( Sum(1, 2, 3, 4));
//        Console.WriteLine("Task 3: ");
//        Console.WriteLine(S(2));
//        Console.WriteLine(S(1, 2));
//        Console.WriteLine(S(4.0, 2));
//        Console.WriteLine("Task 4: ");
//        Num(4, 2, 5);
//        Console.WriteLine("Task 5: ");
//        Console.WriteLine(Sum(1, 2, 3, 4, 5));
//        Console.WriteLine("Task 6: ");
//        Console.WriteLine(Vol(1, 2, 3, 4, 5));
//    }
//    static void Hel(string a)
//    {
//        Console.WriteLine($"Привет, {a}!");
//    }

//    static void Hel(string a, string b)
//    {
//        Console.WriteLine($"Привет, {a} и {b}!");
//    }

//    // task 2   Напишите перегруженные методы, которые выводят сумму двух, трёх или четырёх чисел в зависимости от количества переданных параметров.
//    public static int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    public static int Sum(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    public static int Sum(int a, int b, int c, int d)
//    {
//        return a + b + c + d;
//    }

//    // task 3 Напишите перегруженные методы, которые выводят информацию о площади фигур (круг, прямоугольник, треугольник) в зависимости от переданных параметров (радиус, стороны и т.д.).
//    public static double S(int a)
//    {
//        double pi = Math.PI;
//        return a*a*pi;
//    }

//    public static int S(int a, int b)
//    {
//        return a * b;
//    }
//    public static double S(double a, double b)
//    {
//        return (a*b*0.5);
//    }

//    // task 4  Напишите метод с `params`, который принимает переменное количество целых чисел и выводит их на экран.

//    public static void Num(params int[] numbers)
//    {
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.Write(numbers[i]+" ");
//        }
//    }

//    // task 5  Напишите метод с `params`, который принимает переменное количество чисел и выводит их сумму.

//    public static int Sum(params int[] numbers)
//    {
//        int sum = 0;
//        foreach (int num in numbers)
//        {
//            sum += num;
//        }
//        return sum;
//    }

//    // task 6  Напишите метод с `params`, который принимает переменное количество чисел и выводит только чётные из них.

//    public static int Vol(params int[] numbers)
//    {
//        int vol = 0;
//        foreach (int num in numbers)
//        {
//            if (num%2==0)
//            {
//                vol++;
//            }
//        }
//        return vol;
//    }

//}


/* Задачи для ref 

1. Обмен значений:
   Напишите функцию, которая принимает два числа по ссылке (ref) и меняет их значения местами.

2. Увеличение на процент:
   Напишите функцию, которая принимает число и процент по ссылке (ref), и увеличивает число на указанный процент.
Задачи для out 

1. Инициализация массива:
   Напишите функцию, которая принимает размер массива и переменную для массива по ссылке (out), и создаёт массив указанного размера.

2. Разделение строки:
   Напишите функцию, которая принимает строку и две переменные по ссылке (out), и разделяет строку на две части по первому пробелу.
Задачи для in 

1. Вывод массива:
   Напишите функцию, которая принимает массив по ссылке (in) и выводит его элементы на экран.

2. Подсчёт суммы элементов:
   Напишите функцию, которая принимает массив по ссылке (in) и возвращает сумму его элементов.
*/

// task 1  Напишите функцию, которая принимает два числа по ссылке (ref) и меняет их значения местами.
//Console.WriteLine("Task 1: ");
//static void Exc(ref int x, ref int y)
//{
//    int b = x;
//    x = y;
//    y = b;

//}

//int x = 10;
//int y = 12;

//Exc(ref x, ref y);

//Console.WriteLine($"x: {x}, y: {y}");

//// task 2  Напишите функцию, которая принимает число и процент по ссылке (ref), и увеличивает число на указанный процент.
//Console.WriteLine("Task 2: ");
//static void Per(ref int num,  int per)
//{
//    int a = num * per / 100 + num;
//    num = a;
//}

//int num = 10;
//int per = 200;

//Per(ref num,  per);

//Console.WriteLine($"{num}");

//// task 3  Напишите функцию, которая принимает размер массива и переменную для массива по ссылке (out), и создаёт массив указанного размера.
//Console.WriteLine("Task 3: ");
//static void Arr(int size, out int[] arr)
//{
//    arr = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//        arr[i] = i;
//    }
//}
//int size = 5;
//int[] arr;
//Arr(size, out arr);

//for  (int i = 0; i<arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine();

//// task 4  Напишите функцию, которая принимает строку и две переменные по ссылке (out), и разделяет строку на две части по первому пробелу.
//Console.WriteLine("Task 4: ");
//static void F(string str, out string str1, out string str2)
//{
//    string s1 = "";
//    string s2 = "";
//    char[] chars = [' '];
//        int f = 0;
//        for (int i = 0; i < str.Length; i++)
//        {
//            if (f == 0)
//            {
//                for (int j = i; j <= i; j++)
//                {
//                    s1 += str[i];
//                }
//            }
//            if (chars.Contains(str[i]))
//            {
//                f = 1;
//            }
//            if (f==1)
//            {
//                for (int j = i; j <= i; j++)
//                {
//                    s2 += str[i];
//                }
//            }
//        }
//    str1 = s1;
//    str2 = s2;
//}
//string str = "Hello world!";
//string str1;
//string str2;
//F(str, out str1, out str2);
//Console.WriteLine($"{str1},{str2}");

//// task 5  Напишите функцию, которая принимает массив по ссылке (in) и выводит его элементы на экран.
//Console.WriteLine("Task 5: ");
//static void Array(in int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
//}
//int[] array = { 1, 2, 3 };
//Array(in array);

//// task 6   Напишите функцию, которая принимает массив по ссылке (in) и возвращает сумму его элементов.
//Console.WriteLine("Task 6: ");

//static int Arra(in int[] arra)
//{
//    int sum = 0;
//    for (int i = 0; i < arra.Length; i++)
//    {
//        sum+=arra[i];
//    }
//    return sum;
//}
//int[] arra = { 1, 2, 3 };
//var ans = Arra(in arra);
//Console.WriteLine(ans);


/* Задачи для практики (первые 10 - простые, последние 4 - с WHERE):

1. Метод вывода массива:
   Напишите обобщённый метод, который принимает массив любого типа и выводит его элементы через запятую.

2. Обмен значений:
   Напишите обобщённый метод, который меняет местами два значения любого типа.
*/
// task 1  Напишите обобщённый метод, который принимает массив любого типа и выводит его элементы через запятую.
//using System.Drawing;

//Console.WriteLine("Task 1: ");
//static void Arr<T>(T[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write(arr[i]+", ");
//    }
//}
//int[] arr = { 1, 2, 3 };
//Arr(arr);
//Console.WriteLine();

//// task 2  Напишите обобщённый метод, который меняет местами два значения любого типа.
//Console.WriteLine("Task 2: ");
//static void Num<T>(ref T num1, ref T num2)
//{
//    T num = num1;
//    num1 = num2;
//    num2 = num;
//}
//int num1 = 3;
//int  num2 = 4;
//Num(ref num1,ref num2);
//Console.WriteLine($"num1: {num1},num2: {num2}");

/* Задачи для отработки оператора switch

1. Определить, является ли введенная буква гласной или согласной, используя when.
2. Определить, является ли число четным, нечетным или нулем, используя when.
3. Вывести название месяца по его номеру.
*/
// task 1  Определить, является ли введенная буква гласной или согласной, используя when.
//static string Let(char letter)
//{
//    return letter switch
//    {
//        char c when "aeyuio".Contains(c) => "Гласная буква",
//        char c when "qwrtpsdfghjklzxcvbnm".Contains(c) => "Согласная буква",
//        _ => "Неизвестный символ"
//    };
//}
//Console.WriteLine(Let('g'));

//// task 2  Определить, является ли число четным, нечетным или нулем, используя when.
//static string Par(int num)
//{
//    return num switch
//    {
//        int m when m == 0 => "This is 0",
//        int m when m %2==0  => "Yes",
//        int m when m % 2 == 1 => "No",
//        _ => "Некорректный месяц"
//    };
//}
//Console.WriteLine(Par(0)) ;

//// task 3  Вывести название месяца по его номеру.

//static string Month(int month)
//{
//    switch (month)
//    {
//        case 1: return "Январь";
//        case 2: return "Фебраль";
//        case 3: return "Март";
//        case 4: return "Апрель";
//        case 5: return "Май";
//        case 6: return "Июнь";
//        case 7: return "Июль";
//        case 8: return "Август";
//        case 9: return "Сентябрь";
//        case 10: return "Оетябрь";
//        case 11: return "Ноябрь";
//        case 12 : return "Декабрь";
//        default: return "Некорректный номер дня";
//    }
//}
//Console.WriteLine(Month(9));

// task 1 Проверить, является ли строка номером телефона в формате "+7(XXX)XXX-XX-XX".

//using System.Text.RegularExpressions;

//Console.WriteLine("Введите номер телефона: ");
//string number = "+7(930)087-53-00";
//string num = @"^\+7\((\d{3})\)\d{3}-\d{2}-\d{2}$";
//bool n = Regex.IsMatch(number, num);
//Console.WriteLine(n ? "Корректный номер телефона" : "Некорректный номер телефона");

/* Задачи:

    1. Напишите программу, которая запрашивает у пользователя два числа и делит первое на второе. Обработайте `DivideByZeroException`.
    2. Реализуйте метод, который открывает файл и считывает его содержимое. Обработайте `FileNotFoundException`.
    3. Напишите метод, который просит ввести число и проверяет, является ли оно положительным. Если нет, выбросите `ArgumentException`.
*/

// task 1  Напишите программу, которая запрашивает у пользователя два числа и делит первое на второе. Обработайте `DivideByZeroException`.
//Console.WriteLine("Task 1: ");
//static void Null(int x, int y)
//{
//    try
//    {
//                Console.WriteLine(x / y);
//    }
//    catch(DivideByZeroException)
//    {
//        Console.WriteLine("Делить на 0 нельзя!"); 
//    }
//}
//int x = 10;
//int y = 0;
//Null(x, y);


//// task 2  Реализуйте метод, который открывает файл и считывает его содержимое. Обработайте `FileNotFoundException`.Console.WriteLine("Task 2: ");
//Console.WriteLine("Task 2: ");
//static void Fil()
//{
//    try
//    {
//        string filePath1 = "wefds";
//        string readText = File.ReadAllText(filePath1);
//        File.Create(filePath1).Close();
//        File.WriteAllText(filePath1, readText);
//    }
//    catch (FileNotFoundException)
//    {
//        Console.WriteLine("Ошибка: Файл не найден.");
//    }
//}
//Fil();

//// task 3  Напишите метод, который просит ввести число и проверяет, является ли оно положительным. Если нет, выбросите `ArgumentException`.
//Console.WriteLine("Task 3: ");
//static void Num(int num)
//{
//    if (num>0)
//    {
//        Console.WriteLine("Ok");
//    }
//    else
//    {
//        throw new ArgumentException("Число отрицательное!");
//    }
//}
//int num = int.Parse(Console.ReadLine());
//Num(num);


/* Задания на практику:

    1. Создайте перечисление `Seasons` с элементами: `Winter`, `Spring`, `Summer`, `Autumn`.
    2. Напишите метод, который принимает `Seasons` и выводит пример месяца (например, `Winter → Декабрь`).
    3. Реализуйте перечисление `HttpStatusCode` с популярными кодами (например, `OK = 200`, `NotFound = 404`).
       Напишите метод, который принимает `HttpStatusCode` и возвращает его текстовое описание.
*/

// task 1 - 2  Создайте перечисление `Seasons` с элементами: `Winter`, `Spring`, `Summer`, `Autumn`.
//Console.Write("\nВведите месяц (1-4): ");
//static void Season(int Month)
//{
//    Month--;
//    if (Enum.IsDefined(typeof(Seasons), Month))
//    {
//        Seasons day = (Seasons)Month;

//        switch (day)
//        {
//            case Seasons.Winter:
//                Console.WriteLine("Декабрь");
//                break;
//            case Seasons.Spring:
//                Console.WriteLine("Март");
//                break;
//            case Seasons.Summer:
//                Console.WriteLine("Август");
//                break;
//            case Seasons.Autumn:
//                Console.WriteLine("Ноябрь");
//                break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Некорректный день месяца.");
//    }
//}
//int Month = int.Parse(Console.ReadLine());
//Season(Month);


//// task 3    Реализуйте перечисление `HttpStatusCode` с популярными кодами (например, `OK = 200`, `NotFound = 404`).
////Напишите метод, который принимает `HttpStatusCode` и возвращает его текстовое описание.
//Console.WriteLine("task 2: ");
//Console.Write("\nВведите ошибку:  ");
//static void StatusCode(string Error)
//{
//    if (Enum.TryParse(Error, true, out HttpStatusCode statusCode))
//    {

//        switch (statusCode)
//        {
//            case HttpStatusCode.OK:
//                Console.WriteLine("ошибка: 200");
//                break;
//            case HttpStatusCode.NotFound:
//                Console.WriteLine("ошибка: 404");
//                break;
//            case HttpStatusCode.Created:
//                Console.WriteLine("ошибка: 201");
//                break;
//            case HttpStatusCode.Accepted:
//                Console.WriteLine("ошибка: 202");
//                break;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Некорректная ошибка.");
//    }
//}
//string Error = Console.ReadLine();
//StatusCode(Error);

//enum HttpStatusCode
//{
//    OK = 200,
//    NotFound =404,
//    Created = 201,
//    Accepted = 202
//}
//enum Seasons
//{
//    Winter,
//    Spring,
//    Summer,
//    Autumn

//}

/* Задача
     Сделай поле возраста по умолчанию = 0. После каждой 10-й игры увеличивай поле на 1.
     */


/* Творческое задание

 Создай класс человека - придумай что он будет делать и какие поля у него будут. Реализуй)
 */



class Pet
{
    public string petName; 
    public int petAge;
    public int PetVolPlay;
    public void Play(string petName, ref int PetVolPlay)
    {
        PetVolPlay++;
        Console.WriteLine($"{petName} играет!");
    }

    public void GettingOld(ref int petAge, string petName, ref int PetVolPlay)
    {
        Console.WriteLine(PetVolPlay);
        petAge = PetVolPlay / 10;
        Console.WriteLine($"{petName} постарел. Теперь ему {petAge}");

    }
}
class People
{
    public int PetHunger;
    public void Hunger(ref int PetHunger)
    {
        PetHunger += 20;
        if (PetHunger <= 100)
        {
            Console.WriteLine($"Человек дал вкусняшку, питомец сытен на: {PetHunger}%!");
        }
        else if (PetHunger<141 && PetHunger>100)
        {
            Console.WriteLine($"Питомец объелся!питомец пересытен на: {PetHunger - 100}%!");
        }
        else
        {
            Console.WriteLine($"Питомец умер из-за переедания!");

        }
        
    }
}
internal class Program
{
     public static void Main()
     {
        Pet pet = new Pet();
        People people = new People();
        pet.petName = "Бобик";
        pet.petAge = 0;
        pet.PetVolPlay = 0;
        people.PetHunger = 0;

        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        pet.Play(pet.petName, ref pet.PetVolPlay);
        people.Hunger(ref people.PetHunger);
        people.Hunger(ref people.PetHunger);
        people.Hunger(ref people.PetHunger);
        people.Hunger(ref people.PetHunger);
        people.Hunger(ref people.PetHunger);
        people.Hunger(ref people.PetHunger);
        people.Hunger(ref people.PetHunger);
        people.Hunger(ref people.PetHunger);
        pet.GettingOld(ref pet.petAge, pet.petName, ref pet.PetVolPlay);
    }
}   

