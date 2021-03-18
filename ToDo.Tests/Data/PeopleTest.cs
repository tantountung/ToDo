using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Data;
using ToDo.Model;
using Xunit;

namespace ToDo.Tests.Data
{
    public class PeopleTest
    {
        [Fact]
        public void SizeTest()
        {
            ////Arrange
            //var ListTest[] listTest = new ListTest[2];
            //ListTest[0] = { 1, "John", "Doe" };
            //ListTest[1] = { 2, "GI", "Jane" };
            //ListTest[2] = { 3, "Mario", "Bros" };
            //int result = 3;

            ////Act
            //int resultListTest = People.Size(listTest);


            //Assert
        }
            //Assert.Equal(result, resultListTest);
        [Fact]
        public void ClearTest()
        {
            //Arrange

            string[] listTest = { "John", "Jack", "Maria" };
            //int result = 0;


            //Act
            //int resultListTest = People.Clear(listTest);


            //Assert
            //Assert.Equal(result, resultListTest);
        }

    }
}
