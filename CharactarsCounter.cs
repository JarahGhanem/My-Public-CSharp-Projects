// Charactars Counter Written in C#
//        -+ By: Jarah! +-
using System;
using System.IO;
sealed class MainClass
{
    static void Main()
    {
        int CharactarsCounter = 0;
        var sReader = File.OpenRead(Environment.CurrentDirectory + "\\new.txt");
        for (int i = 0; i < sReader.Length; i++)
        {
            CharactarsCounter++;
        }
        Console.WriteLine("Charactars: " + CharactarsCounter);
        Console.ReadKey();
    }
}
