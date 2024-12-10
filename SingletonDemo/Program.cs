// See https://aka.ms/new-console-template for more information
using SingletonDemo;

Singleton singleton =  Singleton.GetInstance;
singleton.PrintDetails("heloo");


Singleton singleton1 = Singleton.GetInstance;
singleton1.PrintDetails("heloo1");
Console.ReadLine();





