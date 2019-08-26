using System;
using System.Globalization;

string phrase = "The quick brown fox jumps over the lazy dog.";
string[] words = phrase.Split(' ');

    foreach (var word in words)
    {
        System.Console.WriteLine($"<{word}>");
    }

    //This first string split shows that when it runs, it will print out each individual word on its own line. It does this by printing everything thats a letter thats inbetween spaces, hence the ' ', that is a part of the array words.

string phrase = "The quick brown    fox     jumps over the lazy dog.";
string[] words = phrase.Split(' ');

    foreach (var word in words)
    {
        System.Console.WriteLine($"<{word}>");
    }

    //This example shows that the extra spaces will return a empty place in the array words when it prints out. 

char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

string text = "one\ttwo three:four,five six seven";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(delimiterChars);
System.Console.WriteLine($"{words.Length} words in text:");

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

    //This example shows that you can use different symbols to split the array. each part of the array will still print out on its own, you just have to say which characters you want to use to act as splits.

    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

string text = "one\ttwo :,five six seven";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(delimiterChars);
System.Console.WriteLine($"{words.Length} words in text:");

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}

    //This one is very similar to the multiple spaces one. It shows that any consecutive uses of splits will result in an empty array spot.

string[] separatingStrings = { "<<", "..." };

string text = "one<<two......three<four";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
System.Console.WriteLine($"{words.Length} substrings in text:");

foreach (var word in words)
{
    System.Console.WriteLine(word);
}

    //This example shows that you need to make sure you specify what you are using as seperating strings. If you dont specify the right one, it will just print bothwords and the symbol on the same line output.