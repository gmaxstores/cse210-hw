using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Fintech";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Web Designer";
        job2._company = "Fornix";
        job2._startYear = 2010;
        job2._endYear = 2017;
        

        Resume myResume = new Resume();
        myResume._name = "Patrick David";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayJobs();
    }
}