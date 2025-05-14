using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_6._3
{
    internal class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }

    class Node
    {
        public Customers Data;
        public Node Next;

        public Node(Customers data)
        {
            Data = data;
            Next = null;
        }
    }

    class QueueStack
    {
        private Node front;
        private Node rear;
        private int size;
        public QueueStack()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public void AddLast(Customers customer)
        {
            Node newNode = new Node(customer);
            if (IsEmpty())
            {
                this.front = newNode;
                this.rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }

            size++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            this.front = front.Next;
            this.size--;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            Node temp = front;
            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.Data.Id}, Name: {temp.Data.Name}, Description: {temp.Data.Description}");
                temp = temp.Next;
            }
        }
    }
}
