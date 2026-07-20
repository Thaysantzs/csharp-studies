using System;
namespace DataStructures.BinaryTree;


public class BinaryTreeApp
{
    public static void Main(string[] args)
    {
        var root = new Node("A");

        root.Left = new Node("B");
        root.Left.Left = new Node("D");
        root.Left.Left.Left = new Node("H");
        root.Left.Left.Right = new Node("I");
        root.Left.Right = new Node("E");
        root.Left.Right.Left = new Node("J");
        root.Left.Right.Right = new Node("K");
        root.Right = new Node("C");
        root.Right.Left = new Node("F");
        root.Right.Left.Left = new Node("L");
        root.Right.Left.Right = new Node("M");
        root.Right.Right = new Node("G");
        root.Right.Right.Left = new Node("N");
        root.Right.Right.Right = new Node("O");

        /*Console.Write("In-Order: ");
        InOrder(root);
        Console.WriteLine();
        Console.Write("Pre-Order: ");
        PreOrder(root);
        Console.WriteLine();
        Console.Write("Post-Order: ");
        PostOrder(root);

        Console.WriteLine("\nLeves Binary Tree:\n");
        ByLevel(root);*/

        ByLevelWithoutRecursion(root);
    }

    public static void ByLevelWithoutRecursion(Node root)
    {
        var currenLevel = new Queue<Node>();
        var nextLevel = new Queue<Node>();
        currenLevel.Enqueue(root);

        while(currenLevel.Count > 0)
        {
            var currentNode = currenLevel.Dequeue();
            Console.Write($"{currentNode.Data}, ");

            if(currentNode.Left != null)
            {
                nextLevel.Enqueue(currentNode.Left);
            }

            if(currentNode.Right != null)
            {
                nextLevel.Enqueue(currentNode.Right);
            }

            if(currenLevel.Count == 0)
            {
                currenLevel = nextLevel;
                nextLevel = new Queue<Node>();
            }
        }
    }

    /*
      -
    */
    public static void ByLevel(Node node)
    {
        var dic = new Dictionary<int, List<string>>();
        _bylevel(dic, node, 0);
        for(int i = 0; i < dic.Count; i++)
        {
            Console.Write($"[{i}] ");
            foreach(var element in dic[i])
            {
                Console.Write($"{element}, ");
            }
            Console.WriteLine();
        }
    }

    private static void _bylevel(Dictionary<int, List<string>> dic, Node node, int level)
    {
        if(node == null)
        {
            return;
        }

        if(!dic.ContainsKey(level))
        {
            dic[level] = new List<string>();
        }

        dic[level].Add(node.Data);
        _bylevel(dic, node.Left!, level + 1);
        _bylevel(dic, node.Right!, level + 1);
    }

    /*
      -  In-order traversal is most commonlyimplemented using recursion due to the hierarchical nature 
      -  of trees, though iterative methods using an explicit stack are also used to avoid recursion overhead
    */

    public static void InOrder(Node node)
    {
        if(node == null)
        {
            return;
        }

        InOrder(node.Left!);
        Console.Write($"{node.Data}, ");
        InOrder(node.Right!);
    }

    /*
      -  Pre-order traversal is a depth-first search method for binary trees where nodes are visited in the order:
      -  Root, Left Subtree, Right Subtree. It is used to create a copy of the tree, evaluate prefix expressions, 
      -  or serialize trees. The root is always the first node visited
    */

    public static void PreOrder(Node node)
    {
        if(node == null)
        {
            return;
        }

        Console.Write($"{node.Data}, ");
        PreOrder(node.Left!);
        PreOrder(node.Right!);
    }

    /*
     -  Post-order traversal is a depth-first search (DFS) method where each node is visited after its children.
     -  The sequence follows a Left → Right → Root pattern.
    */

    public static void PostOrder(Node node)
    {
        if(node == null)
        {
            return;
        }

        Console.Write($"{node.Data}, ");
        PostOrder(node.Left!);
        PostOrder(node.Right!);
    }
}

public class Node
{
    public string Data { get; set; }
    public Node? Right { get; set; }
    public Node? Left { get; set; }

    public Node(string data)
    {
        Data = data;
        Right = null;
        Left = null;
    }
}

