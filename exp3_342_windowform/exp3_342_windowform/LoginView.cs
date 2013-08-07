using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using exp3_342_windowform.Properties;

namespace exp3_342_windowform
{
    public partial class LoginView : Form
    {
        private IObjectContainer _db;
        public LoginView(IObjectContainer db)
        {
            InitializeComponent();
            _db = db;
            mailBox.Text = "admin@pts.com";
            passwordBox.Text = "1234";
            this.MaximizeBox = false;
            passwordBox.KeyPress += EnterKeyAction;
            mailBox.KeyPress += EnterKeyAction;
        }
        
        private void EnterKeyAction(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                LoginButtonClick(sender, e);
            }
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            IEnumerable<Person> guest = from Person user in _db
                                        where
                                            user.Password.Equals(passwordBox.Text) &&
                                            user.Email.Equals(mailBox.Text)
                                        select user;
            if (!guest.Any())
            {
                MessageBox.Show(Resources.LoginView_LoginButtonClick_User_could_not_found);
            }
            else
            {
                guest.First().LastLogin = DateTime.Now.ToString("dd/MM/yyyy");
                _db.Store(guest.First());
                Hide();
                if(guest.First().IsAdmin)
                {
                    AdminView adm = new AdminView(guest.First(),_db, this);
                    adm.Show();
                }
                else
                {
                    EmployeeView emp = new EmployeeView(guest.First(),_db, this);
                    emp.Show();
                }
            }
        }
    }
}