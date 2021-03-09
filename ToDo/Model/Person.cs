using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Model
{
    public class Person
    {
        //string firstName;
        //string lastName;
        //int personId;


        //Console.WriteLine("Your person number is: " + personID);

        //public Person(int personId)
        public Person(int personID)
        {
            Random rand = new Random();
            //Console.WriteLine("Please enter your date of birth (YYYYMMDD)");
            //int DOB = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your person number is: {0)_{1}", DOB, rand.Next(0, 9999));

            int personId = rand.Next(0, 10000);
            return;
        }


    }

}

