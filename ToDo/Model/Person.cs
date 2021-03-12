using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ToDo;

namespace ToDo.Model
{
    //Create Person class in folder Model.
    ////a.Required private fields are personId(int and readonly), firstName and lastName(String).
    ////b.Make a constructor (giving birth) that can build the object.
    ////c.Use Properties to prevent names from saving NULL & Empty
    ////d.Unit test Person class.
    ////e.Commit changes.
    public class Person
    {
        private readonly int personId;
        private string firstName;
        private string lastName;

        public Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int PersonId
        {
            get { return personId; }
            //no need Set, because redundant (read only)
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    firstName = "Unidentified";
                }
                else
                {
                    //firstName = firstName;
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    lastName = "Unidentified";
                }
                else
                {
                    lastName = value;
                }
            }
        }




        //        public void PerId()
        //        {
        //            int personId = 0;

        //            for (int i = 1; i < 1000; i++)
        //            {
        //                personId = i;
        //                return;

        //            }
        //            return;
        //        }


        //        public static string FirstName()
        //        {


        //            Console.WriteLine("Please enter first name:");
        //            string firstName = Console.ReadLine();




        //            if (string.IsNullOrEmpty(firstName))
        //            {
        //                Console.WriteLine("Cannot be empty, please enter a name.");
        //                return firstName;
        //            }
        //            return firstName;
        //        }

        //        public static string LastName()
        //        { 
        //            Console.WriteLine("Please enter last name:");
        //            string lastName = Console.ReadLine();

        //            if (string.IsNullOrEmpty(lastName))
        //                {
        //                    Console.WriteLine("Cannot be empty, please enter a name.");
        //                return lastName;
        //                }

        //            return lastName;
        //            //return firstName + " " + lastName;
        //        }

    }
}



////string firstName;
////string lastName;
////int personId;


////Console.WriteLine("Your person number is: " + personID);

////public Person(int personId)
//public Person(int personID)
//{
//    //Random rand = new Random();
//    ////Console.WriteLine("Please enter your date of birth (YYYYMMDD)");
//    ////int DOB = Convert.ToInt32(Console.ReadLine());
//    ////Console.WriteLine("Your person number is: {0)_{1}", DOB, rand.Next(0, 9999));

//    //int personId = rand.Next(0, 10000);
//    //return;




//}






