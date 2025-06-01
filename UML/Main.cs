using System;

public class Zamovnyk
{
    // Автоматичні властивості
    public string Telefon { get; set; }
    public string PIB { get; set; }
    public string Email { get; set; }

    // Конструктор без параметрів
    public Zamovnyk()
    {
        Telefon = "";
        PIB = "";
        Email = "";
    }

    // Конструктор з параметрами
    public Zamovnyk(string telefon, string pib, string email)
    {
        Telefon = telefon;
        PIB = pib;
        Email = email;
    }

    // Метод для виведення інформації
    public void ShowInfo()
    {
        Console.WriteLine($"ПІБ: {PIB}");
        Console.WriteLine($"Телефон: {Telefon}");
        Console.WriteLine($"Email: {Email}");
    }
    public class MyString
    {
        private string value;

        // Конструктор
        public MyString(string val = "")
        {
            value = val;
        }

        // Копіювальний конструктор
        public MyString(MyString other)
        {
            value = other.value;
        }

        // Присвоєння
        public void Assign(MyString other)
        {
            value = other.value;
        }

        // Перевантаження оператора +
        public static MyString operator +(MyString a, MyString b)
        {
            return new MyString(a.value + b.value);
        }

        // Імітація оператора <<
        public void WriteToConsole()
        {
            Console.WriteLine(value);
        }

        // Імітація оператора >> (зчитування з консолі)
        public void ReadFromConsole() => value = Console.ReadLine();

        // Перевизначення ToString()
        public override string ToString()
        {
            return value;
        }
    }
}

