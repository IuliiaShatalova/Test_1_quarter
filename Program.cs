string [] array = {"left", "see", "^_^", "Julia", "you"};
string [] array2 = new string [array.Length];

string [] find3CharStrings ()
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                array2[count] = array[i];
                count ++;
            }
        }
        return array2;
    }

void printArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

void printArray2()
    {
        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine(array2[i]);
        }
    }

find3CharStrings();
printArray();
Console.WriteLine();
printArray2();


        