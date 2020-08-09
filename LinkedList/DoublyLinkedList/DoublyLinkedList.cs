
namespace LinkedList.DoublyLinkedList
{
    public class DoublyLinkedList
    {
        private DoublyLinkedListNode Head;
        private DoublyLinkedListNode Tail;

        private int Size = 0;

        public void AddLast(DoublyLinkedListNode doublyLinkedListNode)
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

            if (currentHead.Data == value)
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
                    if (currentHead.Data == value)
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
                if (currentHead.Data == value) return true;

                currentHead = currentHead.Next;
            }

            return false;
        }

        public DoublyLinkedListNode Find(string value)
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
