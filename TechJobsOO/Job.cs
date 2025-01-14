﻿namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
            Name = "ID only";
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override string ToString()
        {
            if (this.Name.Equals("ID only"))
            {
                return "OOPS! This job does not seem to exist.";
            }
            else
            {
                return "\n" + "ID: " + this.Id + "\nName: " + this.Name + "\nEmployer: " + this.EmployerName + "\nLocation: " + this.EmployerLocation + "\nPosition Type: " + this.JobType + "\nCore Competency: " + this.JobCoreCompetency + "\n";
            }
        }
    }
}
