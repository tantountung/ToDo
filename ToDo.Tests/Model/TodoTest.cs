using System;
using ToDo.Model;
using Xunit;

namespace ToDo.Tests.Model
{
    
    public class TodoTest
    {
        [Fact]
        public void TodoInitTest()
        {
            //Arrange
            int tesTodoId = 54321;
            string tesDescription = "mopping";

            //Act
            Todo todo = new Todo(tesTodoId, tesDescription);

            //Assert
            Assert.Equal(tesTodoId, todo.TodoId);
            Assert.Equal(tesDescription, todo.Description);



        }
        [Fact]
        public void TodoInitTest1()
        {
            //Arrange
            int tesTodoId = 5678;
            string tesDescription = null;

            //Act
            Todo todo = new Todo(tesTodoId, tesDescription);

            //Assert
            Assert.Equal(tesTodoId, todo.TodoId);
            Assert.Equal(tesDescription, todo.Description);



        }
    }
}
