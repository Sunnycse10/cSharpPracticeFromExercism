using System.Collections;

public class BinarySearchTree : IEnumerable<int>
{
    public BinarySearchTree? left = null;
    public BinarySearchTree? right = null;
    public int val;
    public BinarySearchTree(int value)
    {
        this.val = value;
    }

    public BinarySearchTree(IEnumerable<int> values)
    {
        this.val = values.First();
        foreach (var value in values.Skip(1))
        {
            Add(value);
        }

    }

    public int Value
    {
        get
        {
            return this.val;
        }
    }

    public BinarySearchTree? Left
    {
        get
        {
            return this.left;
        }
    }

    public BinarySearchTree? Right
    {
        get
        {
            return this.right;
        }
    }

    public BinarySearchTree Add(int value)
    {
        if (value > this.Value)
        {
            if (this.Right == null)
            {
                this.right = new BinarySearchTree(value);
            }
            else
                this.Right.Add(value);
        }
        else
        {
            if (this.Left == null)
            {
                this.left = new BinarySearchTree(value);
            }
            else
                this.Left.Add(value);
        }
        return this;
    }

    public IEnumerator<int> GetEnumerator()
    {
        if (this.Left != null)
        {
            foreach (var val in this.Left)
            {
                yield return val;
            }
           
        }

         yield return this.Value;

        if (this.Right != null)
        {
            foreach (var val in this.Right)
            {
                yield return val;
            }
        }


    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}