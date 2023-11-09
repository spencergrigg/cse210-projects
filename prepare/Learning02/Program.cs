using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company =  "Microsoft";
        job1._startYear = 2004;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Computer Tech";
        job2._company =  "Apple";
        job2._startYear = 2000;
        job2._endYear = 2016;

        Resume userResume = new Resume();
        userResume._name = "Spencer Grigg";
        userResume._jobs.Add(job1);
        userResume._jobs.Add(job2);

        userResume.Display();
    }
}

