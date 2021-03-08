using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_25_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating and populating an employee list of 10 new employee's and their id's
            List<Employee> staff = new List<Employee>();
            staff.Add(new Employee() { firstName = "Joe", lastName = "Bonsai", Id = 1 });
            staff.Add(new Employee() { firstName = "Adam", lastName = "Rodriguez", Id = 2 });
            staff.Add(new Employee() { firstName = "Samantha", lastName = "Murphy", Id = 3 });
            staff.Add(new Employee() { firstName = "Jake", lastName = "Jones", Id = 4 });
            staff.Add(new Employee() { firstName = "Ben", lastName = "Kellogg", Id = 5 });
            staff.Add(new Employee() { firstName = "Simon", lastName = "Adamson", Id = 6 });
            staff.Add(new Employee() { firstName = "Sarah", lastName = "Smalls", Id = 7 });
            staff.Add(new Employee() { firstName = "Joe", lastName = "Dirt", Id = 8 });
            staff.Add(new Employee() { firstName = "Roger", lastName = "Robinson", Id = 9 });
            staff.Add(new Employee() { firstName = "Terry", lastName = "Smith", Id = 10 });

            //Creating a list of all employee's named joe with Foreach loops
            List<Employee> joes = new List<Employee>();
            foreach (Employee joe in staff)
            {

                if (joe.firstName == "Joe")
                {
                    joes.Add(joe);

                }

            }
            //Creating a foreach loop to print the info of the employee's in the new list of Joes
            foreach (Employee newJoes in joes)
            {
                Console.WriteLine(newJoes.firstName + " " + newJoes.lastName + " " + newJoes.Id);
            }



            //Creating a list and populating it with a lambda expression and creating a foreach loop to show the newly populated list
            List<Employee> lamStaff = staff.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee lamJoe in lamStaff)
            {
                Console.WriteLine(lamJoe.firstName + " " + lamJoe.lastName + " " + lamJoe.Id);
            }




            //Creating a list of employees who's Id's are greater than 5 and printing them to the console
            List<Employee> greaterThan = staff.Where(x => x.Id > 5).ToList();
            foreach (Employee higher in greaterThan)
            {
                Console.WriteLine(higher.firstName + " " + higher.lastName + " " + higher.Id);
            }

            Console.ReadLine();
        }
    }
}
