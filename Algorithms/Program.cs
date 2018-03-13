﻿using System;

namespace LinkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.InsertFirst(10);
            myList.InsertFirst(155);
            myList.InsertFirst(13);
            myList.InsertFirst(9);
            myList.InsertFirst(0);

            myList.DisplayList();

            myList.InsertLast(999);

            myList.DisplayList();

            myList.deleteFirst();
        }
    }

    public class SinglyLinkedList
    {
        private Node first;

        public bool IsEmpty()
        {
            return (first == null);
        }
        
        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("List first -- last");
            Node current = first;
            while (current != null)
            {
                current.DisplayNode();
                current = current.next;
            }

            Console.WriteLine();
        }

        public void InsertLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public void DisplayNode()
        {
            Console.WriteLine("<"+data+">");
        }
    }
}
