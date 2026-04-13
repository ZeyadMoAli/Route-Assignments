#region Task1
var grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

Console.WriteLine(string.Join(", ", grades));
Console.WriteLine($"Count: {grades.Count}");
Console.WriteLine($"First: {grades.First()}");
Console.WriteLine($"Last: {grades.Last()}");

grades.Sort();
Console.WriteLine("Sorted: " + string.Join(", ", grades));

Console.WriteLine("First > 90: " + grades.First(g => g > 90));

var failing = grades.Where(g => g < 75).ToList();
Console.WriteLine("Failing: " + string.Join(", ", failing));

grades.RemoveAll(g => g < 75);
Console.WriteLine("After removing failing: " + string.Join(", ", grades));

Console.WriteLine("Has 100: " + grades.Contains(100));

var gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
Console.WriteLine(string.Join(", ", gradeStrings));


#endregion


#region Task2

var leaderboard = new SortedDictionary<int, string>
{
    {500, "Ahmed"},
    {200, "Sara"},
    {800, "Ali"},
    {350, "Mona"}
};

foreach (var item in leaderboard)
    Console.WriteLine($"{item.Key} = {item.Value}");

Console.WriteLine($"First Key: {leaderboard.First().Key}");
Console.WriteLine($"First Value: {leaderboard.First().Value}");

Console.WriteLine("Contains 500: " + leaderboard.ContainsKey(500));

if (leaderboard.TryGetValue(999, out var player))
    Console.WriteLine(player);
else
    Console.WriteLine("Score 999 not found");

leaderboard.Remove(200);

Console.WriteLine("After remove:");
foreach (var item in leaderboard)
    Console.WriteLine($"{item.Key} = {item.Value}");

#endregion


#region Task3
var phoneBook = new Dictionary<string, string>
{
    {"Ahmed", "111"},
    {"Sara", "222"},
    {"Ali", "333"},
    {"Mona", "444"}
};

phoneBook["Omar"] = "555";

try
{
    phoneBook.Add("Ahmed", "999");
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

bool added = phoneBook.TryAdd("Ahmed", "999");
Console.WriteLine("TryAdd success: " + added);

if (!phoneBook.ContainsKey("Youssef"))
    Console.WriteLine("Not found");

string result = phoneBook.GetValueOrDefault("Youssef", "Not Found");
Console.WriteLine(result);

Console.WriteLine("Keys:");
Console.WriteLine(string.Join(", ", phoneBook.Keys));

Console.WriteLine("Values:");
Console.WriteLine(string.Join(", ", phoneBook.Values));


#endregion


#region Task4

var emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
{
    "ahmed@test.com",
    "AHMED@test.com",
    "sara@test.com",
    "Sara@Test.Com"
};

Console.WriteLine("Count: " + emails.Count);

var setA = new HashSet<int> {1,2,3,4,5};
var setB = new HashSet<int> {4,5,6,7,8};

var union = new HashSet<int>(setA);
union.UnionWith(setB);
Console.WriteLine("Union: " + string.Join(", ", union));

var intersect = new HashSet<int>(setA);
intersect.IntersectWith(setB);
Console.WriteLine("Intersect: " + string.Join(", ", intersect));

var except = new HashSet<int>(setA);
except.ExceptWith(setB);
Console.WriteLine("Except: " + string.Join(", ", except));

Console.WriteLine("Is {1,2} subset: " + new HashSet<int> {1,2}.IsSubsetOf(setA));

#endregion


#region Task5

var queue = new Queue<string>();

queue.Enqueue("Report.pdf");
queue.Enqueue("Invoice.pdf");
queue.Enqueue("Letter.docx");
queue.Enqueue("Resume.pdf");
queue.Enqueue("Photo.jpg");

Console.WriteLine(string.Join(", ", queue));
Console.WriteLine("Count: " + queue.Count);

Console.WriteLine("Next: " + queue.Peek());

while (queue.Count > 0)
{
    Console.WriteLine("Printing: " + queue.Dequeue());
}

bool success = queue.TryDequeue(out var doc);
Console.WriteLine("TryDequeue success: " + success);

#endregion


#region Task6

var history = new Stack<string>();

history.Push("google.com");
history.Push("github.com");
history.Push("stackoverflow.com");
history.Push("youtube.com");
history.Push("claude.ai");

Console.WriteLine("Current: " + history.Peek());

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Back from: " + history.Pop());
}

Console.WriteLine("Current page: " + history.Peek());

while (history.Count > 0)
{
    history.Pop();
}

bool popped = history.TryPop(out var page);
Console.WriteLine("TryPop success: " + popped);

#endregion