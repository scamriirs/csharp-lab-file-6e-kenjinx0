using System;

namespace IndexerExample
{
    public class IndexerOverloading
    {
        private string[] students = { "Kunal", "Pitamber", "Ojas", "Rohan", "Kashish" };

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

        public string this[string name]
        {
            get
            {
                foreach (string student in students)
                {
                    if (student == name)
                        return student;
                }
                return "Student Not Found";
            }
            set
            {
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == name)
                    {
                        students[i] = value;
                        return;
                    }
                }
                Console.WriteLine("Student Not Found");
            }
        }
    }

    class IndexOverLoad
    {
        static void Main()
        {
            IndexerOverloading studentCollection = new IndexerOverloading();

            Console.WriteLine("Student at index 0: " + studentCollection[0]);
            studentCollection[0] = "Raj";
            Console.WriteLine("Updated student at index 0: " + studentCollection[0]);

            Console.WriteLine("Accessing 'Ojas': " + studentCollection["Ojas"]);
            studentCollection["Ojas"] = "Ojas Patil";
            Console.WriteLine("Updated 'Ojas': " + studentCollection["Ojas"]);

            Console.Beep();   
        }
    }
}
