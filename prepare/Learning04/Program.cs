using System;

class Program
{
    static void Main(string[] args)
    {
        //Assignment assignment1 = new Assignment();
        //Console.WriteLine(assignment1.GetSummary());

        Assignment assignment2 = new Assignment("Bob Jones", "Math");
        Console.WriteLine(assignment2.GetSummary());    

        MathAssignment math1 = new MathAssignment("Frank Joe", "Calculus 1", "Section 1", "Problems 1-10");
        Console.Write(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment writing1 = new WritingAssignment("Elly Mae", "ELA 4", "Write an Essay");
        Console.Write(writing1.GetSummary());
        Console.WriteLine(writing1.GetWritingInformation());
    }
}