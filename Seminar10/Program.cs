// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

/*

bool IsVowel(char a)
{
    char[] vowels = new char[]{'a', 'e', 'i', 'o', 'u', 'y'};
    for (int i = 0; i < vowels.Length; i++)
    {
       if(vowels[i]==a)
       {
           return true;
       }
    }
    return false;
}

int SearchStartVowel( string[] strs)
{   
    int count = 0;
    for (int i = 0; i < strs.Length; i++)
    {
        string str = strs[i];
        if(IsVowel(str[0]))
        {
            count++;
        }
    } return count;
}

Console.WriteLine(SearchStartVowel(new string[]{"qwe", "wer", "ert", "rty", "tyu"}));

*/

// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

/*

string[] Join(string[] strings)
{
    string[] resualt = new string[strings.Length / 2];
    for (int i = 0; i < strings.Length; i = i + 2)
    {
        resualt[i / 2] = strings[i] + strings[i + 1];
    }
    return resualt;
}
string[] input = new string[] { "qwe", "wer", "ert", "rty", "tyu", "yui" };
string[] join = Join(input);
for (int i = 0; i < join.Length; i++)
{
    Console.Write(join[i] + ", ");
}

*/