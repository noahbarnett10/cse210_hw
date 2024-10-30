using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Assignment A = new Assignment("Noah Barnett", "Circuits");
        Console.WriteLine(A.GetSummary());

        MathAssignment MA = new MathAssignment("Noah Barnett", "Circuits", "6.5", "11-14");
        Console.WriteLine(MA.GetHomeworkList());

        WritingAssignment WA = new WritingAssignment("Noah Barnett", "Circuits", "Digital Systems");
        Console.WriteLine(WA.GetWritingInformation());
    }
}