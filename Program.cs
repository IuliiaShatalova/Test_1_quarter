string [] array = {"left", "see", "^_^", "Julia", "you"};

int size = getArrayLength();
string [] array2 = new string [size];
find3CharStrings();
printArray();
Console.WriteLine();
printArray2();


int getArrayLength()
    {
        int length = 0;
        for (int i = 0; i < array.Length; i++)
        {
             if (array[i].Length <= 3)
            {
                length ++;
            }
        }
        return length;
    }

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



        