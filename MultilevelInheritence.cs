/* Write a program to implement multilevel inheritance:-
    Person -> Employee -> Programmer */
using System;
class Person // Root class
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
class Employee : Person // Node class derives all methods of Root Class (Person)
{
    public int EmployeeID { get; set; }
    public string Company { get; set; }
    public void DisplayEmployeeInfo()
    {
        DisplayPersonInfo();
        Console.WriteLine($"Employee ID: {EmployeeID}, Company: {Company}");
    }
}
class Programmer : Employee // Node class derives all the methods of SubRoot Class Employee which further is Person class' node
{
    public string ProgrammingLanguage { get; set; }
    public void DisplayProgrammerInfo()
    {
        DisplayEmployeeInfo();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }
}
class PersonDetails
{
    static void Main()
    {
        Programmer prog = new Programmer();
        prog.Name = "Kunal Jha";
        prog.Age = 25;
        prog.EmployeeID = 101;
        prog.Company = "TechCorp";
        prog.ProgrammingLanguage = "C#";
        prog.DisplayProgrammerInfo();
    }
}
