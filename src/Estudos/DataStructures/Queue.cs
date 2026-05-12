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
using DataStructures.NewLinked;
namespace DataStructures.Newqueue;

public class NewQueue<T>
{
    private readonly DoublyLinkedList<T> _list;
    public int Capacity { get; private set; }
    public int Length => _list.Count;

    public NewQueue(int capacity = int.MaxValue)
    {
        _list = new DoublyLinkedList<T>();
        Capacity = capacity;
    }

    public T Peek => IsEmpty ? throw new InvalidOperationException("Queue is empty") : _list.Head!;

    public bool IsEmpty => _list.Count == 0; 

    public bool IsFull => Capacity == _list.Count;

    public void Enqueue(T value)
    {
        if (IsFull)
        {
            throw new InvalidOperationException("Queue is full");
        }
        _list.AddAtTail(value);
    }

    public T Dequeue()
    {
        if (IsEmpty)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        T value = _list.Head!;
        _list.RemoveHead();
        return value;
    }
}