namespace exp3_342_windowform
{
    partial class EmployeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            _db.Commit();
            _form.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeTabs = new System.Windows.Forms.TabControl();
            this.personalInfoTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.editInfo = new System.Windows.Forms.TabPage();
            this.editInfoSave = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.birthDayBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginInfo = new System.Windows.Forms.TabPage();
            this.loginInfoSave = new System.Windows.Forms.Button();
            this.passwordAgain = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.notificationsTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.notifyTab = new System.Windows.Forms.TabPage();
            this.notificationSaveButton = new System.Windows.Forms.Button();
            this.notificationDescBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.hourWorkedBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.workDate = new System.Windows.Forms.MonthCalendar();
            this.label13 = new System.Windows.Forms.Label();
            this.projectWorkedList = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.recentNotifiesTab = new System.Windows.Forms.TabPage();
            this.notificationList = new System.Windows.Forms.DataGridView();
            this.assignedWorksTab = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.incompleteTasksTab = new System.Windows.Forms.TabPage();
            this.incompleteTasksView = new System.Windows.Forms.DataGridView();
            this.completedTasksTab = new System.Windows.Forms.TabPage();
            this.completedTasksView = new System.Windows.Forms.DataGridView();
            this.logoutButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.loginStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.employeeTabs.SuspendLayout();
            this.personalInfoTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.editInfo.SuspendLayout();
            this.loginInfo.SuspendLayout();
            this.notificationsTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.notifyTab.SuspendLayout();
            this.recentNotifiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationList)).BeginInit();
            this.assignedWorksTab.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.incompleteTasksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incompleteTasksView)).BeginInit();
            this.completedTasksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.completedTasksView)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeTabs
            // 
            this.employeeTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.employeeTabs.Controls.Add(this.personalInfoTab);
            this.employeeTabs.Controls.Add(this.notificationsTab);
            this.employeeTabs.Controls.Add(this.assignedWorksTab);
            this.employeeTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.employeeTabs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.employeeTabs.ItemSize = new System.Drawing.Size(30, 150);
            this.employeeTabs.Location = new System.Drawing.Point(0, 0);
            this.employeeTabs.Multiline = true;
            this.employeeTabs.Name = "employeeTabs";
            this.employeeTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.employeeTabs.SelectedIndex = 0;
            this.employeeTabs.Size = new System.Drawing.Size(880, 384);
            this.employeeTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.employeeTabs.TabIndex = 0;
            // 
            // personalInfoTab
            // 
            this.personalInfoTab.BackColor = System.Drawing.Color.White;
            this.personalInfoTab.Controls.Add(this.tabControl1);
            this.personalInfoTab.Location = new System.Drawing.Point(154, 4);
            this.personalInfoTab.Name = "personalInfoTab";
            this.personalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfoTab.Size = new System.Drawing.Size(722, 376);
            this.personalInfoTab.TabIndex = 0;
            this.personalInfoTab.Text = "Personal Information";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.editInfo);
            this.tabControl1.Controls.Add(this.loginInfo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 370);
            this.tabControl1.TabIndex = 1;
            // 
            // editInfo
            // 
            this.editInfo.BackColor = System.Drawing.Color.White;
            this.editInfo.Controls.Add(this.editInfoSave);
            this.editInfo.Controls.Add(this.addressBox);
            this.editInfo.Controls.Add(this.cityComboBox);
            this.editInfo.Controls.Add(this.label6);
            this.editInfo.Controls.Add(this.nameBox);
            this.editInfo.Controls.Add(this.phoneBox);
            this.editInfo.Controls.Add(this.femaleButton);
            this.editInfo.Controls.Add(this.label7);
            this.editInfo.Controls.Add(this.label1);
            this.editInfo.Controls.Add(this.label5);
            this.editInfo.Controls.Add(this.maleButton);
            this.editInfo.Controls.Add(this.birthDayBox);
            this.editInfo.Controls.Add(this.surnameBox);
            this.editInfo.Controls.Add(this.label8);
            this.editInfo.Controls.Add(this.label9);
            this.editInfo.Controls.Add(this.label2);
            this.editInfo.Location = new System.Drawing.Point(4, 22);
            this.editInfo.Name = "editInfo";
            this.editInfo.Padding = new System.Windows.Forms.Padding(3);
            this.editInfo.Size = new System.Drawing.Size(708, 344);
            this.editInfo.TabIndex = 0;
            this.editInfo.Text = "Edit Info";
            // 
            // editInfoSave
            // 
            this.editInfoSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editInfoSave.Location = new System.Drawing.Point(627, 315);
            this.editInfoSave.Name = "editInfoSave";
            this.editInfoSave.Size = new System.Drawing.Size(75, 23);
            this.editInfoSave.TabIndex = 17;
            this.editInfoSave.Text = "Save";
            this.editInfoSave.UseVisualStyleBackColor = true;
            this.editInfoSave.Click += new System.EventHandler(this.EditInfoSaveClick);
            // 
            // addressBox
            // 
            this.addressBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressBox.Location = new System.Drawing.Point(285, 204);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(219, 47);
            this.addressBox.TabIndex = 10;
            // 
            // cityComboBox
            // 
            this.cityComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlı urfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cityComboBox.Location = new System.Drawing.Point(285, 173);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(219, 21);
            this.cityComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone                  :";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Location = new System.Drawing.Point(285, 54);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(219, 20);
            this.nameBox.TabIndex = 0;
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneBox.Location = new System.Drawing.Point(285, 144);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(219, 20);
            this.phoneBox.TabIndex = 6;
            // 
            // femaleButton
            // 
            this.femaleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.femaleButton.AutoSize = true;
            this.femaleButton.Location = new System.Drawing.Point(401, 268);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(59, 17);
            this.femaleButton.TabIndex = 15;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "Female";
            this.femaleButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "City                       :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name                   :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surname              :";
            // 
            // maleButton
            // 
            this.maleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maleButton.AutoSize = true;
            this.maleButton.Location = new System.Drawing.Point(331, 268);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(48, 17);
            this.maleButton.TabIndex = 14;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "Male";
            this.maleButton.UseVisualStyleBackColor = true;
            // 
            // birthDayBox
            // 
            this.birthDayBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.birthDayBox.Location = new System.Drawing.Point(285, 115);
            this.birthDayBox.Name = "birthDayBox";
            this.birthDayBox.Size = new System.Drawing.Size(219, 20);
            this.birthDayBox.TabIndex = 4;
            // 
            // surnameBox
            // 
            this.surnameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameBox.Location = new System.Drawing.Point(285, 85);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(219, 20);
            this.surnameBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Address                :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Gender                 :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birth Day              :";
            // 
            // loginInfo
            // 
            this.loginInfo.BackColor = System.Drawing.Color.White;
            this.loginInfo.Controls.Add(this.loginInfoSave);
            this.loginInfo.Controls.Add(this.passwordAgain);
            this.loginInfo.Controls.Add(this.label11);
            this.loginInfo.Controls.Add(this.passwordBox);
            this.loginInfo.Controls.Add(this.label10);
            this.loginInfo.Location = new System.Drawing.Point(4, 22);
            this.loginInfo.Name = "loginInfo";
            this.loginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.loginInfo.Size = new System.Drawing.Size(708, 344);
            this.loginInfo.TabIndex = 1;
            this.loginInfo.Text = "Login Info";
            // 
            // loginInfoSave
            // 
            this.loginInfoSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInfoSave.Location = new System.Drawing.Point(627, 315);
            this.loginInfoSave.Name = "loginInfoSave";
            this.loginInfoSave.Size = new System.Drawing.Size(75, 23);
            this.loginInfoSave.TabIndex = 4;
            this.loginInfoSave.Text = "Save";
            this.loginInfoSave.UseVisualStyleBackColor = true;
            this.loginInfoSave.Click += new System.EventHandler(this.LoginInfoSaveClick);
            // 
            // passwordAgain
            // 
            this.passwordAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordAgain.Location = new System.Drawing.Point(325, 169);
            this.passwordAgain.Name = "passwordAgain";
            this.passwordAgain.PasswordChar = '*';
            this.passwordAgain.Size = new System.Drawing.Size(167, 20);
            this.passwordAgain.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Password Again  :";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Location = new System.Drawing.Point(325, 132);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(167, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(217, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Password            :";
            // 
            // notificationsTab
            // 
            this.notificationsTab.BackColor = System.Drawing.Color.White;
            this.notificationsTab.Controls.Add(this.tabControl2);
            this.notificationsTab.Location = new System.Drawing.Point(154, 4);
            this.notificationsTab.Name = "notificationsTab";
            this.notificationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.notificationsTab.Size = new System.Drawing.Size(722, 376);
            this.notificationsTab.TabIndex = 1;
            this.notificationsTab.Text = "Notifications";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.notifyTab);
            this.tabControl2.Controls.Add(this.recentNotifiesTab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(716, 370);
            this.tabControl2.TabIndex = 0;
            // 
            // notifyTab
            // 
            this.notifyTab.BackColor = System.Drawing.Color.White;
            this.notifyTab.Controls.Add(this.notificationSaveButton);
            this.notifyTab.Controls.Add(this.notificationDescBox);
            this.notifyTab.Controls.Add(this.label16);
            this.notifyTab.Controls.Add(this.label15);
            this.notifyTab.Controls.Add(this.hourWorkedBox);
            this.notifyTab.Controls.Add(this.label14);
            this.notifyTab.Controls.Add(this.workDate);
            this.notifyTab.Controls.Add(this.label13);
            this.notifyTab.Controls.Add(this.projectWorkedList);
            this.notifyTab.Controls.Add(this.label12);
            this.notifyTab.Location = new System.Drawing.Point(4, 22);
            this.notifyTab.Name = "notifyTab";
            this.notifyTab.Padding = new System.Windows.Forms.Padding(3);
            this.notifyTab.Size = new System.Drawing.Size(708, 344);
            this.notifyTab.TabIndex = 0;
            this.notifyTab.Text = "Notify";
            // 
            // notificationSaveButton
            // 
            this.notificationSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationSaveButton.Location = new System.Drawing.Point(627, 315);
            this.notificationSaveButton.Name = "notificationSaveButton";
            this.notificationSaveButton.Size = new System.Drawing.Size(75, 23);
            this.notificationSaveButton.TabIndex = 9;
            this.notificationSaveButton.Text = "Save";
            this.notificationSaveButton.UseVisualStyleBackColor = true;
            this.notificationSaveButton.Click += new System.EventHandler(this.NotificationSaveButtonClick);
            // 
            // notificationDescBox
            // 
            this.notificationDescBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notificationDescBox.Location = new System.Drawing.Point(259, 261);
            this.notificationDescBox.Multiline = true;
            this.notificationDescBox.Name = "notificationDescBox";
            this.notificationDescBox.Size = new System.Drawing.Size(234, 53);
            this.notificationDescBox.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(133, 261);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Description            :";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "e.g. 1,5 or 2";
            // 
            // hourWorkedBox
            // 
            this.hourWorkedBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hourWorkedBox.Location = new System.Drawing.Point(259, 228);
            this.hourWorkedBox.Name = "hourWorkedBox";
            this.hourWorkedBox.Size = new System.Drawing.Size(49, 20);
            this.hourWorkedBox.TabIndex = 5;
            this.hourWorkedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HourWorkedBoxKeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(131, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Hour Worked         :";
            // 
            // workDate
            // 
            this.workDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workDate.Location = new System.Drawing.Point(259, 54);
            this.workDate.MaxSelectionCount = 1;
            this.workDate.Name = "workDate";
            this.workDate.ShowToday = false;
            this.workDate.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Working Date         :";
            // 
            // projectWorkedList
            // 
            this.projectWorkedList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.projectWorkedList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectWorkedList.FormattingEnabled = true;
            this.projectWorkedList.Location = new System.Drawing.Point(259, 25);
            this.projectWorkedList.Name = "projectWorkedList";
            this.projectWorkedList.Size = new System.Drawing.Size(234, 21);
            this.projectWorkedList.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Project                   :";
            // 
            // recentNotifiesTab
            // 
            this.recentNotifiesTab.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.recentNotifiesTab.BackColor = System.Drawing.Color.White;
            this.recentNotifiesTab.Controls.Add(this.notificationList);
            this.recentNotifiesTab.Location = new System.Drawing.Point(4, 22);
            this.recentNotifiesTab.Name = "recentNotifiesTab";
            this.recentNotifiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.recentNotifiesTab.Size = new System.Drawing.Size(708, 344);
            this.recentNotifiesTab.TabIndex = 1;
            this.recentNotifiesTab.Text = "Recent Notifications";
            // 
            // notificationList
            // 
            this.notificationList.AllowUserToAddRows = false;
            this.notificationList.AllowUserToDeleteRows = false;
            this.notificationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notificationList.BackgroundColor = System.Drawing.Color.White;
            this.notificationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notificationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationList.GridColor = System.Drawing.Color.Black;
            this.notificationList.Location = new System.Drawing.Point(3, 3);
            this.notificationList.Name = "notificationList";
            this.notificationList.ReadOnly = true;
            this.notificationList.Size = new System.Drawing.Size(702, 338);
            this.notificationList.TabIndex = 1;
            this.notificationList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotificationListCellClick);
            // 
            // assignedWorksTab
            // 
            this.assignedWorksTab.BackColor = System.Drawing.Color.White;
            this.assignedWorksTab.Controls.Add(this.tabControl3);
            this.assignedWorksTab.Location = new System.Drawing.Point(154, 4);
            this.assignedWorksTab.Name = "assignedWorksTab";
            this.assignedWorksTab.Size = new System.Drawing.Size(722, 376);
            this.assignedWorksTab.TabIndex = 2;
            this.assignedWorksTab.Text = "Assigned Works";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.incompleteTasksTab);
            this.tabControl3.Controls.Add(this.completedTasksTab);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(722, 376);
            this.tabControl3.TabIndex = 0;
            // 
            // incompleteTasksTab
            // 
            this.incompleteTasksTab.BackColor = System.Drawing.Color.White;
            this.incompleteTasksTab.Controls.Add(this.incompleteTasksView);
            this.incompleteTasksTab.Location = new System.Drawing.Point(4, 22);
            this.incompleteTasksTab.Name = "incompleteTasksTab";
            this.incompleteTasksTab.Padding = new System.Windows.Forms.Padding(3);
            this.incompleteTasksTab.Size = new System.Drawing.Size(714, 350);
            this.incompleteTasksTab.TabIndex = 0;
            this.incompleteTasksTab.Text = "Incomplete Tasks";
            // 
            // incompleteTasksView
            // 
            this.incompleteTasksView.AllowUserToAddRows = false;
            this.incompleteTasksView.AllowUserToDeleteRows = false;
            this.incompleteTasksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incompleteTasksView.BackgroundColor = System.Drawing.Color.White;
            this.incompleteTasksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incompleteTasksView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incompleteTasksView.GridColor = System.Drawing.Color.Black;
            this.incompleteTasksView.Location = new System.Drawing.Point(3, 3);
            this.incompleteTasksView.Name = "incompleteTasksView";
            this.incompleteTasksView.ReadOnly = true;
            this.incompleteTasksView.Size = new System.Drawing.Size(708, 344);
            this.incompleteTasksView.TabIndex = 2;
            this.incompleteTasksView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskViewCellClick);
            // 
            // completedTasksTab
            // 
            this.completedTasksTab.BackColor = System.Drawing.Color.White;
            this.completedTasksTab.Controls.Add(this.completedTasksView);
            this.completedTasksTab.Location = new System.Drawing.Point(4, 22);
            this.completedTasksTab.Name = "completedTasksTab";
            this.completedTasksTab.Padding = new System.Windows.Forms.Padding(3);
            this.completedTasksTab.Size = new System.Drawing.Size(714, 350);
            this.completedTasksTab.TabIndex = 1;
            this.completedTasksTab.Text = "Completed Tasks";
            // 
            // completedTasksView
            // 
            this.completedTasksView.AllowUserToAddRows = false;
            this.completedTasksView.AllowUserToDeleteRows = false;
            this.completedTasksView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.completedTasksView.BackgroundColor = System.Drawing.Color.White;
            this.completedTasksView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completedTasksView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completedTasksView.GridColor = System.Drawing.Color.Black;
            this.completedTasksView.Location = new System.Drawing.Point(3, 3);
            this.completedTasksView.Name = "completedTasksView";
            this.completedTasksView.ReadOnly = true;
            this.completedTasksView.Size = new System.Drawing.Size(708, 344);
            this.completedTasksView.TabIndex = 2;
            this.completedTasksView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskViewCellClick);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(793, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButtonClick);
            this.logoutButton.MouseLeave += new System.EventHandler(this.LogoutButtonMouseLeave);
            this.logoutButton.MouseHover += new System.EventHandler(this.LogoutButtonMouseHover);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.loginStatus);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.logo);
            this.splitContainer1.Panel1.Controls.Add(this.logoutButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.employeeTabs);
            this.splitContainer1.Size = new System.Drawing.Size(880, 506);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 2;
            // 
            // loginStatus
            // 
            this.loginStatus.AutoSize = true;
            this.loginStatus.Location = new System.Drawing.Point(833, 38);
            this.loginStatus.Name = "loginStatus";
            this.loginStatus.Size = new System.Drawing.Size(0, 13);
            this.loginStatus.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(123, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Project Team Tracing System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(122, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "BiL342";
            // 
            // logo
            // 
            this.logo.Image = global::exp3_342_windowform.Properties.Resources.welcome;
            this.logo.Location = new System.Drawing.Point(12, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(105, 104);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 506);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(896, 544);
            this.Name = "EmployeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.employeeTabs.ResumeLayout(false);
            this.personalInfoTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.editInfo.ResumeLayout(false);
            this.editInfo.PerformLayout();
            this.loginInfo.ResumeLayout(false);
            this.loginInfo.PerformLayout();
            this.notificationsTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.notifyTab.ResumeLayout(false);
            this.notifyTab.PerformLayout();
            this.recentNotifiesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notificationList)).EndInit();
            this.assignedWorksTab.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.incompleteTasksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.incompleteTasksView)).EndInit();
            this.completedTasksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.completedTasksView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl employeeTabs;
        private System.Windows.Forms.TabPage personalInfoTab;
        private System.Windows.Forms.TabPage notificationsTab;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TabPage assignedWorksTab;
        private System.Windows.Forms.Label loginStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage editInfo;
        private System.Windows.Forms.Button editInfoSave;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.TextBox birthDayBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage loginInfo;
        private System.Windows.Forms.Button loginInfoSave;
        private System.Windows.Forms.TextBox passwordAgain;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage notifyTab;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox projectWorkedList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage recentNotifiesTab;
        private System.Windows.Forms.Button notificationSaveButton;
        private System.Windows.Forms.TextBox notificationDescBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox hourWorkedBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MonthCalendar workDate;
        private System.Windows.Forms.DataGridView notificationList;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage incompleteTasksTab;
        private System.Windows.Forms.DataGridView incompleteTasksView;
        private System.Windows.Forms.TabPage completedTasksTab;
        private System.Windows.Forms.DataGridView completedTasksView;

    }
}