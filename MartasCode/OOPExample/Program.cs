using Microsoft.VisualBasic.CompilerServices;

namespace OOPExample;


internal class MyArray
{
    private int[] array = new int[] { };
    private int arrayLength = 0;

    public void AddItemToArray(int newItem)
    {
        int newArrayLength = arrayLength + 1;
        var newArray = new int[newArrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            newArray[i] = array[i];
        }

        newArray[newArrayLength - 1] = newItem;

        array = newArray;
        arrayLength = newArrayLength;
    }

    public int GetItemAtIndex(int index)
    {
        if (index >= arrayLength)
        {
            throw new ArgumentException("Hodnota indexu je vetsi nez delka pole");
        }

        return array[index];
    }

    public bool TryGetItemAtIndex(int index, out int value)
    {
        if (index >= arrayLength)
        {
            value = 0;
            return false;
        }

        value = array[index];
        return true;
    }
}





internal class Program
{
    static void Main(string[] args)
    {
        var myArray1 = new MyArray();
        var myArray2 = new MyArray();

        myArray1.AddItemToArray(10);
        myArray1.AddItemToArray(20);
        myArray1.AddItemToArray(30);
        myArray1.AddItemToArray(40);


        if (myArray1.TryGetItemAtIndex(2, out var x1))
        {
            Console.WriteLine(x1);
        }

        var x2 = myArray1.GetItemAtIndex(40);

        myArray2.AddItemToArray(11);
    }
}
