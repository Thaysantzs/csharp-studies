using System;
namespace DataStructures.BinarySearch;

public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree Tree = new BinarySearchTree();

        // Left
        Tree.Add(50);
        Tree.Add(48);
        Tree.Add(49);
        Tree.Add(37);
        Tree.Add(45);
        Tree.Add(39);
        Tree.Add(46);
        Tree.Add(47);
        Tree.Add(19);

        // Right
        Tree.Add(80);
        Tree.Add(70);
        Tree.Add(88);
        Tree.Add(77);
        Tree.Add(63);
        Tree.Add(99);
        Tree.Add(100);
        Tree.Add(90);

        Tree.PrintTree();
    }
}

public class BinarySearchTree
{
    // Nodes of Tree
    private class Node
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

    // Binary Tree

    private Node? _root;
    public int Count { get; private set; }

    public BinarySearchTree()
    {
        _root = null;
    }

    // Add

    public void Add(int value)
    {
        if(_root == null)
        {
            _root = new Node(value);
            Count++;
        }
        else
        {
            Add(_root, value);
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

    // remove

    public void Remove(int target)
    {
       _root = Remove(_root, target);
    }

    private Node? Remove(Node? root, int target)
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
                    var sucessor = FindMin(root.Right);
                    root.Data = sucessor.Data;
                    root.Right = Remove(root.Right, sucessor.Data);
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

                    return root;
                }
                else
                {
                    Count--;
                    root = null;
                    return root;
                }
            }
        }

        return root;
    }

    public void Clear()
    {
        _root = null;
        Count = 0;
    }

    private Node FindMax(Node root)
    {

        while(root?.Right != null)
        {
            root = root.Right;
        }

        return root!;
    }

    private Node FindMin(Node root)
    {

        while(root?.Left != null)
        {
            root = root.Left;
        }

        return root!;
    }


    // Contains
    public bool Contains(int value)
    {
        return Contains(_root, value);
    }

    private bool Contains(Node? root, int value)
    {
        if(root == null)
        {
            return false;
        }

        if(value == root.Data)
        {
            return true;
        } 
        else if(value < root.Data)
        {
            return Contains(root.Left, value);
        }
        else
        {
            return Contains(root.Right, value);
        }
    }

    // TraversalInOrder
    public void InOrderTraversal()
    {
        InOrder(_root);
    }

    private void InOrder(Node? root)
    {
        if(root == null)
        {
            return;
        }

        InOrder(root.Left);
        Console.Write($"{root.Data} ");
        InOrder(root.Right);
    }

    // TraversalPreOrder
    public void PreOrderTraversal()
    {
        PreOrder(_root);
    }

    private void PreOrder(Node? root)
    {
        if(root == null)
        {
            return;
        }
        
        Console.Write($"{root.Data} ");
        PreOrder(root.Left);
        PreOrder(root.Right);
    }

    // TraversalPostOrder
    public void PostOrderTraversal()
    {
        PostOrder(_root);
    }

    private void PostOrder(Node? root)
    {
        if(root == null)
        {
            return;
        }
        
        PostOrder(root.Left);
        PostOrder(root.Right);
        Console.Write($"{root.Data} ");
    }

    //height
    public int Height()
    {
        return Height(_root);
    }

    private int Height(Node? root)
    {
        if(root == null)
        {
            return 0;
        }

        int LeftHeight = Height(root.Left);
        int RightHeight = Height(root.Right);

        return 1 + Math.Max(LeftHeight, RightHeight);
    }

    // Print tree
    public void PrintTree()
    {
        Print(_root, "", true);
    }

    private void Print(Node? node, string prefix, bool isRight)
    {
        if (node == null)
            return;

        // Imprime primeiro a direita
        Print(node.Right,
            prefix + (isRight ? "│   " : "    "),
            true);

        // Imprime o nó atual
        Console.WriteLine(prefix +
                        (isRight ? "┌── " : "└── ") +
                        node.Data);

        // Imprime depois a esquerda
        Print(node.Left,
            prefix + (isRight ? "    " : "│   "),
            false);
    }
}