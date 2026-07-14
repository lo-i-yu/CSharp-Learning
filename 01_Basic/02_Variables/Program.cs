// 02_Variables
// C# 變數與資料型別練習

using System;

Console.WriteLine("=== C# 變數與資料型別練習 ===");
Console.WriteLine();

// 1. 宣告基本變數
string name = "小明";
int age = 25;
double height = 175.5;
bool isStudent = true;
char level = 'A';

// 2. 輸出變數內容
Console.WriteLine("姓名：" + name);
Console.WriteLine("年齡：" + age);
Console.WriteLine("身高：" + height);
Console.WriteLine("是否為學生：" + isStudent);
Console.WriteLine("等級：" + level);

Console.WriteLine();
Console.WriteLine("=== 使用者輸入練習 ===");

// 3. 讓使用者輸入姓名
Console.Write("請輸入你的姓名：");
string userName = Console.ReadLine();

// 4. 讓使用者輸入年齡
Console.Write("請輸入你的年齡：");
int userAge = Convert.ToInt32(Console.ReadLine());

// 5. 讓使用者輸入身高
Console.Write("請輸入你的身高：");
double userHeight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("=== 輸入結果 ===");
Console.WriteLine("你的姓名是：" + userName);
Console.WriteLine("你的年齡是：" + userAge);
Console.WriteLine("你的身高是：" + userHeight);

Console.WriteLine();
Console.WriteLine("=== 簡單計算 ===");

// 6. 使用變數做計算
int nextYearAge = userAge + 1;

Console.WriteLine("明年你會是：" + nextYearAge + " 歲");

Console.WriteLine();
Console.WriteLine("程式執行結束，請按任意鍵關閉...");
Console.ReadKey();
Console.WriteLine();
Console.WriteLine("=== BMI ===");

Console.Write("請輸入你的體重：");
double heightMeter = Convert.ToDouble(Console.ReadLine());


double userHeight2 = userHeight / 100;
double bmi = heightMeter / (userHeight2 * userHeight2);

Console.WriteLine("假設體重是 60 公斤");
Console.WriteLine("你的 BMI 約為：" + bmi);