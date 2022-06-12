/* Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
ав, ва, ви, ив, св, вс */

string charsWords = "аисв";
int WordsLength = 2;

void PrintAllWords (string alphabeth, int length, string prefix)
{
    if (length == 0) Console.Write(prefix + " ");
    else foreach (char c in alphabeth) PrintAllWords (alphabeth, length-1, prefix + c);
}

PrintAllWords(charsWords, WordsLength, "");
Console.WriteLine();