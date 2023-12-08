using System;
using Delegate_Predicate.Models;
namespace Delegate_Predicate.Services
{
	public class PersonService
	{
		public delegate bool CheckSalary(Person person);

		public void CheckPerson(List<Person> people, CheckSalary check)
		{
			foreach(var person in people)
			{
				if (check(person))
				{
					Console.WriteLine(person.Name + " " + person.Surname + " " + person.Address);
				}
			}
		}

		public void ShowResult()
		{
			List<Person> people = new();

			people.Add(new Person { Id = 1, Name = "Nisa", Surname = "Narimanova", Address = "yasamal", Salary = 2000 });
            people.Add(new Person { Id = 2, Name = "Rufa", Surname = "Ahmadova", Address = "yasamal", Salary = 1500 });
            people.Add(new Person { Id = 3, Name = "Irana", Surname = "Narimanova", Address = "hezi", Salary = 700 });


			CheckPerson(people, person => person.Salary > 1000);
        }
    }
}

