
//using Ado.net in Dot Net Core Application

// See https://aka.ms/new-console-template for more information

using ADONetCoreAppp;
using Microsoft.Data.SqlClient;

Console.WriteLine("***All Trainers***");

TrainerDB db = new TrainerDB();
var trainers = db.AllTrainers();

foreach (var item in trainers)
{
    Console.WriteLine($"Id:{item.Id} Name:{item.Name}  city:{item.City} Experience:{item.Experience}");
}

Console.ReadLine();
Console.WriteLine("Hello, World!");



