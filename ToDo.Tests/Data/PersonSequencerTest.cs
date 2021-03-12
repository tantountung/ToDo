using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToDo.Data;

namespace ToDo.Tests.Data
{
    public class PersonSequencerTest
    {
        [Fact]
        public void PersonSeqInitTest()
        {
            //Arrange
            int tesId = 123;
            int tesIdNew = 124;

            //Act
            int result = PersonSequencer.NextPersonId(tesId);

            //Assert
            Assert.Equal(tesIdNew, result);
        }
        [Fact]
        public void PersonSeqInitTest1()
        {
            //Arrange
            int tesId = 123;
            

            //Act
            int result = PersonSequencer.Reset(tesId);

            //Assert
            Assert.Equal(0, result);
        }
    }
}
