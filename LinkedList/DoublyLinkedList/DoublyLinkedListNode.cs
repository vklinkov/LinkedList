using System;
namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedListNode
    {
        public DoublyLinkedListNode(string data)
        {
            Data = data;
        }

        public string Data { get; set; }

        public DoublyLinkedListNode Next;
        public DoublyLinkedListNode Previous;
    }
}
