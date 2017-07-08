using System;

namespace csharpapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee e = new Employee();
            
            e.name = "Ash";
            e.type = "FT";
            e.salary = 1000;
            e.Details();

            //FullTime f = new FullTime();
            //f.name = "Ash";
            //f.type = "FT";
            //f.salary = 1000;
            //f.term = "6Month";
            
            e = new FullTime("8Month");
            e.Details();
        }
    }

    class Employee
    {
        public int salary {get; set;}
        public string type {get; set;}
        public string name {get; set;}
        public virtual void Details()
        {
            Console.WriteLine("The name of employee is "+name);
            Console.WriteLine("The type of employee is "+type);
            Console.WriteLine("The salary of employee is "+salary);
        }
        
    }

    class FullTime : Employee
    {
        public string term {get; set;}

        public override void Details()
        {
            Console.WriteLine("The name of employee is "+name);
            Console.WriteLine("The type of employee is "+type);
            Console.WriteLine("The salary of employee is "+salary);
            Console.WriteLine("The Term of employee is "+term);
        }        
        public FullTime(string termInput)
        {
            this.term = termInput;
            //Console.WriteLine("The name of employee is "+name);
            //Console.WriteLine("The type of employee is "+type);
            //Console.WriteLine("The salary of employee is "+salary);
            //Console.WriteLine("The Term of employee is "+term);
        }

    }
}

