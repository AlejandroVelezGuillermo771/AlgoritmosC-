// BinaryTree.cs
using System.Xml.Linq;

public class BinaryTree
{
    private Node root;

    public void Insert(int data)
    {
        root = InsertRecursive(root, data);
    }

    private Node InsertRecursive(Node root, int data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        if (data < root.Data)
            root.Left = InsertRecursive(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRecursive(root.Right, data);

        return root;
    }

    public void InOrderTraversal()
    {
        InOrderTraversalRecursive(root);
    }

    private void InOrderTraversalRecursive(Node root)
    {
        if (root != null)
        {
            InOrderTraversalRecursive(root.Left);
            Console.Write(root.Data + " ");
            InOrderTraversalRecursive(root.Right);
        }
    }
}
