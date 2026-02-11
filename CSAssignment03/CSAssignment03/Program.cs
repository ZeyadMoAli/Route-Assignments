
#region Q1

// this code is unefficient because it use string so it will create 5000 object for every append

using System.Diagnostics;
using System.Text;

Stopwatch sw = new Stopwatch();

sw.Start();
string productList2 = "";
for (int i = 1; i <= 5000; i++)
{
    productList2 += "PROD-" + i + ",";
}
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

sw.Restart();
var productLise = new StringBuilder();
for (int i = 0; i <= 5000; i++)
{
    productLise.Append("PROD");
    productLise.Append(i);
    productLise.Append(",");
}
string productList = productLise.ToString();
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);

#endregion

#region Q2
Console.WriteLine("Enter Age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Day of Week");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Student or Not");
bool isStudent = Convert.ToBoolean(Console.ReadLine());

double price = 0;
if (age < 5)
{
    price = 0;
}
else if (age <= 12)
{
    price = 30;
}
else if (age <= 59)
{
    price = 50;
}
else
{
    price = 25;
}

if ((dayOfWeek == 7 || dayOfWeek == 6) && price > 0)
{
    price += 10;
}

if (price > 0 && isStudent)
{
    double discount = price * 0.20;
    price -= discount;
}

#endregion

#region Q3
string fileExtension = ".pdf";
string fileType;

switch (fileExtension)
{
    case ".pdf":
        fileType = "PDF Document";
        break;
    case  ".docx" :
    case  ".doc":
        fileType = "Word Document";
        break;
    case ".xlsx":
    case ".xls":
        fileType = "Excel Spreadsheet";
        break;
    case ".jpg":
    case ".png":
    case ".gif":
        fileType = "Image File";
        break;
    default:
        fileType = "Unknown File Type";
        break;
}



#endregion

#region Q4

int temperature = 35;
string weatherAdvice;

weatherAdvice = temperature < 0 ? "Freezing! Stay indoors." :
    temperature < 15 ? "Cold. Wear a jacket." :
    temperature < 25 ? "Pleasant weather." :
    temperature < 35 ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure.";

#endregion

#region Q5
const int MAX_ATTEMPTS = 5;
int attempts = 0;
bool isValidPassword;

do
{
    Console.Write("Enter password: ");
    string password = Console.ReadLine();
    attempts++;

    bool hasUpper = false;
    bool hasDigit = false;
    bool hasSpace = false;

    foreach (char c in password)
    {
        if (char.IsUpper(c))
            hasUpper = true;
        else if (char.IsDigit(c))
            hasDigit = true;
        else if (char.IsWhiteSpace(c))
            hasSpace = true;
    }

    isValidPassword =
        password.Length >= 8 &&
        hasUpper &&
        hasDigit &&
        !hasSpace;

    if (!isValidPassword)
    {
        Console.WriteLine("Invalid password:");

        if (password.Length < 8)
            Console.WriteLine("- Must be at least 8 characters");

        if (!hasUpper)
            Console.WriteLine("- Must contain at least one uppercase letter");

        if (!hasDigit)
            Console.WriteLine("- Must contain at least one digit");

        if (hasSpace)
            Console.WriteLine("- Must not contain spaces");

        Console.WriteLine($"Attempts left: {MAX_ATTEMPTS - attempts}\n");
    }
    else
    {
        Console.WriteLine("Password accepted!");
        return;
    }

} while (attempts < MAX_ATTEMPTS);

Console.WriteLine("Account locked");


#endregion


#region Q6

int[] scores = { 95, 82, 47, 60, 38, 77, 90, 55, 100, 42 };

Console.WriteLine("Failing scores:");
foreach (int score in scores)
{
    if (score < 50)
        Console.WriteLine(score);
}

foreach (int score in scores)
{
    if (score > 90)
    {
        Console.WriteLine($"First score above 90: {score}");
        break;
    }
}

int sum = 0;
int count = 0;

foreach (int score in scores)
{
    if (score >= 40)
    {
        sum += score;
        count++;
    }
}

double average = count > 0 ? (double)sum / count : 0;
Console.WriteLine($"Class average (excluding absent): {average:F2}");

int A = 0, B = 0, C = 0, D = 0, F = 0;

foreach (int score in scores)
{
    if (score >= 90)
        A++;
    else if (score >= 80)
        B++;
    else if (score >= 70)
        C++;
    else if (score >= 60)
        D++;
    else
        F++;
}

Console.WriteLine("\nGrade distribution:");
Console.WriteLine($"A (90–100): {A}");
Console.WriteLine($"B (80–89): {B}");
Console.WriteLine($"C (70–79): {C}");
Console.WriteLine($"D (60–69): {D}");
Console.WriteLine($"F (Below 60): {F}");


#endregion