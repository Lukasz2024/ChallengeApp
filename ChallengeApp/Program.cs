using ChallengeApp;
using System;

Employee employee1 = new Employee("Adam", "Mada", "21");
Employee employee2 = new Employee("Monika", "Akimon", "32");
Employee employee3 = new Employee("Zuzia", "Aizuz", "45");
Employee employee4 = new Employee("Damian", "Niamad", "24");

employee1.AddScore(2);
employee1.AddScore(5);
employee1.AddScore(9);

employee2.AddScore(3);
employee2.AddScore(7);
employee2.AddScore(1);

employee3.AddScore(4);
employee3.AddScore(8);
employee3.AddScore(8);

employee4.AddScore(9);
employee4.AddScore(6);
employee4.AddScore(5);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

int maxResult = -1;
Employee bestEmployees = null!;

foreach (var employee in employees)
{
    if (employee.Result >= maxResult)
    {
        maxResult = employee.Result;
        bestEmployees = employee;
    }
}
Console.WriteLine($"The best employee is: {bestEmployees.Name} {bestEmployees.Surname}");
Console.WriteLine($"Age: {bestEmployees.Age}");
Console.WriteLine($"With total score: {maxResult}");

Console.ReadKey();