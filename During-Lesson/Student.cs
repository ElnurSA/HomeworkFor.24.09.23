using System;
namespace During_Lesson
{
	public class Student
	{
		public string name;
		public string surname;
		public string email;
		public int age;

		public void GetFullName()
		{
			Console.WriteLine(name + " " + surname);
		}

        public void GetFullData()
        {
            Console.WriteLine(name + " " + surname + " " + email + " " + age);
        }
    }
}

