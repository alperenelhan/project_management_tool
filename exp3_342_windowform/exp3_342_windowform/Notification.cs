using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace exp3_342_windowform
{
    public class Notification
    {
        private int _id;
        private double _workHour;
        private string _description;
        private string _registerDate;
        private Project _workedProject;
        private string _empUserName;

        public Notification(int id, double workHour, string description, string registerDate, Project workedProject, string empUserName)
        {
            _id = id;
            _workHour = workHour;
            _description = description;
            _registerDate = registerDate;
            _workedProject = workedProject;
            _empUserName = empUserName;
        }

        public Notification()
        {
            
        }

        [DisplayName("ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Project")]
        public Project WorkedProject
        {
            get { return _workedProject; }
            set { _workedProject = value; }
        }

        [DisplayName("Work Time(Hour)")]
        public double WorkHour
        {
            get { return _workHour; }
            set { _workHour = value; }
        }

        [DisplayName("Description")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        [DisplayName("Register Date")]
        public string RegisterDate
        {
            get { return _registerDate; }
            set { _registerDate = value; }
        }

        [Browsable(true)]
        [DisplayName("Employee")]
        public string EmpUserName
        {
            get { return _empUserName; }
            set { _empUserName = value; }
        }
    }
}
