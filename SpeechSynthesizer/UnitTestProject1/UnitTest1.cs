using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string startupText = "Welcome to the speech synthesizer. Please enter text and press enter to hear me speak what you write:";
            SpeechSynth.Main();
            Assert.AreEqual(Console.Out.ToString(), startupText);
            Environment.Exit(0);
        }
    }
}
