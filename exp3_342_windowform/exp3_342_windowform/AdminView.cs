using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace exp3_342_windowform
{
    public partial class AdminView : Form
    {
        private Person _user;
        private readonly IObjectContainer _db;
        private readonly LoginView _form;
        private int _lastProjectId;
        private int _lastTaskId;

        public AdminView(Person user, IObjectContainer db, LoginView form)
        {
            _form = form;
            _user = user;
            _db = db;
            InitializeComponent();
            Init();
            adminTabs.DrawItem += AdminTabsDrawItem;
            projectList.CellClick += ProjectListCellClick;
        }

        public Person User
        {
            get { return _user; }
            set { _user = value; }
        }

        private void Init()
        {
            nameBox.Text = _user.Name;
            birthDayBox.Text = _user.BirthDay;
            surnameBox.Text = _user.Surname;
            phoneBox.Text = _user.Phone;
            cityComboBox.SelectedIndex = cityComboBox.FindStringExact(_user.City);
            addressBox.Text = _user.Addres;
            if (_user.Gender == "Male") maleButton.Select();
            else femaleButton.Select();

            IEnumerable<Project> projects = from Project p in _db select p;
            _lastProjectId = projects.Any() ? projects.Last().Id : 0;

            IEnumerable<Task> tasks = from Task t in _db select t;
            _lastTaskId = tasks.Any() ? tasks.Last().Id : 0;

            UpdateProjectsGrid();

            IObjectSet result = _db.QueryByExample(new Person());
            employees.DataSource = result;
            showTaskEmployeesList.Items.Add("All");
            employeesComboBox.Items.Add("All");
            //showTasksProjectList.Items.Add("All");
            foreach (Person person in result)
            {
                employeeList.Items.Add(person);
                if (!person.IsAdmin)
                {
                    employeesComboBox.Items.Add(person);
                    newTaskAssignEmp.Items.Add(person);
                    showTaskEmployeesList.Items.Add(person);
                    normalUsersList.Items.Add(person);
                }
                else
                {
                    adminsList.Items.Add(person);
                }
            }

            for (int i = 2016; i > 1950; i--)
            {
                yearsComboBox.Items.Add(i);
            }

            if (employeesComboBox.Items.Count > 0)
            {
                employeesComboBox.SelectedIndex = 0;
            }
            UpdateShowTasksView();
            UpdateAnalyzeView();
        }

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AdminTabsDrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush textBrush;
            TabPage page = adminTabs.TabPages[e.Index];
            Rectangle tabBounds = adminTabs.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.White, e.Bounds);
            }
            else
            {
                textBrush = new SolidBrush(Color.RoyalBlue);
            }
            var tabFont = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Pixel);
            var str = new StringFormat {Alignment = StringAlignment.Center};
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

        private void EditInfoSaveClick(object sender, EventArgs e)
        {
            IEnumerable<Person> localUser = from Person p in _db
                                            where
                                                p.Password.Equals(_user.Password) &&
                                                p.UserName.Equals(_user.UserName)
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
                                                p.Password.Equals(_user.Password) &&
                                                p.UserName.Equals(_user.UserName)
                                            select p;
            if (!String.IsNullOrEmpty(passwordBox.Text) && !String.IsNullOrEmpty(passwordAgain.Text))
            {
                if (passwordBox.Text == passwordAgain.Text)
                {
                    localUser.First().Password = passwordBox.Text;
                    UpdateUser(localUser.First());
                    _db.Store(localUser.First());
                    UpdateEmployeesGrid();
                    employees.Update();
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

        private void CreateNewSaveButtonClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(createNewUserNameBox.Text) && !String.IsNullOrEmpty(createPasswordBox.Text) &&
                !String.IsNullOrEmpty(createNewPassAgain.Text) && !String.IsNullOrEmpty(createNewEmail.Text))
            {
                if (createNewPassAgain.Text == createPasswordBox.Text)
                {
                    IEnumerable<Person> users = from Person p in _db
                                                where
                                                    p.UserName.Equals(createNewUserNameBox.Text)
                                                select p;
                    if (!users.Any())
                    {
                        Person newUser = new Person(createNewUserNameBox.Text, createNewEmail.Text,
                                                    createNewPassAgain.Text);
                        _db.Store(newUser);
                        employees.Update();
                        UpdateUsersAndAdmins();
                        UpdateEmployeesGrid();
                        UpdateNotificationsView();
                        employeeList.Items.Add(newUser);
                        createNewEmail.Clear();
                        createNewPassAgain.Clear();
                        createNewUserNameBox.Clear();
                        createPasswordBox.Clear();
                        MessageBox.Show("New Employee created Succesfully!");
                    }
                    else
                    {
                        MessageBox.Show("You can not use that User Name!");
                    }
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
        }

        private void UpdateAnalyzeView()
        {
            analyzeView.Rows.Clear();
            IEnumerable<Project> projects = from Project p in _db select p;
            IEnumerable<Task> tasks = from Task t in _db select t;

            foreach (Project project in projects)
            {
                double totalHour = 0;
                foreach (Task task in tasks)
                {
                    if(project.Id == task.ProjectName.Id && task.Condition)
                    {
                        totalHour += task.WorkHour;
                    }
                }
                analyzeView.Rows.Add(project.Name, totalHour.ToString(CultureInfo.InvariantCulture));
            }
        }

        private void UpdateUser(Person user)
        {
            IEnumerable<Person> u = from Person p in _db where p.UserName == user.UserName select p;
            _user = u.First();
        }

        private void UpdateEmployeesGrid()
        {
            employees.DataSource = _db.QueryByExample(new Person());
            UpdateEmpComboBox();
            _db.Commit();
        }

        private void UpdateProjectsGrid()
        {
            projectList.DataSource = null;
            projectList.Columns.Clear();
            projectList.Rows.Clear();
            IObjectSet result = _db.QueryByExample(new Project());
            projectList.DataSource = result;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Text = "Edit";
            button.UseColumnTextForButtonValue = true;
            button.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            projectList.Columns.Add(button);
            DataGridViewButtonColumn button2 = new DataGridViewButtonColumn();
            button2.Text = "Delete";
            button2.UseColumnTextForButtonValue = true;
            button2.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            projectList.Columns.Add(button2);
            newTaskAssignProj.Items.Clear();
            showTasksProjectList.Items.Clear();
            showTasksProjectList.Items.Add("All");
            foreach (Project project in result)
            {
                newTaskAssignProj.Items.Add(project);
                showTasksProjectList.Items.Add(project);
            }
            UpdateAnalyzeView();
            _db.Commit();
        }

        private void UpdateEmpComboBox()
        {
            employeesComboBox.Items.Clear();
            newTaskAssignEmp.Items.Clear();
            showTaskEmployeesList.Items.Clear();
            showTaskEmployeesList.Items.Add("All");
            employeesComboBox.Items.Add("All");
            IObjectSet result = _db.QueryByExample(new Person());
            foreach (Person person in result)
            {
                if (!person.IsAdmin)
                {
                    employeesComboBox.Items.Add(person);
                    newTaskAssignEmp.Items.Add(person);
                    showTaskEmployeesList.Items.Add(person);

                }
            }
            if (employeesComboBox.Items.Count > 0)
            {
                employeesComboBox.SelectedIndex = 0;
            }
        }

        private void UpdateNotificationsView()
        {
            if (yearsComboBox.SelectedIndex == -1)
                yearsComboBox.SelectedIndex = 0;
            if (monthsComboBox.SelectedIndex == -1)
                monthsComboBox.SelectedIndex = 0;
            if (employeesComboBox.Items.Count > 1)
            {
                if (employeesComboBox.SelectedIndex == -1)
                    employeesComboBox.SelectedIndex = 0;
                notificationsView.DataSource = null;
                notificationsView.Columns.Clear();
                notificationsView.Rows.Clear();
                IEnumerable<Notification> empView;
                if (employeesComboBox.SelectedItem.ToString() == "All")
                {
                    empView = from Notification n in _db select n;
                }
                else
                {
                    DateTime date1 = new DateTime(int.Parse(yearsComboBox.Text), int.Parse(monthsComboBox.Text), 1, 0, 0,
                                                  0);
                    empView = (from Notification n in _db
                                                         where
                                                             ((Person) employeesComboBox.SelectedItem).UserName ==
                                                             n.EmpUserName &&
                                                             DateTime.Compare(date1,
                                                                              new DateTime(
                                                                                  int.Parse(n.RegisterDate.Split('.')[2]),
                                                                                  int.Parse(n.RegisterDate.Split('.')[1]),
                                                                                  1,
                                                                                  0, 0, 0)) == 0
                                                         select n);
                }
                notificationsView.DataSource = empView.ToList();
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.Text = "Delete";
                button.UseColumnTextForButtonValue = true;
                button.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                notificationsView.Columns.Add(button);
                UpdateTotalHourView(empView.ToList());
            }
            _db.Commit();
        }

        private void UpdateTotalHourView(List<Notification> list)
        {
            totalHourView.DataSource = null;
            DataTable dt = new DataTable();
            for (int i = 0; i < 6; i++)
            {
                dt.Columns.Add(i.ToString());
            }
            double totalHour = 0;
            foreach (Notification notification in list)
            {
                totalHour += notification.WorkHour;
            }
            dt.Rows.Add(null, null, "Total : " + totalHour.ToString(CultureInfo.InvariantCulture), null, null, null);
            totalHourView.DataSource = dt;
        }

        private void UpdateShowTasksView()
        {
            if (showTaskEmployeesList.SelectedIndex == -1 && showTaskEmployeesList.Items.Count > 0)
                showTaskEmployeesList.SelectedIndex = 0;
            if (showTasksProjectList.SelectedIndex == -1 && showTasksProjectList.Items.Count > 0)
                showTasksProjectList.SelectedIndex = 0;
            if (showTaskEmployeesList.Items.Count > 1)
            {
                showTasksView.DataSource = null;
                showTasksView.Columns.Clear();
                showTasksView.Rows.Clear();
                IEnumerable<Task> show;
                if (showTaskEmployeesList.SelectedItem.ToString() == "All" && showTasksProjectList.SelectedItem.ToString() != "All")
                {
                    show = from Task t in _db
                           where
                               t.ProjectName.Id == ((Project) showTasksProjectList.SelectedItem).Id
                           select t;
                }
                else if (showTaskEmployeesList.SelectedItem.ToString() != "All" && showTasksProjectList.SelectedItem.ToString() == "All")
                {
                    show = from Task t in _db
                           where
                               t.Employee.UserName == ((Person)showTaskEmployeesList.SelectedItem).UserName
                           select t;
                }
                else if (showTaskEmployeesList.SelectedItem.ToString() == "All" && showTasksProjectList.SelectedItem.ToString() == "All")
                {
                    show = from Task t in _db select t;
                }
                else
                {
                    show = from Task t in _db
                           where
                               t.Employee.UserName ==
                               ((Person)showTaskEmployeesList.SelectedItem).UserName &&
                               t.ProjectName.Id == ((Project)showTasksProjectList.SelectedItem).Id
                           select t;
                }

                showTasksView.DataSource = show.ToList();
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.Text = "Delete";
                button.UseColumnTextForButtonValue = true;
                button.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.AllCells;
                showTasksView.Columns.Add(button);
            }
            _db.Commit();
        }

        private void UpdateUsersAndAdmins()
        {
            IObjectSet result = _db.QueryByExample(new Person());
            normalUsersList.Items.Clear();
            adminsList.Items.Clear();
            foreach (Person person in result)
            {
                if (person.IsAdmin)
                {
                    adminsList.Items.Add(person);
                }
                else
                {
                    normalUsersList.Items.Add(person);
                }
            }
        }

        private void RemoveEmployeeButtonClick(object sender, EventArgs e)
        {
            if (employeeList.SelectedItem != null)
            {
                IEnumerable<Person> admins = from Person p in _db
                                             where
                                                 p.IsAdmin
                                             select p;
                if (admins.Count() == 1 && ((Person) employeeList.SelectedItem).UserName == admins.First().UserName)
                    MessageBox.Show("You can not delete admin. Because there is only one left!");
                else
                {
                    if (((Person)employeeList.SelectedItem).UserName == _user.UserName)
                    {
                        MessageBox.Show("You can not delete yourself!");
                    }
                    else
                    {
                        IEnumerable<Task> tasks = from Task t in _db
                                                  where
                                                      t.Employee.UserName ==
                                                      ((Person) employeeList.SelectedItem).UserName
                                                  select t;
                        foreach (Task task in tasks)
                            _db.Delete(task);
                        IEnumerable<Notification> notifications = from Notification n in _db
                                                                  where
                                                                      n.EmpUserName ==
                                                                      ((Person) employeeList.SelectedItem).UserName
                                                                  select n;
                        foreach (Notification notification in notifications)
                            _db.Delete(notification);

                        _db.Delete((Person) employeeList.SelectedItem);
                        employeeList.Items.Remove(employeeList.SelectedItem);
                        UpdateEmployeesGrid();
                        UpdateNotificationsView();
                        UpdateShowTasksView();
                        UpdateUsersAndAdmins();
                        MessageBox.Show("Employee deleted Succesfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("You must choose an employee first!");
            }
        }

        private void NewProjectSaveButtonClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newProjectDescBox.Text) && !String.IsNullOrEmpty(newProjectNameBox.Text))
            {
                Project newProject = new Project(newProjectNameBox.Text, newProjectDescBox.Text, ++_lastProjectId);
                _db.Store(newProject);
                UpdateProjectsGrid();
                MessageBox.Show("Project added succesfully!");
                newProjectDescBox.Clear();
                newProjectNameBox.Clear();
            }
            else
            {
                MessageBox.Show("Fields can not be empty!");
            }
        }

        private void NewProjectCancelButtonClick(object sender, EventArgs e)
        {
            newProjectDescBox.Clear();
            newProjectNameBox.Clear();
        }

        private void ProjectListCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (projectList[e.ColumnIndex, e.RowIndex].Value.ToString() == "Edit")
                {
                    Project prj = (Project) projectList.Rows[e.RowIndex].DataBoundItem;
                    InputBox inp = new InputBox(prj.Name, prj.Description);

                    inp.ShowDialog();
                    if (inp.IsEdited)
                    {
                        IEnumerable<Project> project = from Project p in _db
                                                       where
                                                           p.Id == prj.Id
                                                       select p;
                        project.First().Name = inp.NewName;
                        project.First().Description = inp.NewDesc;
                        _db.Store(project.First());
                        UpdateProjectsGrid();
                        UpdateNotificationsView();
                        UpdateShowTasksView();
                    }
                }
                else if (projectList[e.ColumnIndex, e.RowIndex].Value.ToString() == "Delete")
                {
                    Project item = (Project) projectList.Rows[e.RowIndex].DataBoundItem;
                    IEnumerable<Project> result = from Project p in _db where p.Id == item.Id select p;

                    IEnumerable<Task> tasks = from Task t in _db
                                              where
                                                  t.ProjectName.Id == result.First().Id
                                              select t;
                    foreach (Task task in tasks)
                        _db.Delete(task);
                    IEnumerable<Notification> notifications = from Notification n in _db
                                                              where
                                                                  n.WorkedProject.Id == result.First().Id
                                                              select n;
                    foreach (Notification notification in notifications)
                        _db.Delete(notification);

                    _db.Delete(result.First());
                    UpdateProjectsGrid();
                    UpdateNotificationsView();
                    UpdateShowTasksView();
                    MessageBox.Show("Project deleted succesfully!");
                }
            }
        }

        private void NotificationViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (notificationsView[e.ColumnIndex, e.RowIndex].Value.ToString() == "Delete")
                {
                    Notification item = (Notification) notificationsView.Rows[e.RowIndex].DataBoundItem;
                    IEnumerable<Notification> result = from Notification p in _db where p.Id == item.Id select p;
                    _db.Delete(result.First());
                    UpdateNotificationsView();
                    MessageBox.Show("Notification deleted succesfully!");
                }
            }
        }

        private void ShowTasksViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (showTasksView[e.ColumnIndex, e.RowIndex].Value.ToString() == "Delete")
                {
                    Task item = (Task)showTasksView.Rows[e.RowIndex].DataBoundItem;
                    IEnumerable<Task> result = from Task t in _db where t.Id == item.Id select t;
                    _db.Delete(result.First());
                    UpdateShowTasksView();
                    MessageBox.Show("Task deleted succesfully!");
                }
            }
        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNotificationsView();
        }

        private void NewTaskSaveButtonClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newTaskDescBox.Text) && newTaskAssignEmp.SelectedItem != null &&
                newTaskAssignProj.SelectedItem != null)
            {
                Task newTask = new Task(++_lastTaskId, (Project) newTaskAssignProj.SelectedItem,
                                        (Person) newTaskAssignEmp.SelectedItem, 0,
                                        newTaskAssignCal.SelectionEnd.ToString("dd.MM.yyyy"), newTaskDescBox.Text);
                _db.Store(newTask);
                UpdateShowTasksView();
                MessageBox.Show("Task succesfully assigned!");
            }
            else
            {
                MessageBox.Show("Fields can not be empty!");
            }
        }

        private void ShowTasksComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateShowTasksView();
        }

        private void FilterBoxTextChanged(object sender, EventArgs e)
        {
            normalUsersList.DataSource = null;
            UpdateUsersAndAdmins();
            IEnumerable<Person> list = from Person p in normalUsersList.Items
                                       where p.UserName.Contains(filterUsers.Text)
                                       select p;
            normalUsersList.DataSource = list.ToList();
        }

        private void MakeManagerButtonClick(object sender, EventArgs e)
        {
            if(normalUsersList.SelectedItem == null)
                return;
            IEnumerable<Person> list = from Person p in _db
                                       where p.UserName == ((Person)normalUsersList.SelectedItem).UserName
                                       select p;
            list.First().IsAdmin = true;
            UpdateEmployeesGrid();
            UpdateNotificationsView();
            UpdateUsersAndAdmins();
        }

        private void DemoteButtonClick(object sender, EventArgs e)
        {
            if (adminsList.SelectedItem == null)
                return;
            IEnumerable<Person> list = from Person p in _db
                                       where p.UserName == ((Person)adminsList.SelectedItem).UserName
                                       select p;
            if (_user.UserName == list.First().UserName)
            {
                MessageBox.Show("You can not demote yourself!");
            }
            else
            {
                list.First().IsAdmin = false;
                UpdateEmployeesGrid();
                UpdateNotificationsView();
                UpdateUsersAndAdmins();
            }
        }
    }
}