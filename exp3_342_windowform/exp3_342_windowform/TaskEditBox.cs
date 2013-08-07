using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exp3_342_windowform
{
    public partial class TaskEditBox : Form
    {
        private double _hour;
        private bool _isCompleted;
        private bool _isEdited = false;

        public TaskEditBox(double hour, bool isCompleted)
        {
            InitializeComponent();
            hourWorkedTextBox.Text = hour.ToString(CultureInfo.InvariantCulture);
            isTaskCompletedBox.Checked = isCompleted;
        }

        private void HourWorkedBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox)sender).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(hourWorkedTextBox.Text))
            {
                _hour = Double.Parse(hourWorkedTextBox.Text);
                _isCompleted = isTaskCompletedBox.Checked;
                _isEdited = true;
                Dispose();
            }
            else
            {
                MessageBox.Show("Fields can not be empty!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _isEdited = false;
            Dispose();
        }

        public double Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set { _isCompleted = value; }
        }

        public bool IsEdited
        {
            get { return _isEdited; }
            set { _isEdited = value; }
        }
    }
}
