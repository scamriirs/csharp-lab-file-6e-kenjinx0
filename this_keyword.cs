// Write a program to show the usage of "this" keyword.
using System;
class Person {
	private string name;
	private int age;
	public Person(string name, int age) {
		this.name = name;
		this.age = age;
	}
	public void DisplayInfo() {
		Console.WriteLine("Name: " + this.name);
		Console.WriteLine("Age: " + this.age);
	}
	public void IntroduceYourself() {
		Introduce(this);
	}
	public static void Introduce(Person person) {
		Console.WriteLine($"Hello, my name is {person.name} and I am {person.age} years old.");
	}
}

class Details {
	public static void Main(string[] args) {
		Person person1 = new Person("Kunal", 20);
		person1.DisplayInfo();
		person1.IntroduceYourself();
	}
}