//Напишите программу, 
//которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа.

//abc = a*10^2 + b*10^1 + c*10^0
//    = a*100 + b*10 + c
// ac = a * 10 + c;

int value = 123;
int a = value / 100; // 5 div - /
int c = value % 10;  // 7 mod - %

int result = a * 10 + c;

Console.WriteLine(result); 
