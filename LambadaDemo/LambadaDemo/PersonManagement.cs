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
            list.Add(new Person { SSN = 102, name = "Vijay", Address = "Delhi", Age = 55 });
            list.Add(new Person { SSN = 103, name = "Aman", Address = "Lucknow", Age = 55 });
            list.Add(new Person { SSN = 104, name = "Anish", Address = "Pune", Age = 55 });
            list.Add(new Person { SSN = 105, name = "Suraj", Address = "Hydrabaad", Age = 55 });
            list.Add(new Person { SSN = 106, name = "Anurag", Address = "Mumbai", Age = 55 });
        }
    }
}
