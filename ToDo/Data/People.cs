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

        private static string[] Person = new string[0];

        //b.Add a method public int Size() that return the length of the array.

        public int Size()
        {
            return Person.Length;
        }

        //c.Add a method public Person[] FindAll() that return the Person array.

        public Person[] FindAll()
        {
            return Array.FindAll<Person>(Person[0], Predicate<Person>);

        }
        //d.Add a method public Person FindById(int personId) that return the person 
        //            that has a matching personId as the passed in parameter.
        public Person FindById(int personId)
        {
            return Array.FindAll<Person>(Person[0], personId.ToString());

        }
        /*e. Add a method that creates a new Person, adds the newly created object in the array 
         * and then return the created object. You have to “expand” the Person array. 
         * (tip: send in parameters needed to create the Person object 
         * and use the PersonSequencer to give a unique personId)*/

        public AddNewPerson(PersonSequencer.nextPersonId, Person.FirstName, Person.LastName)
        {
            var tempList = Person.ToList();
            tempList.Add(PersonSequencer.nextPersonId, Person.FirstName, Person.LastName);
            Person = tempList.ToArray();
            return;


            //ArrayList<Person> updatedPerson = new ArrayList<Person>();
            //updatedPerson.add(new Person(PersonSequencer.nextPersonId, Person.FirstName, Person.LastName);
            //return updatedPerson;

        }

        //f. Add a method public void Clear() that clears all Person objects from the Person array.

        public void Clear()
        {
          Array.Clear(Person, 0, Person.Length);
        }


    }
}
