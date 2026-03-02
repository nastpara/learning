
/*
    # Пользователь вводит два числа, нужно найти их сумму
    # Пользователь вводит число, поделить это число на 5 без остатка
    # Пользователь вводит число, найти остаток от деления 100 на это число
    # Записать данные из задач 1-3 и красиво вывести их через f-строку в консоль
    # Пользователь вводит возраст. Вывести True, если чему больше 18, иначе False
 */


// Задача 1
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = num1 + num2;
Console.WriteLine(num3);
//task 2
int num4 = num1 / 5;
Console.WriteLine(num4);
//Task 3
int num5 = num2 %100;
Console.WriteLine(num5);
//Task 4
Console.WriteLine($"Сложение: {num3} , Деление на 5: {num4}, Остаток от деления на 100: {num5}");
// Task 5
int age = int.Parse(Console.ReadLine());
bool age1 = age > 18;
Console.WriteLine(age1);