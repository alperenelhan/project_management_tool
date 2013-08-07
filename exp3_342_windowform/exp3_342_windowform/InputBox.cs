using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exp3_342_windowform
{
    public partial class InputBox : Form
    {
        private string _newName;
        private string _newDesc;
        public bool IsEdited=false;

        public InputBox(string name, string description)
        {
            InitializeComponent();
            newProjectDesc.Text = description;
            newProjectName.Text = name;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(newProjectDesc.Text) && !String.IsNullOrEmpty(newProjectName.Text))
            {
                _newDesc = newProjectDesc.Text;
                _newName = newProjectName.Text;
                IsEdited = true;
                Dispose();
            }
            else
            {
                MessageBox.Show("Fields can not be empty!");
            }
        }

        public string NewName
        {
            get { return _newName; } 
            set { _newName = value; }
        }
        public string NewDesc
        {
            get { return _newDesc; }
            set { _newDesc = value; }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
