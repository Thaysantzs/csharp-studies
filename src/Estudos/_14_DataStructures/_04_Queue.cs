/*
# What is a Queue?
  # A queue is a type of data structure that stores elements in a sequence which is enforced by the operations used.
  # It follows the FIFO (First-In-First-Out) methodology, meaning the data that gets in first, gets out first.
  # The process to add an element into queue is called enqueue, and to remove an element from the queue is called dequeue.
# Key Operations/Properties
  # Enqueue: Add an element to the end of the queue.
  # Dequeue: Remove an element from the front of the queue.
  # Peek/Top: Get the value of the front of the queue without removing it.
  # IsEmpty: Check if the queue is empty.
  # IsFull: Check if the queue is full.
  # Length: Number of elements in the queue.
  # Capacity: Max length of the queue
# Real World Examples of Queues
  # Computer Buffers: Printers use queues to manage printing processes.
  # Call Center Systems: These use queues to hold people calling them in an order.
  # CPU Scheduling: The processes are kept into a queue according to their priority.
  # E-commerce Websites: Customers making purchases follow a queue-like structure to make payments.
  # Queue Services: Scalling system by queueing requests and processing them as fast as possible with load balance
 */

using System; 
using DataStructures.DoubleLinkedList;

namespace DataStructures.Queue;

public class MyQueue
{
    private DoubleLinked List { get; set; }
    private const string EXCEPTION_EMPTY_MESSAGE = "The list is empty";
    private const string EXCEPTION_FULL_MESSAGE = "The list is full";

    // Get the next element of list
    public string Peek
    {
        get
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException(EXCEPTION_EMPTY_MESSAGE);
            }

            return List.Head;
        }
    }

    // Constructor
    public MyQueue(int capacity = int.MaxValue)
    {
        List = new DoubleLinked();
        Capacity = capacity;
    }

    public int Capacity { get; private set; }

    // Check if the list is empty
    public bool IsEmpty
    {
        get
        {
            if(List.Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // Check if the list is full
    public bool IsFull
    {
        get
        {
            return List.Count == Capacity;
        }
    }

    // set the size of list
    public int Length
    {
        get
        {
            return List.Count;
        }
    }

    // Enqueue add alement inside de list
    public void Enqueue(string data)
    {
        if (IsFull)
        {
            throw new InvalidOperationException(EXCEPTION_FULL_MESSAGE);
        }
        List.AddAtTail(data);
    }
    
    // Dequeue remove element of the list
    public string Dequeue()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException(EXCEPTION_EMPTY_MESSAGE);
        }
        string value = List.Head;
        List.DeleteAtHead();
        return value;
    }
}