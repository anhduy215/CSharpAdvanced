using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using advanced;
public class Program
{
    public static async Task Main(string[] args)
    {
        Person p = new Person();
        //demo delegate------------------------------------------------------
        Console.WriteLine("demo delegate------------------------------------------------------");
        DelegateExample example = new DelegateExample();
        Console.WriteLine("delegate add: "+example.add(2, 3));
        Console.WriteLine("delegate multiply: "+example.multiply(2, 3));
        Console.WriteLine("delegate multicasting: ");
        example.multicasting();
        //demo collection list-----------------------------------------------
        Console.WriteLine("demo collection list-----------------------------------------------");
        List<Person> people = new List<Person>();
        people.Add(new Person("duy", 30));//add của list
        people.Add(new Person("khoa", 25));
        people.Add(new Person("bảo", 35));
        p.showList("People: ", people);//in list ban đầu
        people.Insert(1, new Person("personInsertName", 28));
        Console.WriteLine();
        p.showList("Insert success: ",people);//in list sau khi insert
        Person foundPerson = people.Find(p => p.Name == "duy");// demo hàm find kết hợp lambda để tìm 1 person tên là duy
        if (foundPerson != null)
        {
            Console.WriteLine("\nFound person:");
            Console.WriteLine(foundPerson);
        }
        //demo async task await----------------------------------------------
        Console.WriteLine("demo async task await----------------------------------------------");
        var asyncInstance = new Async();
        Console.WriteLine("Start");
        await asyncInstance.asyncDemo();
        Console.WriteLine("End");
    }
}
