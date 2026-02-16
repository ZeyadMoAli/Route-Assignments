
#region q1

Console.Write("Enter day number (0-6): ");
int number = int.Parse(Console.ReadLine());

DayOfWeek day = (DayOfWeek)number;

Console.WriteLine($"Day is: {day}");

switch (day)
{
    case DayOfWeek.Saturday:
    case DayOfWeek.Friday:
        Console.WriteLine("Weekend");
        break;

    default:
        Console.WriteLine("Workday");
        break;
}


#endregion


#region Q2

Console.Write("Enter array size: ");
int size;

while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
{
    Console.Write("Invalid size. Enter a positive integer: ");
}

int[] numbers = new int[size];

for (int i = 0; i < size; i++)
{
    while (true)
    {
        Console.Write($"Enter element {i + 1}: ");

        if (int.TryParse(Console.ReadLine(), out numbers[i]))
            break;

        Console.WriteLine("Invalid number, please try again.");
    }
}

    int sum = 0;
    int max = numbers[0];
    int min = numbers[0];

        for (int i = 0; i < size; i++)
        {
            sum += numbers[i];

            if (numbers[i] > max)
                max = numbers[i];

            if (numbers[i] < min)
                min = numbers[i];
        }

    double average = (double)sum / size;

    Console.WriteLine("\nResults:");
    Console.WriteLine($"Sum = {sum}");
    Console.WriteLine($"Average = {average:F2}");
    Console.WriteLine($"Maximum = {max}");
    Console.WriteLine($"Minimum = {min}");

    Console.WriteLine("Array in reverse order:");
        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }

#endregion

#region Q3

const int students = 3;
const int subjects = 4;

int[,] grades = new int[students, subjects];

for (int i = 0; i < students; i++)
{
    Console.WriteLine($"\nEntering grades for Student {i + 1}:");

    for (int j = 0; j < subjects; j++)
    {
        while (true)
        {
            Console.Write($"Subject {j + 1}: ");
            if (int.TryParse(Console.ReadLine(), out grades[i, j]))
                break;

            Console.WriteLine("Invalid input. Enter a number.");
        }
    }
}

double classTotal = 0;

Console.WriteLine("\nStudent Averages:");
for (int i = 0; i < students; i++)
{
    int sum1 = 0;

    for (int j = 0; j < subjects; j++)
        sum += grades[i, j];

    double average1 = (double)sum / subjects;
    Console.WriteLine($"Student {i + 1} average = {average:F2}");

    classTotal += sum;
}

double classAverage = classTotal / (students * subjects);
Console.WriteLine($"\nOverall class average = {classAverage:F2}");


#endregion

#region Q4

static double Add(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a - b;
}

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Error: Cannot divide by zero.");
        return double.NaN; 
    }
    return a / b;
}

double num1, num2;

Console.Write("Enter first number: ");
while (!double.TryParse(Console.ReadLine(), out num1))
    Console.Write("Invalid input. Enter a valid number: ");

Console.Write("Enter second number: ");
while (!double.TryParse(Console.ReadLine(), out num2))
    Console.Write("Invalid input. Enter a valid number: ");

Console.Write("Choose operation (+, -, *, /): ");
char op = Console.ReadKey().KeyChar;
Console.WriteLine();

double result = 0;
bool validOperation = true;

switch (op)
{
    case '+':
        result = Add(num1, num2);
        break;

    case '-':
        result = Subtract(num1, num2);
        break;

    case '*':
        result = Multiply(num1, num2);
        break;

    case '/':
        result = Divide(num1, num2);
        break;

    default:
        Console.WriteLine("Invalid operation.");
        validOperation = false;
        break;
}

if (validOperation && !double.IsNaN(result))
    Console.WriteLine($"Result = {result}");


#endregion

#region Q5

static void CalculateCircle(double radius, out double area, out double circumference)
{
    area = Math.PI * radius * radius;
    circumference = 2 * Math.PI * radius;
}

double radius;

Console.Write("Enter circle radius: ");
while (!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
{
    Console.Write("Invalid radius. Enter a positive number: ");
}

double area, circumference;

CalculateCircle(radius, out area, out circumference);

Console.WriteLine($"\nArea = {area:F2}");
Console.WriteLine($"Circumference = {circumference:F2}");


#endregion