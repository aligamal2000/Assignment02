using System.Diagnostics;

namespace Assignment02
{
    #region Q4- Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
    internal enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    } 
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01:Try all what we have learned in the lecture.
            //  writen in notes and Demo
            #endregion
            #region Part 2 1 Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] people = new Person[3];
            //people[0] = new Person("Ali", 25);
            //people[1] = new Person("Mohamed", 30);
            //people[2] = new Person("Gamal", 35);
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}
            #endregion
            #region 2- Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] people = new Person[3];
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.Write($"Enter name for person {i + 1}: ");
            //    string? name = Console.ReadLine();
            //    name = string.IsNullOrWhiteSpace(name) ? "Unknown" : name;

            //    Console.Write($"Enter age for person {i + 1}: ");
            //    string? ageInput = Console.ReadLine();
            //    int age = int.TryParse(ageInput, out int parsedAge) ? parsedAge : 0;

            //    people[i] = new Person(name, age);
            //}


            //Person oldest = people[0];
            //foreach (var person in people)
            //{
            //    if (person.Age > oldest.Age)
            //    {
            //        oldest = person;
            //    }
            //}
            //Console.WriteLine($"\nThe oldest person is {oldest.Name}, Age: {oldest.Age}");
            #endregion
            #region Part 3 Q1 Design and implement a Class for the employees in a company:
            //done
            #region Q2-Develop a Class to represent the Hiring Date Data: consisting of fields to hold the day, month and Years.
            // Check HireDate.CS
            #region Q3
            // Cheack Employee.cs
            #endregion
            #region Q4
            //  UP THERE after nampespace
            #region Q5
            //Cheack Employee.cs
            #region Q6-Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "Sara", SecurityLevel.DBA, 70000, new HireDate(15, 6, 2015), 'F');
            EmpArr[1] = new Employee(2, "Mohamed", SecurityLevel.Guest, 40000, new HireDate(10, 12, 2020), 'M');
            EmpArr[2] = new Employee(3, "Gamal", SecurityLevel.SecurityOfficer, 90000, new HireDate(25, 3, 2010), 'M');


            #region Q7-Sort the employees based on their hire date then Print the sorted array.While sorting(how many times Boxing and Unboxing process has occurred)

            Array.Sort(EmpArr);
            Console.WriteLine("Sorted Employees by Hire Date:");
            foreach (var employee in EmpArr)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("\nBoxing/Unboxing Process: 0 times "); 
            #endregion

            // i used net8.0




            #endregion
            #endregion
            #endregion
            #endregion
            #endregion
        }
    }
}
