// Напишите программу, которая на вход принимает трёхзначное число и удаляет вторую цыфру
// этого числа при выводе
// a = 256 => 26
// b = 891 => 81

System.Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >99 && number <1000)
{
    // int leftDigit = number/100;
    // int rightDigit = number % 10;
    System.Console.WriteLine(number/100 +""+number%10);

}
else
{
System.Console.WriteLine("Введено не трёхзначное число");
}
