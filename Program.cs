/* 
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Enter a number 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number 2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a number 3");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3){
    Console.WriteLine($"Number {number1} more than number {number2} and more than number {number3}");
}
else if (number2 > number1 && number2 > number3){
    Console.WriteLine($"Number {number2} more than number {number1} and more than number {number3}");
}
else 
Console.WriteLine($"Number {number3} more than number {number1} and more than number {number2}");
