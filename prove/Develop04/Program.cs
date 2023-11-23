using System;

class Program
{
    static void Main(string[] args)
    {
        Activity act1 = new Activity("breath", "description", 5);
        act1.ShowSpinner(10);
    }
}