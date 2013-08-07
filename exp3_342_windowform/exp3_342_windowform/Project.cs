using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace exp3_342_windowform
{
    public class Project
    {
        private string _name;
        private string _description;
        private int _id;

        public Project(string name, string description, int id)
        {
            _name = name;
            _description = description;
            _id = id;
        }

        public Project()
        {
        }

        [DisplayName("Project ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Project Name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DisplayName("Description")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string ToString()
        {
            return _name;
        }

    }
}