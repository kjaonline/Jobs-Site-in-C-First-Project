using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junior_Dev_Jobs.Classes
{
    public class Job
    {
        private int Id { get; set; }
        private String Job_name { get; set; }
        private String Job_description { get; set; }
        private double Salary { get; set; }

        public void Job_information(string name, string description, double salary)
        {
            name = this.Job_name;
            description = this.Job_description;
            salary = this.Salary;
        }
    }
}   
