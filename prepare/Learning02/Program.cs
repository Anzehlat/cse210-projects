using System;
using System.Threading.Tasks.Dataflow;
using System.Xml.XPath;
class Program
{
       static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Production Worker";
        job1._jobCompany = "American Biotech Labs";
        job1._startYear = 2018;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Receptionist";
        job2._jobCompany = "Costco Optical";
        job2._startYear = 2021;
        job2._endYear = 2022;
        
        Resume myResume = new Resume();
        myResume._name = "Anzehla Wolfley";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }

}