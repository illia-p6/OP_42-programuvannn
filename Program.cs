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