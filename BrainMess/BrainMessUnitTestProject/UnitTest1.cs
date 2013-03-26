using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrainMess;


namespace BrainMessUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForward()
        {
            
        }
        [TestMethod]
        public void TestMethodBackward()
        {

        }
        [TestMethod]
        public void TestMethodIncrement()
        {
             
           BrainMessInterpreter obj= new BrainMessInterpreter(){tape =new List<int>(0),tapeHead = 0};
            obj.Increment();

            Assert.Equals( obj.tape[0], 1);
        }
        [TestMethod]
        public void TestMethodDecrement()
        {

        }
        [TestMethod]
        public void TestMethodLoopForward()
        {

        }
        [TestMethod]
        public void TestMethodInterprate()
        {

        }

    }
}
