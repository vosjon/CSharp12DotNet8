// Exercise 5.2
using Packt.Shared;
using static System.Console;

Car honda = new() { IsEV = true, Make = "Honda", Model = "Civic"};
honda.Start();

Car toyota = new() { IsEV = false };
toyota.Start();

toyota.Make = "Toyota";
toyota.Model = "4Runner";
toyota.Start();