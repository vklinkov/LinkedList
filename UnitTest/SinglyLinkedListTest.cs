using LinkedList.SinglyLinkedList;
using NUnit.Framework;

namespace UnitTest
{
    public class SinglyLinkedListTest
    {
        private SinglyLinkedList<string> singlyLinkedList;

        private const string DO = "Do";
        private const string RE = "Re";
        private const string MI = "Mi";

        private SinglyLinkedListNode<string> Do;
        private SinglyLinkedListNode<string> Re;
        private SinglyLinkedListNode<string> Mi;

        [SetUp]
        public void SetUp()
        {
            singlyLinkedList = new SinglyLinkedList<string>();

            Do = new SinglyLinkedListNode<string>(DO);
            Re = new SinglyLinkedListNode<string>(RE);
            Mi = new SinglyLinkedListNode<string>(MI);
        }

        [Test]
        public void AddLastNodeTest()
        {
            singlyLinkedList.AddLast(Do);
            singlyLinkedList.AddLast(Re);
            singlyLinkedList.AddLast(Mi);

            Assert.IsTrue(Do.Next == Re && Re.Next == Mi && Mi.Next == null);
        }

        [Test]
        public void RemoveFirstNodeByValueTest()
        {
            singlyLinkedList.AddLast(Do);
            singlyLinkedList.AddLast(Re);
            singlyLinkedList.AddLast(Mi);

            singlyLinkedList.Remove(DO);

            Assert.IsFalse(singlyLinkedList.Contains(DO));
        }

        [Test]
        public void RemoveMiddleNodeByValueTest()
        {
            singlyLinkedList.AddLast(Do);
            singlyLinkedList.AddLast(Re);
            singlyLinkedList.AddLast(Mi);

            singlyLinkedList.Remove(RE);

            Assert.IsTrue(Do.Next == Mi);
        }

        [Test]
        public void RemoveLastNodeByValueTest()
        {
            singlyLinkedList.AddLast(Do);
            singlyLinkedList.AddLast(Re);
            singlyLinkedList.AddLast(Mi);

            singlyLinkedList.Remove(MI);

            Assert.IsTrue(Do.Next == Re && Re.Next == null);
        }

        [Test]
        public void ShouldNotContainsValueTest()
        {
            singlyLinkedList.AddLast(Do);
            singlyLinkedList.AddLast(Mi);

            bool contains = singlyLinkedList.Contains(RE);

            Assert.IsFalse(contains);
        }

        [Test]
        public void ShouldReturnNullIfNoValue()
        {
            singlyLinkedList.AddLast(Do);
            singlyLinkedList.AddLast(Mi);

            var linkedListNode = singlyLinkedList.Find(RE);

            Assert.IsNull(linkedListNode);
        }

        [Test]
        public void AddAndCheckToArrayTest()
        {
            singlyLinkedList.AddLast(Do);
            singlyLinkedList.AddLast(Re);
            singlyLinkedList.AddLast(Mi);

            var arr = singlyLinkedList.ToArray();

            Assert.AreEqual(arr[0], DO);
            Assert.AreEqual(arr[1], RE);
            Assert.AreEqual(arr[2], MI);
        }

        [Test]
        public void AddThenRemoveAndCheckToArrayTest()
        {
            singlyLinkedList.AddLast(Do);
            singlyLinkedList.AddLast(Re);
            singlyLinkedList.AddLast(Mi);

            singlyLinkedList.Remove(RE);

            var arr = singlyLinkedList.ToArray();

            Assert.AreEqual(arr[0], DO);
            Assert.AreEqual(arr[1], MI);
        }
    }
}