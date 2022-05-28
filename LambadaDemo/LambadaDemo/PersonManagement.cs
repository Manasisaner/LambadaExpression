using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaDemo
{
    public class PersonManagement
    {
        List<Person> list = new List<Person>();
        public void AddPerson()
        {
            list.Add(new Person { SSN = 101, name = "Ajay", Address = "Nashik", Age = 55 });
            list.Add(new Person { SSN = 102, name = "Vijay", Address = "Delhi", Age = 67 });
            list.Add(new Person { SSN = 103, name = "Aman", Address = "Lucknow", Age = 75 });
            list.Add(new Person { SSN = 104, name = "Anish", Address = "Pune", Age = 55 });
            list.Add(new Person { SSN = 105, name = "Suraj", Address = "Hydrabaad", Age = 50 });
            list.Add(new Person { SSN = 106, name = "Anurag", Address = "Mumbai", Age = 58 });
            list.Add(new Person { SSN = 106, name = "Anurag", Address = "Mumbai", Age = 58 });
        }


        public void GetTopRecords()
        {
            var result = this.list.Where(x => x.Age < 60).Take(2);
            Display(result);
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person.SSN + "" + person.Name + "" + person.Address + "" + person.Age + "");
            }
        }
        public void AverageAge()
        {
            var result = this.list.Average(x => x.Age);
            Console.WriteLine("Average Age is :->" + result);
        }
        public void GetTopRecordBetweenRange()
        {
            foreach (var record in this.list)
            {
                if (record.Age < 18 && record.Age > 13)
                {
                    Console.WriteLine(record.Age);
                }
            }
        }
    }
}
