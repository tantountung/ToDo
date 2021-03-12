using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDo.Data;

namespace ToDo.Tests.Data
{
    public class TodoSequencerTest
    {
        [Fact]
        public void TodoSeqInitTest()
        {
            //Arrange
            int todoId = 256;
            int todoIdNew = 257;

            //Act
            int result = TodoSequencer.NextTodoId(todoId);

            //Assert
            Assert.Equal(todoIdNew, result);
        }
        [Fact]
        public void TodoSeqInitTest1()
        {
            //Arrange
            int tesId = 253;


            //Act
            int result = TodoSequencer.Reset(tesId);

            //Assert
            Assert.Equal(0, result);
        }
    }
}
