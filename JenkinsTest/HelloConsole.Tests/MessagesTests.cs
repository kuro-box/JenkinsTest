using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsole.Tests
{
    [TestClass()]
    public class MessagesTests
    {
        [TestMethod()]
        public void GetMessageTest()
        {
            var result = new Messages().GetMessage(this);
            Assert.AreNotEqual(string.Empty, result);
        }
    }
}