using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Model;

namespace ToDo.Data
{
    //Create a new class called People inside the Data folder.
    public class People
    {
        //a.Have a private static Person array declared and
        //instantiated as empty and not null (new Person[0]).

        private static Person[] people = new Person[0];

        //b.Add a method public int Size() that return the length of the array.

        public int Size()
        {
            return people.Length;
        }

        //c.Add a method public Person[] FindAll() that return the Person array.

        public Person[] FindAll()
        {
            return people;

        }
        //d.Add a method public Person FindById(int personId) that return the person 
        //            that has a matching personId as the passed in parameter.
        public Person FindById(int personId)
        {
            //for loop, looking 1 by 1

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].PersonId == personId)
                {
                    return people[i];
                }

            }

            return null;
        }
        /*e. Add a method that creates a new Person, adds the newly created object in the array 
         * and then return the created object. You have to “expand” the Person array. 
         * (tip: send in parameters needed to create the Person object 
         * and use the PersonSequencer to give a unique personId)*/

        public Person AddNewPerson(string firstName, string lastName)
        {
            Person person = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            Array.Resize<Person>(ref people, people.Length + 1);

            people[people.Length - 1] = person;
            //minus 1 since array starts from 0
    
            return person;

//Array.Resize<char>(ref arr, 6);


        }

        //f. Add a method public void Clear() that clears all Person objects from the Person array.

        public void Clear()
        {
            Array.Clear(people, 0, people.Length);
        }


    }
}
