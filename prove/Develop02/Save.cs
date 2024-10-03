using System;
using System.IO;

public class Save 
{

    public void saveFun()
    {
        Console.Write("What is the file name? ");
        string fileName = Console.ReadLine();

        using (StreamReader inputFile = new StreamReader(fileName))
        {
            string line;
            while ((line = inputFile.ReadLine()) != null) 
            {
                Console.WriteLine(line);
            }
        }
    }
}