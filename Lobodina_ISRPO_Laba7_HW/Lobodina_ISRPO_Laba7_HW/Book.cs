//using System;

//class Book
//{
//    public string Title;
//    public string Author;
//    public int Year;
//    public bool IsAvailable;
//    public Book()
//    {
//        Title = "Неизвестно";
//        Author = "Неизвестен";
//        Year = 0;
//        IsAvailable = false;
//    }
//    public Book(string title, string author, int year, bool isAvailable)
//    {
//        this.Title = title;
//        this.Author = author;
//        this.Year = year;
//        this.IsAvailable = isAvailable;
//    }

//    public void PrintInfo()
//    {
//        string availability = IsAvailable ? "Да" : "Нет";
//        Console.WriteLine($"Название: \"{Title}\", Автор: {Author}, Год: {Year}, Доступна: {availability}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book1 = new Book(); 
//        Book book2 = new Book("Война и мир", "Толстой", 1869, true);

//        book1.PrintInfo();
//        book2.PrintInfo();
//    }
//}