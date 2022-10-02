void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length){
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
int[] array = new int[10];

void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while(pos < count){
        Console.WriteLine(col[pos]);
        pos++;
    }
}

int IndexOf(int[] collection, int find){
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count){
        if(collection[index] == find){
            position = index;
            break;
        }
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 5);
Console.WriteLine(pos);