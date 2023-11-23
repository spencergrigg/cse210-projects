using System;

class Program
{
    static void Main(string[] args)
    {
        //Assignment ass1 = new Assignment();
        //Console.WriteLine(ass1.GetSummary());

        Assignment ass2 = new Assignment("Bob Jones", "Math");
        Console.WriteLine(ass2.GetSummary());    

        MathAssignment mass1 = new MathAssignment("Frank Joe", "Calculus 1", "Section 1", "Problems 1-10");
        Console.Write(mass1.GetSummary());
        Console.WriteLine(mass1.GetHomeworkList());

        WritingAssignment wass1 = new WritingAssignment("Elly Mae", "ELA 4", "Write an Essay");
        Console.Write(wass1.GetSummary());
        Console.WriteLine(wass1.GetWritingInformation());
    }
}