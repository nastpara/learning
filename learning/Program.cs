
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