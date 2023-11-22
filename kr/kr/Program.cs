using System;
using System.Collections.Generic;
// Абстрактный класс Item
abstract class Item : IComparable<Item>
{
    public int Weight { get; }

    public Item(int weight)
    {
        if (weight <= 0)
        {
            throw new ArgumentException("Weight must be greater than 0.");
        }

        Weight = weight;
    }

    public int CompareTo(Item other)
    {
        return Weight.CompareTo(other.Weight);
    }

    public override string ToString()
    {
        return $"Weight: {Weight}g";
    }
}

// Класс NoteBook
class NoteBook : Item
{
    public int PageCount { get; }

    public NoteBook(int weight, int pageCount) : base(weight)
    {
        if (pageCount <= 0)
        {
            throw new ArgumentException("Page count must be greater than 0.");
        }

        PageCount = pageCount;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Page Count: {PageCount}";
    }
}

// Класс TextBook
class TextBook : Item
{
    public string Subject { get; }

    public TextBook(int weight, string subject) : base(weight)
    {
        Subject = subject;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Subject: {Subject}";
    }
}

// Класс SchoolBag
class SchoolBag
{
    public List<Item> items;

    public SchoolBag()
    {
        items = new List<Item>();
    }

    public void Add(Item item)
    {
        items.Add(item);
    }

    public int Weight
    {
        get
        {
            int totalWeight = 0;
            foreach (Item item in items)
            {
                totalWeight += item.Weight;
            }
            return totalWeight;
        }
    }
        
    public string Find_mathbook()
    {
        foreach(Item it in items)
        {
            string str = it.ToString();
            string[] arr = str.Split();
            foreach(String word in arr)
            {
                if (word.Equals("Mathematics"))
                {
                    return "В рюкзаке содержится учебник по математике";
                }
            }
        }
        return "В рюкзаке не содержится учебник по математике";
    }
    public override string ToString()
    {
        string result = "School Bag Contents:\n";
        foreach (Item item in items)
        {
            result += item.ToString() + "\n";
        }
        return result;
    }

}


// Пример использования
public class Program
{
    public static void Main()
    {
        SchoolBag schoolBag = new SchoolBag();

        NoteBook notebook1 = new NoteBook(300, 100);
        NoteBook notebook2 = new NoteBook(450, 80);
        TextBook textbook1 = new TextBook(500, "Mathematics");
        TextBook textbook2 = new TextBook(400, "History");
        TextBook textbook3 = new TextBook(1000, "English");
        TextBook textbook4 = new TextBook(1200, "Inform");

        schoolBag.Add(notebook1);
        schoolBag.Add(notebook2);
        schoolBag.Add(textbook1);
        schoolBag.Add(textbook2);
        schoolBag.Add(textbook3);
        schoolBag.Add(textbook4);


        schoolBag.items.Sort(); // Сортировка по весу

        if (schoolBag.Weight > 3000)
        {
            schoolBag.items.RemoveAt(schoolBag.items.Count - 1); // Удаление самого тяжелого компонента
        }

        Console.WriteLine(schoolBag.ToString());
    }
}