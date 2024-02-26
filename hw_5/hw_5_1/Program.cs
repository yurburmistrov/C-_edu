string GetStringFromCharArray(char[,] array)
{
    string result = string.Empty; 
    for (int i = 0; i < array.GetLength(0); i++) 
    {
      
        for (int j = 0; j < array.GetLength(1); j++)
 
    {
        result = result + array[i,j];
       
    }
    }
    return result;
}
char[,] chars = {{'a','b','c'} , {'d','e','f'}};
string res = GetStringFromCharArray(chars);
Console.WriteLine(res);
