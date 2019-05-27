using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDoubleCharList()
        {
            LinkedLists.LinkedListHelpers.push('A');
            LinkedLists.LinkedListHelpers.push('B');
            LinkedLists.LinkedListHelpers.push('A');
            LinkedLists.LinkedListHelpers.push('B');
            LinkedLists.LinkedListHelpers.push('E');
            LinkedLists.LinkedListHelpers.push('E');
            LinkedLists.LinkedListHelpers.push('B');
            LinkedLists.LinkedListHelpers.push('E');
            LinkedLists.LinkedListHelpers.deletePlusTwoDuplicates();
            var ListB = LinkedLists.LinkedListHelpers.printList();
            Assert.AreEqual(ListB.Trim(), "EBEBAA");
        }
    }
}
