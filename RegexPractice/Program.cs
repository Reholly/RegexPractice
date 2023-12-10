using System.Text.RegularExpressions;

// Пояснение регулярного выражения @"^\d*\D+\d+$" :
// В начале >=0 символов цифр (\d*),
// потом >= 1 не цифр (\D+),
// потом >=1 цифровых символов (\d+),
// затем строка закончится ($).

Regex matchRegex = new Regex(@"^\d*\D+\d+$");

// Методы регулярных выражений.

// IsMatch() - проверяет соответствие строки некоторому регулярному выражению.
// Используется часто для валидации вводимых данных. 
Console.WriteLine(matchRegex.IsMatch("1235678901")); //Вернёт false
Console.WriteLine(matchRegex.IsMatch("abcdf12345")); // Вернет true


// Regex.Replace() - меняет в исходной строке (1-ый аргумент) всю соответствующую
// регулярному выражению часть (2-ой аргумент) на подстроку (3-й аргумент)

string input = "12abc1d9adc";
string pattern = @"\d+"; // Шаблон любой подстроки из цифр, где их >=1
string replacement = "";
Console.WriteLine(Regex.Replace(input, pattern, replacement)); //Выведет строку abcdadc


//Обработка дат с помощью Replace

string inputDate = "13/12/23";

// В данном регулярном выражении мы заводим так сказать переменные через ?<> и делаем шаблоны с цифрами
// Так шаблон будет соответствовать формату даты день/месяц/год, где день и месяц могут быть 1-2 цифры, а год 2-4.
string datePattern = @"(?<day>\d{1,2})/(?<month>\d{1,2})/(?<year>\d{2,4})";
string dateReplacement = "${day}-${month}-${year}";

Console.WriteLine(Regex.Replace(inputDate, datePattern, dateReplacement));



