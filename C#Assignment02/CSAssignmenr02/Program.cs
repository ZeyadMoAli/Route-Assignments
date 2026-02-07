// See https://aka.ms/new-console-template for more information

#region Q1

// will print 9 because 9.99 converted to int is 9
/*
double d = 9.99;
int x = (int)d;
Console.WriteLine(x);
*/


#endregion

#region Q2
int n = 5;
double d2 = n / 2.0;
Console.WriteLine(d2);
#endregion

#region Q3


Console.WriteLine("Enter Age");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num);
#endregion

#region Q4
//this code will throw an exception as string char 'a' is not a valid digit
/*
string s = "12a";
int x = int.Parse(s);
Console.WriteLine(x);
*/
#endregion

#region Q5
/*string s = "12a";
if (int.TryParse(s, out  x))
{
    Console.WriteLine(x);
}
else
    Console.WriteLine("Invalid");*/
#endregion

#region Q6
// This will print 11 as 10 is converted to int Because Object is the base class of all classes in C#
/*object o = 10;
int a = (int)o;
Console.WriteLine(a + 1);*/
#endregion


#region Q7
// This will throw an exception as o contain integer value
/*object o = 10;
long x = (long)o;
Console.WriteLine(x);*/


/*object o = 10;
long x = Convert.ToInt64(o);
Console.WriteLine(x);*/

#endregion

#region Q8
/*object o = 10;
long x;
try
{
    x = Convert.ToInt64(o);
}
catch (Exception e)
{
    Console.WriteLine(-1);
}*/

#endregion

#region Q9
// this will print empty line as name is null
string? name = null;
Console.WriteLine(name?.Length);
#endregion

#region Q10
// this will print 0 as we assigned 0 to length if name2 is null
string? name2 = null;
int length = name2?.Length ?? 0;
Console.WriteLine(length);
    

#endregion

#region Q11
// this code is not safe if string s has characters it is safer to use try parse
#endregion

#region Q12
// this code will throw an exception as s is null so we need to add ? to s 
//string? s = null;
//Console.WriteLine(s!.Length);


/*string? s = null; 
Console.WriteLine(s?.Length);*/
#endregion

#region Q13

// this code will 0 as s is null
/*string? s = null;
int x = Convert.ToInt32(s); 
Console.WriteLine("-------------");
Console.WriteLine(x);*/
#endregion

#region Q14
// in A the code will throw an exception as s is null in B the code will print 0 because it is null safe
//string? s = null;
// A
// int a = int.Parse(s);
// B
//int b = Convert.ToInt32(s);
//Console.WriteLine(b);

#endregion

#region Q5

string? user = null;
if (user is null)
{
    Console.WriteLine("Guest");
}
else
{
    Console.WriteLine(user);
}

#endregion

