using System;
namespace DataStructures.BinarySearchTree;

public class BinarySearchTreeApp
{
    public static void Main(string[] args)
    {
        var bts = new BinarySearchTree();

        bts.Add(50);
        bts.Add(25);
        bts.Add(75);
        bts.Add(12);
        bts.Add(35);
        bts.Add(65);
        bts.Add(90);
        bts.Add(5);
        bts.Add(47);
        bts.Add(85);
        bts.Add(100);
        bts.Add(89);
        bts.Add(4);
        bts.Add(6);
        bts.Add(40);
        bts.Add(49);
        bts.Add(30);

        var list = bts.TraversalInOrder();

        foreach(var element in list)
        {
            Console.Write($"{element}, ");
        }

        Console.WriteLine();
        Console.WriteLine(bts.Contains(100) == true);
        Console.WriteLine(bts.Contains(35) == true);
        Console.WriteLine(bts.Contains(0) == false);

        bts.Remove(90);
    }
}

public class BinarySearchTree
{
    private Node? Root { get; set; }
    public int Count { get; private set; }

    public BinarySearchTree()
    {
        Root = null;
    }

    public void Add(int value)
    {
        if(Root == null)
        {
            Root = new Node(value);
            Count++;
        }
        else
        {
            Add(Root, value);
        }
    }

    private void Add(Node root, int value)
    {
        if(root.Data != value)
        {
            if(root.Data > value)
            {
                if(root.Left == null)
                {
                    root.Left = new Node(value);
                    Count++;
                }
                else
                {
                    Add(root.Left, value);
                }
            }
            else
            {
                if(root.Right == null)
                {
                    root.Right = new Node(value);
                    Count++;
                }
                else
                {
                    Add(root.Right, value);
                }
            }
        }
    }

    public void Remove(int target)
    {
        Root = Remove(Root, target );
    }

    private Node Remove(Node? root, int target)
    {
        if(root != null)
        {
            if(target < root.Data)
            {
                root.Left = Remove(root.Left, target);
            }
            else if(target > root.Data)
            {
                root.Right = Remove(root.Right, target);
            }
            else
            {
                if(root.Left != null && root.Right != null)
                {
                    var successor = FindMin(root.Right);
                    root.Data = successor.Data;
                    root.Right = Remove(root.Right, successor.Data);
                }
                else if(root.Left != null || root.Right != null)
                {
                    Count--;
                    if(root.Left != null)
                    {
                        root = root.Left;
                    }
                    else
                    {
                        root = root.Right;
                    }
                    return root!;
                }
                else
                {
                    Count--;
                    root = null;
                    return root!;
                }
            }
        }
        return root!;
    }

    private Node FindMin(Node? node)
    {
        while(node?.Left != null)
        {
            node = node.Left;
        }
        return node!;
    }

    public bool Contains(int value)
    {
        return Contains(Root, value);
    }

    private bool Contains(Node? root, int value)
    {
        if(root == null)
        {
            return false;
        }

        if(root.Data == value)
        {
            return true;
        }else if(root.Data > value)
        {
            return Contains(root.Left, value);
        }
        else
        {
            return Contains(root.Right, value);
        }
    }

    public List<int> TraversalInOrder()
    {
        var result = new List<int>(); 
        InOrder(Root, result);
        return result;
    }

    private void InOrder(Node? root, List<int> result)
    {
        if(root != null)
        {
            InOrder(root.Left!, result);
            result.Add(root.Data);
            InOrder(root.Right!, result);
        }
    }

    public List<int> TraversalPreOrder()
    {
        var result = new List<int>();
        PreOrder(Root, result);
        return result;
    }

    private void PreOrder(Node? root, List<int> result)
    {
        if(root != null)
        {
            result.Add(root.Data);
            PreOrder(root.Left, result);
            PreOrder(root.Right, result);
        }
    }

    public List<int> TraversalPostOrder()
    {
        var result = new List<int>();
        PostOrder(Root, result);
        return result;
    }

    private void PostOrder(Node? root, List<int> result)
    {
        if(root != null)
        {
            PostOrder(root.Left, result);
            PostOrder(root.Right, result);
            result.Add(root.Data);
        }
    }
}


public class Node
{
    public int Data { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}