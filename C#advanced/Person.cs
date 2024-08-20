using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced
{//tạo 1 đối tượng để demo list
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
        public void showList(String msg,List<Person> list) {
            Console.WriteLine(msg);
            foreach (Person p in list) { 
            p.ToString() ;
            }
        }
    }
}
