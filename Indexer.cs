// WAP to show the concept of indexers.

using System;
namespace IndexerExample
{
public class StudentCollection
        {
            private string[] students = new string[5];

            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < students.Length)
                        return students[index];
                    else
                        return "Invalid Index";
                }
                set
                {
                    if (index >= 0 && index < students.Length)
                        students[index] = value;
                    else
                        Console.WriteLine("Invalid Index");
                }
            }
        }

        class Program
        {
            static void Main()
            {
                StudentCollection studentCollection = new StudentCollection();

                studentCollection[0] = "Kunal";
                studentCollection[1] = "Pitamber";
                studentCollection[2] = "Ojas";
                studentCollection[3] = "Rohan";
                studentCollection[4] = "Kashish";

                Console.WriteLine("Student at index 0: " + studentCollection[0]);
                Console.WriteLine("Student at index 1: " + studentCollection[1]);
                Console.WriteLine("Student at index 2: " + studentCollection[2]);
                Console.WriteLine("Student at index 3: " + studentCollection[3]);
                Console.WriteLine("Student at index 4: " + studentCollection[4]);

                Console.WriteLine("Student at index 5: " + studentCollection[5]);
            }
        }

    }
