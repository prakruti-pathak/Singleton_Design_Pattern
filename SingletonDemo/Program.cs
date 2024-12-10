// See https://aka.ms/new-console-template for more information
using SingletonDemo;

Parallel.Invoke(
    () => EmployeeMethod(),
    () =>StudentMethod()
);
Console.ReadLine();

static void EmployeeMethod()
{
    Singleton employee = Singleton.GetInstance;
    employee.PrintDetails("From Employee");
}

static void StudentMethod()
{
    Singleton student = Singleton.GetInstance;
    student.PrintDetails("From Student");
}

