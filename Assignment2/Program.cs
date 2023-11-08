using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            float salary;
            DateTime doj;


            Console.WriteLine("enter employee id");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee name");
            name=Console.ReadLine();
            Console.WriteLine("enter employee gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("enter employee salary");
            salary=float.Parse(Console.ReadLine());
            Console.WriteLine("enter employee doj");
            doj=DateTime.Parse(Console.ReadLine());


            Console.WriteLine("ID\tEmployee Name\tEmployee Gender\tEmployee salary\tDOJ");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(id + "\t" + name + "\t\t" +gender+"\t\t"+salary+"\t\t"+doj);
            if (salary > 90000)
            {
                Console.WriteLine("you have to pay 30% tax otherwise tax will be 15%");
            }

        }
    }
}
