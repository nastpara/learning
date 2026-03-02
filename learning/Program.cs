
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
var tuple = (6, "kao", 4, 15);

// task 2  Напишите программу, который принимает кортеж из двух элементов (строки) и возвращает их конкатенацию.
string str1 = Console.ReadLine();
string str2 = Console.ReadLine();
var str = (str1, str2) ;
Console.WriteLine($"{str.Item1}, {str.Item2}");

// task 3  Создайте кортеж, содержащий два вложенных кортежа. Доступ к элементам вложенных кортежей.

var tuple3 = ((2, 3), (4, 5), (6, 7));

// task 4  Напишите программу, которая выводит текущую дату и время в формате "dd.MM.yyyy HH:mm:ss".
DateTime now = DateTime.Now;
Console.WriteLine(now);

// task 5  Напишите программу, которая запрашивает у пользователя дату рождения и вычисляет его возраст.
var now5 = DateOnly.FromDateTime(DateTime.Now);
int def = 0;
Console.WriteLine(now5);
Console.Write("Введите день: ");
int day = int.Parse(Console.ReadLine());
Console.Write("Введите месяц: ");
int month = int.Parse(Console.ReadLine());
Console.Write("Введите год: ");
int year = int.Parse(Console.ReadLine());
var birth = (day, month, year);
if (now5.Month-birth.Item2<0)
{
    def = now5.Year-birth.Item3-1;
}
else if (now5.Month - birth.Item2 == 0)
{
    if (now5.Day - birth.Item1<0)
        def = now5.Year - birth.Item3 - 1;
}
else
{
    def = now5.Year - birth.Item3;
}
Console.WriteLine(def);

// task 6  Напишите программу, которая вычисляет количество дней до нового года.
DateTime NY = new DateTime(2027, 1, 1);
TimeSpan difference = NY - now;
Console.WriteLine($"Всего дней: {difference.Days}");

// task 7  Напишите программу, которая рандомно генерирует два числа и вычисляет их среднее арифметическое.
Random random = new Random();
int num1 = random.Next(0, 10);
int num2 = random.Next(0, 10);
Console.WriteLine($"{num1}, {num2}");
Console.WriteLine((num1+num2)/2);

// task 8  Напишите программу, которая рандомно генерирует радиус круга и вычисляет его площадь.
int R = random.Next(0, 10);
Console.WriteLine(R);
double pi = Math.PI;
Console.WriteLine(pi*R*R);