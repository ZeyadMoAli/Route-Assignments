#region Q1
/*
 A generic class is a class that works with different data types using a placeholder (like <T>).

We use generics to:

avoid code duplication
increase type safety
improve performance (no boxing/unboxing)
 */


#endregion


#region Q2
public class Container<T>
{
 private T item;

 public void Add(T value)
 {
  item = value;
 }

 public T Get()
 {
  return item;
 }
}


#endregion


#region Q3

public class Pair<TKey, TValue>
{
 public TKey Key { get; set; }
 public TValue Value { get; set; }

 public Pair(TKey key, TValue value)
 {
  Key = key;
  Value = value;
 }
}

#endregion


#region Q4

public static void Swap<T>(ref T a, ref T b)
{
 T temp = a;
 a = b;
 b = temp;
}


#endregion


#region Q5

public static T FindMax<T>(T a, T b) where T : IComparable<T>
{
 if (a.CompareTo(b) > 0)
  return a;
 return b;
}

#endregion


#region Q6

public interface IRepository<T>
{
 void Add(T item);
 T Get(int id);
 void Remove(T item);
}

#endregion


#region Q7

public class ValueContainer<T> where T : struct
{
 public T Value { get; set; }
}

#endregion


#region Q8

public class RefContainer<T> where T : class
{
 public T Value { get; set; }
}


#endregion


#region Q9

public class Creator<T> where T : new()
{
 public T Create()
 {
  return new T();
 }
}


#endregion


#region Q10

public class PrintableContainer<T> where T : IPrintable
{
 public void Print(T item)
 {
  item.Print();
 }
}

#endregion


#region Q11

public class Animal { }

public class Dog : Animal { }

public class AnimalContainer<T> where T : Animal
{
 public T Item { get; set; }
}

#endregion

#region Q12

public class Complex<T>
 where T : class, IComparable<T>, new()
{
 public T Create()
 {
  return new T();
 }
}

#endregion


#region Q13

/*
 default returns the default value of a type:

0 → numbers
false → bool
null → reference types
 */

#endregion

#region Q14

public class SafeList<T>
{
 private T[] items = new T[10];

 public T this[int index]
 {
  get
  {
   if (index < 0 || index >= items.Length)
    return default(T);

   return items[index];
  }
  set
  {
   if (index >= 0 && index < items.Length)
    items[index] = value;
  }
 }
}

#endregion


#region Q15

/*
 Covariance allows using a more derived type.

out keyword is used.Covariance allows using a more derived type.

out keyword is used.
 */
public interface IProducer<out T>
{
 T Get();
}


#endregion


#region Q16

/*
 Contravariance allows using a less derived type.

in keyword is used.
 */

public interface IConsumer<in T>
{
 void Set(T item);
}

#endregion


#region Q17

/*
 Covariance → returns data (out)
Contravariance → accepts data (in)
 */

#endregion


#region Q18

/*
 Static members in generic types are separate for each type.

Example:

MyClass<int> has its own static values
MyClass<string> has different static values
 */


#endregion


#region Q19


public class Base<T>
{
 public T Value { get; set; }
}

public class Derived<T> : Base<T>
{
}
#endregion


#region Q20


public class CacheItem<T>
{
 public T Value { get; set; }
 public DateTime Expiration { get; set; }
}

public class Cache<TKey, TValue>
{
 private Dictionary<TKey, CacheItem<TValue>> data = new();

 public void Add(TKey key, TValue value, int seconds)
 {
  data[key] = new CacheItem<TValue>
  {
   Value = value,
   Expiration = DateTime.Now.AddSeconds(seconds)
  };
 }

 public TValue Get(TKey key)
 {
  if (data.ContainsKey(key))
  {
   var item = data[key];

   if (DateTime.Now <= item.Expiration)
    return item.Value;

   data.Remove(key);
  }

  return default;
 }

 public void Remove(TKey key)
 {
  data.Remove(key);
 }

 public bool Contains(TKey key)
 {
  return data.ContainsKey(key);
 }
}

#endregion