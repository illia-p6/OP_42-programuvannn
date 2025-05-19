using System;
using System.Collections.Generic;
//Створимо базовий клас для всіх об'єктів
abstract class BaseEntity
{
    public int ID { get; set; }

    protected BaseEntity(int id)
    {
        ID = id;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"ID: {ID}");
    }
}

interface IReservation
{
    void Reserve(DateTime startDate, DateTime endDate);
    void CancelReservation();
    bool IsReserved { get; }
}

class Admin : BaseEntity
{
    public string Login { get; set; }
    private string password;

    public string Password
    {
        get => password;
        set => password = value;
    }

    public Admin(int id, string login, string password) : base(id)
    {
        Login = login;
        Password = password;
    }
}

class User : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    private string phone;

    public string Phone
    {
        get => phone;
        set => phone = value;
    }

    public User(int id, string firstName, string lastName, string email, string phone) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"User: {FirstName} {LastName}, Email: {Email}");
    }
}

class Book : BaseEntity
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Pages { get; set; }
    public bool Available { get; set; } = true;

    public Book(int id, string title, string author, int year, int pages) : base(id)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
    }

    public string GetStatus()
    {
        return Available ? "Доступна" : "Заброньована";
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title} ({Author}, {Year}) - {GetStatus()}");
    }
}

class Reservation : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public virtual bool IsReserved { get; set; }

    public Reservation(int id) : base(id) { }

    public virtual void Reserve(DateTime startDate, DateTime endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
        IsReserved = true;
    }

    public virtual void CancelReservation()
    {
        IsReserved = false;
        StartDate = DateTime.MinValue;
        EndDate = DateTime.MinValue;
    }
}

class BookReservation : Reservation, IReservation
{
    private Book Book { get; set; }
    private User User { get; set; }

    public override bool IsReserved { get; set; }

    public BookReservation(int id, Book book, User user) : base(id)
    {
        Book = book;
        User = user;
        IsReserved = false;
    }

    public override void Reserve(DateTime startDate, DateTime endDate)
    {
        if (Book.Available && !IsReserved)
        {
            base.Reserve(startDate, endDate);
            Book.Available = false;
            Console.WriteLine($"Книга '{Book.Title}' заброньована користувачем {User.FirstName} з {StartDate.ToShortDateString()} до {EndDate.ToShortDateString()}.");
        }
        else
        {
            Console.WriteLine("Неможливо забронювати книгу. Вона вже заброньована.");
        }
    }