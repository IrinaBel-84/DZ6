//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("введите числа ");
string s = Console.ReadLine();


string [] nums = s.Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);   
int[] n= nums.Select(Int32.Parse).ToArray();  
foreach (var item in nums)
{
    Console.WriteLine(item);
}
int a=0;
for (int i = 0; i < n.Length; i++)
{
    if (n[i]>0) a+=1;
}
Console.WriteLine($"колличество чисел больше 0 = {a}");
 
 
