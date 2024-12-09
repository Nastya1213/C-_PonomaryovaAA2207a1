using System;
using System.Collections;
using System.Collections.Generic;

// Класс Book
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}, {Year}";
    }
}

// Интерфейс итератора
public interface IIterator<T>
{
    bool HasNext();
    T Next();
}

// Интерфейс коллекции
public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}

// Итератор для библиотеки
public class LibraryIterator : IIterator<Book>
{
    private readonly List<Book> _books;
    private int _position = 0;

    public LibraryIterator(List<Book> books)
    {
        _books = books;
    }

    public bool HasNext()
    {
        return _position < _books.Count;
    }

    public Book Next()
    {
        if (!HasNext())
            throw new InvalidOperationException("No more books in the library.");
        return _books[_position++];
    }
}

// Класс Library, реализующий IAggregate
public class Library : IAggregate<Book>
{
    private readonly List<Book> _books;

    public Library()
    {
        _books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public IIterator<Book> CreateIterator()
    {
        return new LibraryIterator(_books);
    }
}


public class Program
{
    public static void Main()
    {
        // Создаем библиотеку
        Library library = new Library();

        // Добавляем книги
        library.AddBook(new Book("1984", "George Orwell", 1949));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));

        // Создаем итератор
        IIterator<Book> iterator = library.CreateIterator();

        // Обходим библиотеку с помощью итератора
        while (iterator.HasNext())
        {
            Book book = iterator.Next();
            Console.WriteLine(book);
        }
    }
}
