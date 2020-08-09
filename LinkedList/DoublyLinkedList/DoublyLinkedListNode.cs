using System;
namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode(T data)
        {
            Data = data;
        }

        public T Data { get; set; }

        public DoublyLinkedListNode<T> Next;
        public DoublyLinkedListNode<T> Previous;
    }
}
