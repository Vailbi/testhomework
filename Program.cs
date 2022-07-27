
string [] inputArr = {"one" , "two0" ,  "=_=" , "rus", "test", "00"};
int newSize = 0;
for (int i = 0; i < inputArr.Length; i++)
{
   if (inputArr[i].Length <= 3)
   {
    newSize++;
   } 
}
string [] newArr = new string[newSize];

int j= 0;

for (int i = 0; i < inputArr.Length; i++)
{
    if (inputArr[i].Length <= 3)
    {
        newArr[j] = inputArr[i];
        j++;
    }
}

string Print(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (i == length-1)
        {
            output+= ($"\"{array[i]}\"");
        }
        else
        output+= ($"\"{array[i]}\", ");
    }
    return output;
}

Console.WriteLine($"[{Print(newArr)}]");
File.WriteAllText("output.txt" , Print(newArr));