﻿Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
if (numText.Length > 2)
{
  Console.WriteLine("цифра " + numText[2]);
}
else 
{
  Console.WriteLine("цифры нет");
}