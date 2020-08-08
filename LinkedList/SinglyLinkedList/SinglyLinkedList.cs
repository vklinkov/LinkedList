
namespace LinkedList.SinglyLinkedList
{
    public class SinglyLinkedList
    {
        private SinglyLinkedListNode Head;
        private SinglyLinkedListNode Tail;

        private int Size = 0;

        public void AddLast(SinglyLinkedListNode linkedListNode)
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

        public void Remove(string value)
        {
            if (Head == null) return;
            var currentHead = Head;

            if (currentHead.Data == value)
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
                    if (currentHead.Data == value)
                    {
                        prev.Next = currentHead.Next;
                        Size--;
                        break;
                    }
                    currentHead = currentHead.Next;
                }
            }
        }

        public bool Contains(string value)
        {
            var currentHead = Head;

            while(currentHead != null)
            {
                if (currentHead.Data == value) return true;

                currentHead = currentHead.Next;
            }

            return false;
        }

        public SinglyLinkedListNode Find(string value)
        {
            var currentHead = Head;

            while(currentHead != null)
            {
                if(currentHead.Data == value)
                {
                    return currentHead;
                }
                currentHead = currentHead.Next;
            }

            return null;
        }

        public string[] ToArray()
        {
            var currentHead = Head;

            string[] res = new string[Size];

            for (var i = 0; i < Size; i++)
            {
                res[i] = currentHead.Data;

                currentHead = currentHead.Next;
            }

            return res;
        }
    }
}
