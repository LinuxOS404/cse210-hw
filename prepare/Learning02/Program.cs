using System;

class Program
{
    static void Main(string[] args)
    {
        
        {
        Job job1 = new Job();
        job1._jobTitle = "Customer support";
        job1._company = "Roi Solutions";
        job1._startYear = 2018;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Cook";
        job2._company = "Via 313";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Celine Heaton";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        }

    }
}