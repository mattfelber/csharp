using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public class Job
{
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _endYear;


    public Job(string title, string company, int startyear, int endyear) 
    {
        _jobTitle = title;
        _companyName = company;
        _startYear = startyear;
        _endYear = endyear;
}

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }




}
/* public class Resume(string name, List<job>)
{
    return $"name: {name}\nJobs:{List<Job>}";
} */