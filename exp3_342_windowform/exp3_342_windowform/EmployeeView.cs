using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace exp3_342_windowform
{
    public partial class EmployeeView : Form
    {
        private Person _user;
        private readonly IObjectContainer _db;
        private readonly LoginView _form;
        private int _lastNotId;

        public EmployeeView(Person user, IObjectContainer db, LoginView form)
        {
            _form = form;
            _user = user;
            _db = db;
            InitializeComponent();
            init();
            employeeTabs.DrawItem += EmployeeTabsDrawItem;
        }

        private void init()
        {
            nameBox.Text = _user.Name;
            birthDayBox.Text = _user.BirthDay;
            surnameBox.Text = _user.Surname;
            phoneBox.Text = _user.Phone;
            cityComboBox.SelectedIndex = cityComboBox.FindStringExact(_user.City);
            addressBox.Text = _user.Addres;
            if (_user.Gender == "Male") maleButton.Select();
            else femaleButton.Select();
            IEnumerable<Notification> notes = from Notification n in _db select n;
            UpdateNotifications();
            _lastNotId = notes.Any() ? notes.Last().Id : 0;
            IEnumerable<Project> project = from Task t in _db where t.Employee.UserName == _user.UserName select t.ProjectName;
            foreach (Project project1 in project)
            {
                projectWorkedList.Items.Add(project1);
            }
            UpdateTasksView(incompleteTasksView, false);
            UpdateTasksView(completedTasksView, true);
        }

        private void UpdateUser(Person user)
        {
            IEnumerable<Person> u = from Person p in _db where p.UserName == user.UserName select p;
            _user = u.First();
        }

        private void EmployeeTabsDrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush textBrush;
            TabPage page = employeeTabs.TabPages[e.Index];
            Rectangle tabBounds = employeeTabs.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.White, e.Bounds);
            }
            else
            {
                textBrush = new SolidBrush(Color.RoyalBlue);
            }
            Font tabFont = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Pixel);
            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Center;
            g.DrawString(page.Text, tabFont, textBrush, tabBounds, new StringFormat(str));
        }

        private void LogoutButtonMouseHover(object sender, EventArgs e)
        {
            string status = "Logged in as " + _user.UserName;
            using (Graphics cg = CreateGraphics())
            {
                SizeF size = cg.MeasureString(status, logoutButton.Font);
                size.Width += 38;
                int x = logoutButton.Location.X -
                        ((int) size.Width - logoutButton.Size.Width);
                var loc = new Point(x, logoutButton.Location.Y);
                logoutButton.Location = loc;
                logoutButton.Width = (int) size.Width;
            }
            logoutButton.Text = status;
        }

        private void LogoutButtonMouseLeave(object sender, EventArgs e)
        {
            const string status = "Logout";
            using (Graphics cg = CreateGraphics())
            {
                SizeF size = cg.MeasureString(status, logoutButton.Font);
                size.Width += 38;
                int x = logoutButton.Location.X +
                        (logoutButton.Size.Width - (int) size.Width);
                var loc = new Point(x, logoutButton.Location.Y);
                logoutButton.Location = loc;
                logoutButton.Width = (int) size.Width;
            }
            logoutButton.Text = status;
        }

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void EditInfoSaveClick(object sender, EventArgs e)
        {
            IEnumerable<Person> localUser = from Person p in _db
                                            where
                                                p.UserName == _user.UserName
                                            select p;
            localUser.First().Name = nameBox.Text;
            localUser.First().Surname = surnameBox.Text;
            localUser.First().BirthDay = birthDayBox.Text;
            localUser.First().Phone = phoneBox.Text;
            localUser.First().City = cityComboBox.Text;
            localUser.First().Addres = addressBox.Text;
            var firstOrDefault = editInfo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (firstOrDefault != null)
                localUser.First().Gender = firstOrDefault.Text;
            _db.Store(localUser.First());
            UpdateUser(localUser.First());
            MessageBox.Show("Saved Succesfully");
        }

        private void LoginInfoSaveClick(object sender, EventArgs e)
        {
            IEnumerable<Person> localUser = from Person p in _db
                                            where
                                                p.UserName == _user.UserName
                                            select p;
            if (!String.IsNullOrEmpty(passwordBox.Text) && !String.IsNullOrEmpty(passwordAgain.Text))
            {
                if (passwordBox.Text == passwordAgain.Text)
                {
                    localUser.First().Password = passwordBox.Text;
                    UpdateUser(localUser.First());
                    _db.Store(localUser.First());
                    MessageBox.Show("Password Changed Succesfully!");
                }
                else
                {
                    MessageBox.Show("Fields must be same!");
                }
            }
            else
            {
                MessageBox.Show("Fields can not be empty!");
            }
            passwordBox.Clear();
            passwordAgain.Clear();
        }

        private void HourWorkedBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && ((TextBox) sender).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void UpdateTasksView(DataGridView view, bool check)
        {
            view.DataSource = null;
            view.Columns.Clear();
            view.Rows.Clear();
            IEnumerable<Task> show = from Task t in _db
                                     where
                                         t.Employee.UserName == _user.UserName && check == t.Condition
                                     select t;

            view.DataSource = show.ToList();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Text = "Edit";
            button.UseColumnTextForButtonValue = true;
            button.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            view.Columns.Add(button);
        }

        private void UpdateNotifications()
        {
            notificationList.DataSource = null;
            notificationList.Columns.Clear();
            notificationList.Rows.Clear();
            IEnumerable<Notification> list = from Notification n in _db where n.EmpUserName == _user.UserName select n;
            notificationList.DataSource = list.ToList();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Text = "Delete";
            button.UseColumnTextForButtonValue = true;
            button.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            notificationList.Columns.Add(button);
        }

        private void NotificationSaveButtonClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(projectWorkedList.Text) && !String.IsNullOrEmpty(notificationDescBox.Text) &&
                !String.IsNullOrEmpty(hourWorkedBox.Text))
            {
                double val;
                Double.TryParse(hourWorkedBox.Text, out val);
                string date = workDate.SelectionEnd.ToString("dd.MM.yyyy");
                Notification not = new Notification(++_lastNotId, val, notificationDescBox.Text, date,
                                                    (Project) projectWorkedList.SelectedItem, _user.UserName);
                _db.Store(not);
                UpdateNotifications();
                MessageBox.Show("Saved Succesfully");
            }
            else
            {
                MessageBox.Show("Fields can not be empty!");
            }
        }

        private void NotificationListCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (notificationList[e.ColumnIndex, e.RowIndex].Value.ToString() == "Delete")
                {
                    Notification item = (Notification)notificationList.Rows[e.RowIndex].DataBoundItem;
                    IEnumerable<Notification> result = from Notification p in _db where p.Id == item.Id select p;
                    _db.Delete(result.First());
                    UpdateNotifications();
                    MessageBox.Show("Notification deleted succesfully!");
                }
            }
        }

        private void TaskViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dv = (DataGridView) sender;
            if(dv == null)
                return;
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dv[e.ColumnIndex, e.RowIndex].Value.ToString() == "Edit")
                {
                    Task item = (Task)dv.Rows[e.RowIndex].DataBoundItem;

                    TaskEditBox tb = new TaskEditBox(item.WorkHour, item.Condition);
                    tb.ShowDialog();
                    if(tb.IsEdited)
                    {
                        IEnumerable<Task> result = from Task t in _db where t.Id == item.Id select t;
                        result.First().WorkHour = tb.Hour;
                        result.First().Condition = tb.IsCompleted;
                        _db.Store(result.First());
                        UpdateTasksView(incompleteTasksView, false);
                        UpdateTasksView(completedTasksView, true);
                    }
                }
            }
        }
    }
}