using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem_SaeedMosaffer
{
    internal abstract class Affiliate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public readonly DateTime AdmissionDate;
        public const string SCHOOL_NAME = "Palestine School";

        public Affiliate(int id, string name, int age, DateTime admissionDate)
        {
            Id = id;
            Name = name;
            Age = age;
            AdmissionDate = admissionDate;
        }

        public abstract string GetDetails();
    }
}
