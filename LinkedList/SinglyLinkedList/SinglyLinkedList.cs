
namespace LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        private SinglyLinkedListNode<T> Head;
        private SinglyLinkedListNode<T> Tail;

        private int Size = 0;

        public void AddLast(SinglyLinkedListNode<T> linkedListNode)
        {
            if(Head == null)
            {
                Head = linkedListNode;
                Tail = linkedListNode;
            }
            else
            {
                Tail.Next = linkedListNode;
                Tail = Tail.Next;
            }
            Size++;
        }

        public void Remove(T value)
        {
            if (Head == null) return;
            var currentHead = Head;

            if (currentHead.Data.Equals(value))
            {
                Head = currentHead.Next;
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

            while(currentHead != null)
            {
                if (currentHead.Data.Equals(value)) return true;

                currentHead = currentHead.Next;
            }

            return false;
        }

        public SinglyLinkedListNode<T> Find(string value)
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
