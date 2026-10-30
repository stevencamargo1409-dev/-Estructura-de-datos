
using System;

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

public class BinarySearchTree
{
    public Node Root;

    // Inserción Recursiva Preservando Propiedad BST
    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    // Búsqueda de un Elemento O(log N) - Versión pública encapsulada
    public bool Search(int key)
    {
        return SearchRec(Root, key);
    }

    private bool SearchRec(Node root, int key)
    {
        if (root == null)
            return false;

        if (root.Data == key)
            return true;

        return key < root.Data
            ? SearchRec(root.Left, key)
            : SearchRec(root.Right, key);
    }

    // --- LO QUE LE FALTABA: Método de Eliminación ---
    public void Delete(int key)
    {
        Root = DeleteRec(Root, key);
    }

    private Node DeleteRec(Node root, int key)
    {
        if (root == null) return root;

        if (key < root.Data)
            root.Left = DeleteRec(root.Left, key);
        else if (key > root.Data)
            root.Right = DeleteRec(root.Right, key);
        else
        {
            // Nodo con un solo hijo o sin hijos
            if (root.Left == null) return root.Right;
            else if (root.Right == null) return root.Left;

            // Nodo con dos hijos: obtener el sucesor in-order (el menor de la derecha)
            root.Data = MinValue(root.Right);
            root.Right = DeleteRec(root.Right, root.Data);
        }
        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Data;
        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }
        return minv;
    }

    
    public void InOrderTraversal()
    {
        InOrderRec(Root);
        Console.WriteLine();
    }

    private void InOrderRec(Node root)
    {
        if (root != null)
        {
            InOrderRec(root.Left);
            Console.Write(root.Data + " ");
            InOrderRec(root.Right);
        }
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

   
        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };
        foreach (var v in valores)
        {
            bst.Insert(v);
        }

        Console.WriteLine("Recorrido In-Order (Ordenado):");
        bst.InOrderTraversal();

        Console.WriteLine("\n¿Existe el 34?: " + bst.Search(34));
        Console.WriteLine("¿Existe el 99?: " + bst.Search(99));

        Console.WriteLine("\nEliminando el 23...");
        bst.Delete(23);

        Console.WriteLine("Recorrido In-Order después de eliminar:");
        bst.InOrderTraversal();
    }
}
