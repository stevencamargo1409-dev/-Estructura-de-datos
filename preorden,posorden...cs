using System;
using System.Collections.Generic;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class TreeTraversals
{
    public void PreOrder(Node node)
    {
        if (node == null) return;
        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    public void InOrder(Node node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    public void PostOrder(Node node)
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    public void LevelOrder(Node root)
    {
        if (root == null) return;
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            Console.Write(current.Data + " ");
            if (current.Left != null) queue.Enqueue(current.Left);
            if (current.Right != null) queue.Enqueue(current.Right);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Node root = new Node(45);
        root.Left = new Node(23);
        root.Right = new Node(67);
        root.Left.Left = new Node(12);
        root.Left.Right = new Node(38);
        root.Right.Left = new Node(6);
        root.Right.Right = new Node(16);

        TreeTraversals traversals = new TreeTraversals();

        traversals.PreOrder(root);
        Console.WriteLine();

        traversals.InOrder(root);
        Console.WriteLine();

        traversals.PostOrder(root);
        Console.WriteLine();

        traversals.LevelOrder(root);
        Console.WriteLine();
    }
}
