using practice.jd.Helpers;
using System;

public class SinglyLinkedList
{
    public Node Head;

    // Add a node to the end
    public void Append(int data)
    {
        Node newNode = new Node(data);

        if (Head == null)
        {
            Head = newNode;
            return;
        }

        Node current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    // Print all nodes
    public void PrintList()
    {
        Node current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " then ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}
