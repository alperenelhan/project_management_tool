using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace exp3_342_windowform
{
    public class Task
    {
        private int _id;
        private Project _projectName;
        private Person _employee;
        private double _workHour;
        private string _assignDate;
        private string _description;
        private bool _condition;

        public Task(int id, Project projectName, Person employee, double workHour,
                    string assignDate, string description)
        {
            _id = id;
            _projectName = projectName;
            _employee = employee;
            _workHour = workHour;
            _assignDate = assignDate;
            _description = description;
            _condition = false;
        }

        public Task()
        {
            
        }

        [DisplayName("ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Project")]
        public Project ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        [Browsable(false)]
        public Person Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }

        [DisplayName("Name")]
        public string EmpName
        {
            get { return _employee.Name; }
            set { _employee.Name = value; }
        }

        [DisplayName("Surname")]
        public string EmpSurname
        {
            get { return _employee.Surname; }
            set { _employee.Surname = value; }
        }

        [DisplayName("Time")]
        public double WorkHour
        {
            get { return _workHour; }
            set { _workHour = value; }
        }

        [DisplayName("Assign Date")]
        public string AssignDate
        {
            get { return _assignDate; }
            set { _assignDate = value; }
        }

        [DisplayName("Description")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [DisplayName("Is Completed")]
        public bool Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }
    }
}