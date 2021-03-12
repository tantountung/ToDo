using System;
using ToDo.Model;
using Xunit;

namespace ToDo.Tests.Model
{
    public class PersonTest
    {
        [Fact]
        public void PersonInitTests()
        {
            //Arrange
            int tesID = 1234;
            string tesFirstName = "Tanto";
            string tesLastName = "Untung";


            //Act
            Person person = new Person(tesID, tesFirstName, tesLastName);

            //Assert
            Assert.Equal(tesID, person.PersonId);
            Assert.Equal(tesFirstName, person.FirstName);
            Assert.Equal(tesLastName, person.LastName);

        }
        [Fact]
        public void PersonInitTests1()
        {
            //Arrange
            int tesID = 1234;
            string tesFirstName = null;
            string tesLastName = "Untung";


            //Act
            Person person = new Person(tesID, tesFirstName, tesLastName);

            //Assert
            Assert.Equal(tesFirstName, person.FirstName);

        }
        [Fact]
        public void PersonInitTests2()
        {
            //Arrange
            int tesID = 1234;
            string tesFirstName = "Tanto";
            string tesLastName = string.Empty;
            //string result = "Unidentified";


            //Act
            Person person = new Person(tesID, tesFirstName, tesLastName);

            //Assert
            Assert.Equal(tesID, person.PersonId);
            Assert.Equal(tesFirstName, person.FirstName);
            Assert.Equal(tesLastName, person.LastName);

        }
        //[Fact]
        //public static string FirstFirstNameTest()
        //{
        //    //Arrange
        //    string name1 = "John";
        //    //string name2 = "McClane";
        //    //string expected = "John McClane";
        //    string expected = "John";

        //    //Act
        //    string result = Person.FirstName(string name1);
        //    //Assert
        //    Assert.Equal(expected, result);


        //}
    }
}
