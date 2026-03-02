
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
Console.Write("Введите количество строк: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Task 1");
for (int i = 0; i<n1; i++)
{
    Console.WriteLine("I love you");
}

// Выведите на экран прямоугольник из нулей. Количество строк вводит пользователь, количество столбцов равно n.

Console.Write("Введите количество строк: ");
int n2_1 = int.Parse(Console.ReadLine());
int n2_2 = int.Parse(Console.ReadLine());
for (int i = 0; i < n2_1; i++)
{
    for (int j = 1; j < n2_2; j++)
    {
        Console.Write('0');
    }
    Console.WriteLine('0');
}

//// task 3   Вывести на экран числа от 1000 до 9999 такие, что среди цифр есть цифра 3.
//for (int i = 1000; i < 9999; i++)
//{
//    if (i / 1000 == 3 || i /10 % 10 == 3 || i /10 %10 == 3 || i %1000==3)
//    {
//        Console.WriteLine(i);
//    }
//}

// task 4  Выведите на экран строки вида:
//*******
//****
//*******
//****
//*******
//****
//(всего n строк, звездочек или 7, или 4 по очереди)
int n4 = int.Parse(Console.ReadLine());
for (int i = 0; i<n4; i++)
{
    if (i % 2 == 1)
        Console.WriteLine("****"); 
    else
        Console.WriteLine("*******");
}

// task 5 Вывести на экран: 
//AAABBBAAABBBAAABBB
//BBBAAABBBAAABBBAAA
//AAABBBAAABBBAAABBB
//    (таких строк n, в каждой строке m троек AAA)
int n5 = int.Parse(Console.ReadLine());
int m5 = int.Parse(Console.ReadLine());
string s1 = "AAABBB";
string s2 = "BBBAAA";
string s = "";
for (int i = 0;i<n5; i++)
{
    if (i % 2 == 0)
    {
        for (int j = 1; j < m5 + 1; j++)
        {
            s += s1;
        }
    }
    if (i % 2 == 1)
    {
        for (int k = 1; k < m5 + 1; k++)
        {
            s += s2;
        }
    }
    Console.WriteLine(s);
    s = "";
}

// task 6  Вывести на экран все числа от 1 до n, которые являются степенью числа 23.
int n6  = int.Parse(Console.ReadLine());
int num = 1;
Console.WriteLine(1);
for (int i = 1; i<n6; i++)
{
    if (num*23 == i && i%23==0)
    {
        num = num*23;
        Console.WriteLine(num);
    }
}