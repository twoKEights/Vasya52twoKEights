﻿//Типы данных в С#
string variable_string = "Это строка";
int variable_int = 12;
double variable_double = 24.5;
bool variable_bool = true;
char variable_char = 'a';
char variable_char2 = 'b';

//Консольный вывод

Console.WriteLine("Тип данных = строчка " + variable_string);
Console.WriteLine("Тип данных = целочисленный " + variable_int);
Console.WriteLine("Тип данных = дробный " + variable_double);
Console.WriteLine("Тип данных = логический " + variable_bool);
Console.WriteLine("Тип данных = символьный " + variable_char);

//сложение двух переменных в консоли

Console.WriteLine(variable_int + variable_double);

//консольный ввод и ковнертация для него

Console.WriteLine("Введите переменную типа int: ");
int xInt;
xInt = Int32.Parse(Console.ReadLine());
Console.WriteLine(xInt + " -ваше значение.");

Console.WriteLine("Введите строчку;");
string xString;
xString = Console.ReadLine();
Console.WriteLine(xString + " - ваше значение.");

Console.WriteLine("Введите переменную типа double: ");
double xDouble;
xDouble = Double.Parse(Console.ReadLine());
Console.WriteLine(xDouble + " - ваше значение.");

Console.WriteLine("Введети переменную типа char:");
char xChar;
xChar = Char.Parse(Console.ReadLine());
Console.WriteLine(xChar + " - ваше значение");

Console.WriteLine("Введети переменную типа bool:");
bool xBool;
xBool = Boolean.Parse(Console.ReadLine());
Console.WriteLine(xBool + " - ваше значение");

// бла бла бла бла раз два три 4 5 это очень важный комментарий для нашв рабарь





























































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































