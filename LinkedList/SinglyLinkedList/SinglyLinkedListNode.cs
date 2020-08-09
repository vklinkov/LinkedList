namespace LinkedList.SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }

    }
}
