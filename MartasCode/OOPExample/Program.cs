namespace OOPExample;

internal class Program
{
    static void Main(string[] args)
    {
        int[] myNumbersArray = new int[]{};
        int myNumbersArrayLength = 0;

        AddItemToArray(ref myNumbersArray, ref myNumbersArrayLength, 10);
        AddItemToArray(ref myNumbersArray, ref myNumbersArrayLength, 20);
        AddItemToArray(ref myNumbersArray, ref myNumbersArrayLength, 30);
    }

    static void AddItemToArray(ref int[] array, ref int arrayLength, int newItem)
    {
        int newNumbersArrayLength = arrayLength + 1;
        var newNumbersArray = new int[newNumbersArrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            newNumbersArray[i] = array[i];
        }

        newNumbersArray[newNumbersArrayLength-1] = newItem;

        array = newNumbersArray;
        arrayLength = newNumbersArrayLength;
    }
}
