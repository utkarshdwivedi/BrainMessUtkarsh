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
            List<int> testtape = new List<int>
                {
                    0
                };
            const int testtapeHead = 0;

            BrainMessInterpreter obj = new BrainMessInterpreter { tape = testtape, tapeHead = testtapeHead };
            obj.Forward();
            Assert.AreEqual(testtape.Count, 2);
        }
        [TestMethod]
        public void TestMethodBackward()
        {
            List<int> testtape = new List<int>
                {
                    0
                };
            

            BrainMessInterpreter obj = new BrainMessInterpreter { tape = testtape, tapeHead =1 };
            obj.Backward();
            Assert.AreEqual(obj.tapeHead, 0);
        }
        [TestMethod]
        public void TestMethodIncrement()
        {
             List<int> testtape= new List<int>
                 {
                     0
                 };
            const int testtapeHead = 0;

           BrainMessInterpreter obj= new BrainMessInterpreter {tape = testtape,tapeHead = testtapeHead};
            obj.Increment();
            Assert.AreEqual( testtape[0],1);
        }
        [TestMethod]
        public void TestMethodDecrement()
        {
            List<int> testtape = new List<int>
                {
                    1
                };
            const int testtapeHead = 0;

            BrainMessInterpreter obj = new BrainMessInterpreter { tape = testtape, tapeHead = testtapeHead };
            obj.Decrement();
            Assert.AreEqual(testtape[0], 0);
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
