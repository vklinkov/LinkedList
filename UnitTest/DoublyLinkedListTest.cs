using LinkedList.DoublyLinkedList;
using NUnit.Framework;

namespace UnitTest
{
    public class DoublyLinkedListTest
    {
        private DoublyLinkedList<string> doublyLinkedList;

        private const string DO = "Do";
        private const string RE = "Re";
        private const string MI = "Mi";

        private DoublyLinkedListNode<string> Do;
        private DoublyLinkedListNode<string> Re;
        private DoublyLinkedListNode<string> Mi;

        [SetUp]
        public void SetUp()
        {
            doublyLinkedList = new DoublyLinkedList<string>();

            Do = new DoublyLinkedListNode<string>(DO);
            Re = new DoublyLinkedListNode<string>(RE);
            Mi = new DoublyLinkedListNode<string>(MI);
        }

        [Test]
        public void AddLastNodeTest()
        {
            doublyLinkedList.AddLast(Do);
            doublyLinkedList.AddLast(Re);
            doublyLinkedList.AddLast(Mi);

            Assert.IsTrue(Do.Next.Equals(Re) && Re.Previous.Equals(Do));
            Assert.IsTrue(Re.Next.Equals(Mi) && Mi.Previous.Equals(Re));
        }

        [Test]
        public void RemoveFirstNodeByValueTest()
        {
            doublyLinkedList.AddLast(Do);
            doublyLinkedList.AddLast(Re);
            doublyLinkedList.AddLast(Mi);

            doublyLinkedList.Remove(DO);

            Assert.IsTrue(Re.Previous == null && Re.Next == Mi);
            Assert.IsTrue(Mi.Previous == Re && Mi.Next == null);
        }

        [Test]
        public void RemoveMiddleNodeByValueTest()
        {
            doublyLinkedList.AddLast(Do);
            doublyLinkedList.AddLast(Re);
            doublyLinkedList.AddLast(Mi);

            doublyLinkedList.Remove(RE);

            Assert.IsTrue(Do.Next == Mi && Mi.Previous == Do);
        }

        [Test]
        public void RemoveLastNodeByValueTest()
        {
            doublyLinkedList.AddLast(Do);
            doublyLinkedList.AddLast(Re);
            doublyLinkedList.AddLast(Mi);

            doublyLinkedList.Remove(MI);

            Assert.IsTrue(Re.Next == null);
        }

        [Test]
        public void ShouldNotContainsValueTest()
        {
            doublyLinkedList.AddLast(Do);
            doublyLinkedList.AddLast(Mi);

            bool contains = doublyLinkedList.Contains(RE);

            Assert.IsFalse(contains);
        }

        [Test]
        public void ShouldReturnNullIfNoValue()
        {
            doublyLinkedList.AddLast(Do);
            doublyLinkedList.AddLast(Mi);

            var linkedListNode = doublyLinkedList.Find(RE);

            Assert.IsNull(linkedListNode);
        }

        [Test]
        public void AddAndCheckToArrayTest()
        {
            doublyLinkedList.AddLast(Do);
            doublyLinkedList.AddLast(Re);
            doublyLinkedList.AddLast(Mi);

            var arr = doublyLinkedList.ToArray();

            Assert.AreEqual(arr[0], DO);
            Assert.AreEqual(arr[1], RE);
            Assert.AreEqual(arr[2], MI);
        }

        [Test]
        public void AddThenRemoveAndCheckToArrayTest()
        {
            doublyLinkedList.AddLast(Do);
            doublyLinkedList.AddLast(Re);
            doublyLinkedList.AddLast(Mi);

            doublyLinkedList.Remove(RE);

            var arr = doublyLinkedList.ToArray();

            Assert.AreEqual(arr[0], DO);
            Assert.AreEqual(arr[1], MI);
        }
    }
}
