using System;
using System.Text;

class Store : IDisposable
{
    public string StoreName { get; set; }
    public string Address { get; set; }
    public string StoreType { get; set; }

    public Store(string storeName, string address, string storeType)
    {
        StoreName = storeName;
        Address = address;
        StoreType = storeType;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Назва магазину: {StoreName}, Адреса: {Address}, Тип: {StoreType}");
    }

    public void Dispose()
    {
        Console.WriteLine($"Метод Dispose викликаний для магазину: {StoreName}");
        GC.SuppressFinalize(this);
    }

    ~Store()
    {
        Console.WriteLine($"Деструктор викликаний для магазину: {StoreName}");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("=== Тестування класу «Магазин» ===");

        using (Store store = new Store("Продукти", "вул. Вулична, 666", "Продовольчий"))
        {
            store.DisplayInfo();
        }  
        Console.WriteLine("Магазин більше не використовується.");
    }
}
