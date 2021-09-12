using System;

namespace ConsoleApp1
{
    class DoublyLinkedList
    {
        private int _size = 0;
        public Node head;
        public Node tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = head;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Size()
        {
            return _size;
        }

        public Node Unshift(dynamic data)
        {
            Node newNode = new Node(data);
            _size++;

            if (head == null)
            {
                head = newNode;
                tail = head;

                return head;
            }

            newNode.next = head;
            head.previous = newNode;
            head = newNode;

            return head;
        }

        public Node Push(dynamic data)
        {
            Node newNode = new Node(data);
            _size++;

            if (head == null)
            {
                head = newNode;
                tail = newNode;
                return head;
            }

            tail.next = newNode;
            newNode.previous = tail;
            tail = newNode;

            return tail;
        }

        public Node Find(dynamic data)
        {
            Node currentNode = head;

            while (currentNode?.data != data && currentNode != null)
            {
                currentNode = currentNode.next;
            }

            if (currentNode == null)
            {
                Console.WriteLine("No se encontró el nodo.");
                return currentNode;
            }

            return currentNode;
        }

        public Node AddBefore(dynamic data, dynamic value)
        {
            Node currentNode = Find(data);

            if (currentNode == null) return currentNode;

            if (currentNode == head)
            {
                Node unshiftedNode = Unshift(value);
                return unshiftedNode;
            }

            _size++;

            Node newNode = new Node(value)
            {
                previous = currentNode.previous,
                next = currentNode
            };


            currentNode.previous.next = newNode;
            currentNode.previous = newNode;


            return newNode;
        }

        public Node AddAfter(dynamic data, dynamic value)
        {
            Node currentNode = Find(data);

            if (currentNode == null) return currentNode;

            Node newNode = new Node(value)
            {
                previous = currentNode,
                next = currentNode.next
            };
            currentNode.next = newNode;
            currentNode.next.previous = newNode;
            _size++;

            return newNode;
        }

        public Node Remove(dynamic data)
        {
            Node node = Find(data);

            Node previousNode = node.previous;
            Node nextNode = node.next;

            previousNode.next = nextNode;
            nextNode.previous = previousNode;
            _size--;

            return node;
        }

        public void GetAll()
        {
            string str = "";
            Node currentNode = head;

            while (currentNode != null)
            {
                str += $"{ currentNode.data } <=> ";
                currentNode = currentNode.next;
            }

            str += "null";

            Console.WriteLine(str);
        }
    }
}
