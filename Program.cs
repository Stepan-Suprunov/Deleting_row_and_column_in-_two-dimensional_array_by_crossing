// Удаление строки и столбца на пересечении которых расположен наименьший элемент двумерного массива


void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(-99, 100);

        }
    }
}

void DeleteTarget(int[,] collection, int[,] collection2)
{
    int x = 0;
    int y = 0;
    int min = collection[0, 0];
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            if (collection[i, j] < min)
            {
                min = collection[i, j];
                x = j;
                y = i;
            }
        }
    }
    Console.WriteLine(min + " " + x + " " + y);

    int countX = 0;
    int countY = 0;
    for (int k = 0; k < collection.GetLength(0); k++)
    {
        for (int l = 0; l < collection.GetLength(1); l++)
        {
            if (k != y && l != x)
            {
                collection2[countY, countX] = collection[k, l];
                countX++;
            }
        }
        countX = 0;
        if (k != y) countY++;
    }
}

int m = 4, n = 4;
int[,] array = new int[m, n];
int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

FillArray(array);
PrintArray(array);
Console.WriteLine("_______________");
DeleteTarget(array, newArray);
Console.WriteLine("_______________");
PrintArray(newArray);