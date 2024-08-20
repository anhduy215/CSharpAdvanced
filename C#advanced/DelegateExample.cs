using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced
{
    public class DelegateExample
    {
        public delegate int MathOperation(int x, int y);
        public MathOperation add = (x, y) => x + y;
        public MathOperation multiply = (x, y) => x * y;

        //demo delegate multicasting
        public delegate void Multicasting();
        public void Task1()
        {
            Console.WriteLine("Task 1 Working !");
        }
        public void Task2()
        {
            Console.WriteLine("Task 2 Working !");
        }
        public Multicasting multicasting;
        public DelegateExample()
        {
            multicasting = Task1;
            multicasting += Task2;

        }
    }
}
