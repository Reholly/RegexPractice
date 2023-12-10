using System.Text.RegularExpressions;

/* Пояснение регулярного выражения ^\d*\D+\d+$
 * В начале >=0 символов цифр (\d*),
 * потом >= 1 не цифр (\D+),
 * потом >=1 цифровых символов (\d+),
 * затем строка закончится ($).
 */

Regex matchRegex = new Regex(@"^\d*\D+\d+$");

//Методы регулярных выражений. IsMatch()

Console.WriteLine(matchRegex.IsMatch("1235678901")); //Вернёт false
Console.WriteLine(matchRegex.IsMatch("abcdf12345")); // Вернет true

