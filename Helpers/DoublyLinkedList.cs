using practice.jd.Helpers;
using System;

public class  DoublyLinkedList 
{
    public DoublyNode? Head;
    public DoublyNode? Tail;

    // Add a node to the end
    public void Append(int data)
    {
        DoublyNode newNode = new DoublyNode(data);

        if (Head == null)
        {
            Head = Tail = newNode;
            return;
        }

        Tail.Next = newNode;
        newNode.Prev = Head;
        Tail = newNode;
    }

    //Print list from tail to head
    public void PrintBackward()
    {
        Console.Write("Backward: ");
        DoublyNode current = Tail;
        while (current != null)
        {
            Console.Write(current.Data + " then ");
            current = current.Prev;
        }
        Console.WriteLine("null");
    }
    //Print list from head to tail
    public void PrintForward()
    {
        Console.Write("Forward: ");
        DoublyNode current = Head;
        while (current != null)
        {
            Console.Write(current.Data + " then ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}