using System;
using System.Text;

class Play : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public Play(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Назва: {Title}, Автор: {Author}, Жанр: {Genre}, Рік: {Year}");
    }

    ~Play()
    {
        Console.WriteLine($"Деструктор викликаний для п'єси: {Title}");
    }

    public void Dispose()
    {
        Console.WriteLine($"Метод Dispose викликаний для п'єси: {Title}");
        GC.SuppressFinalize(this);
    }
}

class Part1
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== Тестування класу «П'єса» ===");

        using (Play play = new Play("Гамлет", "Вільям Шекспір", "Трагедія", 1601))
        {
            play.DisplayInfo();
        }  
        Console.WriteLine("П'єса більше не використовується.");
    }
}
