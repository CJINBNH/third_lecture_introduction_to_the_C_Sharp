// 4 вида методов (функций)
// 1-я группа методов - ничего не принимает и ничего не возвращает

// void Method1()
// {
//     System.Console.WriteLine("");
// }
// вызвать метод
// Method1();

// 2-я группа методов - принимает аргументы, но также ничего не возвращает

// void Method2 (string msg)
// {
//     Console.WriteLine(msg);
// }
//Method2(msg: "Текст сообщения");

// void Method21 (string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         i++;
//     }
// }
// Method21("Текст сообщения", 4);
// Method21(count: 4, msg: "Текст сообщения");

// 3-я группа методов что-то возвращают, но ничего не принимают 

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// 4-я группа методов - принимают и возвращают данные

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(2, "Нана_на_нана");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(2, "Нана_на_нана Life is Life");
Console.WriteLine(res);