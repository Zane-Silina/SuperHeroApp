// See https://aka.ms/new-console-template for more information

string heroName = "Flow";
int heroAge = 31;
string power = "intelligence";
string weakness = "cynicism";
Console.WriteLine(" ");
Console.WriteLine("-----------General info-------------");
Console.WriteLine(" ");
Console.WriteLine($"Hero Name: {heroName}");
Console.WriteLine($"Age: {heroAge}");
Console.WriteLine($"Super power: {power}");
Console.WriteLine($"Weakness: {weakness}");
Console.WriteLine(" ");
Console.WriteLine("-----------Financial info----------");
Console.WriteLine(" ");
/*
string heroName2 = "Krit";
int heroAge2 = 47;
string power2 = "martial arts";
string weakness2 = "impatience";

Console.WriteLine($"Hero Name: {heroName2}");
Console.WriteLine($"Age: {heroAge2}");
Console.WriteLine($"Super power: {power2}");
Console.WriteLine($"Weakness: {weakness2}");
Console.WriteLine("------------------------");

/*  Continue working on Hero Card view
                - Add new variables - deedTimeInHours1, deedTimeInHours2, deedTimeInHours3 (INT), holding time that a deed took to complete
                 - Add methods to calculate:
                - Total time spent on deeds
                - Average time spent on one deed
                - How many cookies Hero will get. 5 cookies per hour 
- Add boughtCookies calculation
-- isEvil or not
-- monthlySalary */

int deedTimeInHours1, deedTimeInHours2, deedTimeInHours3;

deedTimeInHours1 = 5;
deedTimeInHours2 = 15;
deedTimeInHours3 = 4;
double rewardMoney = (deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3) * 5;
int totalTime = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
int averageTime = (deedTimeInHours3 + deedTimeInHours2 + deedTimeInHours3) / 3;
Console.WriteLine($"Total time {heroName} worked on deeds: {totalTime}h.");
Console.WriteLine($"Average time {heroName} worked on deeds: {averageTime}h.");
Console.WriteLine($"{heroName} earned {rewardMoney} cookies.");

float cookiePrice = 3.50f;
double salary = 1500;
bool isEavil = false;
double dailySalary = salary / 30;
double boughtCookies = Math.Floor(salary / cookiePrice);

Console.WriteLine($"{heroName}'s salary is {salary}.");
Console.WriteLine($"{heroName} earns {dailySalary} per day.");
Console.WriteLine($"{heroName} can buy {boughtCookies} cookies.");
//Console.WriteLine($"{heroName} can ")


