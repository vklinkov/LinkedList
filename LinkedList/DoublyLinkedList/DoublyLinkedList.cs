
namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> Head;
        private DoublyLinkedListNode<T> Tail;

        private int Size = 0;

        public void AddLast(DoublyLinkedListNode<T> doublyLinkedListNode)
        {
            if(Head == null)
            {
                Head = doublyLinkedListNode;
                Tail = doublyLinkedListNode;
            }
            else
            {
                Tail.Next = doublyLinkedListNode;
                var temp = Tail;
                Tail = Tail.Next;
                Tail.Previous = temp;
            }
            Size++;
        }

        public void Remove(string value)
        {
            if (Head == null) return;

            var currentHead = Head;

            if (currentHead.Data.Equals(value))
            {
                Head = Head.Next;
                Head.Previous = null;
                Size--;
            }
            else
            {
                var prev = currentHead;
                currentHead = currentHead.Next;
                while (currentHead != null)
                {
                    if (currentHead.Data.Equals(value))
                    {
                        prev.Next = currentHead.Next;
                        if (prev.Next != null)
                        {
                            prev.Next.Previous = prev;
                        }
                        Size--;
                        break;
                    }
                    prev = currentHead;
                    currentHead = currentHead.Next;
                }
            }
        }

        public bool Contains(string value)
        {
            var currentHead = Head;

            while (currentHead != null)
            {
                if (currentHead.Data.Equals(value)) return true;

                currentHead = currentHead.Next;
            }

            return false;
        }

        public DoublyLinkedListNode<T> Find(string value)
        {
            var currentHead = Head;

            while(currentHead != null)
            {
                if(currentHead.Data.Equals(value))
                {
                    return currentHead;
                }
                currentHead = currentHead.Next;
            }

            return null;
        }

        public T[] ToArray()
        {
            var currentHead = Head;

            T[] res = new T[Size];

            for (var i = 0; i < Size; i++)
            {
                res[i] = currentHead.Data;

                currentHead = currentHead.Next;
            }

            return res;
        }
    }
}
