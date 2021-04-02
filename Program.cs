using System;

namespace prct_constructor
{
    class Person
    {
        private string name;
        private  Person()
        {
            this.name = "abhay";
            
        }
         public Person(string myname)
        {
            this.name = myname;
        }
              
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person pr = new Person("priya");  
        }
    }
}
