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