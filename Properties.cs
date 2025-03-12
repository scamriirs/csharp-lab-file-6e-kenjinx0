// write a program to implement the concept of porperties.
using System;
namespace PropertyExample
{
    class Properties
    {
        class Student
        {
            private string name;
            private int age;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                        name = value;
                    else
                    {
                        Console.WriteLine("Name cannot be empty or null.");
                    }
                }
            }
            public int Age { get; set; }
            public Student(string name, int age)
            {
                Name = name;
                Age = age;   
            }

            public void DisplayPersonDetails()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        static void Main(string[] args)
        {
            Student S1 = new Student ("Kunal Jha", 95);
            S1.DisplayPersonDetails();
            S1.Name = "Ayush";
            S1.Age = 69;

            S1.DisplayPersonDetails();

            S1.Name = "";     
            S1.DisplayPersonDetails();
        }
    }
}
